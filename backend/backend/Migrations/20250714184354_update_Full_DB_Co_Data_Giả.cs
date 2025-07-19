using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class update_Full_DB_Co_Data_Giả : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "a3b4c5d6-e7f8-9a0b-1c2d-3e4f5a6b7c8d");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "a7b8c9d0-e1f2-3a4b-5c6d-7e8f9a0b1c2d");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "a9b0c1d2-e3f4-5f6a-7b8c-9d0e1f2a3b4c");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "b0c1d2e3-f4a5-6a7b-8c9d-0e1f2a3b4c5d");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "b4c5d6e7-f8a9-0b1c-2d3e-4f5a6b7c8d9e");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "b8c9d0e1-f2a3-4b5c-6d7e-8f9a0b1c2d3e");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "c5d6e7f8-a9b0-1c2d-3e4f-5a6b7c8d9e0f");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "c9d0e1f2-a3b4-5c6d-7e8f-9a0b1c2d3e4f");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "d0e1f2a3-b4c5-6d7e-8f9a-0b1c2d3e4f5a");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "d6e7f8a9-b0c1-2c3d-4e5f-6a7b8c9d0e1f");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "e1f2a3b4-c5d6-7e8f-9a0b-1c2d3e4f5a6b");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "e7f8a9b0-c1d2-3d4e-5f6a-7b8c9d0e1f2a");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "f2a3b4c5-d6e7-8f9a-0b1c-2d3e4f5a6b7c");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "f8a9b0c1-d2e3-4e5f-6a7b-8c9d0e1f2a3b");

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "cinemaId", "cinemaContactHotlineNumber", "cinemaDescription", "cinemaLocation", "cinemaName" },
                values: new object[] { "5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f", "0987654321", "Không gian ấm cúng, chất lượng hàng đầu.", "456 Đường UVW, Hà Nội", "Rạp Chiếu Phim LMN" });

            migrationBuilder.InsertData(
                table: "HourSchedule",
                columns: new[] { "HourScheduleID", "HourScheduleShowTime" },
                values: new object[,]
                {
                    { "5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f", "14:00" },
                    { "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", "16:30" },
                    { "7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b", "19:00" },
                    { "8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c", "21:30" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "languageId", "languageDetail" },
                values: new object[,]
                {
                    { "11d4e5f6-a7b8-c9d0-e1f2-a3b4c5d6e711", "Korean" },
                    { "22d4e5f6-a7b8-c9d0-e1f2-a3b4c5d6e722", "Japanese" }
                });

            migrationBuilder.InsertData(
                table: "foodInformation",
                columns: new[] { "foodInformationId", "foodInformationName", "foodPrice" },
                values: new object[,]
                {
                    { "3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b", "Coca-Cola", 25000L },
                    { "4f5a6b7c-8d9e-0f1a-2b3c-4d5e6f7a8b9c", "Nachos", 65000L },
                    { "5a6b7c8d-9e0f-1a2b-3c4d-5e6f7a8b9c0d", "Hot Dog", 45000L }
                });

            migrationBuilder.InsertData(
                table: "minimumAges",
                columns: new[] { "minimumAgeID", "minimumAgeDescription", "minimumAgeInfo" },
                values: new object[] { "6a7b8c9d-0e1f-2a3b-4c5d-6e7f8a9b0c1d", "Phim phù hợp với mọi lứa tuổi.", 0 });

            migrationBuilder.InsertData(
                table: "movieGenre",
                columns: new[] { "movieGenreId", "movieGenreName" },
                values: new object[,]
                {
                    { "a1a7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c2", "Horror" },
                    { "b2b7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c3", "Sci-Fi" },
                    { "c3c7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c4", "Romance" },
                    { "d4d7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c5", "Animation" }
                });

            migrationBuilder.InsertData(
                table: "movieInformation",
                columns: new[] { "movieId", "ReleaseDate", "isDelete", "languageId", "minimumAgeID", "movieActor", "movieDescription", "movieDirector", "movieDuration", "movieImage", "movieName", "movieTrailerUrl" },
                values: new object[,]
                {
                    { "2f3a4b5c-6d7e-8f9a-0b1c2d3e4f5a6b7c", new DateTime(2013, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "d4e5f6a7-b8c9-d0e1-f2a3-b4c5d6e7f8a9", "9c0d1e2f-3a4b-5c6d-7e8f-9a0b1c2d3e4f", "Vera Farmiga, Patrick Wilson", "Dựa trên một câu chuyện có thật, phim theo chân hai nhà điều tra hiện tượng siêu nhiên.", "James Wan", 112, "conjuring.com", "Ám Ảnh Kinh Hoàng", "http://trailer.com/conjuring" },
                    { "3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d", new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "d4e5f6a7-b8c9-d0e1-f2a3-b4c5d6e7f8a9", "7a8b9c0d-1e2f-3a4b-5c6d-7e8f9a0b1c2d", "Matthew McConaughey, Anne Hathaway", "Một nhóm các nhà du hành vũ trụ đi qua một hố sâu để tìm một ngôi nhà mới cho nhân loại.", "Christopher Nolan", 169, "interstellar.com", "Hố Đen Du Hành", "http://trailer.com/interstellar" }
                });

            migrationBuilder.InsertData(
                table: "movieVisualFormat",
                columns: new[] { "movieVisualFormatId", "movieVisualFormatName" },
                values: new object[,]
                {
                    { "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", "3D" },
                    { "7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b", "IMAX" }
                });

            migrationBuilder.InsertData(
                table: "priceInformation",
                columns: new[] { "priceInformationId", "priceAmount" },
                values: new object[,]
                {
                    { "1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f", 120000L },
                    { "2d3e4f5a-6b7c-8d9e-0f1a-2b3c4d5e6f7a", 70000L },
                    { "3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b", 60000L }
                });

            migrationBuilder.InsertData(
                table: "userType",
                columns: new[] { "userTypeId", "userTypeDescription" },
                values: new object[,]
                {
                    { "2d3e4f5a-6b7c-8d9e-0f1a-2b3c4d5e6f7a", "Child" },
                    { "3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b", "Student" }
                });

            migrationBuilder.InsertData(
                table: "cinemaRoom",
                columns: new[] { "cinemaRoomId", "cinemaId", "cinemaRoomNumber", "isDeleted", "movieVisualFormatID" },
                values: new object[,]
                {
                    { "7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b", "2f3a4b5c-6d7e-8f9a-0b1c-2d3e4f5a6b7c", 2, false, "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a" },
                    { "8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c", "5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f", 1, false, "5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f" },
                    { "9a0b1c2d-3e4f-5a6b-7c8d-9e0f1a2b3c4d", "5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f", 2, false, "7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b" }
                });

            migrationBuilder.InsertData(
                table: "movieGenreInformation",
                columns: new[] { "movieGenreId", "movieId" },
                values: new object[,]
                {
                    { "a1a7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c2", "2f3a4b5c-6d7e-8f9a-0b1c2d3e4f5a6b7c" },
                    { "b2b7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c3", "3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d" },
                    { "e5f6a7b8-c9d0-e1f2-a3b4-c5d6e7f8a9b0", "3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d" }
                });

            migrationBuilder.InsertData(
                table: "movieInformation",
                columns: new[] { "movieId", "ReleaseDate", "isDelete", "languageId", "minimumAgeID", "movieActor", "movieDescription", "movieDirector", "movieDuration", "movieImage", "movieName", "movieTrailerUrl" },
                values: new object[] { "4b5c6d7e-8f9a-0b1c-2d3e-4f5a6b7c8d9e", new DateTime(2001, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "22d4e5f6-a7b8-c9d0-e1f2-a3b4c5d6e722", "6a7b8c9d-0e1f-2a3b-4c5d-6e7f8a9b0c1d", "Rumi Hiiragi, Miyu Irino", "Trong lúc chuyển nhà, cô bé Chihiro và gia đình đã lạc vào một thế giới của các vị thần.", "Hayao Miyazaki", 125, "spiritedaway.com", "Vùng Đất Linh Hồn", "http://trailer.com/spiritedaway" });

            migrationBuilder.InsertData(
                table: "movieSchedule",
                columns: new[] { "movieScheduleId", "DayInWeekendSchedule", "HourScheduleID", "IsDelete", "ScheduleDate", "cinemaRoomId", "movieId", "movieVisualFormatID" },
                values: new object[] { "8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c", "Friday", "8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c", false, new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", "2f3a4b5c-6d7e-8f9a-0b1c2d3e4f5a6b7c", "5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f" });

            migrationBuilder.InsertData(
                table: "priceInformationForEachUserFilmType",
                columns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                values: new object[,]
                {
                    { "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", "1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f", "1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f" },
                    { "7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b", "1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f", "1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f" },
                    { "5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f", "3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b", "2d3e4f5a-6b7c-8d9e-0f1a-2b3c4d5e6f7a" },
                    { "5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f", "2d3e4f5a-6b7c-8d9e-0f1a-2b3c4d5e6f7a", "3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatsId", "cinemaRoomId", "isDelete", "isTaken", "seatsNumber" },
                values: new object[,]
                {
                    { "11111111-2d3e-4f5a-6b7c-8d9e0f1a2b3c", "7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b", false, false, "B1" },
                    { "22222222-3e4f-5a6b-7c8d-9e0f1a2b3c4d", "7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b", false, false, "B2" },
                    { "33333333-4f5a-6b7c-8d9e-0f1a2b3c4d5e", "7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b", false, false, "B3" },
                    { "44444444-5a6b-7c8d-9e0f-1a2b3c4d5e6f", "8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c", false, false, "C1" },
                    { "55555555-6b7c-8d9e-0f1a-2b3c4d5e6f7a", "8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c", false, false, "C2" },
                    { "66666666-7c8d-9e0f-1a2b-3c4d5e6f7a8b", "9a0b1c2d-3e4f-5a6b-7c8d-9e0f1a2b3c4d", false, false, "D1" },
                    { "77777777-8d9e-0f1a-2b3c-4d5e6f7a8b9c", "9a0b1c2d-3e4f-5a6b-7c8d-9e0f1a2b3c4d", false, false, "D2" }
                });

            migrationBuilder.InsertData(
                table: "movieGenreInformation",
                columns: new[] { "movieGenreId", "movieId" },
                values: new object[] { "d4d7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c5", "4b5c6d7e-8f9a-0b1c-2d3e-4f5a6b7c8d9e" });

            migrationBuilder.InsertData(
                table: "movieSchedule",
                columns: new[] { "movieScheduleId", "DayInWeekendSchedule", "HourScheduleID", "IsDelete", "ScheduleDate", "cinemaRoomId", "movieId", "movieVisualFormatID" },
                values: new object[,]
                {
                    { "9a0b1c2d-3e4f-5a6b-7c8d-9e0f1a2b3c4d", "Saturday", "7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b", false, new DateTime(2025, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "9a0b1c2d-3e4f-5a6b-7c8d-9e0f1a2b3c4d", "3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d", "7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b" },
                    { "a1b2c3d4-e5f6-7a8b-c9d0-e1f2a3b4c5d6", "Sunday", "4b5c6d7e-8f9a-0b1c-2d3e-4f5a6b7c8d9e", false, new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c", "4b5c6d7e-8f9a-0b1c-2d3e-4f5a6b7c8d9e", "5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f");

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "11d4e5f6-a7b8-c9d0-e1f2-a3b4c5d6e711");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "11111111-2d3e-4f5a-6b7c-8d9e0f1a2b3c");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "22222222-3e4f-5a6b-7c8d-9e0f1a2b3c4d");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "33333333-4f5a-6b7c-8d9e-0f1a2b3c4d5e");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "44444444-5a6b-7c8d-9e0f-1a2b3c4d5e6f");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "55555555-6b7c-8d9e-0f1a-2b3c4d5e6f7a");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "66666666-7c8d-9e0f-1a2b-3c4d5e6f7a8b");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "77777777-8d9e-0f1a-2b3c-4d5e6f7a8b9c");

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b");

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "4f5a6b7c-8d9e-0f1a-2b3c-4d5e6f7a8b9c");

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "5a6b7c8d-9e0f-1a2b-3c4d-5e6f7a8b9c0d");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "c3c7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c4");

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "a1a7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c2", "2f3a4b5c-6d7e-8f9a-0b1c2d3e4f5a6b7c" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "b2b7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c3", "3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "e5f6a7b8-c9d0-e1f2-a3b4-c5d6e7f8a9b0", "3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "d4d7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c5", "4b5c6d7e-8f9a-0b1c-2d3e-4f5a6b7c8d9e" });

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c");

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "9a0b1c2d-3e4f-5a6b-7c8d-9e0f1a2b3c4d");

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "a1b2c3d4-e5f6-7a8b-c9d0-e1f2a3b4c5d6");

            migrationBuilder.DeleteData(
                table: "priceInformationForEachUserFilmType",
                keyColumns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                keyValues: new object[] { "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", "1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f", "1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f" });

            migrationBuilder.DeleteData(
                table: "priceInformationForEachUserFilmType",
                keyColumns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                keyValues: new object[] { "7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b", "1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f", "1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f" });

            migrationBuilder.DeleteData(
                table: "priceInformationForEachUserFilmType",
                keyColumns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                keyValues: new object[] { "5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f", "3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b", "2d3e4f5a-6b7c-8d9e-0f1a-2b3c4d5e6f7a" });

            migrationBuilder.DeleteData(
                table: "priceInformationForEachUserFilmType",
                keyColumns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                keyValues: new object[] { "5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f", "2d3e4f5a-6b7c-8d9e-0f1a-2b3c4d5e6f7a", "3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b" });

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b");

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "9a0b1c2d-3e4f-5a6b-7c8d-9e0f1a2b3c4d");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "a1a7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c2");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "b2b7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c3");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "d4d7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c5");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "2f3a4b5c-6d7e-8f9a-0b1c2d3e4f5a6b7c");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "4b5c6d7e-8f9a-0b1c-2d3e-4f5a6b7c8d9e");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "2d3e4f5a-6b7c-8d9e-0f1a-2b3c4d5e6f7a");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "2d3e4f5a-6b7c-8d9e-0f1a-2b3c4d5e6f7a");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "3e4f5a6b-7c8d-9e0f-1a2b-3c4d5e6f7a8b");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "22d4e5f6-a7b8-c9d0-e1f2-a3b4c5d6e722");

            migrationBuilder.DeleteData(
                table: "minimumAges",
                keyColumn: "minimumAgeID",
                keyValue: "6a7b8c9d-0e1f-2a3b-4c5d-6e7f8a9b0c1d");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b");

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatsId", "cinemaRoomId", "isDelete", "isTaken", "seatsNumber" },
                values: new object[,]
                {
                    { "a3b4c5d6-e7f8-9a0b-1c2d-3e4f5a6b7c8d", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A15" },
                    { "a7b8c9d0-e1f2-3a4b-5c6d-7e8f9a0b1c2d", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A9" },
                    { "a9b0c1d2-e3f4-5f6a-7b8c-9d0e1f2a3b4c", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A21" },
                    { "b0c1d2e3-f4a5-6a7b-8c9d-0e1f2a3b4c5d", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A22" },
                    { "b4c5d6e7-f8a9-0b1c-2d3e-4f5a6b7c8d9e", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A16" },
                    { "b8c9d0e1-f2a3-4b5c-6d7e-8f9a0b1c2d3e", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A10" },
                    { "c5d6e7f8-a9b0-1c2d-3e4f-5a6b7c8d9e0f", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A17" },
                    { "c9d0e1f2-a3b4-5c6d-7e8f-9a0b1c2d3e4f", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A11" },
                    { "d0e1f2a3-b4c5-6d7e-8f9a-0b1c2d3e4f5a", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A12" },
                    { "d6e7f8a9-b0c1-2c3d-4e5f-6a7b8c9d0e1f", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A18" },
                    { "e1f2a3b4-c5d6-7e8f-9a0b-1c2d3e4f5a6b", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A13" },
                    { "e7f8a9b0-c1d2-3d4e-5f6a-7b8c9d0e1f2a", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A19" },
                    { "f2a3b4c5-d6e7-8f9a-0b1c-2d3e4f5a6b7c", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A14" },
                    { "f8a9b0c1-d2e3-4e5f-6a7b-8c9d0e1f2a3b", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A20" }
                });
        }
    }
}
