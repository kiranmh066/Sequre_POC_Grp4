using Office_Seat_Booking_DLL.Repost;
using Office_Seat_Booking_Entity;

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
        public void AddAppointment(Booking booking)
        {
            _bookingRepost.AddAppointment(booking);
        }

        //Delete Appointment

        public void DeleteAppointment(int BookingID)
        {
            _bookingRepost.DeleteAppointment(BookingID);
        }

        //Update Appointment

        public void UpdateAppointment(Booking booking)
        {
            _bookingRepost.UpdateAppointment(booking);
        }

        //Get getAppointments

        public IEnumerable<Booking> GetAppointment()
        {
            return _bookingRepost.GetAppointment();
        }
        public Booking GetByAppointmentId(int BookingID)
        {
            return _bookingRepost.GetAppointmentById(BookingID);
        }
    }
}
