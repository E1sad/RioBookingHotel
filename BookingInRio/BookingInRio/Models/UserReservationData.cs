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

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Country { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string? SpecialRequest { get; set; }

        [Required, ForeignKey("Apartment")]
        public int ApartmentId { get; set; }

        public AboutApartment Apartment { get; set; }
    }
}
