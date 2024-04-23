using System.ComponentModel.DataAnnotations;

namespace BookingInRio.Models
{
    public class SearchModel
    {

        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set;}
        public int PersonCount { get; set; }
        public int BedCount { get; set; }
    }
}

