using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Office_Seat_Booking_Entity;

namespace Office_Seat_Booking_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatController : ControllerBase
    {
        private SeatService _SeatService;
        public SeatController(SeatService seatService)
        {

            _SeatService = seatService;
        }
        [HttpGet("GetSeats")]
        public IEnumerable<Seat> GetSeats()
        {
            return _SeatService.GetSeats();
        }
        [HttpGet("GetSeatById")]
        public Seat GetSeatById(int seatId)
        {
            return _SeatService.GetSeatByid(seatId);
        }
        [HttpPost("AddSeat")]
        public IActionResult AddSeat([FromBody] Seat seat)
        {
            _SeatService.AddSeat(seat);


            return Ok("Seat created successfully!!");

        }
        [HttpDelete("DeleteSeat")]
        public IActionResult DeleteSeat(int seatId)
        {
            _SeatService.DeleteSeat(seatId);
            return Ok("Seat deleted successfully!!");
        }
        [HttpPut("UpdateSeat")]
        public IActionResult UpdateSeat([FromBody] Seat seat)
        {
            _SeatService.UpdateSeat(seat);
            return Ok("Seat updated successfully!!");
        }
    }
}
