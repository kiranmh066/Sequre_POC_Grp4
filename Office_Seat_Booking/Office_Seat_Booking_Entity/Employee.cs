﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace Office_Seat_Booking_Entity
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpID { get; set; }

        [AllowNull]
        [Column(TypeName = "varchar(30)")]
        public string Name { get; set; }

        [AllowNull]
        public int PhoneNo { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [AllowNull]
        public char Gender { get; set; }

        [AllowNull]
        public string Secret_Key { get; set; }
        [AllowNull]
        [Column(TypeName = "varchar(30)")]
        public string Place { get; set; }

        [AllowNull]
        public string Role { get; set; }

        [AllowNull]
        public string Designation { get; set; }

    }
}