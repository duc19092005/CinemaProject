using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class addtheminterfaceservicesdtovachinhsualaitenmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userImage",
                table: "userInformation");

            migrationBuilder.RenameColumn(
                name: "loginUserName",
                table: "userInformation",
                newName: "loginUserEmail");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "loginUserEmail",
                table: "userInformation",
                newName: "loginUserName");

            migrationBuilder.AddColumn<byte[]>(
                name: "userImage",
                table: "userInformation",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
