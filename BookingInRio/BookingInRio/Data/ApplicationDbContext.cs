using BookingInRio.Models;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using Microsoft.EntityFrameworkCore;

namespace BookingInRio.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<AboutApartment> AboutApartments { get; set; }

        public DbSet<DetailedApartment> DetailedApartmentInfos { get; set; }

        public DbSet<EmailList> SubscribersEmails { get; set; }
        
        public DbSet<DatesApartmentReserved> DatesApartmentsReserved { get; set; }

        public DbSet<ApartmentImage> ApartmentImages { get; set; }

        public DbSet<Amenity> Amenities { get; set; }

        public DbSet<AmenitiesToDetailedApartments> AmenitiesToDetailedApartments { get; set; }

        public DbSet<UserReservationData> UserReservationData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AmenitiesToDetailedApartments>().HasData(
                new AmenitiesToDetailedApartments { 
                    Id = 1,
                    AmenityId = 1,
                    ApartmentId = 1
                },
                new AmenitiesToDetailedApartments                {
                    Id = 2,
                    AmenityId = 3,
                    ApartmentId = 1
                },
                new AmenitiesToDetailedApartments
                {
                    Id = 3,
                    AmenityId = 1,
                    ApartmentId = 2
                },
                new AmenitiesToDetailedApartments
                {
                    Id = 4,
                    AmenityId = 3,
                    ApartmentId = 2
                },
                new AmenitiesToDetailedApartments
                {
                    Id = 5,
                    AmenityId = 4,
                    ApartmentId = 2
                },
                new AmenitiesToDetailedApartments
                {
                    Id = 6,
                    AmenityId = 5,
                    ApartmentId = 2
                },
                new AmenitiesToDetailedApartments
                {
                    Id = 7,
                    AmenityId = 1,
                    ApartmentId = 3
                },
                new AmenitiesToDetailedApartments
                {
                    Id = 8,
                    AmenityId = 2,
                    ApartmentId = 3
                },
                new AmenitiesToDetailedApartments
                {
                    Id = 9,
                    AmenityId = 3,
                    ApartmentId = 3
                },
                new AmenitiesToDetailedApartments
                {
                    Id = 10,
                    AmenityId = 4,
                    ApartmentId = 3
                },
                new AmenitiesToDetailedApartments
                {
                    Id = 11,
                    AmenityId = 5,
                    ApartmentId = 3
                });
            modelBuilder.Entity<Amenity>().HasData(
                new Amenity
                {
                    Id = 1,
                    Name = "Wi - Fi",
                    ImagePath = "/assets/media/AmenityIcons/wifi.png"
                },
                new Amenity
                {
                    Id = 2,
                    Name = "Gym",
                    ImagePath = "/assets/media/AmenityIcons/gym.png"
                },
                new Amenity
                {
                    Id = 3,
                    Name = "Paper",
                    ImagePath = "/assets/media/AmenityIcons/paper.png"
                },
                new Amenity
                {
                    Id = 4,
                    Name = "Parking",
                    ImagePath = "/assets/media/AmenityIcons/parking.png"
                },
                new Amenity
                {
                    Id = 5,
                    Name = "Slipper",
                    ImagePath = "/assets/media/AmenityIcons/slipper.png"
                });
            modelBuilder.Entity<ApartmentImage>().HasData(
                new ApartmentImage
                {
                    Id = 1,
                    Path = "/assets/media/apartment-1.jpg",
                    ApartmentId = 1
                },
                new ApartmentImage
                {
                    Id=2,
                    Path = "/assets/media/aparment-long.jpg",
                    ApartmentId = 1
                },
                new ApartmentImage
                {
                    Id = 3,
                    Path = "/assets/media/aparment-short.jpg",
                    ApartmentId = 1
                },
                new ApartmentImage
                {
                    Id = 4,
                    Path = "/assets/media/download (1).jpg",
                    ApartmentId = 2
                },
                new ApartmentImage
                {
                    Id = 5,
                    Path = "/assets/media/apartment-2.jpg",
                    ApartmentId = 2
                },
                new ApartmentImage
                {
                    Id = 6,
                    Path = "/assets/media/download.jpg",
                    ApartmentId = 2
                },
                new ApartmentImage
                {
                    Id = 7,
                    Path = "/assets/media/example.jpg",
                    ApartmentId = 3
                },
                new ApartmentImage
                {
                    Id = 8,
                    Path = "/assets/media/standard.jpg",
                    ApartmentId = 3
                },
                new ApartmentImage
                {
                    Id = 9,
                    Path = "/assets/media/42442.jpg",
                    ApartmentId = 3
                });
            modelBuilder.Entity<DatesApartmentReserved>().HasData(
                new DatesApartmentReserved
                {
                    Id = 1,
                    StartTime = new DateTime(2024,04,22),
                    EndTime = new DateTime(2024, 04, 26),
                    ApartId = 1,
                },
                new DatesApartmentReserved
                {
                    Id = 2,
                    StartTime = new DateTime(2024, 03, 22),
                    EndTime = new DateTime(2024, 03, 26),
                    ApartId = 3,
                },
                new DatesApartmentReserved
                {
                    Id = 3,
                    StartTime = new DateTime(2024, 04, 24),
                    EndTime = new DateTime(2024, 04, 28),
                    ApartId = 2,
                });
            modelBuilder.Entity<DetailedApartment>().HasData(
                new DetailedApartment
                {
                    Id = 1,
                    DetailedDescription = "Affordable luxury. Our Junior Suites are the perfect option if you’re looking for a little extra luxury. With an open 65.5 square meter floor plan, the Junior Suites offer the extra space you need to spread out and enjoy the breathtaking views of the city skyline",
                    PersonLimitSize = 2,
                    AboutApartmentId = 1
                },
                new DetailedApartment
                {
                    Id = 2,
                    DetailedDescription = "Affordable luxury. Our Penthouse are the perfect option if you’re looking for a little extra luxury. With an open 220 square foot floor plan, the Junior Suites offer the extra space you need to spread out and enjoy the breathtaking views of the city skyline",
                    PersonLimitSize = 2,
                    AboutApartmentId = 3
                },
                new DetailedApartment
                {
                    Id = 3,
                    DetailedDescription = "Our King Suites represent affordable luxury, making them an excellent choice for those desiring a touch of extravagance. These suites provide a spacious 120.3 square meter layout that allows guests to relax comfortably while admiring stunning city skyline views.",
                    PersonLimitSize = 6,
                    AboutApartmentId = 2
                }
                );
            modelBuilder.Entity<AboutApartment>().HasData(
                new AboutApartment
                {
                    Id = 1,
                    Name = "Junior Suite",
                    Description = "Our Junior Suites offer breathtaking views of the city skyline.",
                    BedCounts = 2,
                    SizeOfRoomInSqrMeter = 65.5f,
                    PersonLimitSize = 2,
                    PriceOfRoom = 250,
                    ApartmentThumbnailImagePath = "/assets/media/apartment-1.jpg"
                },
                new AboutApartment
                {
                    Id = 2,
                    Name = "King Suite",
                    Description = "Our King Suites offer breathtaking views of the city skyline.",
                    BedCounts = 4,
                    SizeOfRoomInSqrMeter = 120.3f,
                    PersonLimitSize = 6,
                    PriceOfRoom = 500,
                    ApartmentThumbnailImagePath = "/assets/media/apartment-2.jpg"
                },
                new AboutApartment
                {
                    Id = 3,
                    Name = "Penthouse",
                    Description = "Our Penthouse Suites offer breathtaking views of the city skyline.",
                    BedCounts = 2,
                    SizeOfRoomInSqrMeter = 220f,
                    PersonLimitSize = 2,
                    PriceOfRoom = 1250,
                    ApartmentThumbnailImagePath = "/assets/media/apartment-3.jpg"
                }
                );
        }
    }
}
