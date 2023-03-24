<<<<<<< HEAD
﻿using Office_Seat_Booking_Entity;

namespace Office_Seat_Booking_DLL.Repost
{
    public class BookingRepost : IBookingRepost
=======
﻿using Microsoft.EntityFrameworkCore;
using Office_Seat_Booking_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Seat_Booking_DLL.Repost
{
    public class BookingRepost:IBookingRepost
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f
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

<<<<<<< HEAD

=======
        
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f
        public void UpdateBooking(Booking booking)
        {

            _dbContext.Entry(booking).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

    }
}
