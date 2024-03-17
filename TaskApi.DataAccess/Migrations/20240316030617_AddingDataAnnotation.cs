using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskApi.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddingDataAnnotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Todos",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Todos",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Aurthors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "AddressNo",
                table: "Aurthors",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Aurthors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Aurthors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Aurthors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "45", "Colombo", "Flower Road" });

            migrationBuilder.UpdateData(
                table: "Aurthors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "10", "Kaluthara", "Smaagi Road" });

            migrationBuilder.UpdateData(
                table: "Aurthors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "67", "Gampaha", "Fifth lane" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressNo",
                table: "Aurthors");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Aurthors");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Aurthors");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Aurthors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Deu" },
                values: new object[] { new DateTime(2024, 3, 15, 7, 29, 57, 968, DateTimeKind.Local).AddTicks(9539), new DateTime(2024, 3, 20, 7, 29, 57, 968, DateTimeKind.Local).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Deu" },
                values: new object[] { new DateTime(2024, 3, 15, 7, 29, 57, 968, DateTimeKind.Local).AddTicks(9570), new DateTime(2024, 3, 20, 7, 29, 57, 968, DateTimeKind.Local).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Deu" },
                values: new object[] { new DateTime(2024, 3, 15, 7, 29, 57, 968, DateTimeKind.Local).AddTicks(9577), new DateTime(2024, 3, 20, 7, 29, 57, 968, DateTimeKind.Local).AddTicks(9579) });
        }
    }
}
