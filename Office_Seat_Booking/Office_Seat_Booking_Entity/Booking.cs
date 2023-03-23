namespace Office_Seat_Booking_Entity
{
    [Table("booking")]
    public class Booking
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingID { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public Employee employee { get; set; }


        [Required]
        public int Food_Type { get; set; }

        [Required]
        public int Type_Of_Request { get; set; }

        [Required]
        public DateOnly From_Date { get; set; }

        [Required]
        public DateOnly To_Date { get; set; }

        [Required]
        public TimeOnly Shift_Time { get; set; }

        [ForeignKey("Seat")]
        public int Seat_No { get; set; }
        public Seat seat { get; set; }

        [Required]
        public int Booking_Status { get; set; }


        [Required]
        public bool Emp_Status { get; set; }

        [Required]
        public bool Vehicle { get; set; }
    }
}
