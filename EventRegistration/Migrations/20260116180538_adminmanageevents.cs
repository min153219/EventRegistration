using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventRegistration.Migrations
{
    /// <inheritdoc />
    public partial class adminmanageevents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RejectionReason",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReviewedBy",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReviewedDate",
                table: "Event",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Event",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3274395e-ed85-4775-a732-6e2166b6844d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94614cbc-c766-4acc-98fb-72de3ee0a012", "AQAAAAIAAYagAAAAEJdkfWo9yEca+MIf4zGYAP5oXadT5Tx/tqi38Ll3zHFYi3OBL4ffnpqQ+C8J3S2Bbg==", "0caf3871-cacb-458a-9cbb-f9d90c2f15a2" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "RejectionReason", "ReviewedBy", "ReviewedDate", "Status" },
                values: new object[] { new DateTime(2026, 1, 17, 2, 5, 37, 456, DateTimeKind.Local).AddTicks(4234), new DateTime(2026, 1, 17, 2, 5, 37, 456, DateTimeKind.Local).AddTicks(4256), null, null, null, "Pending" });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 2, 5, 37, 456, DateTimeKind.Local).AddTicks(4760), new DateTime(2026, 1, 17, 2, 5, 37, 456, DateTimeKind.Local).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 2, 5, 37, 456, DateTimeKind.Local).AddTicks(4859), new DateTime(2026, 1, 17, 2, 5, 37, 456, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 2, 5, 37, 456, DateTimeKind.Local).AddTicks(4987), new DateTime(2026, 1, 17, 2, 5, 37, 456, DateTimeKind.Local).AddTicks(4988) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RejectionReason",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "ReviewedBy",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "ReviewedDate",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Event");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3274395e-ed85-4775-a732-6e2166b6844d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2909414-2f29-42e7-aa99-182e5e5a2200", "AQAAAAIAAYagAAAAECF6iGGwH1PRUayaWnsyhNtVyrxh0d0zMKxXloHM+XR7lsZThXyFjI2ZqOw+Mxs2JA==", "6b80a22e-259e-4a39-90bb-3500e3175f7f" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 21, 53, 51, 983, DateTimeKind.Local).AddTicks(3282), new DateTime(2026, 1, 16, 21, 53, 51, 983, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 21, 53, 51, 983, DateTimeKind.Local).AddTicks(3595), new DateTime(2026, 1, 16, 21, 53, 51, 983, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 21, 53, 51, 983, DateTimeKind.Local).AddTicks(3700), new DateTime(2026, 1, 16, 21, 53, 51, 983, DateTimeKind.Local).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 21, 53, 51, 983, DateTimeKind.Local).AddTicks(3810), new DateTime(2026, 1, 16, 21, 53, 51, 983, DateTimeKind.Local).AddTicks(3811) });
        }
    }
}
