using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventRegistration.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEventStatusToApproved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedBy", "ReviewedDate", "Status" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4479), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4493), "System", new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4496), "Approved" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedBy", "ReviewedDate", "Status" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4503), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4504), "System", new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4505), "Approved" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedBy", "ReviewedDate", "Status" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4507), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4507), "System", new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4509), "Approved" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedBy", "ReviewedDate", "Status" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4510), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4511), "System", new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4512), "Approved" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedBy", "ReviewedDate", "Status" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4513), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4514), "System", new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4515), "Approved" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedBy", "ReviewedDate", "Status" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4516), new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4517), "System", new DateTime(2026, 1, 17, 17, 15, 4, 83, DateTimeKind.Local).AddTicks(4518), "Approved" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3274395e-ed85-4775-a732-6e2166b6844d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fbfdf6f-e9be-47f7-a480-2ab0eb947039", "AQAAAAIAAYagAAAAEL8mFAExCcPkdW35zU48vf18ZerkESZC5pK0nPDA+FeRJYUVFwe944UoQI/l4Xzj3w==", "608b1949-6e85-4800-a9b5-ddc9f8cbfa5e" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedBy", "ReviewedDate", "Status" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8259), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8273), null, null, "Pending" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedBy", "ReviewedDate", "Status" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8279), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8280), null, null, "Pending" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedBy", "ReviewedDate", "Status" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8283), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8284), null, null, "Pending" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedBy", "ReviewedDate", "Status" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8287), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8288), null, null, "Pending" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedBy", "ReviewedDate", "Status" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8291), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8291), null, null, "Pending" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewedBy", "ReviewedDate", "Status" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8294), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8295), null, null, "Pending" });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8595), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8739), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8883), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8887), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8889), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8892), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8895), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8897), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8900), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8903), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8906), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8908), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8909) });
        }
    }
}
