using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskApi.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aurthors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aurthors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    AurthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Todos_Aurthors_AurthorId",
                        column: x => x.AurthorId,
                        principalTable: "Aurthors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Aurthors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Malith Fernandol" },
                    { 2, "Kevin Aravinda" },
                    { 3, "Dilina Supun" }
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AurthorId", "Created", "Description", "Deu", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 15, 7, 29, 57, 968, DateTimeKind.Local).AddTicks(9539), "Test", new DateTime(2024, 3, 20, 7, 29, 57, 968, DateTimeKind.Local).AddTicks(9557), 0, "Example 1 - DB" },
                    { 2, 3, new DateTime(2024, 3, 15, 7, 29, 57, 968, DateTimeKind.Local).AddTicks(9570), "Test", new DateTime(2024, 3, 20, 7, 29, 57, 968, DateTimeKind.Local).AddTicks(9573), 0, "Example 2 - DB" },
                    { 3, 2, new DateTime(2024, 3, 15, 7, 29, 57, 968, DateTimeKind.Local).AddTicks(9577), "Test", new DateTime(2024, 3, 20, 7, 29, 57, 968, DateTimeKind.Local).AddTicks(9579), 0, "Example 3 - DB" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AurthorId",
                table: "Todos",
                column: "AurthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos");

            migrationBuilder.DropTable(
                name: "Aurthors");
        }
    }
}
