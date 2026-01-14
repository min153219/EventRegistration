using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventRegistration.Migrations
{
    /// <inheritdoc />
    public partial class modifynetmenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c23fc6d6-6eb3-453c-b86d-b5d63a1b20c1", "AQAAAAIAAYagAAAAEJPMcPpNjJR6PVM3W/aL6EO66Kha+pkNe9gcN5AZxvZTTbrHpCiMbic75HhBZ1zxKw==", "7e09d28f-a25c-439f-9345-f4fc1d8ffa13" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 15, 20, 57, 215, DateTimeKind.Local).AddTicks(7483), new DateTime(2026, 1, 14, 15, 20, 57, 215, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 15, 20, 57, 215, DateTimeKind.Local).AddTicks(7759), new DateTime(2026, 1, 14, 15, 20, 57, 215, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 15, 20, 57, 215, DateTimeKind.Local).AddTicks(7904), new DateTime(2026, 1, 14, 15, 20, 57, 215, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 15, 20, 57, 215, DateTimeKind.Local).AddTicks(8040), new DateTime(2026, 1, 14, 15, 20, 57, 215, DateTimeKind.Local).AddTicks(8042) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c964ab2-7ac0-45d2-bc92-19bc2d2a071c", "AQAAAAIAAYagAAAAEOS5/QaOnMHuywB6xkPE6ydf2O8OCRyzLphHc/QLd53fpa2+YxTihHPW00Jf1V+haQ==", "a2cb1129-fdf1-4f80-abf3-3f0402ebd836" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 17, 27, 12, 184, DateTimeKind.Local).AddTicks(5404), new DateTime(2026, 1, 13, 17, 27, 12, 184, DateTimeKind.Local).AddTicks(5421) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 17, 27, 12, 184, DateTimeKind.Local).AddTicks(5573), new DateTime(2026, 1, 13, 17, 27, 12, 184, DateTimeKind.Local).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 17, 27, 12, 184, DateTimeKind.Local).AddTicks(5635), new DateTime(2026, 1, 13, 17, 27, 12, 184, DateTimeKind.Local).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 17, 27, 12, 184, DateTimeKind.Local).AddTicks(5701), new DateTime(2026, 1, 13, 17, 27, 12, 184, DateTimeKind.Local).AddTicks(5702) });
        }
    }
}
