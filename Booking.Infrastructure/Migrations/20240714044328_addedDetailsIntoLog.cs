using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addedDetailsIntoLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Details",
                schema: "19118162",
                table: "Log_19118162",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 101,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 102,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 103,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 104,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 201,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 202,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 203,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 301,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 302,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 14, 7, 43, 25, 299, DateTimeKind.Local).AddTicks(6668));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details",
                schema: "19118162",
                table: "Log_19118162");

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
    }
}
