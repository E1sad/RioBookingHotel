using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingInRio.Models
{
    public class EmailList
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }

        [Required, Column(TypeName="date")]
        public DateTime date { get; set; }
    }
}
