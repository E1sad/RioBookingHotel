using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;

namespace BookingInRio.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendEmail(string email)
        {
            return View();
        }

    }
}
