using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.LeaveManagement.Identity.Migrations
{
    /// <inheritdoc />
    public partial class InitialIdentityMigration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d018cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc28991c-6081-4667-ade5-c0a88af0a1bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d018cdb9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d36a01c1-ecca-4e0c-9141-32d157bbe0a0", "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEEp0fU7AX8ROoF62JqQEwFmkudxvppgA9kaTp2YbILjJ6WbGyNTq42lXK3TdvcCZOA==", "c421e8c6-7567-4515-ab6c-1460a25c9d86" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "a4a2a0aa-dfff-4f4b-8ce2-0b2e093c64a8", "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHp+SiC65tfMrmxVPmWMrnqmtnRGabP9U31aAmaFmUYEuN7FKaimv/RrnVUcHFa9Rg==", null, false, "9a282944-5a6b-4236-9057-1cc14857baae", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a6231a8-512e-4093-a2e2-edc173a44532", null, "AQAAAAIAAYagAAAAEP3wL9okrpbHAUzj0TF+OCIdLHbrBFVqmQLJ78TSasg8yp4zDfjl1lYwPF/W63rnbQ==", "b9f3344b-62b1-4e05-baac-987a320cb77a" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d018cdb9", 0, "c9a23106-28c4-416d-b723-f4d1de767df7", "admin@localhost.com", true, "System", "Admin", false, null, null, "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEF0I11nThHrAnk4stEmzEa8Oi2/w1NyL+cRiGJK+HeGQzlUROKfC8CsvFWTc22lNLA==", null, false, "091f02c2-8034-43bb-893b-96d91b0224f7", false, "admin@localhost.com" },
                    { "fc28991c-6081-4667-ade5-c0a88af0a1bd", 0, "181966da-bab6-4b3a-bd79-98943e269cf5", "rene@rene.com", true, "Renee Jonathan", "Callaway", false, null, null, "RENEE@RENEE.COM", "AQAAAAIAAYagAAAAEEdrMqObO7TfsA/YpTfqy48z1nHm54rkRABwWnLwE4z+qNOVvAdrwtHFcvYpMK2LIw==", null, false, "cc3832c9-7211-4e02-9626-196980210502", false, "Renee@Renee.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d018cdb9" });
        }
    }
}
