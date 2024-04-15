using System.ComponentModel.DataAnnotations;

namespace BookingInRio.Models
{
    public class AboutApartment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
