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
    [Table("parking")]
    public class Parking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ParkingID { get; set; }


        [Required]
<<<<<<< HEAD
        public string ParkingType { get; set; }

        [ForeignKey("Booking")]
=======
        public string ParkingType{ get; set; }

        [ForeignKey("booking")]
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f
        public int BookingID { get; set; }
        public Booking booking { get; set; }


    }
}
