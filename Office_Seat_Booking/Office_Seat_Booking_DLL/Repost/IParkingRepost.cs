using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Office_Seat_booking_Entity;

namespace Office_Seat_booking_DLL.Repost
{
    public interface IParkingRepost
    {
        void AddParking(Parking parking);
        void UpdateParking(Parking parking);

        void DeleteParking(int parkingId);

        Parking GetParkingById(int parkingId);

        IEnumerable<Parking> GetParkings();
    }
}
