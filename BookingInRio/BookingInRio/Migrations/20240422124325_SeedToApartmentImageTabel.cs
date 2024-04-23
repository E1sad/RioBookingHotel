using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingInRio.Migrations
{
    /// <inheritdoc />
    public partial class SeedToApartmentImageTabel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApartmentImages",
                columns: new[] { "Id", "ApartmentId", "Path" },
                values: new object[,]
                {
                    { 1, 1, "/assets/media/apartment-1.jpg" },
                    { 2, 1, "/assets/media/aparment-long.jpg" },
                    { 3, 1, "/assets/media/aparment-short.jpg" },
                    { 4, 2, "/assets/media/download(1).jpg" },
                    { 5, 2, "/assets/media/apartment-2.jpg" },
                    { 6, 2, "/assets/media/download.jpg" },
                    { 7, 3, "/assets/media/example.jpg" },
                    { 8, 3, "/assets/media/standard.jpg" },
                    { 9, 3, "/assets/media/42442.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ApartmentImages",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
