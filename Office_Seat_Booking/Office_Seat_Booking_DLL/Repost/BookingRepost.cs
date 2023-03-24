using Microsoft.EntityFrameworkCore;
using Office_Seat_Booking_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Seat_Booking_DLL.Repost
{
    public class BookingRepost:IBookingRepost
    {
        OfficeDbContext _dbContext;//default private

        public BookingRepost(OfficeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddBooking(Booking booking)
        {
            _dbContext.booking.Add(booking);
            _dbContext.SaveChanges();
        }

        public void DeleteBooking(int bookingId)
        {
            var booking = _dbContext.booking.Find(bookingId);
            _dbContext.booking.Remove(booking);
            _dbContext.SaveChanges();
        }

        public Booking GetBookingById(int bookingId)
        {
            return _dbContext.booking.Find(bookingId);
        }

        public IEnumerable<Booking> GetBookings()
        {
            return _dbContext.booking.ToList();
        }

        
        public void UpdateBooking(Booking booking)
        {

            _dbContext.Entry(booking).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

    }
}
