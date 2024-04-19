using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingInRio.Migrations
{
    /// <inheritdoc />
    public partial class NewMigrationAfterSecondGreatPerge : Migration
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
                name: "SubscribersEmails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscribersEmails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DatesApartmentsReserved",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<DateTime>(type: "date", nullable: false),
                    EndTime = table.Column<DateTime>(type: "date", nullable: false),
                    ApartDi = table.Column<int>(type: "int", nullable: false),
                    AboutApartmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatesApartmentsReserved", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DatesApartmentsReserved_AboutApartments_AboutApartmentId",
                        column: x => x.AboutApartmentId,
                        principalTable: "AboutApartments",
                        principalColumn: "Id");
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

            migrationBuilder.InsertData(
                table: "AboutApartments",
                columns: new[] { "Id", "ApartmentThumbnailImagePath", "BedCounts", "Description", "Name", "PersonLimitSize", "PriceOfRoom", "SizeOfRoomInSqrMeter" },
                values: new object[,]
                {
                    { 1, "/assets/media/apartment-1.jpg", 2, "Our Junior Suites offer breathtaking views of the city skyline.", "Junior Suite", 2, 250.0, 65.5f },
                    { 2, "/assets/media/apartment-2.jpg", 4, "Our King Suites offer breathtaking views of the city skyline.", "King Suite", 6, 500.0, 120.3f },
                    { 3, "/assets/media/apartment-3.jpg", 2, "Our Penthouse Suites offer breathtaking views of the city skyline.", "Penthouse", 2, 1250.0, 220f }
                });

            migrationBuilder.InsertData(
                table: "DetailedApartmentInfos",
                columns: new[] { "Id", "AboutApartmentId", "DetailedDescription", "PersonLimitSize" },
                values: new object[,]
                {
                    { 1, 1, "Affordable luxury. Our Junior Suites are the perfect option if you’re looking for a little extra luxury. With an open 65.5 square meter floor plan, the Junior Suites offer the extra space you need to spread out and enjoy the breathtaking views of the city skyline", 2 },
                    { 2, 3, "Affordable luxury. Our Penthouse are the perfect option if you’re looking for a little extra luxury. With an open 220 square foot floor plan, the Junior Suites offer the extra space you need to spread out and enjoy the breathtaking views of the city skyline", 2 },
                    { 3, 2, "Our King Suites represent affordable luxury, making them an excellent choice for those desiring a touch of extravagance. These suites provide a spacious 120.3 square meter layout that allows guests to relax comfortably while admiring stunning city skyline views.", 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DatesApartmentsReserved_AboutApartmentId",
                table: "DatesApartmentsReserved",
                column: "AboutApartmentId");

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
                name: "DatesApartmentsReserved");

            migrationBuilder.DropTable(
                name: "DetailedApartmentInfos");

            migrationBuilder.DropTable(
                name: "SubscribersEmails");

            migrationBuilder.DropTable(
                name: "AboutApartments");
        }
    }
}
