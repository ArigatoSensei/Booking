using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPropertiesToUsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 19, 36, 525, DateTimeKind.Local).AddTicks(5480));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9484));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 101,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 102,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 103,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 104,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 201,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 202,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 203,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 301,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 302,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9101));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 14, 11, 37, 757, DateTimeKind.Local).AddTicks(9104));
        }
    }
}
