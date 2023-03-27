using Microsoft.AspNetCore.Mvc;

namespace Office_Seat_Booking_MVC.Controllers
{
    public class LoginTableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
