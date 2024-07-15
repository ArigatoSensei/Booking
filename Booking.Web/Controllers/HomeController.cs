using Booking.Application.Common.Interfaces;
using Booking.Application.Common.Utility;
using Booking.Web.Models;
using Booking.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Booking.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new()
            {
                VillaList = _unitOfWork.Villa.GetAll(includeProperties: "VillaAmenity"),
                Nights = 1,
                CheckInDate = DateOnly.FromDateTime(DateTime.Now),
            };
            return View(homeVM);
        }
        [HttpPost]

        public IActionResult GetVillasByDate(int nights, DateOnly checkInDate)
        {
            Thread.Sleep(1000);
            var villaList = _unitOfWork.Villa.GetAll(includeProperties: "VillaAmenity").ToList();
            var villaNumbersList = _unitOfWork.VillaNumber.GetAll().ToList();
            var reservedVillas = _unitOfWork.Reservation.GetAll(u => u.Status == SD.StatusApproved ||
            u.Status == SD.StatusCheckedIn).ToList();
            foreach (var villa in villaList)
            {
                int roomAvailable = SD.VillaRoomsAvailable_Count
                     (villa.Id, villaNumbersList, checkInDate, nights, reservedVillas);

                villa.IsAvailable = roomAvailable > 0 ? true : false;
            }

            HomeVM homeVM = new()
            {
                CheckInDate = checkInDate,
                VillaList = villaList,
                Nights = nights
            };

            return PartialView("_VillaList", homeVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
