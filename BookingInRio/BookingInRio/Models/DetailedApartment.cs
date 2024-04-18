using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingInRio.Models
{
    public class DetailedApartment
    {
        [Key]
        public int Id { get; set; }
        public string DetailedDescription{ get; set; }
        public int PersonLimitSize { get; set; }


        [ForeignKey("AboutApartment")]
        public int AboutApartmentId { get; set; }
        public AboutApartment AboutApartment { get; set; }

    }
}
