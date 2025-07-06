using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class CapNhatLaiDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Staff",
                table: "Staff");

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "9e91af8e-4e3c-400d-a8e4-bddf4470b143");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "649cb608-74ff-4860-bc93-5339d2a41846");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "eaaacca9-8e55-4038-be1a-0630d6aef4b4");

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "42c89d7a-9da0-480e-9262-968ee0a90ca8");

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "535b5175-34f7-4dca-bb9a-34876cbd3495", "43d740d2-6db3-4277-8327-fba0780de96d" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "24611f39-53ef-4b7c-98aa-f6bc59404b28", "63424264-5427-44fb-80dc-def567c5a013" });

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "3b62e078-bf61-46d2-a354-3c8f4c81c374");

            migrationBuilder.DeleteData(
                table: "priceInformationForEachUserFilmType",
                keyColumns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                keyValues: new object[] { "68300fb7-3fe0-41d3-82d9-a64b3a9e70b2", "d0dc0cf6-82fc-4298-8a91-b201616bf2c5", "4fcbe932-3c72-4d87-922b-a6bef776bc71" });

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "4b32405a-3249-4a61-8494-c49bd2958e0e");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "4f7b02ce-2b56-4926-a92f-99f0ac7b9b01");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "987ce41d-78fd-41c0-9238-5ce33d3340c0");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "cdc1bb5d-8e04-4b70-8c8d-2eab72bdcf74");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "d89cb727-c0d7-4f34-89ab-79d2dcab6344");

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "3e0d9d72-a12b-45a7-a1e7-351f63eb87f5", "99313ba0-36e8-40aa-8147-7c369f16162b" });

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "77dd5194-74a4-445f-9f91-a491e7b2b72b", "d21cbd3d-df1e-4d2f-9e0e-e3d472933e1a" });

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "d3475024-e0fc-4ff9-8470-051faba33f3b");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "912b869a-3d00-4da0-9d46-b130a4feb073");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "24611f39-53ef-4b7c-98aa-f6bc59404b28");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "535b5175-34f7-4dca-bb9a-34876cbd3495");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "43d740d2-6db3-4277-8327-fba0780de96d");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "63424264-5427-44fb-80dc-def567c5a013");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "d0dc0cf6-82fc-4298-8a91-b201616bf2c5");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "3e0d9d72-a12b-45a7-a1e7-351f63eb87f5");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "77dd5194-74a4-445f-9f91-a491e7b2b72b");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "99313ba0-36e8-40aa-8147-7c369f16162b");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "d21cbd3d-df1e-4d2f-9e0e-e3d472933e1a");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "4fcbe932-3c72-4d87-922b-a6bef776bc71");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "459275f6-bff5-4ccd-bef8-5f19c9562414");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "238b3a89-30e7-4af0-91c8-62c6a58599f2");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "d01a000a-965f-4e6b-bf21-1a7a647d4c20");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "68300fb7-3fe0-41d3-82d9-a64b3a9e70b2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staff",
                table: "Staff",
                column: "Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Staff",
                table: "Staff");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staff",
                table: "Staff",
                columns: new[] { "userID", "cinemaID" });

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "cinemaId", "cinemaContactHotlineNumber", "cinemaDescription", "cinemaLocation", "cinemaName" },
                values: new object[] { "459275f6-bff5-4ccd-bef8-5f19c9562414", "0901234567", "Rạp chiếu phim hiện đại với nhiều phòng chiếu.", "123 Đường XYZ, TP.HCM", "Rạp Chiếu Phim ABC" });

            migrationBuilder.InsertData(
                table: "HourSchedule",
                columns: new[] { "HourScheduleID", "HourScheduleShowTime" },
                values: new object[,]
                {
                    { "9e91af8e-4e3c-400d-a8e4-bddf4470b143", "10:00" },
                    { "d3475024-e0fc-4ff9-8470-051faba33f3b", "08:00" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "languageId", "languageDetail" },
                values: new object[,]
                {
                    { "238b3a89-30e7-4af0-91c8-62c6a58599f2", "English" },
                    { "d01a000a-965f-4e6b-bf21-1a7a647d4c20", "Vietnamese" }
                });

            migrationBuilder.InsertData(
                table: "foodInformation",
                columns: new[] { "foodInformationId", "foodInformationName", "foodPrice" },
                values: new object[] { "42c89d7a-9da0-480e-9262-968ee0a90ca8", "Popcorn", 50000L });

            migrationBuilder.InsertData(
                table: "movieGenre",
                columns: new[] { "movieGenreId", "movieGenreName" },
                values: new object[,]
                {
                    { "24611f39-53ef-4b7c-98aa-f6bc59404b28", "Comedy" },
                    { "535b5175-34f7-4dca-bb9a-34876cbd3495", "Action" }
                });

            migrationBuilder.InsertData(
                table: "movieVisualFormat",
                columns: new[] { "movieVisualFormatId", "movieVisualFormatName" },
                values: new object[] { "68300fb7-3fe0-41d3-82d9-a64b3a9e70b2", "2D" });

            migrationBuilder.InsertData(
                table: "priceInformation",
                columns: new[] { "priceInformationId", "priceAmount" },
                values: new object[] { "d0dc0cf6-82fc-4298-8a91-b201616bf2c5", 80000L });

            migrationBuilder.InsertData(
                table: "roleInformation",
                columns: new[] { "roleId", "roleName" },
                values: new object[,]
                {
                    { "3e0d9d72-a12b-45a7-a1e7-351f63eb87f5", "MovieManager" },
                    { "4b32405a-3249-4a61-8494-c49bd2958e0e", "Cashier" },
                    { "4f7b02ce-2b56-4926-a92f-99f0ac7b9b01", "TheaterManager" },
                    { "77dd5194-74a4-445f-9f91-a491e7b2b72b", "Customer" },
                    { "987ce41d-78fd-41c0-9238-5ce33d3340c0", "TheaterCleaner" },
                    { "cdc1bb5d-8e04-4b70-8c8d-2eab72bdcf74", "Director" },
                    { "d89cb727-c0d7-4f34-89ab-79d2dcab6344", "FacilitiesManager" }
                });

            migrationBuilder.InsertData(
                table: "userInformation",
                columns: new[] { "userId", "loginUserEmail", "loginUserPassword" },
                values: new object[,]
                {
                    { "99313ba0-36e8-40aa-8147-7c369f16162b", "admin@example.com", "hashed_password_admin" },
                    { "d21cbd3d-df1e-4d2f-9e0e-e3d472933e1a", "user@example.com", "hashed_password_user" }
                });

            migrationBuilder.InsertData(
                table: "userType",
                columns: new[] { "userTypeId", "userTypeDescription" },
                values: new object[] { "4fcbe932-3c72-4d87-922b-a6bef776bc71", "Adult" });

            migrationBuilder.InsertData(
                table: "cinemaRoom",
                columns: new[] { "cinemaRoomId", "cinemaId", "cinemaRoomNumber", "isDeleted", "movieVisualFormatID" },
                values: new object[] { "912b869a-3d00-4da0-9d46-b130a4feb073", "459275f6-bff5-4ccd-bef8-5f19c9562414", 1, false, "68300fb7-3fe0-41d3-82d9-a64b3a9e70b2" });

            migrationBuilder.InsertData(
                table: "movieInformation",
                columns: new[] { "movieId", "ReleaseDate", "isDelete", "languageId", "movieActor", "movieDescription", "movieDirector", "movieDuration", "movieImage", "movieName", "movieTrailerUrl" },
                values: new object[,]
                {
                    { "43d740d2-6db3-4277-8327-fba0780de96d", new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "d01a000a-965f-4e6b-bf21-1a7a647d4c20", "Diễn Viên X, Diễn Viên Y", "Đây là một bộ phim hành động đầy kịch tính.", "Đạo Diễn A", 120, new byte[] { 1, 2, 3 }, "Phim Hành Động 1", "http://trailer.com/phimhanhdong1" },
                    { "63424264-5427-44fb-80dc-def567c5a013", new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "238b3a89-30e7-4af0-91c8-62c6a58599f2", "Actor Z, Actress W", "A funny movie for the whole family.", "Director B", 90, new byte[] { 4, 5, 6 }, "Comedy Film 1", "http://trailer.com/comedyfilm1" }
                });

            migrationBuilder.InsertData(
                table: "priceInformationForEachUserFilmType",
                columns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                values: new object[] { "68300fb7-3fe0-41d3-82d9-a64b3a9e70b2", "d0dc0cf6-82fc-4298-8a91-b201616bf2c5", "4fcbe932-3c72-4d87-922b-a6bef776bc71" });

            migrationBuilder.InsertData(
                table: "userRoleInformation",
                columns: new[] { "roleId", "userId" },
                values: new object[,]
                {
                    { "3e0d9d72-a12b-45a7-a1e7-351f63eb87f5", "99313ba0-36e8-40aa-8147-7c369f16162b" },
                    { "77dd5194-74a4-445f-9f91-a491e7b2b72b", "d21cbd3d-df1e-4d2f-9e0e-e3d472933e1a" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatsId", "cinemaRoomId", "isDelete", "isServed", "isTaken", "seatsNumber" },
                values: new object[,]
                {
                    { "649cb608-74ff-4860-bc93-5339d2a41846", "912b869a-3d00-4da0-9d46-b130a4feb073", false, true, false, "A1" },
                    { "eaaacca9-8e55-4038-be1a-0630d6aef4b4", "912b869a-3d00-4da0-9d46-b130a4feb073", false, true, false, "A2" }
                });

            migrationBuilder.InsertData(
                table: "movieGenreInformation",
                columns: new[] { "movieGenreId", "movieId" },
                values: new object[,]
                {
                    { "535b5175-34f7-4dca-bb9a-34876cbd3495", "43d740d2-6db3-4277-8327-fba0780de96d" },
                    { "24611f39-53ef-4b7c-98aa-f6bc59404b28", "63424264-5427-44fb-80dc-def567c5a013" }
                });

            migrationBuilder.InsertData(
                table: "movieSchedule",
                columns: new[] { "movieScheduleId", "DayInWeekendSchedule", "HourScheduleID", "IsDelete", "ScheduleDate", "cinemaRoomId", "movieId", "movieVisualFormatID" },
                values: new object[] { "3b62e078-bf61-46d2-a354-3c8f4c81c374", "Monday", "d3475024-e0fc-4ff9-8470-051faba33f3b", false, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "912b869a-3d00-4da0-9d46-b130a4feb073", "43d740d2-6db3-4277-8327-fba0780de96d", "68300fb7-3fe0-41d3-82d9-a64b3a9e70b2" });
        }
    }
}
