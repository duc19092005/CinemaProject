using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class Fix_Lai_Password_Tang_Them_Bao_Mat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "a1b2c3d4-e5f6-7a8b-c9d0-e1f2a3b4c5d6",
                column: "loginUserPassword",
                value: "$2a$12$hZw7TwWKR/cR2WRRn/Q1guTjMqLH6dYcchlw4sAimSU41bJ42r3Ka");

            migrationBuilder.UpdateData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "b2c3d4e5-f6a7-8b9c-d0e1-f2a3b4c5d6e7",
                column: "loginUserPassword",
                value: "$2a$12$ADqBiSquthm1g7bLZvg6UulJ5QJFQQ6olUQzf66AQfJDGbQ2W1wlG");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "a1b2c3d4-e5f6-7a8b-c9d0-e1f2a3b4c5d6",
                column: "loginUserPassword",
                value: "$2a$11$pygsxEU/dOothY1Uvba5tOiKtT0OoiHsNcWUTt0hpknXOVvE8BA8G");

            migrationBuilder.UpdateData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "b2c3d4e5-f6a7-8b9c-d0e1-f2a3b4c5d6e7",
                column: "loginUserPassword",
                value: "$2a$11$IbdXmPBNLvebUAbc21vKN.OpDIkehFG/DY0CaTXQcIvVdxLnyWA5O");
        }
    }
}
