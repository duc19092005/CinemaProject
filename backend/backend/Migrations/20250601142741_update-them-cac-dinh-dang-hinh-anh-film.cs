using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class updatethemcacdinhdanghinhanhfilm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "movieVisualFormatId",
                table: "priceInformation",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "movieVisualFormatId",
                table: "movieInformation",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "movieVisualFormat",
                columns: table => new
                {
                    movieVisualFormatId = table.Column<string>(type: "varchar(100)", nullable: false),
                    movieVisualFormatName = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieVisualFormat", x => x.movieVisualFormatId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_priceInformation_movieVisualFormatId",
                table: "priceInformation",
                column: "movieVisualFormatId");

            migrationBuilder.CreateIndex(
                name: "IX_movieInformation_movieVisualFormatId",
                table: "movieInformation",
                column: "movieVisualFormatId");

            migrationBuilder.AddForeignKey(
                name: "FK_movieInformation_movieVisualFormat_movieVisualFormatId",
                table: "movieInformation",
                column: "movieVisualFormatId",
                principalTable: "movieVisualFormat",
                principalColumn: "movieVisualFormatId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_priceInformation_movieVisualFormat_movieVisualFormatId",
                table: "priceInformation",
                column: "movieVisualFormatId",
                principalTable: "movieVisualFormat",
                principalColumn: "movieVisualFormatId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movieInformation_movieVisualFormat_movieVisualFormatId",
                table: "movieInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_priceInformation_movieVisualFormat_movieVisualFormatId",
                table: "priceInformation");

            migrationBuilder.DropTable(
                name: "movieVisualFormat");

            migrationBuilder.DropIndex(
                name: "IX_priceInformation_movieVisualFormatId",
                table: "priceInformation");

            migrationBuilder.DropIndex(
                name: "IX_movieInformation_movieVisualFormatId",
                table: "movieInformation");

            migrationBuilder.DropColumn(
                name: "movieVisualFormatId",
                table: "priceInformation");

            migrationBuilder.DropColumn(
                name: "movieVisualFormatId",
                table: "movieInformation");
        }
    }
}
