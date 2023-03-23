using Office_Seat_Booking_Entity;

namespace Office_Seat_Booking_DLL.Repost
{
    public interface ISeatRepost
    {
        void AddSeat(Seat seat);
        void UpdateSeat(Seat seat);

        void DeleteSeat(int seatId);

        Seat GetSeatById(int seatId);

        IEnumerable<Seat> GetSeats();
    }
}
