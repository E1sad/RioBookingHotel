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
        //private readonly EmailService _emailService;

        public OurApartmentController(ApplicationDbContext db/*, EmailService emailService*/) { 
            _db = db; /*_emailService = emailService;*/
        }
        public IActionResult Index()
        {
            List<AboutApartment> Apartments = _db.AboutApartments.ToList();
            /*try
            {
                string toEmail = "elsad.abdullayev.02703@gmail.com";
                string subject = "Test Email";
                string body = "This is a test email sent from my .NET application.";
                _emailService.SendEmail(toEmail, subject, body);
            }
            catch (Exception ex)
            {  
            }*/
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
        [HttpPost]
        public IActionResult Search(SearchModel searchData) {
            if(searchData == null ) { return NotFound(); }

            List<AboutApartment>? apartments = 
                _db.AboutApartments.Include(apart=>apart.DetailedInformationApartment).Include(apart=>apart.ReservedTimes)
                .Where(apart=>apart.BedCounts >= searchData.BedCount)
                .Where(apart=>apart.DetailedInformationApartment.PersonLimitSize >= searchData.PersonCount)
                .Where(apart=>apart.ReservedTimes
                .Any(rt => ((rt.EndTime < searchData.StartingTime  ) || (rt.StartTime > searchData.EndingTime))))
                .ToList();
            return View("Index",apartments);
        }


        #region Not Web Dev
        private bool isInRange(DateTime starting, DateTime ending, DateTime searchStartingTime, DateTime searchEndingTime)
        {
            if(starting > searchEndingTime && starting > searchStartingTime) { return true; }
            else if(ending < searchStartingTime && ending < searchEndingTime) {  return true; }
            return false;
        }
        #endregion

    }
}
