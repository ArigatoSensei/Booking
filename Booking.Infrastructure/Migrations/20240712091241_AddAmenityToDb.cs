using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Booking.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAmenityToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amenities",
                schema: "19118162",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VillaId = table.Column<int>(type: "int", nullable: false),
                    Date_19118162 = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Amenities_Villas_VillaId",
                        column: x => x.VillaId,
                        principalSchema: "19118162",
                        principalTable: "Villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "19118162",
                table: "Amenities",
                columns: new[] { "Id", "Date_19118162", "Description", "Name", "VillaId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5064), null, "Private Pool", 1 },
                    { 2, new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5068), null, "Microwave", 1 },
                    { 3, new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5070), null, "Private Balcony", 1 },
                    { 4, new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5071), null, "1 king bed and 1 sofa bed", 1 },
                    { 5, new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5073), null, "Private Plunge Pool", 2 },
                    { 6, new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5075), null, "Microwave and Mini Refrigerator", 2 },
                    { 7, new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5077), null, "Private Balcony", 2 },
                    { 8, new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5079), null, "King bed or 2 double beds", 2 },
                    { 9, new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5080), null, "Private Pool", 3 },
                    { 10, new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5082), null, "Jacuzzi", 3 },
                    { 11, new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5084), null, "Private Balcony", 3 }
                });

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 101,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 102,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(4977));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 103,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 104,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 201,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 202,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 203,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 301,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 302,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.CreateIndex(
                name: "IX_Amenities_VillaId",
                schema: "19118162",
                table: "Amenities",
                column: "VillaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amenities",
                schema: "19118162");

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 101,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 11, 12, 34, 45, 555, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 102,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 11, 12, 34, 45, 555, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 103,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 11, 12, 34, 45, 555, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 104,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 11, 12, 34, 45, 555, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 201,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 11, 12, 34, 45, 555, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 202,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 11, 12, 34, 45, 555, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 203,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 11, 12, 34, 45, 555, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 301,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 11, 12, 34, 45, 555, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "VillaNumbers",
                keyColumn: "Villa_Number",
                keyValue: 302,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 11, 12, 34, 45, 555, DateTimeKind.Local).AddTicks(9914));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 11, 12, 34, 45, 555, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 11, 12, 34, 45, 555, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 11, 12, 34, 45, 555, DateTimeKind.Local).AddTicks(9825));
        }
    }
}
