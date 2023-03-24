using Office_Seat_Booking_Entity;

<<<<<<< HEAD
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f
namespace Office_Seat_Booking_DLL.Repost
{
    public interface IFloorRepost
    {
        void AddFloor(Floor floor);
        void UpdateFloor(Floor floor);

<<<<<<< HEAD
        void DeleteFloor(int floorId);

        Floor GetFloorById(int FloorId);
=======
        void DeleteFloor(int FloorId);

        Floor GetFloorById(int floorId);
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f

        IEnumerable<Floor> GetFloors();
    }
}
