using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmaInventory.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PharmaItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedManufactureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PharmaItem", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PharmaItem");
        }
    }
}
