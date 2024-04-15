using BookingInRio.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingInRio.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<AboutApartment> AboutApartments { get; set; }

    }
}
