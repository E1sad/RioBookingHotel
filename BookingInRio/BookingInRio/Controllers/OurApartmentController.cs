using BookingInRio.Data;
using BookingInRio.Models;
using BookingInRio.Services;
using BookingInRio.ViewModels;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Runtime.ExceptionServices;
using System.Text.Json.Serialization;

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
            /*List<AboutApartment> Apartments = _db.AboutApartments.ToList();*/
            ViewBag.Message = TempData["Message"] as string;
            List<AboutApartment> Apartments = _db.AboutApartments
                .Include(apart => apart.DetailedInformationApartment)
                .ThenInclude(d=>d.AmenitiesToDetailedApartments)
                .ThenInclude(a=>a.Amenity)
                .ToList();
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
            AboutApartment? apart = _db.AboutApartments
                .Include(d => d.DetailedInformationApartment)
                .ThenInclude(d=>d.AmenitiesToDetailedApartments)
                .ThenInclude(d=>d.Amenity)
                .Include(i=>i.Images)
                .FirstOrDefault(a => a.Id == id);
            if (apart == null) { return NotFound(); }
            return View(apart);
        }
        [HttpPost]
        public IActionResult Search(SearchModel searchData) {
            if(searchData == null ) { return NotFound(); }
                List<AboutApartment>? apartments =
                    _db.AboutApartments
                    .Include(apart => apart.DetailedInformationApartment)
                    .ThenInclude(d => d.AmenitiesToDetailedApartments)
                    .ThenInclude(a => a.Amenity)
                    .Include(apart => apart.ReservedTimes)
                    .Where(apart => apart.BedCounts >= searchData.BedCount)
                    .Where(apart => apart.DetailedInformationApartment.PersonLimitSize >= searchData.PersonCount)
                    .Where(apart => apart.ReservedTimes
                    .Any(rt => ((rt.EndTime < searchData.StartingTime) || (rt.StartTime > searchData.EndingTime))))
                    .ToList();
                return View("Index", apartments);
        }

        [HttpPost]
        public IActionResult CheckOut(FirtCheckoutInformations data)
        {
            if (data == null || data.ApartmentId == 0) return NotFound();
            if (ModelState.IsValid) {
                TempData["OrderDetails"] = JsonConvert.SerializeObject(data);
                return RedirectToAction("ConfirmOrder", new { id = data.ApartmentId });
            }
            else return RedirectToAction("Apartment",new {id = data.ApartmentId});
        }
        public IActionResult ConfirmOrder(int? id)
        {
            if(id == null) return NotFound();
            AboutApartment? apart = _db.AboutApartments.Find(id);
            if(apart  == null) return NotFound();
            return View("CheckOut",apart);
        }
        [HttpPost]
        public IActionResult PlaceOrder(PlaceOrderDataVIewModel data)
        {
            ViewBag.Message = TempData["Message"] as string;
            if (ModelState.IsValid)
            {
                if (TempData["OrderDetails"] is string jsonData)
                {
                    FirtCheckoutInformations? resData = JsonConvert.DeserializeObject<FirtCheckoutInformations>(jsonData);
                    if(resData != null) { 
                        UserReservationData orderData = new UserReservationData
                        {
                            StartingDate = resData.StartingDate,
                            EndingTime = resData.EndingTime,
                            PersonCount = resData.PersonCount,
                            BedCount = resData.BedCount,
                            FirstName = data.FirstName,
                            LastName = data.LastName,
                            Email = data.email,
                            PhoneNumber = data.phone,
                            Country = data.country,
                            SpecialRequest = data.Request,
                            ApartmentId = resData.ApartmentId,
                        };
                        DatesApartmentReserved reservedDate = new DatesApartmentReserved
                        {
                            StartTime = resData.StartingDate,
                            EndTime = resData.EndingTime,
                            ApartId = resData.ApartmentId
                        };
                        _db.UserReservationData.Add(orderData);
                        _db.DatesApartmentsReserved.Add(reservedDate);
                        _db.SaveChanges();
                        TempData["Message"] = "Order placed";
                        return RedirectToAction("Index");
                    }
                    return Json(new { success = false, message = "Something went wrong!" });
                }
                else
                {
                    return Json(new { success = false, message = "Something went wrong!" });
                }
            }
            else {
                FirtCheckoutInformations? resData = JsonConvert.DeserializeObject<FirtCheckoutInformations>((string)TempData["OrderDetails"]);
                if (resData != null)
                {
                    TempData["Message"] = "Please fill all necessary boxes!";
                    return RedirectToAction("ConfirmOrder", new { id = resData.ApartmentId }); 
                }
                return Json(new { success = false, message = "Something went wrong!"}); 
            }
        }
    } 
}
