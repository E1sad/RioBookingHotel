using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingInRio.Migrations
{
    /// <inheritdoc />
    public partial class AddingDataAnnotationsAndRenaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SizeOfRoom",
                table: "AboutApartments",
                newName: "SizeOfRoomInSqrMeter");

            migrationBuilder.RenameColumn(
                name: "LimitPersonSize",
                table: "AboutApartments",
                newName: "PersonLimitSize");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SizeOfRoomInSqrMeter",
                table: "AboutApartments",
                newName: "SizeOfRoom");

            migrationBuilder.RenameColumn(
                name: "PersonLimitSize",
                table: "AboutApartments",
                newName: "LimitPersonSize");
        }
    }
}
