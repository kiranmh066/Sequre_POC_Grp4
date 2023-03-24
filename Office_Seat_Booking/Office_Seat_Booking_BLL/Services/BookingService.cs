using Office_Seat_Booking_DLL.Repost;
using Office_Seat_Booking_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Seat_Booking_BLL.Services
{
    public class BookingService
    {
        IBookingRepost _bookingRepost;
        public BookingService(IBookingRepost bookingRepost)
        {
            _bookingRepost = bookingRepost;
        }

        //Add Appointment
        public void AddBooking(Booking booking)
        {
            _bookingRepost.AddBooking(booking);
        }

        //Delete Appointment

        public void DeleteBooking(int bookingID)
        {
            _bookingRepost.DeleteBooking(bookingID);
        }

        //Update Appointment

        public void UpdateBooking(Booking booking)
        {
            _bookingRepost.UpdateBooking(booking);
        }

        //Get getAppointments

        public IEnumerable<Booking> GetBookings()
        {
            return _bookingRepost.GetBookings();
        }
        public Booking GetBookingById(int bookingID)
        {
            return _bookingRepost.GetBookingById(bookingID);
        }
    }
}
