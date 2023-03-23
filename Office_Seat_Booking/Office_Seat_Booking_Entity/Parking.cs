namespace Office_Seat_Booking_Entity
{
    [Table("parking")]
    public class Parking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ParkingID { get; set; }


        [Required]
        public string ParkingType { get; set; }

        [ForeignKey("Booking")]
        public int BookingID { get; set; }
        public Booking booking { get; set; }


    }
}
