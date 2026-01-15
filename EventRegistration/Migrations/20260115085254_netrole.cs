using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventRegistration.Migrations
{
    /// <inheritdoc />
    public partial class netrole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bc6edf4-86ed-42b7-9dc4-058e09b881fd", "AQAAAAIAAYagAAAAEFHumjVqkmnLWrwmW2KoquBJVRnTELjK22D0KgbDB6pLmeoGnFxB5fY/kv9l0TXnig==", "3511e9f7-b787-48ee-ba63-4dfd679c942c" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 16, 52, 53, 488, DateTimeKind.Local).AddTicks(6782), new DateTime(2026, 1, 15, 16, 52, 53, 488, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 16, 52, 53, 488, DateTimeKind.Local).AddTicks(7019), new DateTime(2026, 1, 15, 16, 52, 53, 488, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 16, 52, 53, 488, DateTimeKind.Local).AddTicks(7135), new DateTime(2026, 1, 15, 16, 52, 53, 488, DateTimeKind.Local).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 16, 52, 53, 488, DateTimeKind.Local).AddTicks(7232), new DateTime(2026, 1, 15, 16, 52, 53, 488, DateTimeKind.Local).AddTicks(7232) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e05e686e-b235-4ab3-aec6-1b3d3a2379a4", "AQAAAAIAAYagAAAAEFw0KLVbFj68eZgj1DPPCTfcXvHHbsCXsJrh6zAWn1QxvHqhwzMlHionGJCqjo9BCg==", "20676dbd-c9a7-475b-9dbd-95f744ce17e8" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 16, 47, 56, 546, DateTimeKind.Local).AddTicks(4618), new DateTime(2026, 1, 15, 16, 47, 56, 546, DateTimeKind.Local).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 16, 47, 56, 546, DateTimeKind.Local).AddTicks(4936), new DateTime(2026, 1, 15, 16, 47, 56, 546, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 16, 47, 56, 546, DateTimeKind.Local).AddTicks(5077), new DateTime(2026, 1, 15, 16, 47, 56, 546, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 16, 47, 56, 546, DateTimeKind.Local).AddTicks(5218), new DateTime(2026, 1, 15, 16, 47, 56, 546, DateTimeKind.Local).AddTicks(5219) });
        }
    }
}
