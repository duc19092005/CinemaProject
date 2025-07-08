using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class Them_bang_miniumAge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "c70ee78d-7250-46b4-a0f9-7d93ad48aa41");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "bcde4517-8d60-4121-9ffb-0386616bb72d");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "e24caeec-e5e8-4926-8166-b69a1fe42536");

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "80474513-4409-47e7-99bb-ce65b32544e6");

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "752f2f92-e3f8-4ad6-ac1a-f591847328b3", "8dac25a5-fc45-4858-816b-2889968ad88e" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "644f9e71-23a2-4da3-8954-b7c1eaefc771", "be80cad5-0162-407e-acb9-f047169730e2" });

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "bd4e4e69-e1bf-436c-9f1c-144fa182eb23");

            migrationBuilder.DeleteData(
                table: "priceInformationForEachUserFilmType",
                keyColumns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                keyValues: new object[] { "ef392c2e-c3ed-4688-95d6-35cddc517164", "98e66d99-7097-4d54-ba15-b9ecbbc957d0", "d64857b1-cf23-4e66-921b-09d31f19d4ea" });

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "417377a9-daaa-4d5a-a54e-87422deb5894");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "5396687a-470c-41ac-8453-5d494cbbd4e5");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "903c0ff7-e31c-4252-89a0-040bd159c521");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "94857849-a56e-4ab0-b20f-c5f07bc97cf8");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "ed42c633-c35e-4b6f-a58b-bcf0ce8e7873");

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "ba162364-2319-4ce0-85ba-b50cd3f7c4a1", "a77f3623-50a2-40ac-ab8d-64de5d16cd71" });

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "e2576997-0a9c-4b60-8a4e-df641324d6e0", "53307433-2178-4ceb-8b1a-160d24d71aa1" });

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "3f208744-51fa-407f-8ad5-a9d275df7b1f");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "a15abf0d-7497-4706-9bd7-780298c53b43");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "644f9e71-23a2-4da3-8954-b7c1eaefc771");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "752f2f92-e3f8-4ad6-ac1a-f591847328b3");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "8dac25a5-fc45-4858-816b-2889968ad88e");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "be80cad5-0162-407e-acb9-f047169730e2");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "98e66d99-7097-4d54-ba15-b9ecbbc957d0");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "ba162364-2319-4ce0-85ba-b50cd3f7c4a1");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "e2576997-0a9c-4b60-8a4e-df641324d6e0");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "53307433-2178-4ceb-8b1a-160d24d71aa1");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "a77f3623-50a2-40ac-ab8d-64de5d16cd71");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "d64857b1-cf23-4e66-921b-09d31f19d4ea");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "eb2ce2bd-5761-4ded-afaf-d0f90a848485");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "318b690e-952c-4132-9f77-1e56951ce585");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "5f31b3a1-a3d2-49bf-bf9d-9245213ebd0c");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "ef392c2e-c3ed-4688-95d6-35cddc517164");

            migrationBuilder.DropColumn(
                name: "isServed",
                table: "Seats");

            migrationBuilder.AlterColumn<string>(
                name: "movieImage",
                table: "movieInformation",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AddColumn<string>(
                name: "minimumAgeID",
                table: "movieInformation",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "minimumAges",
                columns: table => new
                {
                    minimumAgeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    minimumAgeInfo = table.Column<int>(type: "int", nullable: false),
                    minimumAgeDescription = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_minimumAges", x => x.minimumAgeID);
                });

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "cinemaId", "cinemaContactHotlineNumber", "cinemaDescription", "cinemaLocation", "cinemaName" },
                values: new object[] { "279e86b0-bf61-4113-8191-b548ff71d13a", "0901234567", "Rạp chiếu phim hiện đại với nhiều phòng chiếu.", "123 Đường XYZ, TP.HCM", "Rạp Chiếu Phim ABC" });

            migrationBuilder.InsertData(
                table: "HourSchedule",
                columns: new[] { "HourScheduleID", "HourScheduleShowTime" },
                values: new object[,]
                {
                    { "309d65b8-52bb-4402-afb7-0f3ebb145583", "10:00" },
                    { "ddf4470d-7380-46e2-856d-4a1390cd9cc2", "08:00" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "languageId", "languageDetail" },
                values: new object[,]
                {
                    { "7bebe152-5dd1-44f4-8bfe-07e975caa47a", "English" },
                    { "8845197b-99ce-4cd5-95c2-5cfa542f7aed", "Vietnamese" }
                });

            migrationBuilder.InsertData(
                table: "foodInformation",
                columns: new[] { "foodInformationId", "foodInformationName", "foodPrice" },
                values: new object[] { "ca5b6bdf-31be-4da5-80e1-d39f7cde2e0b", "Popcorn", 50000L });

            migrationBuilder.InsertData(
                table: "minimumAges",
                columns: new[] { "minimumAgeID", "minimumAgeDescription", "minimumAgeInfo" },
                values: new object[,]
                {
                    { "07b61b2d-455e-4535-b99f-0157170cbd99", "Phim dành cho khán giả từ 13 tuổi trở lên.", 13 },
                    { "412f21a1-7afc-4fcb-9251-dc2fb31e2430", "Phim dành cho khán giả từ 18 tuổi trở lên.", 18 },
                    { "c35fbf12-d58f-4b64-8847-829d194ae5a8", "Phim dành cho khán giả từ 16 tuổi trở lên.", 16 }
                });

            migrationBuilder.InsertData(
                table: "movieGenre",
                columns: new[] { "movieGenreId", "movieGenreName" },
                values: new object[,]
                {
                    { "39e42ec9-e92f-4955-8a65-2900785e216b", "Action" },
                    { "9e78e35a-e21f-4eb5-a003-87120461e532", "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "movieVisualFormat",
                columns: new[] { "movieVisualFormatId", "movieVisualFormatName" },
                values: new object[] { "740b85a6-d811-4c63-8cb5-1a95fa709142", "2D" });

            migrationBuilder.InsertData(
                table: "priceInformation",
                columns: new[] { "priceInformationId", "priceAmount" },
                values: new object[] { "ee283ab5-4a58-4bbd-8e6e-6dbfdfac4422", 80000L });

            migrationBuilder.InsertData(
                table: "roleInformation",
                columns: new[] { "roleId", "roleName" },
                values: new object[,]
                {
                    { "31ad2ca7-9a0e-46d3-a8d3-e4a9d2bb068b", "FacilitiesManager" },
                    { "49185915-30fc-4e38-96b3-1a2241c35d92", "MovieManager" },
                    { "6a354735-696e-4ce0-a7d1-13fcc5a91586", "Cashier" },
                    { "91a251d0-a110-4ea4-8902-413f75906d5f", "Director" },
                    { "96ff6b2a-0e6a-4c1f-80c7-579bf340a679", "TheaterManager" },
                    { "d4f55e24-14d8-4ae6-89d7-fe6d76ffa580", "Customer" }
                });

            migrationBuilder.InsertData(
                table: "userInformation",
                columns: new[] { "userId", "loginUserEmail", "loginUserPassword" },
                values: new object[,]
                {
                    { "19f73c44-8c58-4d62-8621-d0fc716fc52a", "user@example.com", "hashed_password_user" },
                    { "5acc7093-d49a-4d5e-a75a-9bcd654d09cb", "admin@example.com", "hashed_password_admin" }
                });

            migrationBuilder.InsertData(
                table: "userType",
                columns: new[] { "userTypeId", "userTypeDescription" },
                values: new object[] { "0534953f-fa7e-43a1-8e35-dc9fcc4ea0c9", "Adult" });

            migrationBuilder.InsertData(
                table: "cinemaRoom",
                columns: new[] { "cinemaRoomId", "cinemaId", "cinemaRoomNumber", "isDeleted", "movieVisualFormatID" },
                values: new object[] { "40f480e4-1b20-4a62-a932-0f9101c547ef", "279e86b0-bf61-4113-8191-b548ff71d13a", 1, false, "740b85a6-d811-4c63-8cb5-1a95fa709142" });

            migrationBuilder.InsertData(
                table: "movieInformation",
                columns: new[] { "movieId", "ReleaseDate", "isDelete", "languageId", "minimumAgeID", "movieActor", "movieDescription", "movieDirector", "movieDuration", "movieImage", "movieName", "movieTrailerUrl" },
                values: new object[,]
                {
                    { "8b4d578e-eb44-4998-8bae-d99ee2cb6a0d", new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8845197b-99ce-4cd5-95c2-5cfa542f7aed", "07b61b2d-455e-4535-b99f-0157170cbd99", "Diễn Viên X, Diễn Viên Y", "Đây là một bộ phim hành động đầy kịch tính.", "Đạo Diễn A", 120, "aa.com", "Phim Hành Động 1", "http://trailer.com/phimhanhdong1" },
                    { "aa9acdd4-4d33-4bdf-9d41-5ab79d111032", new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "7bebe152-5dd1-44f4-8bfe-07e975caa47a", "412f21a1-7afc-4fcb-9251-dc2fb31e2430", "Actor Z, Actress W", "A funny movie for the whole family.", "Director B", 90, "aa.com.vn", "Comedy Film 1", "http://trailer.com/comedyfilm1" }
                });

            migrationBuilder.InsertData(
                table: "priceInformationForEachUserFilmType",
                columns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                values: new object[] { "740b85a6-d811-4c63-8cb5-1a95fa709142", "ee283ab5-4a58-4bbd-8e6e-6dbfdfac4422", "0534953f-fa7e-43a1-8e35-dc9fcc4ea0c9" });

            migrationBuilder.InsertData(
                table: "userRoleInformation",
                columns: new[] { "roleId", "userId" },
                values: new object[,]
                {
                    { "49185915-30fc-4e38-96b3-1a2241c35d92", "5acc7093-d49a-4d5e-a75a-9bcd654d09cb" },
                    { "d4f55e24-14d8-4ae6-89d7-fe6d76ffa580", "19f73c44-8c58-4d62-8621-d0fc716fc52a" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatsId", "cinemaRoomId", "isDelete", "isTaken", "seatsNumber" },
                values: new object[,]
                {
                    { "f4e5269c-98b2-4dbe-b577-36ca3ec042da", "40f480e4-1b20-4a62-a932-0f9101c547ef", false, false, "A2" },
                    { "f68f728a-0e71-4033-ac9d-7890c585b015", "40f480e4-1b20-4a62-a932-0f9101c547ef", false, false, "A1" }
                });

            migrationBuilder.InsertData(
                table: "movieGenreInformation",
                columns: new[] { "movieGenreId", "movieId" },
                values: new object[,]
                {
                    { "39e42ec9-e92f-4955-8a65-2900785e216b", "8b4d578e-eb44-4998-8bae-d99ee2cb6a0d" },
                    { "9e78e35a-e21f-4eb5-a003-87120461e532", "aa9acdd4-4d33-4bdf-9d41-5ab79d111032" }
                });

            migrationBuilder.InsertData(
                table: "movieSchedule",
                columns: new[] { "movieScheduleId", "DayInWeekendSchedule", "HourScheduleID", "IsDelete", "ScheduleDate", "cinemaRoomId", "movieId", "movieVisualFormatID" },
                values: new object[] { "d4e5d3c3-7af5-4476-b492-691d72597044", "Monday", "ddf4470d-7380-46e2-856d-4a1390cd9cc2", false, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "40f480e4-1b20-4a62-a932-0f9101c547ef", "8b4d578e-eb44-4998-8bae-d99ee2cb6a0d", "740b85a6-d811-4c63-8cb5-1a95fa709142" });

            migrationBuilder.CreateIndex(
                name: "IX_userType_userTypeDescription",
                table: "userType",
                column: "userTypeDescription",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_roleInformation_roleName",
                table: "roleInformation",
                column: "roleName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_priceInformation_priceAmount",
                table: "priceInformation",
                column: "priceAmount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_movieVisualFormat_movieVisualFormatName",
                table: "movieVisualFormat",
                column: "movieVisualFormatName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_movieInformation_minimumAgeID",
                table: "movieInformation",
                column: "minimumAgeID");

            migrationBuilder.CreateIndex(
                name: "IX_movieInformation_movieImage",
                table: "movieInformation",
                column: "movieImage",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_movieInformation_movieName",
                table: "movieInformation",
                column: "movieName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_movieInformation_movieTrailerUrl",
                table: "movieInformation",
                column: "movieTrailerUrl",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_movieGenre_movieGenreName",
                table: "movieGenre",
                column: "movieGenreName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Language_languageDetail",
                table: "Language",
                column: "languageDetail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HourSchedule_HourScheduleShowTime",
                table: "HourSchedule",
                column: "HourScheduleShowTime",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_minimumAges_minimumAgeDescription",
                table: "minimumAges",
                column: "minimumAgeDescription",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_minimumAges_minimumAgeInfo",
                table: "minimumAges",
                column: "minimumAgeInfo",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_movieInformation_minimumAges_minimumAgeID",
                table: "movieInformation",
                column: "minimumAgeID",
                principalTable: "minimumAges",
                principalColumn: "minimumAgeID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movieInformation_minimumAges_minimumAgeID",
                table: "movieInformation");

            migrationBuilder.DropTable(
                name: "minimumAges");

            migrationBuilder.DropIndex(
                name: "IX_userType_userTypeDescription",
                table: "userType");

            migrationBuilder.DropIndex(
                name: "IX_roleInformation_roleName",
                table: "roleInformation");

            migrationBuilder.DropIndex(
                name: "IX_priceInformation_priceAmount",
                table: "priceInformation");

            migrationBuilder.DropIndex(
                name: "IX_movieVisualFormat_movieVisualFormatName",
                table: "movieVisualFormat");

            migrationBuilder.DropIndex(
                name: "IX_movieInformation_minimumAgeID",
                table: "movieInformation");

            migrationBuilder.DropIndex(
                name: "IX_movieInformation_movieImage",
                table: "movieInformation");

            migrationBuilder.DropIndex(
                name: "IX_movieInformation_movieName",
                table: "movieInformation");

            migrationBuilder.DropIndex(
                name: "IX_movieInformation_movieTrailerUrl",
                table: "movieInformation");

            migrationBuilder.DropIndex(
                name: "IX_movieGenre_movieGenreName",
                table: "movieGenre");

            migrationBuilder.DropIndex(
                name: "IX_Language_languageDetail",
                table: "Language");

            migrationBuilder.DropIndex(
                name: "IX_HourSchedule_HourScheduleShowTime",
                table: "HourSchedule");

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "309d65b8-52bb-4402-afb7-0f3ebb145583");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "f4e5269c-98b2-4dbe-b577-36ca3ec042da");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "f68f728a-0e71-4033-ac9d-7890c585b015");

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "ca5b6bdf-31be-4da5-80e1-d39f7cde2e0b");

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "39e42ec9-e92f-4955-8a65-2900785e216b", "8b4d578e-eb44-4998-8bae-d99ee2cb6a0d" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "9e78e35a-e21f-4eb5-a003-87120461e532", "aa9acdd4-4d33-4bdf-9d41-5ab79d111032" });

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "d4e5d3c3-7af5-4476-b492-691d72597044");

            migrationBuilder.DeleteData(
                table: "priceInformationForEachUserFilmType",
                keyColumns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                keyValues: new object[] { "740b85a6-d811-4c63-8cb5-1a95fa709142", "ee283ab5-4a58-4bbd-8e6e-6dbfdfac4422", "0534953f-fa7e-43a1-8e35-dc9fcc4ea0c9" });

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "31ad2ca7-9a0e-46d3-a8d3-e4a9d2bb068b");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "6a354735-696e-4ce0-a7d1-13fcc5a91586");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "91a251d0-a110-4ea4-8902-413f75906d5f");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "96ff6b2a-0e6a-4c1f-80c7-579bf340a679");

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "49185915-30fc-4e38-96b3-1a2241c35d92", "5acc7093-d49a-4d5e-a75a-9bcd654d09cb" });

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "d4f55e24-14d8-4ae6-89d7-fe6d76ffa580", "19f73c44-8c58-4d62-8621-d0fc716fc52a" });

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "ddf4470d-7380-46e2-856d-4a1390cd9cc2");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "40f480e4-1b20-4a62-a932-0f9101c547ef");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "39e42ec9-e92f-4955-8a65-2900785e216b");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "9e78e35a-e21f-4eb5-a003-87120461e532");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "8b4d578e-eb44-4998-8bae-d99ee2cb6a0d");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "aa9acdd4-4d33-4bdf-9d41-5ab79d111032");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "ee283ab5-4a58-4bbd-8e6e-6dbfdfac4422");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "49185915-30fc-4e38-96b3-1a2241c35d92");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "d4f55e24-14d8-4ae6-89d7-fe6d76ffa580");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "19f73c44-8c58-4d62-8621-d0fc716fc52a");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "5acc7093-d49a-4d5e-a75a-9bcd654d09cb");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "0534953f-fa7e-43a1-8e35-dc9fcc4ea0c9");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "279e86b0-bf61-4113-8191-b548ff71d13a");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "7bebe152-5dd1-44f4-8bfe-07e975caa47a");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "8845197b-99ce-4cd5-95c2-5cfa542f7aed");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "740b85a6-d811-4c63-8cb5-1a95fa709142");

            migrationBuilder.DropColumn(
                name: "minimumAgeID",
                table: "movieInformation");

            migrationBuilder.AddColumn<bool>(
                name: "isServed",
                table: "Seats",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<byte[]>(
                name: "movieImage",
                table: "movieInformation",
                type: "varbinary(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "cinemaId", "cinemaContactHotlineNumber", "cinemaDescription", "cinemaLocation", "cinemaName" },
                values: new object[] { "eb2ce2bd-5761-4ded-afaf-d0f90a848485", "0901234567", "Rạp chiếu phim hiện đại với nhiều phòng chiếu.", "123 Đường XYZ, TP.HCM", "Rạp Chiếu Phim ABC" });

            migrationBuilder.InsertData(
                table: "HourSchedule",
                columns: new[] { "HourScheduleID", "HourScheduleShowTime" },
                values: new object[,]
                {
                    { "3f208744-51fa-407f-8ad5-a9d275df7b1f", "08:00" },
                    { "c70ee78d-7250-46b4-a0f9-7d93ad48aa41", "10:00" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "languageId", "languageDetail" },
                values: new object[,]
                {
                    { "318b690e-952c-4132-9f77-1e56951ce585", "Vietnamese" },
                    { "5f31b3a1-a3d2-49bf-bf9d-9245213ebd0c", "English" }
                });

            migrationBuilder.InsertData(
                table: "foodInformation",
                columns: new[] { "foodInformationId", "foodInformationName", "foodPrice" },
                values: new object[] { "80474513-4409-47e7-99bb-ce65b32544e6", "Popcorn", 50000L });

            migrationBuilder.InsertData(
                table: "movieGenre",
                columns: new[] { "movieGenreId", "movieGenreName" },
                values: new object[,]
                {
                    { "644f9e71-23a2-4da3-8954-b7c1eaefc771", "Comedy" },
                    { "752f2f92-e3f8-4ad6-ac1a-f591847328b3", "Action" }
                });

            migrationBuilder.InsertData(
                table: "movieVisualFormat",
                columns: new[] { "movieVisualFormatId", "movieVisualFormatName" },
                values: new object[] { "ef392c2e-c3ed-4688-95d6-35cddc517164", "2D" });

            migrationBuilder.InsertData(
                table: "priceInformation",
                columns: new[] { "priceInformationId", "priceAmount" },
                values: new object[] { "98e66d99-7097-4d54-ba15-b9ecbbc957d0", 80000L });

            migrationBuilder.InsertData(
                table: "roleInformation",
                columns: new[] { "roleId", "roleName" },
                values: new object[,]
                {
                    { "417377a9-daaa-4d5a-a54e-87422deb5894", "FacilitiesManager" },
                    { "5396687a-470c-41ac-8453-5d494cbbd4e5", "Cashier" },
                    { "903c0ff7-e31c-4252-89a0-040bd159c521", "TheaterManager" },
                    { "94857849-a56e-4ab0-b20f-c5f07bc97cf8", "Director" },
                    { "ba162364-2319-4ce0-85ba-b50cd3f7c4a1", "MovieManager" },
                    { "e2576997-0a9c-4b60-8a4e-df641324d6e0", "Customer" },
                    { "ed42c633-c35e-4b6f-a58b-bcf0ce8e7873", "TheaterCleaner" }
                });

            migrationBuilder.InsertData(
                table: "userInformation",
                columns: new[] { "userId", "loginUserEmail", "loginUserPassword" },
                values: new object[,]
                {
                    { "53307433-2178-4ceb-8b1a-160d24d71aa1", "user@example.com", "hashed_password_user" },
                    { "a77f3623-50a2-40ac-ab8d-64de5d16cd71", "admin@example.com", "hashed_password_admin" }
                });

            migrationBuilder.InsertData(
                table: "userType",
                columns: new[] { "userTypeId", "userTypeDescription" },
                values: new object[] { "d64857b1-cf23-4e66-921b-09d31f19d4ea", "Adult" });

            migrationBuilder.InsertData(
                table: "cinemaRoom",
                columns: new[] { "cinemaRoomId", "cinemaId", "cinemaRoomNumber", "isDeleted", "movieVisualFormatID" },
                values: new object[] { "a15abf0d-7497-4706-9bd7-780298c53b43", "eb2ce2bd-5761-4ded-afaf-d0f90a848485", 1, false, "ef392c2e-c3ed-4688-95d6-35cddc517164" });

            migrationBuilder.InsertData(
                table: "movieInformation",
                columns: new[] { "movieId", "ReleaseDate", "isDelete", "languageId", "movieActor", "movieDescription", "movieDirector", "movieDuration", "movieImage", "movieName", "movieTrailerUrl" },
                values: new object[,]
                {
                    { "8dac25a5-fc45-4858-816b-2889968ad88e", new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "318b690e-952c-4132-9f77-1e56951ce585", "Diễn Viên X, Diễn Viên Y", "Đây là một bộ phim hành động đầy kịch tính.", "Đạo Diễn A", 120, new byte[] { 1, 2, 3 }, "Phim Hành Động 1", "http://trailer.com/phimhanhdong1" },
                    { "be80cad5-0162-407e-acb9-f047169730e2", new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "5f31b3a1-a3d2-49bf-bf9d-9245213ebd0c", "Actor Z, Actress W", "A funny movie for the whole family.", "Director B", 90, new byte[] { 4, 5, 6 }, "Comedy Film 1", "http://trailer.com/comedyfilm1" }
                });

            migrationBuilder.InsertData(
                table: "priceInformationForEachUserFilmType",
                columns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                values: new object[] { "ef392c2e-c3ed-4688-95d6-35cddc517164", "98e66d99-7097-4d54-ba15-b9ecbbc957d0", "d64857b1-cf23-4e66-921b-09d31f19d4ea" });

            migrationBuilder.InsertData(
                table: "userRoleInformation",
                columns: new[] { "roleId", "userId" },
                values: new object[,]
                {
                    { "ba162364-2319-4ce0-85ba-b50cd3f7c4a1", "a77f3623-50a2-40ac-ab8d-64de5d16cd71" },
                    { "e2576997-0a9c-4b60-8a4e-df641324d6e0", "53307433-2178-4ceb-8b1a-160d24d71aa1" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatsId", "cinemaRoomId", "isDelete", "isServed", "isTaken", "seatsNumber" },
                values: new object[,]
                {
                    { "bcde4517-8d60-4121-9ffb-0386616bb72d", "a15abf0d-7497-4706-9bd7-780298c53b43", false, true, false, "A1" },
                    { "e24caeec-e5e8-4926-8166-b69a1fe42536", "a15abf0d-7497-4706-9bd7-780298c53b43", false, true, false, "A2" }
                });

            migrationBuilder.InsertData(
                table: "movieGenreInformation",
                columns: new[] { "movieGenreId", "movieId" },
                values: new object[,]
                {
                    { "752f2f92-e3f8-4ad6-ac1a-f591847328b3", "8dac25a5-fc45-4858-816b-2889968ad88e" },
                    { "644f9e71-23a2-4da3-8954-b7c1eaefc771", "be80cad5-0162-407e-acb9-f047169730e2" }
                });

            migrationBuilder.InsertData(
                table: "movieSchedule",
                columns: new[] { "movieScheduleId", "DayInWeekendSchedule", "HourScheduleID", "IsDelete", "ScheduleDate", "cinemaRoomId", "movieId", "movieVisualFormatID" },
                values: new object[] { "bd4e4e69-e1bf-436c-9f1c-144fa182eb23", "Monday", "3f208744-51fa-407f-8ad5-a9d275df7b1f", false, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "a15abf0d-7497-4706-9bd7-780298c53b43", "8dac25a5-fc45-4858-816b-2889968ad88e", "ef392c2e-c3ed-4688-95d6-35cddc517164" });
        }
    }
}
