using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Office_Seat_Booking_Entity;

namespace Office_Seat_booking_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class bookingController : ControllerBase
    {
        private FloorService _FloorService;
        public FloorController(FloorService floorService)
        {

            _FloorService = floorService;
        }
        [HttpGet("GetFloors")]
        public IEnumerable<Floor> GetFloors()
        {
            return _FloorService.GetFloors();
        }
        [HttpGet("GetFloorById")]
        public Floor GetFloorById(int floorId)
        {
            return _FloorService.GetFloorByid(floorId);
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
    }
}
