using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Seat_booking_Entity
{
    [Table("parking")]
    public class Parking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ParkingID { get; set; }


        [Required]
        public string ParkingType{ get; set; }

        [ForeignKey("booking")]
        public int BookingID { get; set; }
        public booking booking { get; set; }


    }
}
