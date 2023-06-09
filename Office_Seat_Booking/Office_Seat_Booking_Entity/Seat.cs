﻿using System;
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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Seat_No { get; set; }

        [ForeignKey("floor")]
        public int FloorID { get; set; }
        public Floor floor { get; set; }
    }
}
