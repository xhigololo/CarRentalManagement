using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "60329d72-c13b-4335-acc8-0bbde948cb05", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "c2fe6bc7-74ed-49ce-acb6-2add5d543191", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "269d4c58-acc7-450c-81d5-0411ed488f03", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEIxZTfdVpsFxV36ojtMbyeN8uMgsQVfPkZqKeep647YYb4w1ePaG+obDXh5YnxzHRQ==", null, false, "05be8c7f-6dc8-4c66-9883-b52caf699d5c", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 22, 13, 23, 12, 999, DateTimeKind.Local).AddTicks(3051), new DateTime(2022, 11, 22, 13, 23, 13, 0, DateTimeKind.Local).AddTicks(8350), "Black", "System" },
                    { 2, "System", new DateTime(2022, 11, 22, 13, 23, 13, 0, DateTimeKind.Local).AddTicks(9361), new DateTime(2022, 11, 22, 13, 23, 13, 0, DateTimeKind.Local).AddTicks(9366), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 22, 13, 23, 13, 2, DateTimeKind.Local).AddTicks(1386), new DateTime(2022, 11, 22, 13, 23, 13, 2, DateTimeKind.Local).AddTicks(1394), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 11, 22, 13, 23, 13, 2, DateTimeKind.Local).AddTicks(1398), new DateTime(2022, 11, 22, 13, 23, 13, 2, DateTimeKind.Local).AddTicks(1399), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 22, 13, 23, 13, 2, DateTimeKind.Local).AddTicks(5001), new DateTime(2022, 11, 22, 13, 23, 13, 2, DateTimeKind.Local).AddTicks(5007), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 11, 22, 13, 23, 13, 2, DateTimeKind.Local).AddTicks(5011), new DateTime(2022, 11, 22, 13, 23, 13, 2, DateTimeKind.Local).AddTicks(5012), "X5", "System" },
                    { 3, "System", new DateTime(2022, 11, 22, 13, 23, 13, 2, DateTimeKind.Local).AddTicks(5014), new DateTime(2022, 11, 22, 13, 23, 13, 2, DateTimeKind.Local).AddTicks(5015), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 11, 22, 13, 23, 13, 2, DateTimeKind.Local).AddTicks(5016), new DateTime(2022, 11, 22, 13, 23, 13, 2, DateTimeKind.Local).AddTicks(5017), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
