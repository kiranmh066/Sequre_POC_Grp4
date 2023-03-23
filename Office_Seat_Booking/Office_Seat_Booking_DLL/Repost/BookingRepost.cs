using Microsoft.EntityFrameworkCore;
using Office_Seat_booking_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Seat_booking_DLL.Repost
{
    public class bookingRepost:IbookingRepost
    {
        OfficeDbContext _dbContext;//default private

        public bookingRepost(OfficeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Addbooking(Booking booking)
        {
            _dbContext.booking.Add(booking);
            _dbContext.SaveChanges();
        }

        public void Deletebooking(int bookingId)
        {
            var booking = _dbContext.booking.Find(bookingId);
            _dbContext.booking.Remove(booking);
            _dbContext.SaveChanges();
        }

        public Booking GetbookingById(int bookingId)
        {
            return _dbContext.booking.Find(bookingId);
        }

        public IEnumerable<Booking> Getbookings()
        {
            return _dbContext.booking.ToList();
        }

        
        public void Updatebooking(Booking booking)
        {

            _dbContext.Entry(booking).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

    }
}
