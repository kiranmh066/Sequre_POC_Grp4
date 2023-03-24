<<<<<<< HEAD
﻿namespace Office_Seat_Booking_Entity
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Seat_Booking_Entity
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f
{
    [Table("seat")]
    public class Seat
    {
<<<<<<< HEAD
        public int Seat_No { get; set; }

        [ForeignKey("Floor")]
        public int FloorID { get; set; }
        public Floor floor { get; set; }
=======
        [Key]
        public int Seat_No { get; set; }

        [ForeignKey("booking")]
        public int BookingID { get; set; }
        public Booking booking { get; set; }
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f
    }
}
