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
    [Table("floor")]
    public class Floor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FloorID { get; set; }

        [Required]
<<<<<<< HEAD
        public string FloorName { get; set; }
=======
        public string FloorName { get; set; }   
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f

    }
}
