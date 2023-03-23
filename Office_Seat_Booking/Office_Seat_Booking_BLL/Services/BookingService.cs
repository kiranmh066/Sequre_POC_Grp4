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
        public void AddAppointment(Booking booking)
        {
            _employeeRepost.AddAppointment(booking);
        }

        //Delete Appointment

        public void DeleteAppointment(int BookingID)
        {
            _employeeRepost.DeleteAppointment(BookingID);
        }

        //Update Appointment

        public void UpdateAppointment(Booking booking)
        {
            _employeeRepost.UpdateAppointment(booking);
        }

        //Get getAppointments

        public IEnumerable<Booking> GetAppointment()
        {
            return _employeeRepost.GetAppointment();
        }
        public Booking GetByAppointmentId(int BookingID)
        {
            return _employeeRepost.GetAppointmentById(BookingID);
        }
    }
}
