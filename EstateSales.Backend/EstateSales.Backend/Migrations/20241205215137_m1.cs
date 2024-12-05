using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EstateSales.Backend.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
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
                    AdvertisementId = table.Column<Guid>(type: "char(36)", nullable: false)
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
                    { new Guid("39dd19f3-e486-481d-90a9-bf3e6ec9694b"), 120.0, 2005, "Komfortos", "Csendes környék, nagy kerttel.", 0, false, 1, "Nyugat", 85000000.0, 4, "Családi ház kertvárosi övezetben", null },
                    { new Guid("5738cfed-8495-413e-97f4-9c642b6a4e53"), 200.0, 2022, "Extra luxus", "Luxus szintű lakás panorámás kilátással.", 5, true, 5, "Kelet-Dél", 150000000.0, 5, "Új építésű penthouse", null },
                    { new Guid("6e336009-ea37-4d87-9a98-2dffef21f4b6"), 50.0, 1980, "Alap", "Kiváló befektetési lehetőség a belvárosban.", 3, false, 5, "Észak", 30000000.0, 2, "Felújítandó lakás", null },
                    { new Guid("ef4b28b9-1a17-4c37-b647-7bf18ebd2aba"), 75.5, 2010, "Luxus", "Tágas, világos lakás remek közlekedéssel.", 2, true, 4, "Dél", 45000000.0, 3, "Modern lakás a belvárosban", null }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "CreatedAt", "SenderEmailAddress", "UserId" },
                values: new object[,]
                {
                    { new Guid("840a4d02-d98b-41b1-a5d2-85a37e1c8e3f"), "Szia Eszter!\nÉrdekel a házad!", new DateTime(2024, 12, 5, 22, 51, 37, 56, DateTimeKind.Local).AddTicks(9769), "frakk@gmail.com", null },
                    { new Guid("c1195499-d33b-46be-a190-b0c9701c2632"), "Szia Elek!\nÉrdekel a házad!", new DateTime(2024, 12, 5, 22, 51, 37, 56, DateTimeKind.Local).AddTicks(9711), "mirmur@gmail.com", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Number", "Password" },
                values: new object[,]
                {
                    { new Guid("0991eebc-df6a-43c7-9672-fa54b23bb001"), "teszt@teszt.com", "Teszt Eszter", "+36-20-735-2742", "teszt" },
                    { new Guid("5fab70bd-b457-4da5-ad55-8bb41cb789f4"), "mekk@mek.com", "Mekk Elek", "+36/309025476", "mekmek" }
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
