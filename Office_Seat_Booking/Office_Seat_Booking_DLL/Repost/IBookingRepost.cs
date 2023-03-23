using Office_Seat_Booking_Entity;

namespace Office_Seat_Booking_DLL.Repost
{
    public interface IBookingRepost
    {
        void UpdateBooking(Booking booking);

        void DeleteBooking(int bookingId);

        Booking GetBookingById(int bookingId);

        IEnumerable<Booking> GetBookings();

        void AddBooking(Booking booking);
    }
}
