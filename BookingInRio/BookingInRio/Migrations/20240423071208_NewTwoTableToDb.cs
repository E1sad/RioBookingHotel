using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingInRio.Migrations
{
    /// <inheritdoc />
    public partial class NewTwoTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amenities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmenitiesToDetailedApartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApartmentId = table.Column<int>(type: "int", nullable: false),
                    AmenityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmenitiesToDetailedApartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AmenitiesToDetailedApartments_AboutApartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "AboutApartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AmenitiesToDetailedApartments_Amenities_AmenityId",
                        column: x => x.AmenityId,
                        principalTable: "Amenities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ApartmentImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Path",
                value: "/assets/media/download (1).jpg");

            migrationBuilder.CreateIndex(
                name: "IX_AmenitiesToDetailedApartments_AmenityId",
                table: "AmenitiesToDetailedApartments",
                column: "AmenityId");

            migrationBuilder.CreateIndex(
                name: "IX_AmenitiesToDetailedApartments_ApartmentId",
                table: "AmenitiesToDetailedApartments",
                column: "ApartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmenitiesToDetailedApartments");

            migrationBuilder.DropTable(
                name: "Amenities");

            migrationBuilder.UpdateData(
                table: "ApartmentImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Path",
                value: "/assets/media/download(1).jpg");
        }
    }
}
