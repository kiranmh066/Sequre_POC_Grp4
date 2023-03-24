<<<<<<< HEAD
﻿using Office_Seat_Booking_Entity;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Office_Seat_Booking_Entity;
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f

namespace Office_Seat_Booking_DLL.Repost
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
