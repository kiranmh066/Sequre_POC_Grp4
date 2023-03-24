using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Seat_Booking_Entity
{
    [Table("seat")]
    public class Seat
    {
        public int Seat_No { get; set; }

<<<<<<< HEAD
        [ForeignKey("booking")]
        public int BookingID { get; set; }
        public booking booking { get; set; }
=======
        [ForeignKey("floor")]

        public int FloorID { get; set; }
        public Floor floor { get; set; }
>>>>>>> 7e518fababa9a419a691327be98a8c0278557ab6
    }
}
