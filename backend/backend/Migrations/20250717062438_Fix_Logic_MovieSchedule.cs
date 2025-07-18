using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class Fix_Logic_MovieSchedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_movieSchedule_movieId",
                table: "movieSchedule");

            migrationBuilder.CreateIndex(
                name: "IX_movieSchedule_cinemaRoomId_ScheduleDate_HourScheduleID",
                table: "movieSchedule",
                columns: new[] { "cinemaRoomId", "ScheduleDate", "HourScheduleID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_movieSchedule_movieId_ScheduleDate_HourScheduleID",
                table: "movieSchedule",
                columns: new[] { "movieId", "ScheduleDate", "HourScheduleID" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_movieSchedule_cinemaRoomId_ScheduleDate_HourScheduleID",
                table: "movieSchedule");

            migrationBuilder.DropIndex(
                name: "IX_movieSchedule_movieId_ScheduleDate_HourScheduleID",
                table: "movieSchedule");

            migrationBuilder.CreateIndex(
                name: "IX_movieSchedule_movieId",
                table: "movieSchedule",
                column: "movieId");
        }
    }
}
