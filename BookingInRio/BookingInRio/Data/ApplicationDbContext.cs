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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AboutApartment>().HasData(
                new AboutApartment
                {
                    Id = 1,
                    Name = "Junior Suite",
                    Description = "Our Junior Suites offer breathtaking views of the city skyline.",
                    BedCounts = 2,
                    SizeOfRoomInSqrMeter = 65.5f,
                    PersonLimitSize = 2,
                    PriceOfRoom = 250
                },
                new AboutApartment
                {
                    Id = 2,
                    Name = "King Suite",
                    Description = "Our King Suites offer breathtaking views of the city skyline.",
                    BedCounts = 4,
                    SizeOfRoomInSqrMeter = 120.3f,
                    PersonLimitSize = 6,
                    PriceOfRoom = 500
                },
                new AboutApartment
                {
                    Id = 3,
                    Name = "Penthouse",
                    Description = "Our Penthouse Suites offer breathtaking views of the city skyline.",
                    BedCounts = 2,
                    SizeOfRoomInSqrMeter = 220f,
                    PersonLimitSize = 2,
                    PriceOfRoom = 1250
                }
                );
        }
    }
}
