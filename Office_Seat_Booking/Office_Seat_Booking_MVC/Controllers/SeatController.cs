using Microsoft.AspNetCore.Mvc;

namespace Office_Seat_Booking_MVC.Controllers
{
    public class SeatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
