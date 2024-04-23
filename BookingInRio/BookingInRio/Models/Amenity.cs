using System.ComponentModel.DataAnnotations;

namespace BookingInRio.Models
{
    public class Amenity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ImagePath { get; set; }

        public List<AmenitiesToDetailedApartments> Apartments { get; set; }
    }
}
