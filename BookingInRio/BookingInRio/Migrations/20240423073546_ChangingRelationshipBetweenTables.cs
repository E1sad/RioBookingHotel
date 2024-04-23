using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingInRio.Migrations
{
    /// <inheritdoc />
    public partial class ChangingRelationshipBetweenTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AmenitiesToDetailedApartments_AboutApartments_ApartmentId",
                table: "AmenitiesToDetailedApartments");

            migrationBuilder.AddForeignKey(
                name: "FK_AmenitiesToDetailedApartments_DetailedApartmentInfos_ApartmentId",
                table: "AmenitiesToDetailedApartments",
                column: "ApartmentId",
                principalTable: "DetailedApartmentInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AmenitiesToDetailedApartments_DetailedApartmentInfos_ApartmentId",
                table: "AmenitiesToDetailedApartments");

            migrationBuilder.AddForeignKey(
                name: "FK_AmenitiesToDetailedApartments_AboutApartments_ApartmentId",
                table: "AmenitiesToDetailedApartments",
                column: "ApartmentId",
                principalTable: "AboutApartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
