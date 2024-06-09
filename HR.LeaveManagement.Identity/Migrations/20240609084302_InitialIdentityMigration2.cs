using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.LeaveManagement.Identity.Migrations
{
    /// <inheritdoc />
    public partial class InitialIdentityMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d018cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1784a417-a53d-46e3-8926-9bed7f3cb331", "AQAAAAIAAYagAAAAEL4AG5yKC5sTaLD1hJnuctNHnz5C6iBj1ZCSmNHsKSrmZdv9PinZR4pe+YUmoG+gKA==", "35bd43b4-0c01-4a30-99f9-aa62ce5b0ac9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7220b510-1ceb-49fb-b3c2-b4d2f3e966ef", "AQAAAAIAAYagAAAAENoDmHYRt3skdMJ3N8UdeC6iH2XOaorBcQ2oxXMZUFoP3QSBmvrfZKy9EL85YsLE1A==", "d1a0c379-8d72-45ea-a2e3-1b4cf24b5d10" });
        }
    }
}
