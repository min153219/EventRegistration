using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventRegistration.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalCapacity = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Registration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    TicketId = table.Column<int>(type: "int", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registration_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registration_Ticket_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Ticket",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Administrator", "ADMINISTRATOR" },
                    { "2", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3274395e-ed85-4775-a732-6e2166b6844d", 0, "ae7a402e-0297-46e6-906c-ebbf6a704cae", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEGSw06xJxKGi3GyhL67vEmdVQKynHPruUbmcR7wS8DQQm6Yb5ZR6ni/QcslXJJIjoQ==", null, false, "d8d2a0f9-cbce-4a22-88d1-e171a58e884d", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Category", "CreatedBy", "DateCreated", "DateUpdated", "Description", "EventDate", "ImageUrl", "IsFeatured", "Location", "RejectionReason", "ReviewedBy", "ReviewedDate", "Status", "Title", "TotalCapacity", "Type", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Educational", "System", new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2366), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2380), "Join us for Temasek Polytechnic's Open House! Explore our facilities, meet our faculty, and discover exciting courses.", new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Temasek Polytechnic, Convention Centre", null, null, null, "Pending", "TP Open House", 500, "Physical", "System" },
                    { 2, "Professional", "System", new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2475), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2475), "Join industry leaders and tech innovators for an inspiring day of talks covering AI, cloud computing, cybersecurity, and the future of technology in Southeast Asia.", new DateTime(2026, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Marina Bay Sands Convention Centre", null, null, null, "Pending", "Tech Talks 2026", 300, "Physical", "System" },
                    { 3, "Entertainment", "System", new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2479), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2480), "Experience the best of independent cinema from local and international filmmakers. Three days of screenings, Q&A sessions, and networking opportunities.", new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "National Museum of Singapore", null, null, null, "Pending", "Indie Film Festival", 200, "Physical", "System" },
                    { 4, "Sports", "System", new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2483), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2484), "Challenge yourself in Singapore's premier marathon event! Choose from full marathon (42km), half marathon (21km), or 10km fun run. All fitness levels welcome.", new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Marina Bay Area", null, null, null, "Pending", "City Marathon 2026", 1000, "Physical", "System" },
                    { 5, "Music", "System", new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2487), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2487), "Singapore's biggest beach music festival featuring international and local artists across multiple stages. Two days of sun, sand, and amazing music!", new DateTime(2026, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Siloso Beach, Sentosa", null, null, null, "Pending", "Summer Music Festival 2026", 5000, "Physical", "System" },
                    { 6, "Arts", "System", new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2490), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2491), "Exhibitions, theater, and cultural events celebrating modern and contemporary art from Southeast Asian artists. Free admission for all visitors.", new DateTime(2026, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "City Gallery", null, null, null, "Pending", "Modern Art Exhibition", 200, "Physical", "System" }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "Amount", "CreatedBy", "Currency", "DateCreated", "DateUpdated", "PaymentDate", "PaymentMethod", "RegistrationId", "UpdatedBy" },
                values: new object[] { 1, 0.00m, "System", "SGD", new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2801), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(2801), new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Free", 1, "System" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "3274395e-ed85-4775-a732-6e2166b6844d" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "EventId", "Price", "Type", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3166), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3167), 1, 0.00m, "Free Admission", "System" },
                    { 2, "System", new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3170), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3170), 2, 75.00m, "General Admission", "System" },
                    { 3, "System", new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3172), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3173), 2, 120.00m, "VIP Pass", "System" },
                    { 4, "System", new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3175), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3176), 3, 35.00m, "Standard Pass", "System" },
                    { 5, "System", new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3178), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3179), 3, 25.00m, "Student Pass", "System" },
                    { 6, "System", new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3181), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3182), 4, 50.00m, "Runner Registration", "System" },
                    { 7, "System", new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3184), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3184), 5, 45.00m, "General Admission", "System" },
                    { 8, "System", new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3186), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3187), 5, 80.00m, "VIP Experience", "System" },
                    { 9, "System", new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3189), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3190), 5, 30.00m, "Early Bird", "System" },
                    { 10, "System", new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3192), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3192), 6, 0.00m, "Free Admission", "System" }
                });

            migrationBuilder.InsertData(
                table: "Registration",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Email", "EventId", "FullName", "Quantity", "RegistrationDate", "Status", "TicketId", "TotalAmount", "UpdatedBy" },
                values: new object[] { 1, "System", new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3031), new DateTime(2026, 1, 17, 16, 50, 19, 842, DateTimeKind.Local).AddTicks(3032), "", 1, "", 1, new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", 1, 0m, "System" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Registration_EventId",
                table: "Registration",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Registration_TicketId",
                table: "Registration",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_EventId",
                table: "Ticket",
                column: "EventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Registration");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Event");
        }
    }
}
