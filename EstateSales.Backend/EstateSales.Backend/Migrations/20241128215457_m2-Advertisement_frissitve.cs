using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EstateSales.Backend.Migrations
{
    /// <inheritdoc />
    public partial class m2Advertisement_frissitve : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: new Guid("217ce06d-1a80-4209-b66d-4c31e179a6bd"));

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: new Guid("73dc4529-f3b2-4282-8d9c-c9618092a590"));

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: new Guid("990f1a72-9278-4cd0-a783-8888a32e22c5"));

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: new Guid("f6293251-d616-4201-a46e-8190b221d460"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("084b8040-fdd3-4384-9e3f-c29ef145fa48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b3c98cc-4b07-4168-a167-8c5e84b0b717"));

            migrationBuilder.DropColumn(
                name: "HasAirCondition",
                table: "Advertisements");

            migrationBuilder.RenameColumn(
                name: "HasGarage",
                table: "Advertisements",
                newName: "HasElevator");

            migrationBuilder.AddColumn<double>(
                name: "BaseArea",
                table: "Advertisements",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "BuiltYear",
                table: "Advertisements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Confort",
                table: "Advertisements",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "FloorLevel",
                table: "Advertisements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MainBuildingFloorLevel",
                table: "Advertisements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Orientation",
                table: "Advertisements",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "PhotosPath",
                table: "Advertisements",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Advertisements",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Advertisements",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    SenderEmailAddress = table.Column<string>(type: "longtext", nullable: false),
                    Content = table.Column<string>(type: "longtext", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "BaseArea", "BuiltYear", "Confort", "Description", "FloorLevel", "HasElevator", "MainBuildingFloorLevel", "Orientation", "PhotosPath", "Price", "RoomNumber", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("4162e3aa-74cd-40c4-be8d-2e2fed210f5d"), 120.0, 2005, "Komfortos", "Csendes környék, nagy kerttel.", 0, false, 1, "Nyugat", "[]", 85000000.0, 4, "Családi ház kertvárosi övezetben", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("623fb916-4fba-4c48-8194-da46a418a2ee"), 75.5, 2010, "Luxus", "Tágas, világos lakás remek közlekedéssel.", 2, true, 4, "Dél", "[]", 45000000.0, 3, "Modern lakás a belvárosban", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("63f5a5f8-08e6-40db-a265-47ef283edc89"), 50.0, 1980, "Alap", "Kiváló befektetési lehetőség a belvárosban.", 3, false, 5, "Észak", "[]", 30000000.0, 2, "Felújítandó lakás", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d0b2eec0-b070-463b-8620-d62429371c10"), 200.0, 2022, "Extra luxus", "Luxus szintű lakás panorámás kilátással.", 5, true, 5, "Kelet-Dél", "[]", 150000000.0, 5, "Új építésű penthouse", new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "CreatedAt", "SenderEmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("0d5e3a1b-fa5f-4d5e-828e-f8fed77c666e"), "Szia Elek!\nÉrdekel a házad!", new DateTime(2024, 11, 28, 22, 54, 56, 657, DateTimeKind.Local).AddTicks(7001), "mirmur@gmail.com", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0e61ad7e-a5b6-4d96-9e98-d138a2fa0b45"), "Szia Eszter!\nÉrdekel a házad!", new DateTime(2024, 11, 28, 22, 54, 56, 657, DateTimeKind.Local).AddTicks(7059), "frakk@gmail.com", new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Number", "Password" },
                values: new object[,]
                {
                    { new Guid("23151404-ded3-4b55-bdf0-58b41137d9d7"), "teszt@teszt.com", "Teszt Eszter", "+36-20-735-2742", "teszt" },
                    { new Guid("fd3a5dd7-2f22-4d72-806b-01ed2bb3d71f"), "mekk@mek.com", "Mekk Elek", "+36/309025476", "mekmek" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_UserId",
                table: "Advertisements",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_Users_UserId",
                table: "Advertisements",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_Users_UserId",
                table: "Advertisements");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Advertisements_UserId",
                table: "Advertisements");

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: new Guid("4162e3aa-74cd-40c4-be8d-2e2fed210f5d"));

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: new Guid("623fb916-4fba-4c48-8194-da46a418a2ee"));

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: new Guid("63f5a5f8-08e6-40db-a265-47ef283edc89"));

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: new Guid("d0b2eec0-b070-463b-8620-d62429371c10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23151404-ded3-4b55-bdf0-58b41137d9d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd3a5dd7-2f22-4d72-806b-01ed2bb3d71f"));

            migrationBuilder.DropColumn(
                name: "BaseArea",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "BuiltYear",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "Confort",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "FloorLevel",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "MainBuildingFloorLevel",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "Orientation",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "PhotosPath",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Advertisements");

            migrationBuilder.RenameColumn(
                name: "HasElevator",
                table: "Advertisements",
                newName: "HasGarage");

            migrationBuilder.AddColumn<bool>(
                name: "HasAirCondition",
                table: "Advertisements",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "Description", "HasAirCondition", "HasGarage", "RoomNumber", "Title" },
                values: new object[,]
                {
                    { new Guid("217ce06d-1a80-4209-b66d-4c31e179a6bd"), "A comfortable studio in a quiet neighborhood, perfect for singles.", false, false, 1, "Cozy Studio Apartment" },
                    { new Guid("73dc4529-f3b2-4282-8d9c-c9618092a590"), "A luxury penthouse with stunning city views, ideal for families or executives.", true, true, 5, "Luxury Penthouse Suite" },
                    { new Guid("990f1a72-9278-4cd0-a783-8888a32e22c5"), "A spacious apartment in the city center with modern amenities.", true, true, 3, "Beautiful Apartment" },
                    { new Guid("f6293251-d616-4201-a46e-8190b221d460"), "A stylish loft with open space design and close to all amenities.", true, false, 2, "Modern Loft" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Number", "Password" },
                values: new object[,]
                {
                    { new Guid("084b8040-fdd3-4384-9e3f-c29ef145fa48"), "teszt@teszt.com", "Teszt Eszter", "+36-20-735-2742", "teszt" },
                    { new Guid("9b3c98cc-4b07-4168-a167-8c5e84b0b717"), "mekk@mek.com", "Mekk Elek", "+36/309025476", "mekmek" }
                });
        }
    }
}
