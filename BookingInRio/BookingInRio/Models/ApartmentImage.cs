using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingInRio.Models
{
    public class ApartmentImage
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Path { get; set; }
        
        [Required]
        [ForeignKey("Apartment")]        
        public int ApartmentId { get; set; }
        public AboutApartment Apartment { get; set; }

    }
}
