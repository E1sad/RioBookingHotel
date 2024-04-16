using BookingInRio.Data;
using BookingInRio.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookingInRio.Controllers
{
    public class OurApartmentController : Controller
    {
        private readonly ApplicationDbContext _db;
        public OurApartmentController(ApplicationDbContext db) { _db = db; }
        public IActionResult Index()
        {
            List<AboutApartment> Apartments = _db.AboutApartments.ToList();
            return View(Apartments);
        }
        public IActionResult Apartment(int? id)
        {
            if (id == null || id == 0) { /*return RedirectToAction("Index"); */ return NotFound(); }
            AboutApartment? apart = _db.AboutApartments.Find(id);
            if (apart == null) { return NotFound(); }
            return View(apart);
        }
    }
}
