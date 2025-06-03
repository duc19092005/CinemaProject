using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class Them_Bang_Comment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movieCommentDetail",
                columns: table => new
                {
                    movieId = table.Column<string>(type: "varchar(100)", nullable: false),
                    userId = table.Column<string>(type: "varchar(100)", nullable: false),
                    userCommentDetail = table.Column<string>(type: "nvarchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieCommentDetail", x => new { x.movieId, x.userId });
                    table.ForeignKey(
                        name: "FK_movieCommentDetail_movieInformation_movieId",
                        column: x => x.movieId,
                        principalTable: "movieInformation",
                        principalColumn: "movieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movieCommentDetail_userInformation_userId",
                        column: x => x.userId,
                        principalTable: "userInformation",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_movieCommentDetail_userId",
                table: "movieCommentDetail",
                column: "userId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movieCommentDetail");
        }
    }
}
