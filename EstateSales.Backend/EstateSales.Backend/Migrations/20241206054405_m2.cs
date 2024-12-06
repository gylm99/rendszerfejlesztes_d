using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EstateSales.Backend.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false),
                    Password = table.Column<string>(type: "longtext", nullable: false),
                    Number = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Advertisements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Title = table.Column<string>(type: "longtext", nullable: false),
                    Price = table.Column<double>(type: "double", nullable: false),
                    BaseArea = table.Column<double>(type: "double", nullable: false),
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    BuiltYear = table.Column<int>(type: "int", nullable: false),
                    Confort = table.Column<string>(type: "longtext", nullable: false),
                    FloorLevel = table.Column<int>(type: "int", nullable: false),
                    MainBuildingFloorLevel = table.Column<int>(type: "int", nullable: false),
                    HasElevator = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Orientation = table.Column<string>(type: "longtext", nullable: false),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Advertisements_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    SenderEmailAddress = table.Column<string>(type: "longtext", nullable: false),
                    Content = table.Column<string>(type: "longtext", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    ImagePath = table.Column<string>(type: "longtext", nullable: false),
                    AdvertisementId = table.Column<Guid>(type: "char(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Advertisements_AdvertisementId",
                        column: x => x.AdvertisementId,
                        principalTable: "Advertisements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "BaseArea", "BuiltYear", "Confort", "Description", "FloorLevel", "HasElevator", "MainBuildingFloorLevel", "Orientation", "Price", "RoomNumber", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("4b910331-6bd9-46f9-9f9b-7a89eff7fe94"), 75.5, 2010, "Luxus", "Tágas, világos lakás remek közlekedéssel.", 2, true, 4, "Dél", 45000000.0, 3, "Modern lakás a belvárosban", null },
                    { new Guid("70602bc9-41cc-42a7-89cf-3084c5bcd328"), 50.0, 1980, "Alap", "Kiváló befektetési lehetőség a belvárosban.", 3, false, 5, "Észak", 30000000.0, 2, "Felújítandó lakás", null },
                    { new Guid("7bd112da-6095-4958-a5d8-0658d3acdf71"), 120.0, 2005, "Komfortos", "Csendes környék, nagy kerttel.", 0, false, 1, "Nyugat", 85000000.0, 4, "Családi ház kertvárosi övezetben", null },
                    { new Guid("a462b0d3-e69b-491f-9c1c-9b582a796e04"), 200.0, 2022, "Extra luxus", "Luxus szintű lakás panorámás kilátással.", 5, true, 5, "Kelet-Dél", 150000000.0, 5, "Új építésű penthouse", null }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "CreatedAt", "SenderEmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("9ebcab83-7fca-4db9-ae57-a0b57fbda7bf"), "Szia Eszter!\nÉrdekel a házad!", new DateTime(2024, 12, 6, 6, 44, 5, 648, DateTimeKind.Local).AddTicks(8581), "frakk@gmail.com", null },
                    { new Guid("fe0d043f-4b40-41d2-9657-ed703749a946"), "Szia Elek!\nÉrdekel a házad!", new DateTime(2024, 12, 6, 6, 44, 5, 648, DateTimeKind.Local).AddTicks(8534), "mirmur@gmail.com", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Number", "Password" },
                values: new object[,]
                {
                    { new Guid("d938ba9e-155d-4190-9e04-0c0e9814a0bc"), "mekk@mek.com", "Mekk Elek", "+36/309025476", "mekmek" },
                    { new Guid("f3c8aef9-4c0c-4786-bc76-85c419dfe39a"), "teszt@teszt.com", "Teszt Eszter", "+36-20-735-2742", "teszt" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_UserId",
                table: "Advertisements",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_AdvertisementId",
                table: "Photos",
                column: "AdvertisementId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Advertisements");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
