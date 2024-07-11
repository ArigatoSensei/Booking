using Booking.Domain.Entities;
using Booking.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Web.Controllers
{
    public class VillaController : Controller
    {
        private readonly ApplicationDbContext _db;

        public VillaController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var villas = _db.Villas.ToList();
            return View(villas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Villa obj)
        {
            if (obj.Name == obj.Description)
            {
                ModelState.AddModelError("name", "The description cannot exactly match the Name.");
            }
            if (ModelState.IsValid)
            {
                obj.Date_19118162 = DateTime.Now;
                _db.Villas.Add(obj);
                _db.SaveChanges();
                LogAction("Insert", "Villa", $"Created Category with Id: {obj.Id}");
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Update(int villaid)
        {
            Villa? obj = _db.Villas.FirstOrDefault(u=>u.Id == villaid);
            //Villa? obj = _db.Villas.Find(villaId);
            //var VillaList = _db.Villas.Where(u => u.Price > 50 && u.Occupancy > 0);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
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
            _db.Log_19118162.Add(log);
            _db.SaveChanges();
        }
    }
}
