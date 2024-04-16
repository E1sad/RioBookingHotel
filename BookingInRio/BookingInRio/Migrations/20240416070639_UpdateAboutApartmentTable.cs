using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingInRio.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAboutApartmentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BedCounts",
                table: "AboutApartments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LimitPersonSize",
                table: "AboutApartments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "PriceOfRoom",
                table: "AboutApartments",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<float>(
                name: "SizeOfRoom",
                table: "AboutApartments",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BedCounts",
                table: "AboutApartments");

            migrationBuilder.DropColumn(
                name: "LimitPersonSize",
                table: "AboutApartments");

            migrationBuilder.DropColumn(
                name: "PriceOfRoom",
                table: "AboutApartments");

            migrationBuilder.DropColumn(
                name: "SizeOfRoom",
                table: "AboutApartments");
        }
    }
}
