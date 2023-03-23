namespace Office_Seat_Booking_Entity
{
    [Table("floor")]
    public class Floor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FloorID { get; set; }

        [Required]
        public string FloorName { get; set; }

    }
}
