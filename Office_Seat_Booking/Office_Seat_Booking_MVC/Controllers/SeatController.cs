using Microsoft.AspNetCore.Mvc;

namespace Office_Seat_Booking_MVC.Controllers
{
    public class SeatController : Controller
    {
        private IConfiguration _configuration;
        public SeatController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }


    }
}
