using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingInRio.Models
{
    public class UserReservationData
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime StartingDate { get; set; }

        [Required]
        public DateTime EndingTime { get; set; }

        [Required, Range(1,10)]
        public int PersonCount { get; set; }

        [Required, Range(1, 10)]
        public int BedCount { get; set; }

        [Required, ForeignKey("Apartment")]
        public int ApartmentId { get; set; }

        public AboutApartment Apartment { get; set; }
    }
}
