using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Seat_Booking_Entity
{
    [Table("seat")]
    public class Seat
    {
        [Key]
        public int Seat_No { get; set; }


        [ForeignKey("booking")]


        public int BookingId { get; set; }
        public Booking booking { get; set; }
    }
}
