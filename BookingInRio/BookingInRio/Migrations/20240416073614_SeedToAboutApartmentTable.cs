using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingInRio.Migrations
{
    /// <inheritdoc />
    public partial class SeedToAboutApartmentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AboutApartments",
                columns: new[] { "Id", "BedCounts", "Description", "Name", "PersonLimitSize", "PriceOfRoom", "SizeOfRoomInSqrMeter" },
                values: new object[,]
                {
                    { 1, 2, "Our Junior Suites offer breathtaking views of the city skyline.", "Junior Suite", 2, 250.0, 65.5f },
                    { 2, 4, "Our King Suites offer breathtaking views of the city skyline.", "King Suite", 6, 500.0, 120.3f },
                    { 3, 2, "Our Penthouse Suites offer breathtaking views of the city skyline.", "Penthouse", 2, 1250.0, 220f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
