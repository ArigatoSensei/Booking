using Booking.Application.Common.Interfaces;
using Booking.Application.Common.Utility;
using Booking.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocIO;
using Syncfusion.DocIORenderer;
using System.Security.Claims;
using Syncfusion.Drawing;
using Syncfusion.Pdf;

namespace Booking.Web.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ReservationController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
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
        [Authorize]
        public IActionResult GenerateInvoice(int id, string downloadType)
        {
            string basePath = _webHostEnvironment.WebRootPath;

            WordDocument document = new WordDocument();


            // Load the template.
            string dataPath = basePath + @"/exports/ReservationDetails.docx";
            using FileStream fileStream = new(dataPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            document.Open(fileStream, FormatType.Automatic);

            //Update Template
            Reservation reservationFromDb = _unitOfWork.Reservation.Get(u => u.Id == id,
                            includeProperties: "User,Villa");

            TextSelection textSelection = document.Find("xx_customer_name", false, true);
            WTextRange textRange = textSelection.GetAsOneRange();
            textRange.Text = reservationFromDb.Name;

            textSelection = document.Find("xx_customer_phone", false, true);
            textRange = textSelection.GetAsOneRange();
            textRange.Text = reservationFromDb.Phone;

            textSelection = document.Find("xx_customer_email", false, true);
            textRange = textSelection.GetAsOneRange();
            textRange.Text = reservationFromDb.Email;

            textSelection = document.Find("XX_RESERVATION_NUMBER", false, true);
            textRange = textSelection.GetAsOneRange();
            textRange.Text = "RESERVATION ID - " + reservationFromDb.Id;
            textSelection = document.Find("XX_RESERVATION_DATE", false, true);
            textRange = textSelection.GetAsOneRange();
            textRange.Text = "RESERVATION DATE - " + reservationFromDb.ReservationDate.ToShortDateString();


            textSelection = document.Find("xx_payment_date", false, true);
            textRange = textSelection.GetAsOneRange();
            textRange.Text = reservationFromDb.PaymentDate.ToShortDateString();
            textSelection = document.Find("xx_checkin_date", false, true);
            textRange = textSelection.GetAsOneRange();
            textRange.Text = reservationFromDb.CheckInDate.ToShortDateString();
            textSelection = document.Find("xx_checkout_date", false, true);
            textRange = textSelection.GetAsOneRange();
            textRange.Text = reservationFromDb.CheckOutDate.ToShortDateString(); ;
            textSelection = document.Find("xx_booking_total", false, true);
            textRange = textSelection.GetAsOneRange();
            textRange.Text = reservationFromDb.TotalCost.ToString("c");

            WTable table = new(document);

            table.TableFormat.Borders.LineWidth = 1f;
            table.TableFormat.Borders.Color = Color.Black;
            table.TableFormat.Paddings.Top = 7f;
            table.TableFormat.Paddings.Bottom = 7f;
            table.TableFormat.Borders.Horizontal.LineWidth = 1f;


            int rows = reservationFromDb.VillaNumber > 0 ? 3 : 2;
            table.ResetCells(rows, 4);

            WTableRow row0 = table.Rows[0];

            row0.Cells[0].AddParagraph().AppendText("NIGHTS");
            row0.Cells[0].Width = 80;
            row0.Cells[1].AddParagraph().AppendText("VILLA");
            row0.Cells[1].Width = 220;
            row0.Cells[2].AddParagraph().AppendText("PRICE PER NIGHT");
            row0.Cells[3].AddParagraph().AppendText("TOTAL");
            row0.Cells[3].Width = 80;

            WTableRow row1 = table.Rows[1];

            row1.Cells[0].AddParagraph().AppendText(reservationFromDb.Nights.ToString());
            row1.Cells[0].Width = 80;
            row1.Cells[1].AddParagraph().AppendText(reservationFromDb.Villa.Name);
            row1.Cells[1].Width = 220;
            row1.Cells[2].AddParagraph().AppendText((reservationFromDb.TotalCost / reservationFromDb.Nights).ToString("c"));
            row1.Cells[3].AddParagraph().AppendText(reservationFromDb.TotalCost.ToString("c"));
            row1.Cells[3].Width = 80;

            if (reservationFromDb.VillaNumber > 0)
            {
                WTableRow row2 = table.Rows[2];

                row2.Cells[0].Width = 80;
                row2.Cells[1].AddParagraph().AppendText("Villa Number - " + reservationFromDb.VillaNumber.ToString());
                row2.Cells[1].Width = 220;
                row2.Cells[3].Width = 80;
            }

            WTableStyle tableStyle = document.AddTableStyle("CustomStyle") as WTableStyle;
            tableStyle.TableProperties.RowStripe = 1;
            tableStyle.TableProperties.ColumnStripe = 2;
            tableStyle.TableProperties.Paddings.Top = 2;
            tableStyle.TableProperties.Paddings.Bottom = 1;
            tableStyle.TableProperties.Paddings.Left = 5.4f;
            tableStyle.TableProperties.Paddings.Right = 5.4f;

            ConditionalFormattingStyle firstRowStyle = tableStyle.ConditionalFormattingStyles.Add(ConditionalFormattingType.FirstRow);
            firstRowStyle.CharacterFormat.Bold = true;
            firstRowStyle.CharacterFormat.TextColor = Color.FromArgb(255, 255, 255, 255);
            firstRowStyle.CellProperties.BackColor = Color.Black;

            table.ApplyStyle("CustomStyle");


            TextBodyPart bodyPart = new(document);
            bodyPart.BodyItems.Add(table);

            document.Replace("<ADDTABLEHERE>", bodyPart, false, false);

            using DocIORenderer renderer = new();
            MemoryStream stream = new();
            if (downloadType == "word")
            {

                document.Save(stream, FormatType.Docx);
                stream.Position = 0;

                return File(stream, "application/docx", "ReservationDetails.docx");
            }
            else
            {
                PdfDocument pdfDocument = renderer.ConvertToPDF(document);
                pdfDocument.Save(stream);
                stream.Position = 0;

                return File(stream, "application/pdf", "ReservationDetails.pdf");
            }

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
