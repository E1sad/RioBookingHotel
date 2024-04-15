using Microsoft.AspNetCore.Mvc;

namespace BookingInRio.Controllers
{
    public class OurApartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
