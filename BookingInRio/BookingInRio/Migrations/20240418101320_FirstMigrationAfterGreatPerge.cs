using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingInRio.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigrationAfterGreatPerge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutApartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SizeOfRoomInSqrMeter = table.Column<float>(type: "real", nullable: false),
                    BedCounts = table.Column<int>(type: "int", nullable: false),
                    PriceOfRoom = table.Column<double>(type: "float", nullable: false),
                    PersonLimitSize = table.Column<int>(type: "int", nullable: false),
                    ApartmentThumbnailImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutApartments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetailedApartmentInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetailedDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonLimitSize = table.Column<int>(type: "int", nullable: false),
                    AboutApartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailedApartmentInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailedApartmentInfos_AboutApartments_AboutApartmentId",
                        column: x => x.AboutApartmentId,
                        principalTable: "AboutApartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailedApartmentInfos_AboutApartmentId",
                table: "DetailedApartmentInfos",
                column: "AboutApartmentId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailedApartmentInfos");

            migrationBuilder.DropTable(
                name: "AboutApartments");
        }
    }
}
