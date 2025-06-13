using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class updatethemdatavaobang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "cinemaId", "cinemaContactHotlineNumber", "cinemaDescription", "cinemaLocation", "cinemaName", "isSupportedIMAX" },
                values: new object[] { "b7891a66-61d8-436f-b9dd-20d2c53f4687", "0901234567", "Rạp chiếu phim hiện đại với nhiều phòng chiếu.", "123 Đường XYZ, TP.HCM", "Rạp Chiếu Phim ABC", true });

            migrationBuilder.InsertData(
                table: "DayInWeekendSchedule",
                columns: new[] { "DayInWeekendScheduleID", "DayInWeekendScheduleName" },
                values: new object[,]
                {
                    { "756058d3-e62c-4db5-b819-b553bff60a45", "Tuesday" },
                    { "cf536d43-0c45-4f29-abbf-f4e381e17d23", "Monday" }
                });

            migrationBuilder.InsertData(
                table: "HourSchedule",
                columns: new[] { "HourScheduleID", "HourScheduleDate" },
                values: new object[,]
                {
                    { "9e350bfa-4fbe-4ac8-b455-a401e38639e2", "10:00" },
                    { "fec859cf-457f-49c2-bec1-b4c2aff8980a", "08:00" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "languageId", "languageDetail" },
                values: new object[,]
                {
                    { "ce8562fe-d24e-40ca-8a4b-d93ff9d03358", "English" },
                    { "dd21302a-2586-4366-a0e3-4676d1005f37", "Vietnamese" }
                });

            migrationBuilder.InsertData(
                table: "foodInformation",
                columns: new[] { "foodInformationId", "foodInformationName", "foodPrice" },
                values: new object[] { "7749eb1c-9668-4282-94c0-3579fc41d6bd", "Popcorn", 50000L });

            migrationBuilder.InsertData(
                table: "movieGenre",
                columns: new[] { "movieGenreId", "movieGenreName" },
                values: new object[,]
                {
                    { "1e23c3aa-3a7f-4611-8d9e-c2a7f6e3c4f4", "Action" },
                    { "902c5992-6ac5-4d8d-833d-5a80a2579479", "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "movieVisualFormat",
                columns: new[] { "movieVisualFormatId", "movieVisualFormatName" },
                values: new object[] { "fa596364-c33f-43f1-8d53-fe47ed60363a", "2D" });

            migrationBuilder.InsertData(
                table: "priceInformation",
                columns: new[] { "priceInformationId", "priceAmount" },
                values: new object[] { "4a6f34dc-c473-44b1-8276-44e5a6d69f62", 80000L });

            migrationBuilder.InsertData(
                table: "roleInformation",
                columns: new[] { "roleId", "roleName" },
                values: new object[,]
                {
                    { "491b7b20-0c03-4a24-98ce-3bb45aad3bf1", "User" },
                    { "d12836b1-f40c-4818-8cb6-328354170f35", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "userInformation",
                columns: new[] { "userId", "IdentityCode", "dateOfBirth", "loginUserEmail", "loginUserPassword", "phoneNumber", "userName", "userPoint" },
                values: new object[,]
                {
                    { "1331da60-f460-449b-906d-e44559c228ed", "123456789012", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", "hashed_password_admin", "0123456789", "Admin User", 1000 },
                    { "a9f402d6-e31f-4723-9827-5e17b04ea9e1", "987654321098", new DateTime(1995, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", "hashed_password_user", "0987654321", "Regular User", 50 }
                });

            migrationBuilder.InsertData(
                table: "userType",
                columns: new[] { "userTypeId", "userTypeDescription" },
                values: new object[] { "ad103ec6-ca6d-48e5-a258-da8e95049bc2", "Adult" });

            migrationBuilder.InsertData(
                table: "cinemaRoom",
                columns: new[] { "cinemaRoomId", "cinemaId", "cinemaRoomNumber", "isIMAXRoom" },
                values: new object[] { "6fa1bab3-146f-49a5-bb80-d4af1b77cda0", "b7891a66-61d8-436f-b9dd-20d2c53f4687", 1, true });

            migrationBuilder.InsertData(
                table: "movieInformation",
                columns: new[] { "movieId", "languageId", "movieActor", "movieDescription", "movieDirector", "movieDuration", "movieImage", "movieName", "movieTrailerUrl" },
                values: new object[,]
                {
                    { "b88d27cc-92ce-4962-8758-c658f003249b", "ce8562fe-d24e-40ca-8a4b-d93ff9d03358", "Actor Z, Actress W", "A funny movie for the whole family.", "Director B", 90, new byte[] { 4, 5, 6 }, "Comedy Film 1", "http://trailer.com/comedyfilm1" },
                    { "f266f9ce-c0f5-45d6-863a-81cb1a732b23", "dd21302a-2586-4366-a0e3-4676d1005f37", "Diễn Viên X, Diễn Viên Y", "Đây là một bộ phim hành động đầy kịch tính.", "Đạo Diễn A", 120, new byte[] { 1, 2, 3 }, "Phim Hành Động 1", "http://trailer.com/phimhanhdong1" }
                });

            migrationBuilder.InsertData(
                table: "priceInformationForEachUserFilmType",
                columns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                values: new object[] { "fa596364-c33f-43f1-8d53-fe47ed60363a", "4a6f34dc-c473-44b1-8276-44e5a6d69f62", "ad103ec6-ca6d-48e5-a258-da8e95049bc2" });

            migrationBuilder.InsertData(
                table: "userRoleInformation",
                columns: new[] { "roleId", "userId" },
                values: new object[,]
                {
                    { "491b7b20-0c03-4a24-98ce-3bb45aad3bf1", "a9f402d6-e31f-4723-9827-5e17b04ea9e1" },
                    { "d12836b1-f40c-4818-8cb6-328354170f35", "1331da60-f460-449b-906d-e44559c228ed" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatsId", "cinemaRoomId", "isMiddle", "isTaken", "seatsNumber" },
                values: new object[,]
                {
                    { "7aed212c-0c09-4dbe-ba0b-a3ea7750e3dd", "6fa1bab3-146f-49a5-bb80-d4af1b77cda0", true, false, "A2" },
                    { "a8c28186-40ff-4271-8c53-2707e1053f70", "6fa1bab3-146f-49a5-bb80-d4af1b77cda0", true, false, "A1" }
                });

            migrationBuilder.InsertData(
                table: "movieGenreInformation",
                columns: new[] { "movieGenreId", "movieId" },
                values: new object[,]
                {
                    { "902c5992-6ac5-4d8d-833d-5a80a2579479", "b88d27cc-92ce-4962-8758-c658f003249b" },
                    { "1e23c3aa-3a7f-4611-8d9e-c2a7f6e3c4f4", "f266f9ce-c0f5-45d6-863a-81cb1a732b23" }
                });

            migrationBuilder.InsertData(
                table: "movieSchedule",
                columns: new[] { "movieScheduleId", "DayInWeekendScheduleID", "HourScheduleID", "cinemaRoomId", "movieId" },
                values: new object[] { "a9045eb0-dc02-4fdd-9e6a-6f9a6f7e5510", "cf536d43-0c45-4f29-abbf-f4e381e17d23", "fec859cf-457f-49c2-bec1-b4c2aff8980a", "6fa1bab3-146f-49a5-bb80-d4af1b77cda0", "f266f9ce-c0f5-45d6-863a-81cb1a732b23" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DayInWeekendSchedule",
                keyColumn: "DayInWeekendScheduleID",
                keyValue: "756058d3-e62c-4db5-b819-b553bff60a45");

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "9e350bfa-4fbe-4ac8-b455-a401e38639e2");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "7aed212c-0c09-4dbe-ba0b-a3ea7750e3dd");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "a8c28186-40ff-4271-8c53-2707e1053f70");

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "7749eb1c-9668-4282-94c0-3579fc41d6bd");

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "902c5992-6ac5-4d8d-833d-5a80a2579479", "b88d27cc-92ce-4962-8758-c658f003249b" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "1e23c3aa-3a7f-4611-8d9e-c2a7f6e3c4f4", "f266f9ce-c0f5-45d6-863a-81cb1a732b23" });

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "a9045eb0-dc02-4fdd-9e6a-6f9a6f7e5510");

            migrationBuilder.DeleteData(
                table: "priceInformationForEachUserFilmType",
                keyColumns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                keyValues: new object[] { "fa596364-c33f-43f1-8d53-fe47ed60363a", "4a6f34dc-c473-44b1-8276-44e5a6d69f62", "ad103ec6-ca6d-48e5-a258-da8e95049bc2" });

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "491b7b20-0c03-4a24-98ce-3bb45aad3bf1", "a9f402d6-e31f-4723-9827-5e17b04ea9e1" });

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "d12836b1-f40c-4818-8cb6-328354170f35", "1331da60-f460-449b-906d-e44559c228ed" });

            migrationBuilder.DeleteData(
                table: "DayInWeekendSchedule",
                keyColumn: "DayInWeekendScheduleID",
                keyValue: "cf536d43-0c45-4f29-abbf-f4e381e17d23");

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "fec859cf-457f-49c2-bec1-b4c2aff8980a");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "6fa1bab3-146f-49a5-bb80-d4af1b77cda0");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "1e23c3aa-3a7f-4611-8d9e-c2a7f6e3c4f4");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "902c5992-6ac5-4d8d-833d-5a80a2579479");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "b88d27cc-92ce-4962-8758-c658f003249b");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "f266f9ce-c0f5-45d6-863a-81cb1a732b23");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "fa596364-c33f-43f1-8d53-fe47ed60363a");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "4a6f34dc-c473-44b1-8276-44e5a6d69f62");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "491b7b20-0c03-4a24-98ce-3bb45aad3bf1");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "d12836b1-f40c-4818-8cb6-328354170f35");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "1331da60-f460-449b-906d-e44559c228ed");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "a9f402d6-e31f-4723-9827-5e17b04ea9e1");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "ad103ec6-ca6d-48e5-a258-da8e95049bc2");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "b7891a66-61d8-436f-b9dd-20d2c53f4687");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "ce8562fe-d24e-40ca-8a4b-d93ff9d03358");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "dd21302a-2586-4366-a0e3-4676d1005f37");
        }
    }
}
