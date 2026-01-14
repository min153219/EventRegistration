using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventRegistration.Migrations
{
    /// <inheritdoc />
    public partial class AddRoleSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 16, 19, 8, 697, DateTimeKind.Local).AddTicks(8312), new DateTime(2026, 1, 13, 16, 19, 8, 697, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 16, 19, 8, 697, DateTimeKind.Local).AddTicks(8504), new DateTime(2026, 1, 13, 16, 19, 8, 697, DateTimeKind.Local).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 16, 19, 8, 697, DateTimeKind.Local).AddTicks(8566), new DateTime(2026, 1, 13, 16, 19, 8, 697, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 16, 19, 8, 697, DateTimeKind.Local).AddTicks(8639), new DateTime(2026, 1, 13, 16, 19, 8, 697, DateTimeKind.Local).AddTicks(8639) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
