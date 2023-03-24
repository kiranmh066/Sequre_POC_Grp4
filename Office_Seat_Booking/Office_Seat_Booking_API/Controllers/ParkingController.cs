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
    public class ParkingController : ControllerBase
    {
<<<<<<< HEAD
=======
        private ParkingService _ParkingService;
        public ParkingController(ParkingService parkingService)
        {

            _ParkingService = parkingService;
        }
        [HttpGet("GetParkings")]
        public IEnumerable<Parking> GetParkings()
        {
            return _ParkingService.GetParking();
        }
        [HttpGet("GetParkingById")]
        public Parking GetParkingById(int parkingId)
        {
            return _ParkingService.GetByParkingId(parkingId);
        }
        [HttpPost("AddParking")]
        public IActionResult AddParking([FromBody] Parking parking)
        {
            _ParkingService.AddParking(parking);


            return Ok("Parking created successfully!!");

        }
        [HttpDelete("DeleteParking")]
        public IActionResult DeleteParking(int parkingId)
        {
            _ParkingService.DeleteParking(parkingId);
            return Ok("Parking deleted successfully!!");
        }
        [HttpPut("UpdateParking")]
        public IActionResult UpdateParking([FromBody] Parking parking)
        {
            _ParkingService.UpdateParking(parking);
            return Ok("Parking updated successfully!!");
        }
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f
    }
}
