using BookingInRio.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookingInRio.Controllers
{
    public class RioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
