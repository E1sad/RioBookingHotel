using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingInRio.Migrations
{
    /// <inheritdoc />
    public partial class addmigrationNewImagePathesToAboutApartmentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutApartments",
                keyColumn: "Id",
                keyValue: 3,
                column: "ApartmentThumbnailImagePath",
                value: "/assets/media/apartment-3.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutApartments",
                keyColumn: "Id",
                keyValue: 3,
                column: "ApartmentThumbnailImagePath",
                value: "/assets/media/apartment-2.jpg");
        }
    }
}
