using Office_Seat_Booking_DLL.Repost;
using Office_Seat_Booking_Entity;
<<<<<<< HEAD
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f

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
<<<<<<< HEAD
        public void AddAppointment(Booking booking)
        {
            _bookingRepost.AddAppointment(booking);
=======
        public void AddBooking(Booking booking)
        {
            _bookingRepost.AddBooking(booking);
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f
        }

        //Delete Appointment

<<<<<<< HEAD
        public void DeleteAppointment(int BookingID)
        {
            _bookingRepost.DeleteAppointment(BookingID);
=======
        public void DeleteBooking(int bookingID)
        {
            _bookingRepost.DeleteBooking(bookingID);
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f
        }

        //Update Appointment

<<<<<<< HEAD
        public void UpdateAppointment(Booking booking)
        {
            _bookingRepost.UpdateAppointment(booking);
=======
        public void UpdateBooking(Booking booking)
        {
            _bookingRepost.UpdateBooking(booking);
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f
        }

        //Get getAppointments

<<<<<<< HEAD
        public IEnumerable<Booking> GetAppointment()
        {
            return _bookingRepost.GetAppointment();
        }
        public Booking GetByAppointmentId(int BookingID)
        {
            return _bookingRepost.GetAppointmentById(BookingID);
=======
        public IEnumerable<Booking> GetBookings()
        {
            return _bookingRepost.GetBookings();
        }
        public Booking GetBookingById(int bookingID)
        {
            return _bookingRepost.GetBookingById(bookingID);
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f
        }
    }
}
