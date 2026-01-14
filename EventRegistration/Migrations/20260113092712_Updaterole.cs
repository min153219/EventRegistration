using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventRegistration.Migrations
{
    /// <inheritdoc />
    public partial class Updaterole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "User", "USER" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Organizer", "ORGANIZER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3", null, "Customer", "CUSTOMER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ecd1d69b-aac4-49cc-bfd7-f54c550fcf7d", "AQAAAAIAAYagAAAAEASmf+O814MpW387UmUr6Z87TK0qoEw3DjuHhHO741WS2+ve3uZDpBHNS9oob3pKXg==", "65eb9061-ec55-4b8f-9cd6-cbfa36dd4a67" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 16, 40, 6, 943, DateTimeKind.Local).AddTicks(9356), new DateTime(2026, 1, 13, 16, 40, 6, 943, DateTimeKind.Local).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 16, 40, 6, 943, DateTimeKind.Local).AddTicks(9572), new DateTime(2026, 1, 13, 16, 40, 6, 943, DateTimeKind.Local).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 16, 40, 6, 943, DateTimeKind.Local).AddTicks(9649), new DateTime(2026, 1, 13, 16, 40, 6, 943, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 16, 40, 6, 943, DateTimeKind.Local).AddTicks(9730), new DateTime(2026, 1, 13, 16, 40, 6, 943, DateTimeKind.Local).AddTicks(9731) });
        }
    }
}
