using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using BookingInRio.Models;
using BookingInRio.Data;

namespace BookingInRio.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ContactController(ApplicationDbContext db){_db = db;}
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Subscribe(string email)
        {
            if(email == null) { return Json(new { success = false, message = "Email is required!" }); }
            EmailList obj = new EmailList
            {
                Email = email,
                date = DateTime.Now,
            };
            if(obj == null) { return Json(new { success = false, message = "Try again something went wrong!"}); }
            _db.SubscribersEmails.Add(obj);
            _db.SaveChanges();
            return Json(new { success = true, message = "Your email susccessfuly added to subscribers list!" }) ;
        }

    }
}
