
using Office_Seat_Booking_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Seat_Booking_DLL.Repost
{
    public interface ISeatRepost
    {
        void AddSeat(Seat seat);
        void UpdateSeat(Seat seat);

        void DeleteSeat(int seatId);

        Seat GetSeatById(int seatId);

        IEnumerable<Seat> GetSeats();
    }
}
