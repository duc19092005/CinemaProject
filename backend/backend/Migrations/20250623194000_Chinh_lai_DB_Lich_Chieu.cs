using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class Chinh_lai_DB_Lich_Chieu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_movieSchedule_cinemaRoomId",
                table: "movieSchedule");

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "43e141f9-dfd3-40a3-8bca-fc4064a4cf1f");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "7ce9a9e8-223d-4262-b6e1-2d229bd76094");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "bb9b83dd-5fe3-4621-afea-006a218f9d9b");

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "951cabc5-a2c5-45a7-8906-d73ba9e1fcf5");

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "82b48385-d679-4495-8835-d0c500500d66", "9f64aba0-5377-4e43-a2ac-9a31dfa8d0bb" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "ad1bf5a8-08b5-4410-86d4-d2c16feae08c", "bf7e5dd7-ade2-430a-9aa2-e6fa2a5253d7" });

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "d9de5fea-2c53-4de8-b142-5f5c47b73475");

            migrationBuilder.DeleteData(
                table: "priceInformationForEachUserFilmType",
                keyColumns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                keyValues: new object[] { "a16ec615-f61a-4537-bf8b-f5ec723d8046", "c434ce6a-af11-4125-a559-8dd39e5fc65e", "fe92495a-a8f6-4b9d-a9b7-a68b3aeab9f2" });

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "10d4f6b3-e063-4fbf-ad4c-c0110b9de4e6");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "36362348-aa92-4131-bca7-27938b099889");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "67b21539-41c0-4ccf-8dbf-bdca062373c4");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "7bac5e3e-0d42-47a2-8f02-fc4c8e4b7f0f");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "8a2026f4-4b74-40ea-831e-487ef0790362");

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "83f2b568-ea33-42da-abfc-fb0c211eaf14", "9fff4863-1c07-4e5e-a7f1-e50b060a7755" });

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "a35a8508-7b82-4f4c-9588-afee17fd1115", "a6b19dc7-9897-428b-ad80-b7d973af812a" });

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "cfdae06f-8db9-4046-9cd7-8683ce42b915");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "f292983b-2dc5-429a-a541-82a30e8626f6");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "82b48385-d679-4495-8835-d0c500500d66");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "ad1bf5a8-08b5-4410-86d4-d2c16feae08c");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "9f64aba0-5377-4e43-a2ac-9a31dfa8d0bb");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "bf7e5dd7-ade2-430a-9aa2-e6fa2a5253d7");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "a16ec615-f61a-4537-bf8b-f5ec723d8046");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "c434ce6a-af11-4125-a559-8dd39e5fc65e");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "83f2b568-ea33-42da-abfc-fb0c211eaf14");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "a35a8508-7b82-4f4c-9588-afee17fd1115");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "9fff4863-1c07-4e5e-a7f1-e50b060a7755");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "a6b19dc7-9897-428b-ad80-b7d973af812a");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "fe92495a-a8f6-4b9d-a9b7-a68b3aeab9f2");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "72a8ab3c-ad00-4167-9570-c60cead703a0");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "abd2eb7e-1528-4e75-ae29-ac31ca161dc1");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "b6ce3086-75b3-4898-9368-164bff14c933");

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "cinemaId", "cinemaContactHotlineNumber", "cinemaDescription", "cinemaLocation", "cinemaName", "isSupportedIMAX" },
                values: new object[] { "ee3f21ca-d2c2-4b29-9992-6609b06e7027", "0901234567", "Rạp chiếu phim hiện đại với nhiều phòng chiếu.", "123 Đường XYZ, TP.HCM", "Rạp Chiếu Phim ABC", true });

            migrationBuilder.InsertData(
                table: "HourSchedule",
                columns: new[] { "HourScheduleID", "HourScheduleDate" },
                values: new object[,]
                {
                    { "8c7703b1-7081-451f-bc68-97b264e95431", "10:00" },
                    { "c9671979-4f85-4f5e-abe5-99a403a0e231", "08:00" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "languageId", "languageDetail" },
                values: new object[,]
                {
                    { "3040d895-54dd-4680-82c3-42795fa780ba", "English" },
                    { "38a39e70-98e4-4d59-a058-bb505c17b46b", "Vietnamese" }
                });

            migrationBuilder.InsertData(
                table: "foodInformation",
                columns: new[] { "foodInformationId", "foodInformationName", "foodPrice" },
                values: new object[] { "77125357-e6b1-4a2d-87fc-a2bb0095ecb9", "Popcorn", 50000L });

            migrationBuilder.InsertData(
                table: "movieGenre",
                columns: new[] { "movieGenreId", "movieGenreName" },
                values: new object[,]
                {
                    { "3d4c8fb0-5ed4-4a18-811a-aaafcae2b128", "Action" },
                    { "8317d642-f713-40e8-a5b5-963d8df2f3ab", "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "movieVisualFormat",
                columns: new[] { "movieVisualFormatId", "movieVisualFormatName" },
                values: new object[] { "fd7f0e94-ebc1-4b15-a8be-ea776f042a66", "2D" });

            migrationBuilder.InsertData(
                table: "priceInformation",
                columns: new[] { "priceInformationId", "priceAmount" },
                values: new object[] { "c6dd9fd4-70e1-4db3-8550-df866a8bc0a0", 80000L });

            migrationBuilder.InsertData(
                table: "roleInformation",
                columns: new[] { "roleId", "roleName" },
                values: new object[,]
                {
                    { "18df653f-05f7-4552-93fc-d7154acf9b4f", "Director" },
                    { "23f9683b-fe66-40d1-9b9a-ef4dab0f1902", "TheaterCleaner" },
                    { "81a380cf-aa23-4986-a61f-d78dd31f2a28", "Customer" },
                    { "9e98f71e-a897-41f1-ac14-89cd09464d1f", "TheaterManager" },
                    { "b264ebf6-b36d-40ee-bcf1-f8af8f9837d5", "FacilitiesManager" },
                    { "c6b0fd7c-4c74-4fa1-83d3-57451a873666", "Cashier" },
                    { "e43e01c6-b256-4bcf-b388-1271c07fb4de", "MovieManager" }
                });

            migrationBuilder.InsertData(
                table: "userInformation",
                columns: new[] { "userId", "IdentityCode", "dateOfBirth", "loginUserEmail", "loginUserPassword", "phoneNumber", "userName", "userPoint" },
                values: new object[,]
                {
                    { "0e5b69ea-ad10-4230-b235-982e11b8faf0", "987654321098", new DateTime(1995, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", "hashed_password_user", "0987654321", "Regular User", 50 },
                    { "f2d70f56-1c44-450a-a91a-3e96fe116dc5", "123456789012", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", "hashed_password_admin", "0123456789", "Admin User", 1000 }
                });

            migrationBuilder.InsertData(
                table: "userType",
                columns: new[] { "userTypeId", "userTypeDescription" },
                values: new object[] { "1d131f8a-ffa5-40dd-96d6-529ee851ccd0", "Adult" });

            migrationBuilder.InsertData(
                table: "cinemaRoom",
                columns: new[] { "cinemaRoomId", "cinemaId", "cinemaRoomNumber", "isIMAXRoom" },
                values: new object[] { "7e44cf47-0cba-4d85-8ac1-d214fe9258c3", "ee3f21ca-d2c2-4b29-9992-6609b06e7027", 1, true });

            migrationBuilder.InsertData(
                table: "movieInformation",
                columns: new[] { "movieId", "languageId", "movieActor", "movieDescription", "movieDirector", "movieDuration", "movieImage", "movieName", "movieTrailerUrl" },
                values: new object[,]
                {
                    { "820c0758-e6b9-4d0c-bcdd-8939d0076841", "3040d895-54dd-4680-82c3-42795fa780ba", "Actor Z, Actress W", "A funny movie for the whole family.", "Director B", 90, new byte[] { 4, 5, 6 }, "Comedy Film 1", "http://trailer.com/comedyfilm1" },
                    { "b5335cd7-e917-43b0-8c6b-46f7f92aa428", "38a39e70-98e4-4d59-a058-bb505c17b46b", "Diễn Viên X, Diễn Viên Y", "Đây là một bộ phim hành động đầy kịch tính.", "Đạo Diễn A", 120, new byte[] { 1, 2, 3 }, "Phim Hành Động 1", "http://trailer.com/phimhanhdong1" }
                });

            migrationBuilder.InsertData(
                table: "priceInformationForEachUserFilmType",
                columns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                values: new object[] { "fd7f0e94-ebc1-4b15-a8be-ea776f042a66", "c6dd9fd4-70e1-4db3-8550-df866a8bc0a0", "1d131f8a-ffa5-40dd-96d6-529ee851ccd0" });

            migrationBuilder.InsertData(
                table: "userRoleInformation",
                columns: new[] { "roleId", "userId" },
                values: new object[,]
                {
                    { "81a380cf-aa23-4986-a61f-d78dd31f2a28", "0e5b69ea-ad10-4230-b235-982e11b8faf0" },
                    { "e43e01c6-b256-4bcf-b388-1271c07fb4de", "f2d70f56-1c44-450a-a91a-3e96fe116dc5" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatsId", "cinemaRoomId", "isMiddle", "isTaken", "seatsNumber" },
                values: new object[,]
                {
                    { "49e8fa60-4293-4904-bfb4-f69eaf9b7441", "7e44cf47-0cba-4d85-8ac1-d214fe9258c3", true, false, "A2" },
                    { "53c7aaf4-362d-45c0-b9d4-e7b1e5223a9e", "7e44cf47-0cba-4d85-8ac1-d214fe9258c3", true, false, "A1" }
                });

            migrationBuilder.InsertData(
                table: "movieGenreInformation",
                columns: new[] { "movieGenreId", "movieId" },
                values: new object[,]
                {
                    { "8317d642-f713-40e8-a5b5-963d8df2f3ab", "820c0758-e6b9-4d0c-bcdd-8939d0076841" },
                    { "3d4c8fb0-5ed4-4a18-811a-aaafcae2b128", "b5335cd7-e917-43b0-8c6b-46f7f92aa428" }
                });

            migrationBuilder.InsertData(
                table: "movieSchedule",
                columns: new[] { "movieScheduleId", "DayInWeekendSchedule", "HourScheduleID", "IsDelete", "ReleaseDate", "cinemaID", "cinemaRoomId", "movieId" },
                values: new object[] { "c8a62d01-45ab-4f25-ba28-1197b9a6c6a2", "Monday", "c9671979-4f85-4f5e-abe5-99a403a0e231", false, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ee3f21ca-d2c2-4b29-9992-6609b06e7027", "7e44cf47-0cba-4d85-8ac1-d214fe9258c3", "b5335cd7-e917-43b0-8c6b-46f7f92aa428" });

            migrationBuilder.CreateIndex(
                name: "IX_movieSchedule_cinemaRoomId_cinemaID_ReleaseDate",
                table: "movieSchedule",
                columns: new[] { "cinemaRoomId", "cinemaID", "ReleaseDate" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_movieSchedule_cinemaRoomId_cinemaID_ReleaseDate",
                table: "movieSchedule");

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "8c7703b1-7081-451f-bc68-97b264e95431");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "49e8fa60-4293-4904-bfb4-f69eaf9b7441");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "53c7aaf4-362d-45c0-b9d4-e7b1e5223a9e");

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "77125357-e6b1-4a2d-87fc-a2bb0095ecb9");

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "8317d642-f713-40e8-a5b5-963d8df2f3ab", "820c0758-e6b9-4d0c-bcdd-8939d0076841" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "3d4c8fb0-5ed4-4a18-811a-aaafcae2b128", "b5335cd7-e917-43b0-8c6b-46f7f92aa428" });

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "c8a62d01-45ab-4f25-ba28-1197b9a6c6a2");

            migrationBuilder.DeleteData(
                table: "priceInformationForEachUserFilmType",
                keyColumns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                keyValues: new object[] { "fd7f0e94-ebc1-4b15-a8be-ea776f042a66", "c6dd9fd4-70e1-4db3-8550-df866a8bc0a0", "1d131f8a-ffa5-40dd-96d6-529ee851ccd0" });

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "18df653f-05f7-4552-93fc-d7154acf9b4f");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "23f9683b-fe66-40d1-9b9a-ef4dab0f1902");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "9e98f71e-a897-41f1-ac14-89cd09464d1f");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "b264ebf6-b36d-40ee-bcf1-f8af8f9837d5");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "c6b0fd7c-4c74-4fa1-83d3-57451a873666");

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "81a380cf-aa23-4986-a61f-d78dd31f2a28", "0e5b69ea-ad10-4230-b235-982e11b8faf0" });

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "e43e01c6-b256-4bcf-b388-1271c07fb4de", "f2d70f56-1c44-450a-a91a-3e96fe116dc5" });

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "c9671979-4f85-4f5e-abe5-99a403a0e231");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "7e44cf47-0cba-4d85-8ac1-d214fe9258c3");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "3d4c8fb0-5ed4-4a18-811a-aaafcae2b128");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "8317d642-f713-40e8-a5b5-963d8df2f3ab");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "820c0758-e6b9-4d0c-bcdd-8939d0076841");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "b5335cd7-e917-43b0-8c6b-46f7f92aa428");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "fd7f0e94-ebc1-4b15-a8be-ea776f042a66");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "c6dd9fd4-70e1-4db3-8550-df866a8bc0a0");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "81a380cf-aa23-4986-a61f-d78dd31f2a28");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "e43e01c6-b256-4bcf-b388-1271c07fb4de");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "0e5b69ea-ad10-4230-b235-982e11b8faf0");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "f2d70f56-1c44-450a-a91a-3e96fe116dc5");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "1d131f8a-ffa5-40dd-96d6-529ee851ccd0");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "ee3f21ca-d2c2-4b29-9992-6609b06e7027");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "3040d895-54dd-4680-82c3-42795fa780ba");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "38a39e70-98e4-4d59-a058-bb505c17b46b");

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "cinemaId", "cinemaContactHotlineNumber", "cinemaDescription", "cinemaLocation", "cinemaName", "isSupportedIMAX" },
                values: new object[] { "72a8ab3c-ad00-4167-9570-c60cead703a0", "0901234567", "Rạp chiếu phim hiện đại với nhiều phòng chiếu.", "123 Đường XYZ, TP.HCM", "Rạp Chiếu Phim ABC", true });

            migrationBuilder.InsertData(
                table: "HourSchedule",
                columns: new[] { "HourScheduleID", "HourScheduleDate" },
                values: new object[,]
                {
                    { "43e141f9-dfd3-40a3-8bca-fc4064a4cf1f", "10:00" },
                    { "cfdae06f-8db9-4046-9cd7-8683ce42b915", "08:00" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "languageId", "languageDetail" },
                values: new object[,]
                {
                    { "abd2eb7e-1528-4e75-ae29-ac31ca161dc1", "Vietnamese" },
                    { "b6ce3086-75b3-4898-9368-164bff14c933", "English" }
                });

            migrationBuilder.InsertData(
                table: "foodInformation",
                columns: new[] { "foodInformationId", "foodInformationName", "foodPrice" },
                values: new object[] { "951cabc5-a2c5-45a7-8906-d73ba9e1fcf5", "Popcorn", 50000L });

            migrationBuilder.InsertData(
                table: "movieGenre",
                columns: new[] { "movieGenreId", "movieGenreName" },
                values: new object[,]
                {
                    { "82b48385-d679-4495-8835-d0c500500d66", "Action" },
                    { "ad1bf5a8-08b5-4410-86d4-d2c16feae08c", "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "movieVisualFormat",
                columns: new[] { "movieVisualFormatId", "movieVisualFormatName" },
                values: new object[] { "a16ec615-f61a-4537-bf8b-f5ec723d8046", "2D" });

            migrationBuilder.InsertData(
                table: "priceInformation",
                columns: new[] { "priceInformationId", "priceAmount" },
                values: new object[] { "c434ce6a-af11-4125-a559-8dd39e5fc65e", 80000L });

            migrationBuilder.InsertData(
                table: "roleInformation",
                columns: new[] { "roleId", "roleName" },
                values: new object[,]
                {
                    { "10d4f6b3-e063-4fbf-ad4c-c0110b9de4e6", "TheaterCleaner" },
                    { "36362348-aa92-4131-bca7-27938b099889", "Director" },
                    { "67b21539-41c0-4ccf-8dbf-bdca062373c4", "FacilitiesManager" },
                    { "7bac5e3e-0d42-47a2-8f02-fc4c8e4b7f0f", "Cashier" },
                    { "83f2b568-ea33-42da-abfc-fb0c211eaf14", "Customer" },
                    { "8a2026f4-4b74-40ea-831e-487ef0790362", "TheaterManager" },
                    { "a35a8508-7b82-4f4c-9588-afee17fd1115", "MovieManager" }
                });

            migrationBuilder.InsertData(
                table: "userInformation",
                columns: new[] { "userId", "IdentityCode", "dateOfBirth", "loginUserEmail", "loginUserPassword", "phoneNumber", "userName", "userPoint" },
                values: new object[,]
                {
                    { "9fff4863-1c07-4e5e-a7f1-e50b060a7755", "987654321098", new DateTime(1995, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", "hashed_password_user", "0987654321", "Regular User", 50 },
                    { "a6b19dc7-9897-428b-ad80-b7d973af812a", "123456789012", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", "hashed_password_admin", "0123456789", "Admin User", 1000 }
                });

            migrationBuilder.InsertData(
                table: "userType",
                columns: new[] { "userTypeId", "userTypeDescription" },
                values: new object[] { "fe92495a-a8f6-4b9d-a9b7-a68b3aeab9f2", "Adult" });

            migrationBuilder.InsertData(
                table: "cinemaRoom",
                columns: new[] { "cinemaRoomId", "cinemaId", "cinemaRoomNumber", "isIMAXRoom" },
                values: new object[] { "f292983b-2dc5-429a-a541-82a30e8626f6", "72a8ab3c-ad00-4167-9570-c60cead703a0", 1, true });

            migrationBuilder.InsertData(
                table: "movieInformation",
                columns: new[] { "movieId", "languageId", "movieActor", "movieDescription", "movieDirector", "movieDuration", "movieImage", "movieName", "movieTrailerUrl" },
                values: new object[,]
                {
                    { "9f64aba0-5377-4e43-a2ac-9a31dfa8d0bb", "abd2eb7e-1528-4e75-ae29-ac31ca161dc1", "Diễn Viên X, Diễn Viên Y", "Đây là một bộ phim hành động đầy kịch tính.", "Đạo Diễn A", 120, new byte[] { 1, 2, 3 }, "Phim Hành Động 1", "http://trailer.com/phimhanhdong1" },
                    { "bf7e5dd7-ade2-430a-9aa2-e6fa2a5253d7", "b6ce3086-75b3-4898-9368-164bff14c933", "Actor Z, Actress W", "A funny movie for the whole family.", "Director B", 90, new byte[] { 4, 5, 6 }, "Comedy Film 1", "http://trailer.com/comedyfilm1" }
                });

            migrationBuilder.InsertData(
                table: "priceInformationForEachUserFilmType",
                columns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                values: new object[] { "a16ec615-f61a-4537-bf8b-f5ec723d8046", "c434ce6a-af11-4125-a559-8dd39e5fc65e", "fe92495a-a8f6-4b9d-a9b7-a68b3aeab9f2" });

            migrationBuilder.InsertData(
                table: "userRoleInformation",
                columns: new[] { "roleId", "userId" },
                values: new object[,]
                {
                    { "83f2b568-ea33-42da-abfc-fb0c211eaf14", "9fff4863-1c07-4e5e-a7f1-e50b060a7755" },
                    { "a35a8508-7b82-4f4c-9588-afee17fd1115", "a6b19dc7-9897-428b-ad80-b7d973af812a" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatsId", "cinemaRoomId", "isMiddle", "isTaken", "seatsNumber" },
                values: new object[,]
                {
                    { "7ce9a9e8-223d-4262-b6e1-2d229bd76094", "f292983b-2dc5-429a-a541-82a30e8626f6", true, false, "A2" },
                    { "bb9b83dd-5fe3-4621-afea-006a218f9d9b", "f292983b-2dc5-429a-a541-82a30e8626f6", true, false, "A1" }
                });

            migrationBuilder.InsertData(
                table: "movieGenreInformation",
                columns: new[] { "movieGenreId", "movieId" },
                values: new object[,]
                {
                    { "82b48385-d679-4495-8835-d0c500500d66", "9f64aba0-5377-4e43-a2ac-9a31dfa8d0bb" },
                    { "ad1bf5a8-08b5-4410-86d4-d2c16feae08c", "bf7e5dd7-ade2-430a-9aa2-e6fa2a5253d7" }
                });

            migrationBuilder.InsertData(
                table: "movieSchedule",
                columns: new[] { "movieScheduleId", "DayInWeekendSchedule", "HourScheduleID", "IsDelete", "ReleaseDate", "cinemaID", "cinemaRoomId", "movieId" },
                values: new object[] { "d9de5fea-2c53-4de8-b142-5f5c47b73475", "Monday", "cfdae06f-8db9-4046-9cd7-8683ce42b915", false, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "72a8ab3c-ad00-4167-9570-c60cead703a0", "f292983b-2dc5-429a-a541-82a30e8626f6", "9f64aba0-5377-4e43-a2ac-9a31dfa8d0bb" });

            migrationBuilder.CreateIndex(
                name: "IX_movieSchedule_cinemaRoomId",
                table: "movieSchedule",
                column: "cinemaRoomId");
        }
    }
}
