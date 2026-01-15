using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventRegistration.Migrations
{
    /// <inheritdoc />
    public partial class EventExplores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Event",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3402ebba-95d3-4a4d-9854-d6ff92295f23", "AQAAAAIAAYagAAAAEKRrJgnpwB57VxF4y8+f+TNcgN2XXDFP/TzxaPD7cu0FOAfO/0v+/Rg+3qpRfkEIFQ==", "cd20dbe3-335e-4da4-b21d-c18605839a40" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "DateCreated", "DateUpdated", "Description", "ImageUrl", "IsFeatured" },
                values: new object[] { null, new DateTime(2026, 1, 15, 0, 59, 38, 728, DateTimeKind.Local).AddTicks(8801), new DateTime(2026, 1, 15, 0, 59, 38, 728, DateTimeKind.Local).AddTicks(8816), null, null, false });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 0, 59, 38, 728, DateTimeKind.Local).AddTicks(8952), new DateTime(2026, 1, 15, 0, 59, 38, 728, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 0, 59, 38, 728, DateTimeKind.Local).AddTicks(9011), new DateTime(2026, 1, 15, 0, 59, 38, 728, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 15, 0, 59, 38, 728, DateTimeKind.Local).AddTicks(9089), new DateTime(2026, 1, 15, 0, 59, 38, 728, DateTimeKind.Local).AddTicks(9089) });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_EventId",
                table: "Ticket",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Event_EventId",
                table: "Ticket",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Event_EventId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_EventId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Event");

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
    }
}
