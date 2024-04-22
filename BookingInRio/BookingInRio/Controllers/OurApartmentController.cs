using BookingInRio.Data;
using BookingInRio.Models;
using BookingInRio.Services;
using BookingInRio.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookingInRio.Controllers
{
    public class OurApartmentController : Controller
    {
        private readonly ApplicationDbContext _db;

        public OurApartmentController(ApplicationDbContext db) { 
            _db = db;
        }
        public IActionResult Index()
        {
            List<AboutApartment> Apartments = _db.AboutApartments.ToList();
            return View(Apartments);
        }

        [HttpPost]
        public IActionResult Index(List<AboutApartment> apartments)
        {
            if (apartments == null) { return RedirectToAction("Index", "Home"); } /*TEMPROARY, After NotFOund page created,
                                                                                   * this should cahnge*/
            return View(apartments);
        }
        public IActionResult Apartment(int? id)
        {
            if (id == null || id == 0) {return NotFound(); }
            AboutApartment? apart = _db.AboutApartments.Include(d => d.DetailedInformationApartment)
                .Include(i=>i.Images).FirstOrDefault(a => a.Id == id);
            if (apart == null) { return NotFound(); }
            return View(apart);
        }
        [HttpPost]
        public IActionResult Search(SearchModel searchData) {
            if(searchData == null ) { return NotFound(); }
            if (ModelState.IsValid){return View("Index");}
            List<AboutApartment>? apartments = 
                _db.AboutApartments.Include(apart=>apart.DetailedInformationApartment).Include(apart=>apart.ReservedTimes)
                .Where(apart=>apart.BedCounts >= searchData.BedCount)
                .Where(apart=>apart.DetailedInformationApartment.PersonLimitSize >= searchData.PersonCount)
                .Where(apart=>apart.ReservedTimes
                .Any(rt => ((rt.EndTime < searchData.StartingTime  ) || (rt.StartTime > searchData.EndingTime))))
                .ToList();
            return View("Index",apartments);
        }

    }
}
