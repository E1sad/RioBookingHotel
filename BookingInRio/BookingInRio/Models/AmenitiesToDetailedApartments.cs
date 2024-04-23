using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingInRio.Models
{
    public class AmenitiesToDetailedApartments
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Apartment")]
        public int ApartmentId { get; set; }

        [Required]
        [ForeignKey("Amenity")]
        public int AmenityId {  get; set; }

        public DetailedApartment? Apartment { get; set; }

        public Amenity? Amenity { get; set; }
    }
}
