using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskApi.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Created", "Description", "Deu", "Status", "Title" },
                values: new object[] { 1, new DateTime(2024, 3, 15, 3, 3, 1, 989, DateTimeKind.Local).AddTicks(4510), "Test", new DateTime(2024, 3, 20, 3, 3, 1, 989, DateTimeKind.Local).AddTicks(4527), 0, "Example 1 - DB" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
