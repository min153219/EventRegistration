using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventRegistration.Migrations
{
    /// <inheritdoc />
    public partial class userseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Administrator", "ADMINISTRATOR" },
                    { "2", null, "Organizer", "ORGANIZER" },
                    { "3", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "75faf304-add2-452f-bbe1-da9feea04c91", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAENBSf9B5qCkeXtAUzNj5WTinPbMq4FB3COulfvzYYdHJf3vMDyfMAd6N9j42vSEfMQ==", null, false, "f5c4f877-5b9c-4bdd-856f-284c21a203ba", false, "admin@localhost.com" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

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
    }
}
