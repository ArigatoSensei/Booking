using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixedDateInReservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookingDate",
                schema: "19118162",
                table: "Reservations",
                newName: "ReservationDate");

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(569));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(582));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 101,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 102,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 103,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 104,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 201,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 202,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 203,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 301,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 302,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 13, 18, 56, 35, 990, DateTimeKind.Local).AddTicks(295));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReservationDate",
                schema: "19118162",
                table: "Reservations",
                newName: "BookingDate");

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
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 17, 5, 33, 80, DateTimeKind.Local).AddTicks(3591));
        }
    }
}
