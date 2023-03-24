<<<<<<< HEAD
﻿using Office_Seat_Booking_Entity;
=======
﻿
using Office_Seat_Booking_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f

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
