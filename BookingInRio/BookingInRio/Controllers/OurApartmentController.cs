using BookingInRio.Data;
using BookingInRio.Models;
using BookingInRio.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            if (id == null || id == 0) {return NotFound(); }
            //AboutApartment? apart = _db.AboutApartments.Find(id);
            /*DetailedInfoApartmentViewMod viewMod = new DetailedInfoApartmentViewMod
            {
                Apartment = _db.AboutApartments.Include(d=>d.DetailedInformationApartment).FirstOrDefault(a => a.Id == id),
                DetailedInfo = _db.DetailedApartmentInfos.FirstOrDefault(d => d.AboutApartmentId == id)
            };*/
            //if (apart == null) { return NotFound(); }
            //return View(apart);
            /*if(viewMod.Apartment == null) { return NotFound(); }
            return View(viewMod);*/
            AboutApartment? apart = _db.AboutApartments.Include(d => d.DetailedInformationApartment).FirstOrDefault(a => a.Id == id);
            if (apart == null) { return NotFound(); }
            return View(apart);
        }
    }
}
