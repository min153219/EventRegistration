using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventRegistration.Migrations
{
    /// <inheritdoc />
    public partial class AddPaymentStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PaymentDate",
                table: "Registration",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentStatus",
                table: "Registration",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TransactionId",
                table: "Registration",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3274395e-ed85-4775-a732-6e2166b6844d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bce9f7fa-19db-459a-9f55-f73f6c331a61", "AQAAAAIAAYagAAAAEL1kxAdNfsZ9nODoqBbLg8lArBMw5gwRX3Qlk+wFc9s9dZjzLr59SKSdtTkrHBg6QA==", "1d3845e1-cf33-4ccd-b5f0-e1bd0d2324d5" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedDate" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 45, 22, 368, DateTimeKind.Local).AddTicks(9988), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(8), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedDate" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(19), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(19), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedDate" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(23), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(23), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedDate" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(26), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(27), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(28) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedDate" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(30), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(30), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedDate" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(33), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(33), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(365), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "PaymentDate", "PaymentStatus", "TransactionId" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(520), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(520), null, "Unpaid", null });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(626), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(628), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(629), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(631), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(633), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(634), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(636), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(638), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(639), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(641), new DateTime(2026, 1, 18, 19, 45, 22, 369, DateTimeKind.Local).AddTicks(641) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentDate",
                table: "Registration");

            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "Registration");

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "Registration");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3274395e-ed85-4775-a732-6e2166b6844d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0f1770e-eebc-46c6-b7aa-eb729a0a619f", "AQAAAAIAAYagAAAAEGxsMB0o9F14c72FAanhja4rD/w02ad8P8mv6FK/JqZJr4h9QSjKdLjLAF0wTF3aMQ==", "ee8cc9d2-7f78-457f-9b71-d6b58091110c" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedDate" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4479), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4493), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4496) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedDate" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4503), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4504), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedDate" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4507), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4507), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedDate" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4510), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4511), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedDate" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4513), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4514), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4515) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedDate" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4516), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4517), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4748), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4748) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4884), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4885) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(5017), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(5019), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(5021), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(5023), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(5025), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(5027), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(5028), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(5030), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(5031) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(5032), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(5034), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(5034) });
        }
    }
}
