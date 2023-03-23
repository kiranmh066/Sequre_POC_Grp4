using Office_Seat_Booking_Entity;

namespace Office_Seat_Booking_DLL.Repost
{
    public interface IParkingRepost
    {
        void AddParking(Parking parking);
        void UpdateParking(Parking parking);

        void DeleteParking(int parkingId);

        Parking GetParkingById(int parkingId);

        IEnumerable<Parking> GetParkings();
    }
}
