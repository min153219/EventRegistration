using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventRegistration.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 23, 5, 3, 966, DateTimeKind.Local).AddTicks(7231), new DateTime(2026, 1, 9, 23, 5, 3, 966, DateTimeKind.Local).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 23, 5, 3, 966, DateTimeKind.Local).AddTicks(7535), new DateTime(2026, 1, 9, 23, 5, 3, 966, DateTimeKind.Local).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 23, 5, 3, 966, DateTimeKind.Local).AddTicks(7623), new DateTime(2026, 1, 9, 23, 5, 3, 966, DateTimeKind.Local).AddTicks(7626) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 23, 5, 3, 966, DateTimeKind.Local).AddTicks(7715), new DateTime(2026, 1, 9, 23, 5, 3, 966, DateTimeKind.Local).AddTicks(7716) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 22, 54, 1, 435, DateTimeKind.Local).AddTicks(1939), new DateTime(2026, 1, 9, 22, 54, 1, 435, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 22, 54, 1, 435, DateTimeKind.Local).AddTicks(2206), new DateTime(2026, 1, 9, 22, 54, 1, 435, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 22, 54, 1, 435, DateTimeKind.Local).AddTicks(2286), new DateTime(2026, 1, 9, 22, 54, 1, 435, DateTimeKind.Local).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 9, 22, 54, 1, 435, DateTimeKind.Local).AddTicks(2373), new DateTime(2026, 1, 9, 22, 54, 1, 435, DateTimeKind.Local).AddTicks(2374) });
        }
    }
}
