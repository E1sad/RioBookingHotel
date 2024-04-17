using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingInRio.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailedApartment");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetailedApartment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApartmentId = table.Column<int>(type: "int", nullable: false),
                    DetailedDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonLimitSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailedApartment", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DetailedApartment",
                columns: new[] { "Id", "ApartmentId", "DetailedDescription", "PersonLimitSize" },
                values: new object[,]
                {
                    { 1, 1, "Affordable luxury. Our Junior Suites are the perfect option if you’re looking for a little extra luxury. With an open 65.5 square meter floor plan, the Junior Suites offer the extra space you need to spread out and enjoy the breathtaking views of the city skyline", 2 },
                    { 2, 3, "Affordable luxury. Our Penthouse are the perfect option if you’re looking for a little extra luxury. With an open 220 square foot floor plan, the Junior Suites offer the extra space you need to spread out and enjoy the breathtaking views of the city skyline", 2 },
                    { 3, 2, "Our King Suites represent affordable luxury, making them an excellent choice for those desiring a touch of extravagance. These suites provide a spacious 120.3 square meter layout that allows guests to relax comfortably while admiring stunning city skyline views.", 6 }
                });
        }
    }
}
