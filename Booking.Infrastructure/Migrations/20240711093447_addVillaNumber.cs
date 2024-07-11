using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Booking.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addVillaNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "19118162",
                table: "Villas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "VillaNumbers",
                schema: "19118162",
                columns: table => new
                {
                    Villa_Number = table.Column<int>(type: "int", nullable: false),
                    VillaId = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_19118162 = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers", x => x.Villa_Number);
                    table.ForeignKey(
                        name: "FK_VillaNumbers_Villas_VillaId",
                        column: x => x.VillaId,
                        principalSchema: "19118162",
                        principalTable: "Villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "19118162",
                table: "VillaNumbers",
                columns: new[] { "Villa_Number", "Date_19118162", "SpecialDetails", "VillaId" },
                values: new object[,]
                {
                    { 101, new DateTime(2024, 7, 11, 12, 34, 45, 555, DateTimeKind.Local).AddTicks(9899), null, 1 },
                    { 102, new DateTime(2024, 7, 11, 12, 34, 45, 555, DateTimeKind.Local).AddTicks(9902), null, 1 },
                    { 103, new DateTime(2024, 7, 11, 12, 34, 45, 555, DateTimeKind.Local).AddTicks(9904), null, 1 },
                    { 104, new DateTime(2024, 7, 11, 12, 34, 45, 555, DateTimeKind.Local).AddTicks(9906), null, 1 },
                    { 201, new DateTime(2024, 7, 11, 12, 34, 45, 555, DateTimeKind.Local).AddTicks(9907), null, 2 },
                    { 202, new DateTime(2024, 7, 11, 12, 34, 45, 555, DateTimeKind.Local).AddTicks(9909), null, 2 },
                    { 203, new DateTime(2024, 7, 11, 12, 34, 45, 555, DateTimeKind.Local).AddTicks(9911), null, 2 },
                    { 301, new DateTime(2024, 7, 11, 12, 34, 45, 555, DateTimeKind.Local).AddTicks(9912), null, 3 },
                    { 302, new DateTime(2024, 7, 11, 12, 34, 45, 555, DateTimeKind.Local).AddTicks(9914), null, 3 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaId",
                schema: "19118162",
                table: "VillaNumbers",
                column: "VillaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers",
                schema: "19118162");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "19118162",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 10, 17, 41, 50, 423, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 10, 17, 41, 50, 423, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 10, 17, 41, 50, 423, DateTimeKind.Local).AddTicks(3641));
        }
    }
}
