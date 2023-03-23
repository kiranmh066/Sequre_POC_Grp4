using Office_Seat_Booking_Entity;

namespace Office_Seat_Booking_DLL.Repost
{
    public interface IFloorRepost
    {
        void AddFloor(Floor floor);
        void UpdateFloor(Floor floor);

        void DeleteFloor(int floorId);

        Floor GetFloorById(int FloorId);

        IEnumerable<Floor> GetFloors();
    }
}
