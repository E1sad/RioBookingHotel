using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingInRio.Models
{
    public class DatesApartmentReserved
    {
        [Key]
        public int Id { get; set; }
        [Required, Column(TypeName = "date")]
        public DateTime StartTime { get; set; }
        [Required, Column(TypeName = "date")]
        public DateTime EndTime { get; set;}
        [ForeignKey("AboutApartment")]
        public int ApartDi { get; set; }
    }
}
