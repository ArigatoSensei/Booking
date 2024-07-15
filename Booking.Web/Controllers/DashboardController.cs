using Booking.Application.Common.Interfaces;
using Booking.Application.Common.Utility;
using Booking.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Web.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        static int previousMonth = DateTime.Now.Month == 1 ? 12 : DateTime.Now.Month - 1;
        readonly DateTime previousMonthStartDate = new(DateTime.Now.Year, previousMonth, 1);
        readonly DateTime currentMonthStartDate = new(DateTime.Now.Year, DateTime.Now.Month, 1);
        public DashboardController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetTotalReservationRadialChartData()
        {
            var totalReservations = _unitOfWork.Reservation.GetAll(u => u.Status != SD.StatusPending
            || u.Status == SD.StatusCancelled);

            var countByCurrentMonth = totalReservations.Count(u => u.ReservationDate >= currentMonthStartDate &&
            u.ReservationDate <= DateTime.Now);

            var countByPreviousMonth = totalReservations.Count(u => u.ReservationDate >= previousMonthStartDate &&
            u.ReservationDate <= currentMonthStartDate);

            return Json(GetRadialCartDataModel(totalReservations.Count(), countByCurrentMonth, countByPreviousMonth));
        }

        public async Task<IActionResult> GetRegisteredUserChartData()
        {
            var totalUsers = _unitOfWork.User.GetAll();

            var countByCurrentMonth = totalUsers.Count(u => u.CreatedAt >= currentMonthStartDate &&
            u.CreatedAt <= DateTime.Now);

            var countByPreviousMonth = totalUsers.Count(u => u.CreatedAt >= previousMonthStartDate &&
            u.CreatedAt <= currentMonthStartDate);


            return Json(GetRadialCartDataModel(totalUsers.Count(), countByCurrentMonth, countByPreviousMonth));
        }

        public async Task<IActionResult> GetRevenueChartData()
        {
            var totalReservations = _unitOfWork.Reservation.GetAll(u => u.Status != SD.StatusPending
           || u.Status == SD.StatusCancelled);

            var totalRevenue = Convert.ToInt32(totalReservations.Sum(u => u.TotalCost));

            var countByCurrentMonth = totalReservations.Where(u => u.ReservationDate >= currentMonthStartDate &&
            u.ReservationDate <= DateTime.Now).Sum(u => u.TotalCost);

            var countByPreviousMonth = totalReservations.Where(u => u.ReservationDate >= previousMonthStartDate &&
            u.ReservationDate <= currentMonthStartDate).Sum(u => u.TotalCost);

            return Json(GetRadialCartDataModel(totalRevenue, countByCurrentMonth, countByPreviousMonth));
        }

        public async Task<IActionResult> GetReservationPieChartData()
        {
            var totalReservations = _unitOfWork.Reservation.GetAll(u => u.ReservationDate >= DateTime.Now.AddDays(-30) &&
            (u.Status != SD.StatusPending || u.Status == SD.StatusCancelled));

            var customerWithOneReservation = totalReservations.GroupBy(b => b.UserId).Where(x => x.Count() == 1).Select(x => x.Key).ToList();

            int reservationsByNewCustomer = customerWithOneReservation.Count();
            int reservationsByReturningCustomer = totalReservations.Count() - reservationsByNewCustomer;

            PieChartVM pieChartVM = new()
            {
                Labels = new string[] { "New Customer Reservations", "Returning Customer Reservations" },
                Series = new decimal[] { reservationsByNewCustomer, reservationsByReturningCustomer }
            };

            return Json(pieChartVM);
        }

        public async Task<IActionResult> GetMemberAndReservationLineChartData()
        {
            var reservationData = _unitOfWork.Reservation.GetAll(u => u.ReservationDate >= DateTime.Now.AddDays(-30) &&
            u.ReservationDate.Date <= DateTime.Now)
                .GroupBy(b => b.ReservationDate.Date)
                .Select(u => new {
                    DateTime = u.Key,
                    NewReservationCount = u.Count()
                });

            var customerData = _unitOfWork.User.GetAll(u => u.CreatedAt >= DateTime.Now.AddDays(-30) &&
            u.CreatedAt.Date <= DateTime.Now)
                .GroupBy(b => b.CreatedAt.Date)
                .Select(u => new {
                    DateTime = u.Key,
                    NewCustomerCount = u.Count()
                });


            var leftJoin = reservationData.GroupJoin(customerData, reservation => reservation.DateTime, customer => customer.DateTime,
                (reservation, customer) => new
                {
                    reservation.DateTime,
                    reservation.NewReservationCount,
                    NewCustomerCount = customer.Select(x => x.NewCustomerCount).FirstOrDefault()
                });


            var rightJoin = customerData.GroupJoin(reservationData, customer => customer.DateTime, reservation => reservation.DateTime,
                (customer, reservation) => new
                {
                    customer.DateTime,
                    NewReservationCount = reservation.Select(x => x.NewReservationCount).FirstOrDefault(),
                    customer.NewCustomerCount
                });

            var mergedData = leftJoin.Union(rightJoin).OrderBy(x => x.DateTime).ToList();

            var newReservationData = mergedData.Select(x => x.NewReservationCount).ToArray();
            var newCustomerData = mergedData.Select(x => x.NewCustomerCount).ToArray();
            var categories = mergedData.Select(x => x.DateTime.ToString("MM/dd/yyyy")).ToArray();

            List<ChartData> chartDataList = new()
            {
                new ChartData
                {
                    Name = "New Reservations",
                    Data = newReservationData
                },
                new ChartData
                {
                    Name = "New Members",
                    Data = newCustomerData
                },
            };

            LineChartVM lineChartVM = new()
            {
                Categories = categories,
                Series = chartDataList
            };



            return Json(lineChartVM);
        }


        private static RadialBarChartVM GetRadialCartDataModel(int totalCount, double currentMonthCount, double prevMonthCount)
        {
            RadialBarChartVM radialBarChartVM = new();


            int increaseDecreaseRatio = 100;

            if (prevMonthCount != 0)
            {
                increaseDecreaseRatio = Convert.ToInt32((currentMonthCount - prevMonthCount) / prevMonthCount * 100);
            }

            radialBarChartVM.TotalCount = totalCount;
            radialBarChartVM.CountInCurrentMonth = Convert.ToInt32(currentMonthCount);
            radialBarChartVM.HasRatioIncreased = currentMonthCount > prevMonthCount;
            radialBarChartVM.Series = new int[] { increaseDecreaseRatio };

            return radialBarChartVM;
        }
    }
}