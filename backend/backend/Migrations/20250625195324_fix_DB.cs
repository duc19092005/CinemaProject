using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class fix_DB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "ec3ee02f-19a7-4e94-8477-1af213b2c165");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "29a46960-810a-49be-a5dd-524016dcd58b");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "6d466e5c-80fb-4aad-8068-d5b8f26c1706");

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "af73e73e-3b16-438a-9e5e-ba700abca839");

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "87061725-db04-4d71-a91a-7e890f799bd5", "39e9688c-0297-4169-b97b-e41d542b719f" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "3c0237cc-d545-4e0e-8cda-711f34d67d96", "c8f2f519-9616-40b5-ba03-c9c21fe4ad11" });

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "1da269b3-fd18-4694-83e7-a0bbbc71f30f");

            migrationBuilder.DeleteData(
                table: "priceInformationForEachUserFilmType",
                keyColumns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                keyValues: new object[] { "76c7526b-09bd-4cd8-b155-dc2915350e20", "13ed9c94-06af-49dc-8baa-afb1a0fb02ed", "a8c3dd1b-7d79-4e79-a13f-21310ae67b71" });

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "49bb193f-d428-4e38-9055-8fc4f83cd5f1");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "672da49d-1742-4c44-ae10-c8902d0367aa");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "b7657304-97a5-4613-b298-17054cfbc190");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "dec1f605-2e5a-4461-a624-5cbd5be781a7");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "f55a39fc-b948-4e97-9330-2858165d02ef");

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "03e485f6-4f4d-4ede-a533-88a48867c9e9", "4b00f6d2-8692-445f-8758-9687a8237dbd" });

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "e3c8e86a-7a5f-4c43-9d55-80a0e8eafda5", "4bb225ed-afca-4c16-a764-eef3b6a5879f" });

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "d7853d5a-15e6-4041-8f4b-432fc25c9df6");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "e6046455-864e-4c66-8d31-89bf3d8e2b9b");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "3c0237cc-d545-4e0e-8cda-711f34d67d96");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "87061725-db04-4d71-a91a-7e890f799bd5");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "39e9688c-0297-4169-b97b-e41d542b719f");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "c8f2f519-9616-40b5-ba03-c9c21fe4ad11");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "76c7526b-09bd-4cd8-b155-dc2915350e20");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "13ed9c94-06af-49dc-8baa-afb1a0fb02ed");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "03e485f6-4f4d-4ede-a533-88a48867c9e9");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "e3c8e86a-7a5f-4c43-9d55-80a0e8eafda5");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "4b00f6d2-8692-445f-8758-9687a8237dbd");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "4bb225ed-afca-4c16-a764-eef3b6a5879f");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "a8c3dd1b-7d79-4e79-a13f-21310ae67b71");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "46da5f2c-01d0-461c-ab41-c584e933ee3d");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "63f18f02-e063-4a73-9fe9-4a152fc35b06");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "d032e50c-dc76-48b9-9245-190375a7c101");

            migrationBuilder.DropColumn(
                name: "isSupportedIMAX",
                table: "Cinema");

            migrationBuilder.RenameColumn(
                name: "isMiddle",
                table: "Seats",
                newName: "isDelete");

            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "movieSchedule",
                newName: "ScheduleDate");

            migrationBuilder.RenameIndex(
                name: "IX_movieSchedule_cinemaRoomId_cinemaID_ReleaseDate",
                table: "movieSchedule",
                newName: "IX_movieSchedule_cinemaRoomId_cinemaID_ScheduleDate");

            migrationBuilder.RenameColumn(
                name: "isIMAXRoom",
                table: "cinemaRoom",
                newName: "isDeleted");

            migrationBuilder.AddColumn<string>(
                name: "movieVisualFormatID",
                table: "movieSchedule",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "amount",
                table: "materialReport",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "movieVisualFormatID",
                table: "cinemaRoom",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "cinemaId", "cinemaContactHotlineNumber", "cinemaDescription", "cinemaLocation", "cinemaName" },
                values: new object[] { "78d18c38-e169-4b4b-b35b-b738b2c28f36", "0901234567", "Rạp chiếu phim hiện đại với nhiều phòng chiếu.", "123 Đường XYZ, TP.HCM", "Rạp Chiếu Phim ABC" });

            migrationBuilder.InsertData(
                table: "HourSchedule",
                columns: new[] { "HourScheduleID", "HourScheduleShowTime" },
                values: new object[,]
                {
                    { "bf03f24b-3817-4ca9-af00-218b27e3add8", "08:00" },
                    { "e2c9789f-f135-496d-a2d4-e0a5ec31eb39", "10:00" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "languageId", "languageDetail" },
                values: new object[,]
                {
                    { "3bf9deb7-3738-487a-a922-5e7f8d0b80fa", "Vietnamese" },
                    { "de32be34-f888-47df-be2d-44549e61c21d", "English" }
                });

            migrationBuilder.InsertData(
                table: "foodInformation",
                columns: new[] { "foodInformationId", "foodInformationName", "foodPrice" },
                values: new object[] { "db0c701c-3585-45df-9656-d12a731c4ad4", "Popcorn", 50000L });

            migrationBuilder.InsertData(
                table: "movieGenre",
                columns: new[] { "movieGenreId", "movieGenreName" },
                values: new object[,]
                {
                    { "124ae20c-f652-4edb-8420-ba9c2a20ffb6", "Action" },
                    { "1b9a3055-4af5-4750-b3d6-815b9876402b", "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "movieVisualFormat",
                columns: new[] { "movieVisualFormatId", "movieVisualFormatName" },
                values: new object[] { "9eb8afc1-96f0-4ff8-b9d8-7648fb9f50c2", "2D" });

            migrationBuilder.InsertData(
                table: "priceInformation",
                columns: new[] { "priceInformationId", "priceAmount" },
                values: new object[] { "1d6927c3-6e36-4a5e-b7e6-227c0ff46341", 80000L });

            migrationBuilder.InsertData(
                table: "roleInformation",
                columns: new[] { "roleId", "roleName" },
                values: new object[,]
                {
                    { "3025d94e-c32f-429e-8d4d-f77fa80616fc", "MovieManager" },
                    { "3443a8c8-2100-40e1-96f1-c40561914eb1", "Customer" },
                    { "4cf88c7a-636c-4cdd-8344-458966645676", "FacilitiesManager" },
                    { "9578b8b8-e960-4949-82a6-c4464d35a9cb", "Cashier" },
                    { "a5e81a76-4c30-41e8-b3a2-9644f85c67f6", "TheaterManager" },
                    { "fbc7b03b-3d5f-4dde-b10c-7c707ba19c64", "Director" },
                    { "fc59cdf4-fd9d-4a11-bbc0-b1c658f9a12f", "TheaterCleaner" }
                });

            migrationBuilder.InsertData(
                table: "userInformation",
                columns: new[] { "userId", "IdentityCode", "dateOfBirth", "loginUserEmail", "loginUserPassword", "phoneNumber", "userName", "userPoint" },
                values: new object[,]
                {
                    { "61fb08fb-3145-4a4c-b4cd-afd6b39fae33", "987654321098", new DateTime(1995, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", "hashed_password_user", "0987654321", "Regular User", 0 },
                    { "d4e55416-dee3-455f-8b3a-fba65cd2576b", "123456789012", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", "hashed_password_admin", "0123456789", "Admin User", 0 }
                });

            migrationBuilder.InsertData(
                table: "userType",
                columns: new[] { "userTypeId", "userTypeDescription" },
                values: new object[] { "2938a87e-8c5d-4d0d-9a24-0ac683afa216", "Adult" });

            migrationBuilder.InsertData(
                table: "cinemaRoom",
                columns: new[] { "cinemaRoomId", "cinemaId", "cinemaRoomNumber", "isDeleted", "movieVisualFormatID" },
                values: new object[] { "b8db568f-279f-4721-9b39-011c8fb96655", "78d18c38-e169-4b4b-b35b-b738b2c28f36", 1, false, "9eb8afc1-96f0-4ff8-b9d8-7648fb9f50c2" });

            migrationBuilder.InsertData(
                table: "movieInformation",
                columns: new[] { "movieId", "isDelete", "languageId", "movieActor", "movieDescription", "movieDirector", "movieDuration", "movieImage", "movieName", "movieTrailerUrl" },
                values: new object[,]
                {
                    { "4baf65a6-4db7-4c30-93d5-afe24315c7ee", false, "de32be34-f888-47df-be2d-44549e61c21d", "Actor Z, Actress W", "A funny movie for the whole family.", "Director B", 90, new byte[] { 4, 5, 6 }, "Comedy Film 1", "http://trailer.com/comedyfilm1" },
                    { "67868ce3-b1f7-4bc9-bd39-d6299ea6e0c8", false, "3bf9deb7-3738-487a-a922-5e7f8d0b80fa", "Diễn Viên X, Diễn Viên Y", "Đây là một bộ phim hành động đầy kịch tính.", "Đạo Diễn A", 120, new byte[] { 1, 2, 3 }, "Phim Hành Động 1", "http://trailer.com/phimhanhdong1" }
                });

            migrationBuilder.InsertData(
                table: "priceInformationForEachUserFilmType",
                columns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                values: new object[] { "9eb8afc1-96f0-4ff8-b9d8-7648fb9f50c2", "1d6927c3-6e36-4a5e-b7e6-227c0ff46341", "2938a87e-8c5d-4d0d-9a24-0ac683afa216" });

            migrationBuilder.InsertData(
                table: "userRoleInformation",
                columns: new[] { "roleId", "userId" },
                values: new object[,]
                {
                    { "3025d94e-c32f-429e-8d4d-f77fa80616fc", "d4e55416-dee3-455f-8b3a-fba65cd2576b" },
                    { "3443a8c8-2100-40e1-96f1-c40561914eb1", "61fb08fb-3145-4a4c-b4cd-afd6b39fae33" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatsId", "cinemaRoomId", "isDelete", "isServed", "isTaken", "seatsNumber" },
                values: new object[,]
                {
                    { "c86fa13a-12e6-4ee7-b9a6-48c840d60a4d", "b8db568f-279f-4721-9b39-011c8fb96655", false, true, false, "A1" },
                    { "e7e02423-f9fc-4ece-aad4-e69fb9802e5f", "b8db568f-279f-4721-9b39-011c8fb96655", false, true, false, "A2" }
                });

            migrationBuilder.InsertData(
                table: "movieGenreInformation",
                columns: new[] { "movieGenreId", "movieId" },
                values: new object[,]
                {
                    { "1b9a3055-4af5-4750-b3d6-815b9876402b", "4baf65a6-4db7-4c30-93d5-afe24315c7ee" },
                    { "124ae20c-f652-4edb-8420-ba9c2a20ffb6", "67868ce3-b1f7-4bc9-bd39-d6299ea6e0c8" }
                });

            migrationBuilder.InsertData(
                table: "movieSchedule",
                columns: new[] { "movieScheduleId", "DayInWeekendSchedule", "HourScheduleID", "IsDelete", "ScheduleDate", "cinemaID", "cinemaRoomId", "movieId", "movieVisualFormatID" },
                values: new object[] { "4a8cde71-04d9-4074-a070-5621a0c2dacc", "Monday", "bf03f24b-3817-4ca9-af00-218b27e3add8", false, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "78d18c38-e169-4b4b-b35b-b738b2c28f36", "b8db568f-279f-4721-9b39-011c8fb96655", "67868ce3-b1f7-4bc9-bd39-d6299ea6e0c8", "9eb8afc1-96f0-4ff8-b9d8-7648fb9f50c2" });

            migrationBuilder.CreateIndex(
                name: "IX_movieSchedule_movieVisualFormatID",
                table: "movieSchedule",
                column: "movieVisualFormatID");

            migrationBuilder.CreateIndex(
                name: "IX_cinemaRoom_movieVisualFormatID",
                table: "cinemaRoom",
                column: "movieVisualFormatID");

            migrationBuilder.AddForeignKey(
                name: "FK_cinemaRoom_movieVisualFormat_movieVisualFormatID",
                table: "cinemaRoom",
                column: "movieVisualFormatID",
                principalTable: "movieVisualFormat",
                principalColumn: "movieVisualFormatId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_movieSchedule_movieVisualFormat_movieVisualFormatID",
                table: "movieSchedule",
                column: "movieVisualFormatID",
                principalTable: "movieVisualFormat",
                principalColumn: "movieVisualFormatId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cinemaRoom_movieVisualFormat_movieVisualFormatID",
                table: "cinemaRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_movieSchedule_movieVisualFormat_movieVisualFormatID",
                table: "movieSchedule");

            migrationBuilder.DropIndex(
                name: "IX_movieSchedule_movieVisualFormatID",
                table: "movieSchedule");

            migrationBuilder.DropIndex(
                name: "IX_cinemaRoom_movieVisualFormatID",
                table: "cinemaRoom");

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "e2c9789f-f135-496d-a2d4-e0a5ec31eb39");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "c86fa13a-12e6-4ee7-b9a6-48c840d60a4d");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "e7e02423-f9fc-4ece-aad4-e69fb9802e5f");

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "db0c701c-3585-45df-9656-d12a731c4ad4");

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "1b9a3055-4af5-4750-b3d6-815b9876402b", "4baf65a6-4db7-4c30-93d5-afe24315c7ee" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "124ae20c-f652-4edb-8420-ba9c2a20ffb6", "67868ce3-b1f7-4bc9-bd39-d6299ea6e0c8" });

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "4a8cde71-04d9-4074-a070-5621a0c2dacc");

            migrationBuilder.DeleteData(
                table: "priceInformationForEachUserFilmType",
                keyColumns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                keyValues: new object[] { "9eb8afc1-96f0-4ff8-b9d8-7648fb9f50c2", "1d6927c3-6e36-4a5e-b7e6-227c0ff46341", "2938a87e-8c5d-4d0d-9a24-0ac683afa216" });

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "4cf88c7a-636c-4cdd-8344-458966645676");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "9578b8b8-e960-4949-82a6-c4464d35a9cb");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "a5e81a76-4c30-41e8-b3a2-9644f85c67f6");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "fbc7b03b-3d5f-4dde-b10c-7c707ba19c64");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "fc59cdf4-fd9d-4a11-bbc0-b1c658f9a12f");

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "3025d94e-c32f-429e-8d4d-f77fa80616fc", "d4e55416-dee3-455f-8b3a-fba65cd2576b" });

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "3443a8c8-2100-40e1-96f1-c40561914eb1", "61fb08fb-3145-4a4c-b4cd-afd6b39fae33" });

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "bf03f24b-3817-4ca9-af00-218b27e3add8");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "b8db568f-279f-4721-9b39-011c8fb96655");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "124ae20c-f652-4edb-8420-ba9c2a20ffb6");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "1b9a3055-4af5-4750-b3d6-815b9876402b");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "4baf65a6-4db7-4c30-93d5-afe24315c7ee");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "67868ce3-b1f7-4bc9-bd39-d6299ea6e0c8");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "1d6927c3-6e36-4a5e-b7e6-227c0ff46341");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "3025d94e-c32f-429e-8d4d-f77fa80616fc");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "3443a8c8-2100-40e1-96f1-c40561914eb1");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "61fb08fb-3145-4a4c-b4cd-afd6b39fae33");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "d4e55416-dee3-455f-8b3a-fba65cd2576b");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "2938a87e-8c5d-4d0d-9a24-0ac683afa216");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "78d18c38-e169-4b4b-b35b-b738b2c28f36");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "3bf9deb7-3738-487a-a922-5e7f8d0b80fa");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "de32be34-f888-47df-be2d-44549e61c21d");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "9eb8afc1-96f0-4ff8-b9d8-7648fb9f50c2");

            migrationBuilder.DropColumn(
                name: "movieVisualFormatID",
                table: "movieSchedule");

            migrationBuilder.DropColumn(
                name: "amount",
                table: "materialReport");

            migrationBuilder.DropColumn(
                name: "movieVisualFormatID",
                table: "cinemaRoom");

            migrationBuilder.RenameColumn(
                name: "isDelete",
                table: "Seats",
                newName: "isMiddle");

            migrationBuilder.RenameColumn(
                name: "ScheduleDate",
                table: "movieSchedule",
                newName: "ReleaseDate");

            migrationBuilder.RenameIndex(
                name: "IX_movieSchedule_cinemaRoomId_cinemaID_ScheduleDate",
                table: "movieSchedule",
                newName: "IX_movieSchedule_cinemaRoomId_cinemaID_ReleaseDate");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "cinemaRoom",
                newName: "isIMAXRoom");

            migrationBuilder.AddColumn<bool>(
                name: "isSupportedIMAX",
                table: "Cinema",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "cinemaId", "cinemaContactHotlineNumber", "cinemaDescription", "cinemaLocation", "cinemaName", "isSupportedIMAX" },
                values: new object[] { "46da5f2c-01d0-461c-ab41-c584e933ee3d", "0901234567", "Rạp chiếu phim hiện đại với nhiều phòng chiếu.", "123 Đường XYZ, TP.HCM", "Rạp Chiếu Phim ABC", true });

            migrationBuilder.InsertData(
                table: "HourSchedule",
                columns: new[] { "HourScheduleID", "HourScheduleShowTime" },
                values: new object[,]
                {
                    { "d7853d5a-15e6-4041-8f4b-432fc25c9df6", "08:00" },
                    { "ec3ee02f-19a7-4e94-8477-1af213b2c165", "10:00" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "languageId", "languageDetail" },
                values: new object[,]
                {
                    { "63f18f02-e063-4a73-9fe9-4a152fc35b06", "Vietnamese" },
                    { "d032e50c-dc76-48b9-9245-190375a7c101", "English" }
                });

            migrationBuilder.InsertData(
                table: "foodInformation",
                columns: new[] { "foodInformationId", "foodInformationName", "foodPrice" },
                values: new object[] { "af73e73e-3b16-438a-9e5e-ba700abca839", "Popcorn", 50000L });

            migrationBuilder.InsertData(
                table: "movieGenre",
                columns: new[] { "movieGenreId", "movieGenreName" },
                values: new object[,]
                {
                    { "3c0237cc-d545-4e0e-8cda-711f34d67d96", "Comedy" },
                    { "87061725-db04-4d71-a91a-7e890f799bd5", "Action" }
                });

            migrationBuilder.InsertData(
                table: "movieVisualFormat",
                columns: new[] { "movieVisualFormatId", "movieVisualFormatName" },
                values: new object[] { "76c7526b-09bd-4cd8-b155-dc2915350e20", "2D" });

            migrationBuilder.InsertData(
                table: "priceInformation",
                columns: new[] { "priceInformationId", "priceAmount" },
                values: new object[] { "13ed9c94-06af-49dc-8baa-afb1a0fb02ed", 80000L });

            migrationBuilder.InsertData(
                table: "roleInformation",
                columns: new[] { "roleId", "roleName" },
                values: new object[,]
                {
                    { "03e485f6-4f4d-4ede-a533-88a48867c9e9", "Customer" },
                    { "49bb193f-d428-4e38-9055-8fc4f83cd5f1", "Cashier" },
                    { "672da49d-1742-4c44-ae10-c8902d0367aa", "TheaterManager" },
                    { "b7657304-97a5-4613-b298-17054cfbc190", "FacilitiesManager" },
                    { "dec1f605-2e5a-4461-a624-5cbd5be781a7", "TheaterCleaner" },
                    { "e3c8e86a-7a5f-4c43-9d55-80a0e8eafda5", "MovieManager" },
                    { "f55a39fc-b948-4e97-9330-2858165d02ef", "Director" }
                });

            migrationBuilder.InsertData(
                table: "userInformation",
                columns: new[] { "userId", "IdentityCode", "dateOfBirth", "loginUserEmail", "loginUserPassword", "phoneNumber", "userName", "userPoint" },
                values: new object[,]
                {
                    { "4b00f6d2-8692-445f-8758-9687a8237dbd", "987654321098", new DateTime(1995, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", "hashed_password_user", "0987654321", "Regular User", 0 },
                    { "4bb225ed-afca-4c16-a764-eef3b6a5879f", "123456789012", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", "hashed_password_admin", "0123456789", "Admin User", 0 }
                });

            migrationBuilder.InsertData(
                table: "userType",
                columns: new[] { "userTypeId", "userTypeDescription" },
                values: new object[] { "a8c3dd1b-7d79-4e79-a13f-21310ae67b71", "Adult" });

            migrationBuilder.InsertData(
                table: "cinemaRoom",
                columns: new[] { "cinemaRoomId", "cinemaId", "cinemaRoomNumber", "isIMAXRoom" },
                values: new object[] { "e6046455-864e-4c66-8d31-89bf3d8e2b9b", "46da5f2c-01d0-461c-ab41-c584e933ee3d", 1, true });

            migrationBuilder.InsertData(
                table: "movieInformation",
                columns: new[] { "movieId", "isDelete", "languageId", "movieActor", "movieDescription", "movieDirector", "movieDuration", "movieImage", "movieName", "movieTrailerUrl" },
                values: new object[,]
                {
                    { "39e9688c-0297-4169-b97b-e41d542b719f", false, "63f18f02-e063-4a73-9fe9-4a152fc35b06", "Diễn Viên X, Diễn Viên Y", "Đây là một bộ phim hành động đầy kịch tính.", "Đạo Diễn A", 120, new byte[] { 1, 2, 3 }, "Phim Hành Động 1", "http://trailer.com/phimhanhdong1" },
                    { "c8f2f519-9616-40b5-ba03-c9c21fe4ad11", false, "d032e50c-dc76-48b9-9245-190375a7c101", "Actor Z, Actress W", "A funny movie for the whole family.", "Director B", 90, new byte[] { 4, 5, 6 }, "Comedy Film 1", "http://trailer.com/comedyfilm1" }
                });

            migrationBuilder.InsertData(
                table: "priceInformationForEachUserFilmType",
                columns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                values: new object[] { "76c7526b-09bd-4cd8-b155-dc2915350e20", "13ed9c94-06af-49dc-8baa-afb1a0fb02ed", "a8c3dd1b-7d79-4e79-a13f-21310ae67b71" });

            migrationBuilder.InsertData(
                table: "userRoleInformation",
                columns: new[] { "roleId", "userId" },
                values: new object[,]
                {
                    { "03e485f6-4f4d-4ede-a533-88a48867c9e9", "4b00f6d2-8692-445f-8758-9687a8237dbd" },
                    { "e3c8e86a-7a5f-4c43-9d55-80a0e8eafda5", "4bb225ed-afca-4c16-a764-eef3b6a5879f" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatsId", "cinemaRoomId", "isMiddle", "isServed", "isTaken", "seatsNumber" },
                values: new object[,]
                {
                    { "29a46960-810a-49be-a5dd-524016dcd58b", "e6046455-864e-4c66-8d31-89bf3d8e2b9b", false, true, false, "A2" },
                    { "6d466e5c-80fb-4aad-8068-d5b8f26c1706", "e6046455-864e-4c66-8d31-89bf3d8e2b9b", false, true, false, "A1" }
                });

            migrationBuilder.InsertData(
                table: "movieGenreInformation",
                columns: new[] { "movieGenreId", "movieId" },
                values: new object[,]
                {
                    { "87061725-db04-4d71-a91a-7e890f799bd5", "39e9688c-0297-4169-b97b-e41d542b719f" },
                    { "3c0237cc-d545-4e0e-8cda-711f34d67d96", "c8f2f519-9616-40b5-ba03-c9c21fe4ad11" }
                });

            migrationBuilder.InsertData(
                table: "movieSchedule",
                columns: new[] { "movieScheduleId", "DayInWeekendSchedule", "HourScheduleID", "IsDelete", "ReleaseDate", "cinemaID", "cinemaRoomId", "movieId" },
                values: new object[] { "1da269b3-fd18-4694-83e7-a0bbbc71f30f", "Monday", "d7853d5a-15e6-4041-8f4b-432fc25c9df6", false, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "46da5f2c-01d0-461c-ab41-c584e933ee3d", "e6046455-864e-4c66-8d31-89bf3d8e2b9b", "39e9688c-0297-4169-b97b-e41d542b719f" });
        }
    }
}
