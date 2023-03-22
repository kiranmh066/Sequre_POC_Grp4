using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Office_Seat_Booking_Entity
{
    [Table("booking")]
    public class Empoyee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpID { get; set; }

        
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