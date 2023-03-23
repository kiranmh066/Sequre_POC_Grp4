﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Office_Seat_Booking_Entity;

namespace Office_Seat_Booking_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
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
            return _BookingService.GetBookingByid(bookingId);
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
    }
}
