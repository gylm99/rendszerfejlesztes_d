using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EstateSales.Backend.Migrations
{
    /// <inheritdoc />
    public partial class m1_init_db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Advertisements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Title = table.Column<string>(type: "longtext", nullable: false),
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    HasAirCondition = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HasGarage = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisements", x => x.Id);
                })
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertisements");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
