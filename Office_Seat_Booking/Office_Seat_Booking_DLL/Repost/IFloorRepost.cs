using Office_Seat_Booking_Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Seat_Booking_DLL.Repost
{
    public interface IFloorRepost
    {
        void AddFloor(Floor floor);
        void UpdateFloor(Floor floor);

        void DeleteFloor(int FloorId);

        Floor GetFloorById(int floorId);

        IEnumerable<Floor> GetFloors();
    }
}
