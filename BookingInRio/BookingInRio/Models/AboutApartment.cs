using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingInRio.Models
{
    public class AboutApartment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public float SizeOfRoomInSqrMeter { get; set; }
        public int BedCounts { get; set; }
        [Required]
        public double PriceOfRoom { get; set; }
        public int PersonLimitSize { get; set; }
        public string ApartmentThumbnailImagePath { get; set; }
        public DetailedApartment DetailedInformationApartment { get; set; }
        public List<DatesApartmentReserved> ReservedTimes { get; set; }
        public List<ApartmentImage> Images { get; set; }
    }
}
