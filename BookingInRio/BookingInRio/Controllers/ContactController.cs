using Microsoft.AspNetCore.Mvc;

namespace BookingInRio.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
