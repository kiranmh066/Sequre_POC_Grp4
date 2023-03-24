<<<<<<< HEAD
﻿using Office_Seat_Booking_DLL;
using Office_Seat_Booking_DLL.Repost;
using Office_Seat_Booking_Entity;

namespace Office_Seat_Seat_DLL.Repost
{
    public class SeatRepost : ISeatRepost
=======
﻿using Microsoft.EntityFrameworkCore;
using Office_Seat_Booking_DLL;
using Office_Seat_Booking_Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Seat_Booking_DLL.Repost
{
    public class SeatRepost:ISeatRepost
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f
    {
        OfficeDbContext _dbContext;//default private

        public SeatRepost(OfficeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddSeat(Seat seat)
        {
            _dbContext.seat.Add(seat);
            _dbContext.SaveChanges();
        }

        public void DeleteSeat(int seatId)
        {
            var seat = _dbContext.seat.Find(seatId);
            _dbContext.seat.Remove(seat);
            _dbContext.SaveChanges();
        }

        public Seat GetSeatById(int seatId)
        {
            return _dbContext.seat.Find(seatId);
        }

        public IEnumerable<Seat> GetSeats()
        {
            return _dbContext.seat.ToList();
        }


        public void UpdateSeat(Seat seat)
        {

            _dbContext.Entry(seat).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
