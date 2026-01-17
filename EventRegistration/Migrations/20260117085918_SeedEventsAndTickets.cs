using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventRegistration.Migrations
{
    /// <inheritdoc />
    public partial class SeedEventsAndTickets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8259), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8279), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8283), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8287), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8291), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8294), new DateTime(2026, 1, 17, 16, 59, 16, 878, DateTimeKind.Local).AddTicks(8295) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3274395e-ed85-4775-a732-6e2166b6844d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae7a402e-0297-46e6-906c-ebbf6a704cae", "AQAAAAIAAYagAAAAEGSw06xJxKGi3GyhL67vEmdVQKynHPruUbmcR7wS8DQQm6Yb5ZR6ni/QcslXJJIjoQ==", "d8d2a0f9-cbce-4a22-88d1-e171a58e884d" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2366), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2475), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2479), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2483), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2487), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2490), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2801), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3031), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3166), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3170), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3172), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3175), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3178), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3181), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3184), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3186), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3189), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3192), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3192) });
        }
    }
}
