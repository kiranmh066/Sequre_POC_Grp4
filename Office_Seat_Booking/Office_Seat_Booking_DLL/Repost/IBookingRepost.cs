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
    public interface IBookingRepost
    {
        void UpdateBooking(Booking booking);

        void DeleteBooking(int bookingId);

        Booking GetBookingById(int bookingId);

        IEnumerable<Booking> GetBookings();

        void AddBooking(Booking booking);
    }
}
