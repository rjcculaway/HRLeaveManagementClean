using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.LeaveManagement.Identity.Migrations
{
    /// <inheritdoc />
    public partial class InitialIdentityMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d018cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9a23106-28c4-416d-b723-f4d1de767df7", "AQAAAAIAAYagAAAAEF0I11nThHrAnk4stEmzEa8Oi2/w1NyL+cRiGJK+HeGQzlUROKfC8CsvFWTc22lNLA==", "091f02c2-8034-43bb-893b-96d91b0224f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a6231a8-512e-4093-a2e2-edc173a44532", "AQAAAAIAAYagAAAAEP3wL9okrpbHAUzj0TF+OCIdLHbrBFVqmQLJ78TSasg8yp4zDfjl1lYwPF/W63rnbQ==", "b9f3344b-62b1-4e05-baac-987a320cb77a" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fc28991c-6081-4667-ade5-c0a88af0a1bd", 0, "181966da-bab6-4b3a-bd79-98943e269cf5", "rene@rene.com", true, "Renee Jonathan", "Callaway", false, null, null, "RENEE@RENEE.COM", "AQAAAAIAAYagAAAAEEdrMqObO7TfsA/YpTfqy48z1nHm54rkRABwWnLwE4z+qNOVvAdrwtHFcvYpMK2LIw==", null, false, "cc3832c9-7211-4e02-9626-196980210502", false, "Renee@Renee.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc28991c-6081-4667-ade5-c0a88af0a1bd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d018cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "030db722-b2a3-439c-9055-c4072115a5d5", "AQAAAAIAAYagAAAAELA1qXgeD/Qv1kVsA4AwasR7XqiRHxtlDJ74pvL6dLWx8QZtwhD7BBE5uBSJBl2bJQ==", "d740b907-9af9-447a-9031-d4d5036bad87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a201a984-b7bc-4c12-ba3f-adbc77c32a4a", "AQAAAAIAAYagAAAAEFWJe13P9qh2typDM/RTWBIrESaEJQeC2ZSmJqScjj+FBpckf+VD6MUEiT1OVxWzqA==", "3c48c120-f9bd-4a32-8ef5-a598d3ba485a" });
        }
    }
}
