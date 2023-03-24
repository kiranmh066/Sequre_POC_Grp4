<<<<<<< HEAD
﻿namespace Office_Seat_Booking_API.Controllers
=======
﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Office_Seat_Booking_BLL.Services;
using Office_Seat_Booking_Entity;

namespace Office_Seat_booking_API.Controllers
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
<<<<<<< HEAD
=======
        private BookingService _BookingService;
        public BookingController(BookingService bookingService)
        {
            _BookingService = bookingService;
        }
        [HttpGet("GetBookings")]
        public IEnumerable<Booking> GetBookings()
        {
            return _BookingService.GetBookings();
        }
        [HttpGet("GetBookingById")]
        public Booking GetBookingById(int bookingId)
        {
            return _BookingService.GetBookingById(bookingId);
        }
        [HttpPost("AddBooking")]
        public IActionResult AddBooking([FromBody] Booking booking)
        {
            _BookingService.AddBooking(booking);


            return Ok("Booking created successfully!!");

        }
        [HttpDelete("DeleteBooking")]
        public IActionResult DeleteBooking(int bookingId)
        {
            _BookingService.DeleteBooking(bookingId);
            return Ok("Booking deleted successfully!!");
        }
        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking([FromBody] Booking booking)
        {
            _BookingService.UpdateBooking(booking);
            return Ok("Booking updated successfully!!");
        }
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f
    }
}
