using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingInRio.Migrations
{
    /// <inheritdoc />
    public partial class AddingSeedToAmenitiesToDetailedApartmentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AmenitiesToDetailedApartments",
                columns: new[] { "Id", "AmenityId", "ApartmentId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 3, 1 },
                    { 3, 1, 2 },
                    { 4, 3, 2 },
                    { 5, 4, 2 },
                    { 6, 5, 2 },
                    { 7, 1, 3 },
                    { 8, 2, 3 },
                    { 9, 3, 3 },
                    { 10, 4, 3 },
                    { 11, 5, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AmenitiesToDetailedApartments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AmenitiesToDetailedApartments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AmenitiesToDetailedApartments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AmenitiesToDetailedApartments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AmenitiesToDetailedApartments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AmenitiesToDetailedApartments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AmenitiesToDetailedApartments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AmenitiesToDetailedApartments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AmenitiesToDetailedApartments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AmenitiesToDetailedApartments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AmenitiesToDetailedApartments",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
