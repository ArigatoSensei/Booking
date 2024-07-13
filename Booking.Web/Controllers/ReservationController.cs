using Booking.Application.Common.Interfaces;
using Booking.Application.Common.Utility;
using Booking.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
                _unitOfWork.Reservation.Add(reservation);
                _unitOfWork.Save();
                LogAction("Insert", "Reservation", $"Created Reservation with Id: {reservation.Id}");
                return RedirectToAction(nameof(ReservationConfirmation), new { reservationId = reservation.Id });
        }

        [Authorize]
        public IActionResult ReservationConfirmation(int reservationId)
        {
                return View(reservationId);
        }

        private void LogAction(string operationType, string tableName, string details)
        {
            var log = new Log_19118162
            {
                Id = Guid.NewGuid(),
                TableName = tableName,
                OperationType = operationType,
                Date = DateTime.Now
            };
            _unitOfWork.Villa.LogAction(log);
            _unitOfWork.Save();
        }
    }
}
