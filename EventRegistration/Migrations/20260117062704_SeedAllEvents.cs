using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventRegistration.Migrations
{
    /// <inheritdoc />
    public partial class SeedAllEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Category", "CreatedBy", "DateCreated", "DateUpdated", "Description", "EventDate", "ImageUrl", "IsFeatured", "Location", "Title", "TotalCapacity", "Type", "UpdatedBy" },
                values: new object[,]
                {
                    { 2, "Professional", "System", new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6476), new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6476), "Join industry leaders and tech innovators for an inspiring day of talks covering AI, cloud computing, cybersecurity, and the future of technology in Southeast Asia.", new DateTime(2026, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Marina Bay Sands Convention Centre", "Tech Talks 2026", 300, "Physical", "System" },
                    { 3, "Entertainment", "System", new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6478), new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6479), "Experience the best of independent cinema from local and international filmmakers. Three days of screenings, Q&A sessions, and networking opportunities.", new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "National Museum of Singapore", "Indie Film Festival", 200, "Physical", "System" },
                    { 4, "Sports", "System", new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6480), new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6481), "Challenge yourself in Singapore's premier marathon event! Choose from full marathon (42km), half marathon (21km), or 10km fun run. All fitness levels welcome.", new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Marina Bay Area", "City Marathon 2026", 1000, "Physical", "System" },
                    { 5, "Music", "System", new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6482), new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6483), "Singapore's biggest beach music festival featuring international and local artists across multiple stages. Two days of sun, sand, and amazing music!", new DateTime(2026, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Siloso Beach, Sentosa", "Summer Music Festival 2026", 5000, "Physical", "System" },
                    { 6, "Arts", "System", new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6484), new DateTime(2026, 1, 17, 14, 27, 3, 198, DateTimeKind.Local).AddTicks(6485), "Exhibitions, theater, and cultural events celebrating modern and contemporary art from Southeast Asian artists. Free admission for all visitors.", new DateTime(2026, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "City Gallery", "Modern Art Exhibition", 200, "Physical", "System" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87ed98db-c46d-45ab-a057-f61bf1a6f8c4", "AQAAAAIAAYagAAAAEGQOS0Uy8Kssra0KPyKHg0Eyz3N1aDLhl4SflgaeidG/DSthOStAq2Nddc9AJ6djdg==", "46c30ff9-4129-4c06-81b9-bef1c4ef2705" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 21, 34, 31, 518, DateTimeKind.Local).AddTicks(1961), new DateTime(2026, 1, 16, 21, 34, 31, 518, DateTimeKind.Local).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Payment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 21, 34, 31, 518, DateTimeKind.Local).AddTicks(2262), new DateTime(2026, 1, 16, 21, 34, 31, 518, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 21, 34, 31, 518, DateTimeKind.Local).AddTicks(2353), new DateTime(2026, 1, 16, 21, 34, 31, 518, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 16, 21, 34, 31, 518, DateTimeKind.Local).AddTicks(2454), new DateTime(2026, 1, 16, 21, 34, 31, 518, DateTimeKind.Local).AddTicks(2455) });
        }
    }
}
