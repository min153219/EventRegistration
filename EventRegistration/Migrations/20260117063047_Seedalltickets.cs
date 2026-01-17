using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventRegistration.Migrations
{
    /// <inheritdoc />
    public partial class Seedalltickets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e88dac0d-43dc-4898-a6dd-94b5923b3a99", "AQAAAAIAAYagAAAAEPSTZV+KoxDPNH8vk8HkIvibJoYUBVzFBGNA+elIesiV/z+gn3qI7QqtoNBpgZrsgA==", "a250fe4e-5e65-44f2-bff6-d524c1032557" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8380), new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8398), new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8401), new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8403), new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8405), new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8405) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8407), new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8641), new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8794), new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8897), new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "EventId", "Price", "Type", "UpdatedBy" },
                values: new object[,]
                {
                    { 2, "System", new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8899), new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8899), 2, 75.00m, "General Admission", "System" },
                    { 3, "System", new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8901), new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8902), 2, 120.00m, "VIP Pass", "System" },
                    { 4, "System", new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8903), new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8903), 3, 35.00m, "Standard Pass", "System" },
                    { 5, "System", new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8905), new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8905), 3, 25.00m, "Student Pass", "System" },
                    { 6, "System", new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8906), new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8907), 4, 50.00m, "Runner Registration", "System" },
                    { 7, "System", new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8908), new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8908), 5, 45.00m, "General Admission", "System" },
                    { 8, "System", new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8910), new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8910), 5, 80.00m, "VIP Experience", "System" },
                    { 9, "System", new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8911), new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8912), 5, 30.00m, "Early Bird", "System" },
                    { 10, "System", new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8913), new DateTime(2026, 1, 17, 14, 30, 46, 658, DateTimeKind.Local).AddTicks(8913), 6, 0.00m, "Free Admission", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f8329c7-b520-42a9-9db3-da3246ff765c", "AQAAAAIAAYagAAAAEDMNuzCX5sJvblVmcyuY6373q5ryXEtMWUX/RpO9I+SPndveypVhaQVtMP2gBd/3pw==", "c7b4cc8c-3320-44ad-b0fc-1093c8b92c54" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6460), new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6473) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6476), new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6476) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6478), new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6480), new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6482), new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6484), new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6485) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6715), new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6803), new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6891), new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6892) });
        }
    }
}
