using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskApi.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addinngJobRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Aurthors",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Aurthors",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobRole",
                value: "Software Devloper");

            migrationBuilder.UpdateData(
                table: "Aurthors",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobRole",
                value: "BA");

            migrationBuilder.UpdateData(
                table: "Aurthors",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobRole",
                value: "QA");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Deu" },
                values: new object[] { new DateTime(2024, 3, 17, 14, 41, 0, 544, DateTimeKind.Local).AddTicks(2977), new DateTime(2024, 3, 22, 14, 41, 0, 544, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Deu" },
                values: new object[] { new DateTime(2024, 3, 17, 14, 41, 0, 544, DateTimeKind.Local).AddTicks(3002), new DateTime(2024, 3, 22, 14, 41, 0, 544, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Deu" },
                values: new object[] { new DateTime(2024, 3, 17, 14, 41, 0, 544, DateTimeKind.Local).AddTicks(3007), new DateTime(2024, 3, 22, 14, 41, 0, 544, DateTimeKind.Local).AddTicks(3008) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Aurthors");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Deu" },
                values: new object[] { new DateTime(2024, 3, 16, 8, 36, 16, 668, DateTimeKind.Local).AddTicks(260), new DateTime(2024, 3, 21, 8, 36, 16, 668, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Deu" },
                values: new object[] { new DateTime(2024, 3, 16, 8, 36, 16, 668, DateTimeKind.Local).AddTicks(287), new DateTime(2024, 3, 21, 8, 36, 16, 668, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Deu" },
                values: new object[] { new DateTime(2024, 3, 16, 8, 36, 16, 668, DateTimeKind.Local).AddTicks(292), new DateTime(2024, 3, 21, 8, 36, 16, 668, DateTimeKind.Local).AddTicks(294) });
        }
    }
}
