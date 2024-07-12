using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addBookingToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservations",
                schema: "19118162",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VillaId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalCost = table.Column<double>(type: "float", nullable: false),
                    Nights = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckInDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CheckOutDate = table.Column<DateOnly>(type: "date", nullable: false),
                    IsPaymentSuccessful = table.Column<bool>(type: "bit", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StripeSessionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StripePaymentIntentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActualCheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualCheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VillaNumber = table.Column<int>(type: "int", nullable: false),
                    Date_19118162 = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Villas_VillaId",
                        column: x => x.VillaId,
                        principalSchema: "19118162",
                        principalTable: "Villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 101,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 102,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 103,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 104,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 201,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 202,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 203,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 301,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 302,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date_19118162", "Description" },
                values: new object[] { new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3548), "Villa, country estate, complete with house, grounds, and subsidiary buildings." });

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date_19118162", "Description" },
                values: new object[] { new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3589), "Villa, country estate, complete with house, grounds, and subsidiary buildings." });

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date_19118162", "Description" },
                values: new object[] { new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3591), "Villa, country estate, complete with house, grounds, and subsidiary buildings." });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                schema: "19118162",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_VillaId",
                schema: "19118162",
                table: "Reservations",
                column: "VillaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations",
                schema: "19118162");

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5706));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 101,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 102,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 103,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 104,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 201,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 202,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 203,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 301,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 302,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date_19118162", "Description" },
                values: new object[] { new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5438), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim." });

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date_19118162", "Description" },
                values: new object[] { new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5477), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim." });

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date_19118162", "Description" },
                values: new object[] { new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5480), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim." });
        }
    }
}
