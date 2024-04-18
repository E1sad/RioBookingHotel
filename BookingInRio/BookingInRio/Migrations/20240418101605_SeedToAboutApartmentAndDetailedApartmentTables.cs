using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingInRio.Migrations
{
    /// <inheritdoc />
    public partial class SeedToAboutApartmentAndDetailedApartmentTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AboutApartments",
                columns: new[] { "Id", "ApartmentThumbnailImagePath", "BedCounts", "Description", "Name", "PersonLimitSize", "PriceOfRoom", "SizeOfRoomInSqrMeter" },
                values: new object[,]
                {
                    { 1, "/assets/media/apartment-1.jpg", 2, "Our Junior Suites offer breathtaking views of the city skyline.", "Junior Suite", 2, 250.0, 65.5f },
                    { 2, "/assets/media/apartment-2.jpg", 4, "Our King Suites offer breathtaking views of the city skyline.", "King Suite", 6, 500.0, 120.3f },
                    { 3, "/assets/media/apartment-3.jpg", 2, "Our Penthouse Suites offer breathtaking views of the city skyline.", "Penthouse", 2, 1250.0, 220f }
                });

            migrationBuilder.InsertData(
                table: "DetailedApartmentInfos",
                columns: new[] { "Id", "AboutApartmentId", "DetailedDescription", "PersonLimitSize" },
                values: new object[,]
                {
                    { 1, 1, "Affordable luxury. Our Junior Suites are the perfect option if you’re looking for a little extra luxury. With an open 65.5 square meter floor plan, the Junior Suites offer the extra space you need to spread out and enjoy the breathtaking views of the city skyline", 2 },
                    { 2, 3, "Affordable luxury. Our Penthouse are the perfect option if you’re looking for a little extra luxury. With an open 220 square foot floor plan, the Junior Suites offer the extra space you need to spread out and enjoy the breathtaking views of the city skyline", 2 },
                    { 3, 2, "Our King Suites represent affordable luxury, making them an excellent choice for those desiring a touch of extravagance. These suites provide a spacious 120.3 square meter layout that allows guests to relax comfortably while admiring stunning city skyline views.", 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DetailedApartmentInfos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DetailedApartmentInfos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DetailedApartmentInfos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AboutApartments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AboutApartments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AboutApartments",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
