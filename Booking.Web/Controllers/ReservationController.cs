using Booking.Application.Common.Interfaces;
using Booking.Application.Common.Utility;
using Booking.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;
using System.Security.Claims;

namespace Booking.Web.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReservationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult FinalizeReservation(int villaId, DateOnly checkInDate, int nights)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            ApplicationUser user = _unitOfWork.User.Get(u => u.Id == userId);

            Reservation reservation = new()
            {
                VillaId = villaId,
                Villa = _unitOfWork.Villa.Get(u => u.Id == villaId, includeProperties: "VillaAmenity"),
                CheckInDate = checkInDate,
                Nights = nights,
                CheckOutDate = checkInDate.AddDays(nights),
                UserId = userId,
                Phone = user.PhoneNumber,
                Email = user.Email,
                Name = user.Name
            };
            reservation.TotalCost = reservation.Villa.Price * nights;
            return View(reservation);
        }

        [Authorize]
        [HttpPost]
        public IActionResult FinalizeReservation(Reservation reservation)
        {
                var villa = _unitOfWork.Villa.Get(u => u.Id == reservation.VillaId);
                reservation.TotalCost = villa.Price * reservation.Nights;

                reservation.Status = SD.StatusPending;
                reservation.ReservationDate = DateTime.Now;

            var villaNumbersList = _unitOfWork.VillaNumber.GetAll().ToList();
            var reservedVillas = _unitOfWork.Reservation.GetAll(u => u.Status == SD.StatusApproved ||
            u.Status == SD.StatusCheckedIn).ToList();



            int roomAvailable = SD.VillaRoomsAvailable_Count
                (villa.Id, villaNumbersList, reservation.CheckInDate, reservation.Nights, reservedVillas);

            if (roomAvailable == 0)
            {
                TempData["error"] = "Room has been sold out!";
                //no rooms available
                return RedirectToAction(nameof(FinalizeReservation), new
                {
                    villaId = reservation.VillaId,
                    checkInDate = reservation.CheckInDate,
                    nights = reservation.Nights
                });
            }

            _unitOfWork.Reservation.Add(reservation);
                _unitOfWork.Save();
                LogAction("Insert", "Reservation", $"Created Reservation with Id: {reservation.Id}");


            var domain = Request.Scheme + "://" + Request.Host.Value + "/";
            var options = new SessionCreateOptions
            {
                LineItems = new List<SessionLineItemOptions>(),
                Mode = "payment",
                SuccessUrl = domain + $"reservation/ReservationConfirmation?reservationId={reservation.Id}",
                CancelUrl = domain + $"reservation/FinalizeReservation?villaId={reservation.VillaId}&checkInDate={reservation.CheckInDate}&nights={reservation.Nights}",
            };


            options.LineItems.Add(new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    UnitAmount = (long)(reservation.TotalCost * 100),
                    Currency = "usd",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = villa.Name
                    },
                },
                Quantity = 1,
            });


            var service = new SessionService();
            Session session = service.Create(options);
            _unitOfWork.Reservation.UpdateStripePaymentID(reservation.Id, session.Id, session.PaymentIntentId);
            _unitOfWork.Save();

            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);
        }

        [Authorize]
        public IActionResult ReservationConfirmation(int reservationId)
        {
            Reservation reservationFromDb = _unitOfWork.Reservation.Get(u => u.Id == reservationId,
                includeProperties: "User,Villa");

            if (reservationFromDb.Status == SD.StatusPending)
            {
                var service = new SessionService();
                Session session = service.Get(reservationFromDb.StripeSessionId);

                if (session.PaymentStatus == "paid")
                {
                    _unitOfWork.Reservation.UpdateStatus(reservationFromDb.Id, SD.StatusApproved, 0);
                    _unitOfWork.Reservation.UpdateStripePaymentID(reservationFromDb.Id, session.Id, session.PaymentIntentId);

                    _unitOfWork.Save();
                    LogAction("Update", "Reservation", $"Payment successful for Reservation with Id: {reservationFromDb.Id}");
                }
            }

            return View(reservationId);
        }


        private void LogAction(string operationType, string tableName, string details)
        {
            var log = new Log_19118162
            {
                Id = Guid.NewGuid(),
                TableName = tableName,
                OperationType = operationType,
                Details = details,
                Date = DateTime.Now
            };
            _unitOfWork.Villa.LogAction(log);
            _unitOfWork.Save();
        }

        [Authorize]
        public IActionResult ReservationDetails(int reservationId)
        {
            Reservation reservationFromDb = _unitOfWork.Reservation.Get(u => u.Id == reservationId,
             includeProperties: "User,Villa");
            if (reservationFromDb.VillaNumber == 0 && reservationFromDb.Status == SD.StatusApproved)
            {
                var availableVillaNumber = AssignAvailableVillaNumberByVilla(reservationFromDb.VillaId);

                reservationFromDb.VillaNumbers = _unitOfWork.VillaNumber.GetAll(u => u.VillaId == reservationFromDb.VillaId
                && availableVillaNumber.Any(x => x == u.Villa_Number)).ToList();
            }
            return View(reservationFromDb);
        }

        [HttpPost]
        [Authorize(Roles = SD.Role_Admin)]
        public IActionResult CheckIn(Reservation reservation)
        {
            _unitOfWork.Reservation.UpdateStatus(reservation.Id, SD.StatusCheckedIn, reservation.VillaNumber);
            _unitOfWork.Save();
            TempData["Success"] = "Reservation Updated Successfully.";
            LogAction("Insert", "Reservation", $"Checked In for Reservation with Id: {reservation.Id}");
            return RedirectToAction(nameof(ReservationDetails), new { reservationId = reservation.Id });
        }

        [HttpPost]
        [Authorize(Roles = SD.Role_Admin)]
        public IActionResult CheckOut(Reservation reservation)
        {
            _unitOfWork.Reservation.UpdateStatus(reservation.Id, SD.StatusCompleted, reservation.VillaNumber);
            _unitOfWork.Save();
            TempData["Success"] = "Reservation Updated Successfully.";
            LogAction("Update", "Reservation", $"Checked Out for Reservation with Id: {reservation.Id}");
            return RedirectToAction(nameof(ReservationDetails), new { reservationId = reservation.Id });
        }

        [HttpPost]
        [Authorize(Roles = SD.Role_Admin)]
        public IActionResult CancelReservation(Reservation reservation)
        {
            _unitOfWork.Reservation.UpdateStatus(reservation.Id, SD.StatusCancelled, 0);
            _unitOfWork.Save();
            TempData["Success"] = "Reservation Updated Successfully.";
            LogAction("Update", "Reservation", $"Cancelled for Reservation with Id: {reservation.Id}");
            return RedirectToAction(nameof(ReservationDetails), new { reservationId = reservation.Id });
        }

        private List<int> AssignAvailableVillaNumberByVilla(int villaId)
        {
            List<int> availableVillaNumbers = new();

            var villaNumbers = _unitOfWork.VillaNumber.GetAll(u => u.VillaId == villaId);

            var checkedInVilla = _unitOfWork.Reservation    .GetAll(u => u.VillaId == villaId && u.Status == SD.StatusCheckedIn)
                .Select(u => u.VillaNumber);

            foreach (var villaNumber in villaNumbers)
            {
                if (!checkedInVilla.Contains(villaNumber.Villa_Number))
                {
                    availableVillaNumbers.Add(villaNumber.Villa_Number);
                }
            }
            return availableVillaNumbers;
        }

        #region API Calls
        [HttpGet]
        [Authorize]
        public IActionResult GetAll(string status)
        {
            IEnumerable<Reservation> objReservations;

            if (User.IsInRole(SD.Role_Admin))
            {
                objReservations =
                    _unitOfWork.Reservation.GetAll(includeProperties: "User,Villa");
            }
            else
            {
                var claimsIdentity = (ClaimsIdentity)User.Identity;
                var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

                objReservations = _unitOfWork.Reservation
                    .GetAll(u => u.UserId == userId, includeProperties: "User,Villa");
            }
            if (!string.IsNullOrEmpty(status))
            {
                objReservations = objReservations.Where(u => u.Status.ToLower().Equals(status.ToLower()));
            }
            return Json(new { data = objReservations });
        }
        #endregion
    }
}
