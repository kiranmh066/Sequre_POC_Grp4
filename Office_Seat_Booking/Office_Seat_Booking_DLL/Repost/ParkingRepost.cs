using Microsoft.EntityFrameworkCore;
using Office_Seat_Booking_DLL;
using Office_Seat_Booking_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Seat_Booking_DLL.Repost
{
    public class ParkingRepost:IParkingRepost
    {
        OfficeDbContext _dbContext;//default private

        public ParkingRepost(OfficeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddParking(Parking parking)
        {
            _dbContext.parking.Add(parking);
            _dbContext.SaveChanges();
        }

        public void DeleteParking(int parkingId)
        {
            var parking = _dbContext.parking.Find(parkingId);
            _dbContext.parking.Remove(parking);
            _dbContext.SaveChanges();
        }

        public Parking GetParkingById(int parkingId)
        {
            return _dbContext.parking.Find(parkingId);
        }

        public IEnumerable<Parking> GetParkings()
        {
            return _dbContext.parking.ToList();
        }


        public void UpdateParking(Parking parking)
        {

            _dbContext.Entry(parking).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
