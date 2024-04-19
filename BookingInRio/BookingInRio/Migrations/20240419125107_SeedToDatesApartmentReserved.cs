using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingInRio.Migrations
{
    /// <inheritdoc />
    public partial class SeedToDatesApartmentReserved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DatesApartmentsReserved",
                columns: new[] { "Id", "AboutApartmentId", "ApartDi", "EndTime", "StartTime" },
                values: new object[] { 1, 1, 1, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DatesApartmentsReserved",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
