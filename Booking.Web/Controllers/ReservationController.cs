using Booking.Application.Common.Interfaces;
using Booking.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Web.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReservationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult FinalizeReservation(int villaId, DateOnly checkInDate, int nights)
        {
            Reservation reservation = new()
            {
                VillaId = villaId,
                Villa = _unitOfWork.Villa.Get(u => u.Id == villaId, includeProperties: "VillaAmenity"),
                CheckInDate = checkInDate,
                Nights = nights,
                CheckOutDate = checkInDate.AddDays(nights),
            };
            reservation.TotalCost = reservation.Villa.Price*nights;
            return View(reservation);
        }
    }
}
