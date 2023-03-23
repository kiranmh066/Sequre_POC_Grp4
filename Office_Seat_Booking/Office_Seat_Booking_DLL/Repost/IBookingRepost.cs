using Office_Seat_Booking_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
