using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                schema: "19118162",
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date_19118162",
                value: new DateTime(2024, 7, 12, 12, 12, 39, 274, DateTimeKind.Local).AddTicks(5084));

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
        }
    }
}
