<<<<<<< HEAD
﻿namespace Office_Seat_Booking_Entity
=======
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Office_Seat_Booking_Entity
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpID { get; set; }

<<<<<<< HEAD

=======
        
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f
        [Column(TypeName = "varchar(30)")]
        public string Name { get; set; }

        [Required]
        public int PhoneNo { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public char Gender { get; set; }

        [Required]
        public string Secret_Key { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Place { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        public string Designation { get; set; }

    }
}