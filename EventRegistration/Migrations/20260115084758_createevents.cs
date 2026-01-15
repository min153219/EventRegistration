using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventRegistration.Migrations
{
    /// <inheritdoc />
    public partial class createevents : Migration
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
                values: new object[] { "e05e686e-b235-4ab3-aec6-1b3d3a2379a4", "AQAAAAIAAYagAAAAEFw0KLVbFj68eZgj1DPPCTfcXvHHbsCXsJrh6zAWn1QxvHqhwzMlHionGJCqjo9BCg==", "20676dbd-c9a7-475b-9dbd-95f744ce17e8" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "DateCreated", "DateUpdated", "Description", "ImageUrl", "IsFeatured" },
                values: new object[] { null, new DateTime(2026, 1, 15, 16, 47, 56, 546, DateTimeKind.Local).AddTicks(4618), new DateTime(2026, 1, 15, 16, 47, 56, 546, DateTimeKind.Local).AddTicks(4632), null, null, false });

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
