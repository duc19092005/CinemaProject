using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class Them_Data_Vao_Cac_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_cinemaRoom_cinemaId",
                table: "cinemaRoom");

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "cinemaId", "cinemaContactHotlineNumber", "cinemaDescription", "cinemaLocation", "cinemaName" },
                values: new object[,]
                {
                    { "73df57c3-1248-4a45-a392-8ab846245e0e", "0901234567", "A modern cinema with multiple screens.", "19 Cao Thang", "Mega GS Cao Thang" },
                    { "f7d1f350-bdd6-43d5-9cda-44bac941caeb", "0907654321", "Comfortable seating and great sound system.", "12 Cantavil", "Lotte Cinema Cantavil" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "languageId", "languageDetail" },
                values: new object[,]
                {
                    { "3d0ea2b8-a1fb-4043-bd35-c3cf9270d018", "Vietnamese" },
                    { "a4bb38c5-8a5c-4d91-ac77-9e8c090a7ba9", "English" },
                    { "f9b2a6eb-f0d9-4c9e-9250-876400c1d714", "Korean" }
                });

            migrationBuilder.InsertData(
                table: "foodInformation",
                columns: new[] { "foodInformationId", "foodInformationName", "foodPrice" },
                values: new object[,]
                {
                    { "2f842e1d-34f3-4520-951e-f4c4a73fda78", "Coca-Cola", 30000L },
                    { "ba7359bf-9ff6-47f3-b3e8-662aa52990ad", "Popcorn Medium", 50000L }
                });

            migrationBuilder.InsertData(
                table: "movieGenre",
                columns: new[] { "movieGenreId", "movieGenreName" },
                values: new object[,]
                {
                    { "20971004-cc45-4989-b364-1e21af03e4cf", "Drama" },
                    { "3d528643-b94f-40e2-a4b9-21317d3a0fc2", "Comedy" },
                    { "5bfd0bb8-3b93-4b2c-af40-1bb2b70c128c", "Action" },
                    { "ec5c3c99-b103-4e43-9f10-1b75e5a958e4", "Horror" }
                });

            migrationBuilder.InsertData(
                table: "movieVisualFormat",
                columns: new[] { "movieVisualFormatId", "movieVisualFormatName" },
                values: new object[,]
                {
                    { "1536eb08-b05f-4bcf-be4e-14ecdfc0181e", "3D" },
                    { "44a3f756-b678-4f87-b45b-80dcabafbe6f", "IMAX" },
                    { "4ad81bf3-db6e-4703-a172-686e4b047b23", "2D" }
                });

            migrationBuilder.InsertData(
                table: "roleInformation",
                columns: new[] { "roleId", "roleName" },
                values: new object[,]
                {
                    { "4e5e6cdf-9de5-42a3-96a8-bfe787b5aa19", "Cleaning Staff" },
                    { "4fdd19fa-4265-44f4-b9ae-aca63fad38fe", "Ticket Inspector Staff" },
                    { "9e710d03-cc1c-4346-b7ed-50ee658a605e", "Cashier Staff" },
                    { "bebf6767-c801-44c0-885e-d59e3a7452ba", "Customer" },
                    { "d6095d4e-10de-45c4-b3af-26f288978c7b", "Director" }
                });

            migrationBuilder.InsertData(
                table: "userInformation",
                columns: new[] { "userId", "IdentityCode", "dateOfBirth", "loginUserEmail", "loginUserPassword", "phoneNumber", "userName", "userPoint" },
                values: new object[,]
                {
                    { "4588f68a-c24a-4ec1-9b26-74a4fa65b5e5", "012345678901", new DateTime(1995, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer1@example.com", "password123", "0987654321", "Nguyen Van A", 250 },
                    { "be6dc62f-4934-4bac-b77f-2846a4b49966", "123456789012", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", "password123", "0912345678", "Admin User", 1000 }
                });

            migrationBuilder.InsertData(
                table: "userType",
                columns: new[] { "userTypeId", "userTypeDescription" },
                values: new object[,]
                {
                    { "585b8fbe-84ea-4a96-9e32-40941e409aa0", "Senior" },
                    { "6fcc46cf-45a7-41a1-b212-b76ad60eaa3f", "Student" },
                    { "77163d45-09cc-48ea-acc4-cb029440aa83", "Adult" },
                    { "9388228a-01f2-444e-ab2c-80a9eed42a3c", "Child" }
                });

            migrationBuilder.InsertData(
                table: "cinemaRoom",
                columns: new[] { "cinemaRoomId", "cinemaId", "cinemaRoomNumber" },
                values: new object[,]
                {
                    { "08b50204-0fd4-4da1-b390-c2da2f188b05", "73df57c3-1248-4a45-a392-8ab846245e0e", 1 },
                    { "24f89629-602a-44a7-b393-25a10d223632", "f7d1f350-bdd6-43d5-9cda-44bac941caeb", 1 },
                    { "ccd0f422-7764-447f-af0f-dc7afb415fa5", "73df57c3-1248-4a45-a392-8ab846245e0e", 2 }
                });

            migrationBuilder.InsertData(
                table: "movieInformation",
                columns: new[] { "movieId", "languageId", "movieActor", "movieDescription", "movieDirector", "movieDuration", "movieImage", "movieName", "movieTrailerUrl", "movieVisualFormatId" },
                values: new object[,]
                {
                    { "2da0d967-7e02-436f-9315-add2964c89ec", "a4bb38c5-8a5c-4d91-ac77-9e8c090a7ba9", "Timothée Chalamet, Zendaya, Rebecca Ferguson", "Paul Atreides unites with Chani and the Fremen while seeking revenge against those who destroyed his family.", "Denis Villeneuve", 166, new byte[] { 100, 117, 110, 101, 50, 95, 105, 109, 97, 103, 101, 95, 112, 108, 97, 99, 101, 104, 111, 108, 100, 101, 114 }, "Dune: Part Two", "https://www.youtube.com/watch?v=Way9Dexny3w", "4ad81bf3-db6e-4703-a172-686e4b047b23" },
                    { "d6855575-7707-4df0-8d41-7301063fed06", "a4bb38c5-8a5c-4d91-ac77-9e8c090a7ba9", "Rebecca Hall, Brian Tyree Henry, Dan Stevens", "Godzilla and Kong must unite to fight a colossal undiscovered threat hidden within our world.", "Adam Wingard", 115, new byte[] { 103, 111, 100, 122, 105, 108, 108, 97, 120, 107, 111, 110, 103, 95, 105, 109, 97, 103, 101, 95, 112, 108, 97, 99, 101, 104, 111, 108, 100, 101, 114 }, "Godzilla x Kong: The New Empire", "https://www.youtube.com/watch?v=EOk9z-WbN5o", "1536eb08-b05f-4bcf-be4e-14ecdfc0181e" }
                });

            migrationBuilder.InsertData(
                table: "priceInformation",
                columns: new[] { "priceInformationId", "movieVisualFormatId", "priceAmount", "userTypeId" },
                values: new object[,]
                {
                    { "052c094f-3477-4ca9-bf5c-3227e912d01c", "4ad81bf3-db6e-4703-a172-686e4b047b23", 70000L, "9388228a-01f2-444e-ab2c-80a9eed42a3c" },
                    { "7b520b64-e894-4556-8ba7-8719fb7629e6", "4ad81bf3-db6e-4703-a172-686e4b047b23", 100000L, "77163d45-09cc-48ea-acc4-cb029440aa83" },
                    { "7bfcbe58-8f8a-4c63-b437-a71851271536", "1536eb08-b05f-4bcf-be4e-14ecdfc0181e", 130000L, "77163d45-09cc-48ea-acc4-cb029440aa83" }
                });

            migrationBuilder.InsertData(
                table: "userRoleInformation",
                columns: new[] { "roleId", "userId" },
                values: new object[,]
                {
                    { "bebf6767-c801-44c0-885e-d59e3a7452ba", "4588f68a-c24a-4ec1-9b26-74a4fa65b5e5" },
                    { "d6095d4e-10de-45c4-b3af-26f288978c7b", "be6dc62f-4934-4bac-b77f-2846a4b49966" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatsId", "cinemaRoomId", "isMiddle", "isTaken", "seatsNumber" },
                values: new object[,]
                {
                    { "03401084-b5d8-41cd-8764-73ddb9269897", "08b50204-0fd4-4da1-b390-c2da2f188b05", true, false, "A1" },
                    { "15c5bea5-d152-49f3-9361-338b9737d6a2", "24f89629-602a-44a7-b393-25a10d223632", true, false, "D1" },
                    { "364539a4-f250-4d78-8bea-b28b8fa80455", "ccd0f422-7764-447f-af0f-dc7afb415fa5", true, false, "C1" },
                    { "6a2ca9f2-1560-4903-acfb-c8d766fb9fad", "08b50204-0fd4-4da1-b390-c2da2f188b05", false, false, "B2" },
                    { "9c03d765-8bce-4a3a-bdc4-cb61d852748c", "24f89629-602a-44a7-b393-25a10d223632", false, false, "D2" },
                    { "d28de0d3-9cff-4f02-8b75-96d434ccc6fa", "ccd0f422-7764-447f-af0f-dc7afb415fa5", false, false, "C2" },
                    { "d6386a41-46af-4dde-a41e-ecd39989aa97", "08b50204-0fd4-4da1-b390-c2da2f188b05", true, false, "A2" },
                    { "f0d1ee36-deb3-4433-9a9a-cdf86b60ef6f", "08b50204-0fd4-4da1-b390-c2da2f188b05", false, false, "B1" }
                });

            migrationBuilder.InsertData(
                table: "cinemaMovieInformation",
                columns: new[] { "cinemaId", "movieId" },
                values: new object[,]
                {
                    { "73df57c3-1248-4a45-a392-8ab846245e0e", "2da0d967-7e02-436f-9315-add2964c89ec" },
                    { "73df57c3-1248-4a45-a392-8ab846245e0e", "d6855575-7707-4df0-8d41-7301063fed06" },
                    { "f7d1f350-bdd6-43d5-9cda-44bac941caeb", "2da0d967-7e02-436f-9315-add2964c89ec" }
                });

            migrationBuilder.InsertData(
                table: "movieGenreInformation",
                columns: new[] { "movieGenreId", "movieId" },
                values: new object[,]
                {
                    { "20971004-cc45-4989-b364-1e21af03e4cf", "2da0d967-7e02-436f-9315-add2964c89ec" },
                    { "5bfd0bb8-3b93-4b2c-af40-1bb2b70c128c", "2da0d967-7e02-436f-9315-add2964c89ec" },
                    { "5bfd0bb8-3b93-4b2c-af40-1bb2b70c128c", "d6855575-7707-4df0-8d41-7301063fed06" }
                });

            migrationBuilder.InsertData(
                table: "movieSchedule",
                columns: new[] { "movieScheduleId", "cinemaRoomId", "movieId", "showDateTime" },
                values: new object[,]
                {
                    { "0b0bda4a-589b-4b8f-aae7-cec507b1f980", "08b50204-0fd4-4da1-b390-c2da2f188b05", "d6855575-7707-4df0-8d41-7301063fed06", new DateTime(2025, 6, 5, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { "c266965c-6acc-46f7-84cd-de15d235d6bf", "24f89629-602a-44a7-b393-25a10d223632", "2da0d967-7e02-436f-9315-add2964c89ec", new DateTime(2025, 6, 6, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "e0963750-79e8-4bef-a311-d2ebc819e205", "08b50204-0fd4-4da1-b390-c2da2f188b05", "2da0d967-7e02-436f-9315-add2964c89ec", new DateTime(2025, 6, 5, 10, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_cinemaRoom_cinemaId",
                table: "cinemaRoom",
                column: "cinemaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_cinemaRoom_cinemaId",
                table: "cinemaRoom");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "3d0ea2b8-a1fb-4043-bd35-c3cf9270d018");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "f9b2a6eb-f0d9-4c9e-9250-876400c1d714");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "03401084-b5d8-41cd-8764-73ddb9269897");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "15c5bea5-d152-49f3-9361-338b9737d6a2");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "364539a4-f250-4d78-8bea-b28b8fa80455");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "6a2ca9f2-1560-4903-acfb-c8d766fb9fad");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "9c03d765-8bce-4a3a-bdc4-cb61d852748c");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "d28de0d3-9cff-4f02-8b75-96d434ccc6fa");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "d6386a41-46af-4dde-a41e-ecd39989aa97");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "f0d1ee36-deb3-4433-9a9a-cdf86b60ef6f");

            migrationBuilder.DeleteData(
                table: "cinemaMovieInformation",
                keyColumns: new[] { "cinemaId", "movieId" },
                keyValues: new object[] { "73df57c3-1248-4a45-a392-8ab846245e0e", "2da0d967-7e02-436f-9315-add2964c89ec" });

            migrationBuilder.DeleteData(
                table: "cinemaMovieInformation",
                keyColumns: new[] { "cinemaId", "movieId" },
                keyValues: new object[] { "73df57c3-1248-4a45-a392-8ab846245e0e", "d6855575-7707-4df0-8d41-7301063fed06" });

            migrationBuilder.DeleteData(
                table: "cinemaMovieInformation",
                keyColumns: new[] { "cinemaId", "movieId" },
                keyValues: new object[] { "f7d1f350-bdd6-43d5-9cda-44bac941caeb", "2da0d967-7e02-436f-9315-add2964c89ec" });

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "2f842e1d-34f3-4520-951e-f4c4a73fda78");

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "ba7359bf-9ff6-47f3-b3e8-662aa52990ad");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "3d528643-b94f-40e2-a4b9-21317d3a0fc2");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "ec5c3c99-b103-4e43-9f10-1b75e5a958e4");

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "20971004-cc45-4989-b364-1e21af03e4cf", "2da0d967-7e02-436f-9315-add2964c89ec" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "5bfd0bb8-3b93-4b2c-af40-1bb2b70c128c", "2da0d967-7e02-436f-9315-add2964c89ec" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "5bfd0bb8-3b93-4b2c-af40-1bb2b70c128c", "d6855575-7707-4df0-8d41-7301063fed06" });

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "0b0bda4a-589b-4b8f-aae7-cec507b1f980");

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "c266965c-6acc-46f7-84cd-de15d235d6bf");

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "e0963750-79e8-4bef-a311-d2ebc819e205");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "44a3f756-b678-4f87-b45b-80dcabafbe6f");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "052c094f-3477-4ca9-bf5c-3227e912d01c");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "7b520b64-e894-4556-8ba7-8719fb7629e6");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "7bfcbe58-8f8a-4c63-b437-a71851271536");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "4e5e6cdf-9de5-42a3-96a8-bfe787b5aa19");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "4fdd19fa-4265-44f4-b9ae-aca63fad38fe");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "9e710d03-cc1c-4346-b7ed-50ee658a605e");

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "bebf6767-c801-44c0-885e-d59e3a7452ba", "4588f68a-c24a-4ec1-9b26-74a4fa65b5e5" });

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "d6095d4e-10de-45c4-b3af-26f288978c7b", "be6dc62f-4934-4bac-b77f-2846a4b49966" });

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "585b8fbe-84ea-4a96-9e32-40941e409aa0");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "6fcc46cf-45a7-41a1-b212-b76ad60eaa3f");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "08b50204-0fd4-4da1-b390-c2da2f188b05");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "24f89629-602a-44a7-b393-25a10d223632");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "ccd0f422-7764-447f-af0f-dc7afb415fa5");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "20971004-cc45-4989-b364-1e21af03e4cf");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "5bfd0bb8-3b93-4b2c-af40-1bb2b70c128c");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "2da0d967-7e02-436f-9315-add2964c89ec");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "d6855575-7707-4df0-8d41-7301063fed06");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "bebf6767-c801-44c0-885e-d59e3a7452ba");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "d6095d4e-10de-45c4-b3af-26f288978c7b");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "4588f68a-c24a-4ec1-9b26-74a4fa65b5e5");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "be6dc62f-4934-4bac-b77f-2846a4b49966");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "77163d45-09cc-48ea-acc4-cb029440aa83");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "9388228a-01f2-444e-ab2c-80a9eed42a3c");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "73df57c3-1248-4a45-a392-8ab846245e0e");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "f7d1f350-bdd6-43d5-9cda-44bac941caeb");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "a4bb38c5-8a5c-4d91-ac77-9e8c090a7ba9");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "1536eb08-b05f-4bcf-be4e-14ecdfc0181e");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "4ad81bf3-db6e-4703-a172-686e4b047b23");

            migrationBuilder.CreateIndex(
                name: "IX_cinemaRoom_cinemaId",
                table: "cinemaRoom",
                column: "cinemaId",
                unique: true);
        }
    }
}
