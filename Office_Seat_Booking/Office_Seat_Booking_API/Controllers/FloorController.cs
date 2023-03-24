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
    public class FloorController : ControllerBase
    {
<<<<<<< HEAD
=======
        private FloorService _FloorService;
        public FloorController(FloorService floorService)
        {

            _FloorService = floorService;
        }
        [HttpGet("GetFloors")]
        public IEnumerable<Floor> GetFloors()
        {
            return _FloorService.GetFloor();
        }
        [HttpGet("GetFloorById")]
        public Floor GetFloorById(int floorId)
        {
            return _FloorService.GetByFloorId(floorId);
        }
        [HttpPost("AddFloor")]
        public IActionResult AddFloor([FromBody] Floor floor)
        {
            _FloorService.AddFloor(floor);


            return Ok("Floor created successfully!!");

        }
        [HttpDelete("DeleteFloor")]
        public IActionResult DeleteFloor(int floorId)
        {
            _FloorService.DeleteFloor(floorId);
            return Ok("Floor deleted successfully!!");
        }
        [HttpPut("UpdateFloor")]
        public IActionResult UpdateFloor([FromBody] Floor floor)
        {
            _FloorService.UpdateFloor(floor);
            return Ok("Floor updated successfully!!");
        }
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f
    }
}
