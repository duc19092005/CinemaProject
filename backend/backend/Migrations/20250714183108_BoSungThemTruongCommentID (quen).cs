using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class BoSungThemTruongCommentIDquen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_movieCommentDetail",
                table: "movieCommentDetail");

            migrationBuilder.AddColumn<string>(
                name: "commentID",
                table: "movieCommentDetail",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_movieCommentDetail",
                table: "movieCommentDetail",
                column: "commentID");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_seatsId",
                table: "Seats",
                column: "seatsId");

            migrationBuilder.CreateIndex(
                name: "IX_movieCommentDetail_movieId",
                table: "movieCommentDetail",
                column: "movieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Seats_seatsId",
                table: "Seats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_movieCommentDetail",
                table: "movieCommentDetail");

            migrationBuilder.DropIndex(
                name: "IX_movieCommentDetail_movieId",
                table: "movieCommentDetail");

            migrationBuilder.DropColumn(
                name: "commentID",
                table: "movieCommentDetail");

            migrationBuilder.AddPrimaryKey(
                name: "PK_movieCommentDetail",
                table: "movieCommentDetail",
                columns: new[] { "movieId", "customerID" });
        }
    }
}
