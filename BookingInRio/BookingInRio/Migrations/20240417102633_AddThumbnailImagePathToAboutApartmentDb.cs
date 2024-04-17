using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingInRio.Migrations
{
    /// <inheritdoc />
    public partial class AddThumbnailImagePathToAboutApartmentDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApartmentThumbnailImagePath",
                table: "AboutApartments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AboutApartments",
                keyColumn: "Id",
                keyValue: 1,
                column: "ApartmentThumbnailImagePath",
                value: "/assets/media/apartment-1.jpg");

            migrationBuilder.UpdateData(
                table: "AboutApartments",
                keyColumn: "Id",
                keyValue: 2,
                column: "ApartmentThumbnailImagePath",
                value: "/assets/media/apartment-2.jpg");

            migrationBuilder.UpdateData(
                table: "AboutApartments",
                keyColumn: "Id",
                keyValue: 3,
                column: "ApartmentThumbnailImagePath",
                value: "/assets/media/apartment-2.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApartmentThumbnailImagePath",
                table: "AboutApartments");
        }
    }
}
