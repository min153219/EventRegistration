using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventRegistration.Migrations
{
    /// <inheritdoc />
    public partial class userroleseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75faf304-add2-452f-bbe1-da9feea04c91", "AQAAAAIAAYagAAAAENBSf9B5qCkeXtAUzNj5WTinPbMq4FB3COulfvzYYdHJf3vMDyfMAd6N9j42vSEfMQ==", "f5c4f877-5b9c-4bdd-856f-284c21a203ba" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 16, 34, 55, 810, DateTimeKind.Local).AddTicks(8683), new DateTime(2026, 1, 13, 16, 34, 55, 810, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 16, 34, 55, 810, DateTimeKind.Local).AddTicks(8951), new DateTime(2026, 1, 13, 16, 34, 55, 810, DateTimeKind.Local).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 16, 34, 55, 810, DateTimeKind.Local).AddTicks(9017), new DateTime(2026, 1, 13, 16, 34, 55, 810, DateTimeKind.Local).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 13, 16, 34, 55, 810, DateTimeKind.Local).AddTicks(9084), new DateTime(2026, 1, 13, 16, 34, 55, 810, DateTimeKind.Local).AddTicks(9085) });
        }
    }
}
