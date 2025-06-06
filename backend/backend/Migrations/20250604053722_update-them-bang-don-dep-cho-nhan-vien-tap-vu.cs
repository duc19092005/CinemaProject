using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class updatethembangdondepchonhanvientapvu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "cleaningStatus",
                columns: table => new
                {
                    roomID = table.Column<string>(type: "varchar(100)", nullable: false),
                    staffID = table.Column<string>(type: "varchar(100)", nullable: false),
                    startedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cinemaRoomId = table.Column<string>(type: "varchar(100)", nullable: false),
                    userInformationuserId = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cleaningStatus", x => new { x.roomID, x.staffID, x.startedTime });
                    table.ForeignKey(
                        name: "FK_cleaningStatus_cinemaRoom_cinemaRoomId",
                        column: x => x.cinemaRoomId,
                        principalTable: "cinemaRoom",
                        principalColumn: "cinemaRoomId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cleaningStatus_userInformation_userInformationuserId",
                        column: x => x.userInformationuserId,
                        principalTable: "userInformation",
                        principalColumn: "userId");
                });

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "cinemaId", "cinemaContactHotlineNumber", "cinemaDescription", "cinemaLocation", "cinemaName" },
                values: new object[,]
                {
                    { "60a38b4c-a233-42bd-a91b-2f06eb78e4c4", "0907654321", "Comfortable seating and great sound system.", "12 Cantavil", "Lotte Cinema Cantavil" },
                    { "6150789a-662c-4db2-83c2-45fd5ffb6fb9", "0901234567", "A modern cinema with multiple screens.", "19 Cao Thang", "Mega GS Cao Thang" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "languageId", "languageDetail" },
                values: new object[,]
                {
                    { "316ec4b2-87cf-4b6f-9a3f-45717069ba26", "English" },
                    { "41486d7b-88de-47e2-9aaa-c9707c8e6ce7", "Vietnamese" },
                    { "4a015649-2ec0-4776-8ee8-6694bfc98c54", "Korean" }
                });

            migrationBuilder.InsertData(
                table: "foodInformation",
                columns: new[] { "foodInformationId", "foodInformationName", "foodPrice" },
                values: new object[,]
                {
                    { "f30816cf-9519-4198-9707-06860d7d2eb9", "Coca-Cola", 30000L },
                    { "fb5f120e-a69d-4df0-b048-9dcaad789261", "Popcorn Medium", 50000L }
                });

            migrationBuilder.InsertData(
                table: "movieGenre",
                columns: new[] { "movieGenreId", "movieGenreName" },
                values: new object[,]
                {
                    { "10d1643d-0728-4812-9f23-6763eaa87ec0", "Drama" },
                    { "700355b6-8b87-4411-a86b-0786a4df55f5", "Horror" },
                    { "b09a62b0-9ff5-4ab6-a6c0-0914960d5cc7", "Action" },
                    { "b9f55917-5d1e-4bba-a41d-536860e15849", "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "movieVisualFormat",
                columns: new[] { "movieVisualFormatId", "movieVisualFormatName" },
                values: new object[,]
                {
                    { "1494b18c-bdcd-4985-a905-c065ed9c0f04", "IMAX" },
                    { "7b52efc6-9ff1-4e28-932e-a2df9c39049c", "3D" },
                    { "7bfa77f1-3257-46bc-9016-d65fdc098fa2", "2D" }
                });

            migrationBuilder.InsertData(
                table: "roleInformation",
                columns: new[] { "roleId", "roleName" },
                values: new object[,]
                {
                    { "0e73a120-1b4c-4fb8-827c-5484ebca3c44", "Cashier Staff" },
                    { "2608e42d-a808-4f6b-a834-81241cb0e05f", "Cleaning Staff" },
                    { "45b367d8-9bdc-4589-8b57-9eee358f014b", "Director" },
                    { "4cb1d82c-ec82-4902-af84-8040862a4dfe", "Ticket Inspector Staff" },
                    { "62a9a81b-b226-4f6b-9212-a629c41f162e", "Customer" }
                });

            migrationBuilder.InsertData(
                table: "userInformation",
                columns: new[] { "userId", "IdentityCode", "dateOfBirth", "loginUserEmail", "loginUserPassword", "phoneNumber", "userName", "userPoint" },
                values: new object[,]
                {
                    { "0f43dc88-a427-4360-a16d-42cac375046e", "123456789012", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", "password123", "0912345678", "Admin User", 1000 },
                    { "2dd341f8-cb65-4f47-aa08-2acd1ac35087", "012345678901", new DateTime(1995, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer1@example.com", "password123", "0987654321", "Nguyen Van A", 250 }
                });

            migrationBuilder.InsertData(
                table: "userType",
                columns: new[] { "userTypeId", "userTypeDescription" },
                values: new object[,]
                {
                    { "112a64b4-aa15-4d63-94bb-25de3ec8893d", "Senior" },
                    { "9563d067-07f4-4d8f-a98a-f19388fecfd8", "Student" },
                    { "a7417183-2193-4977-9a41-a89419da4bce", "Child" },
                    { "f45dfec0-295e-4c7c-9ea8-1ed09a4acf9e", "Adult" }
                });

            migrationBuilder.InsertData(
                table: "cinemaRoom",
                columns: new[] { "cinemaRoomId", "cinemaId", "cinemaRoomNumber" },
                values: new object[,]
                {
                    { "02be2fc9-7db4-463b-8c14-f2eccc9a27af", "6150789a-662c-4db2-83c2-45fd5ffb6fb9", 2 },
                    { "1faff209-1204-4500-a0a5-57d5e7e763cf", "60a38b4c-a233-42bd-a91b-2f06eb78e4c4", 1 },
                    { "6d4a7444-ed65-4906-81ba-3236980544a1", "6150789a-662c-4db2-83c2-45fd5ffb6fb9", 1 }
                });

            migrationBuilder.InsertData(
                table: "movieInformation",
                columns: new[] { "movieId", "languageId", "movieActor", "movieDescription", "movieDirector", "movieDuration", "movieImage", "movieName", "movieTrailerUrl", "movieVisualFormatId" },
                values: new object[,]
                {
                    { "0fd06f66-9112-4cc4-9aeb-f0a96bb73f51", "316ec4b2-87cf-4b6f-9a3f-45717069ba26", "Timothée Chalamet, Zendaya, Rebecca Ferguson", "Paul Atreides unites with Chani and the Fremen while seeking revenge against those who destroyed his family.", "Denis Villeneuve", 166, new byte[] { 100, 117, 110, 101, 50, 95, 105, 109, 97, 103, 101, 95, 112, 108, 97, 99, 101, 104, 111, 108, 100, 101, 114 }, "Dune: Part Two", "https://www.youtube.com/watch?v=Way9Dexny3w", "7bfa77f1-3257-46bc-9016-d65fdc098fa2" },
                    { "ddaf57a9-b032-4a16-a437-f992db311123", "316ec4b2-87cf-4b6f-9a3f-45717069ba26", "Rebecca Hall, Brian Tyree Henry, Dan Stevens", "Godzilla and Kong must unite to fight a colossal undiscovered threat hidden within our world.", "Adam Wingard", 115, new byte[] { 103, 111, 100, 122, 105, 108, 108, 97, 120, 107, 111, 110, 103, 95, 105, 109, 97, 103, 101, 95, 112, 108, 97, 99, 101, 104, 111, 108, 100, 101, 114 }, "Godzilla x Kong: The New Empire", "https://www.youtube.com/watch?v=EOk9z-WbN5o", "7b52efc6-9ff1-4e28-932e-a2df9c39049c" }
                });

            migrationBuilder.InsertData(
                table: "priceInformation",
                columns: new[] { "priceInformationId", "movieVisualFormatId", "priceAmount", "userTypeId" },
                values: new object[,]
                {
                    { "2d9f9cfe-0364-4a6a-9445-0846e35d40cb", "7bfa77f1-3257-46bc-9016-d65fdc098fa2", 100000L, "f45dfec0-295e-4c7c-9ea8-1ed09a4acf9e" },
                    { "860902ce-d76d-4339-80e0-d21b6aa7997d", "7bfa77f1-3257-46bc-9016-d65fdc098fa2", 70000L, "a7417183-2193-4977-9a41-a89419da4bce" },
                    { "b8fc6e32-7350-4ff3-af69-eaa805695cbd", "7b52efc6-9ff1-4e28-932e-a2df9c39049c", 130000L, "f45dfec0-295e-4c7c-9ea8-1ed09a4acf9e" }
                });

            migrationBuilder.InsertData(
                table: "userRoleInformation",
                columns: new[] { "roleId", "userId" },
                values: new object[,]
                {
                    { "45b367d8-9bdc-4589-8b57-9eee358f014b", "0f43dc88-a427-4360-a16d-42cac375046e" },
                    { "62a9a81b-b226-4f6b-9212-a629c41f162e", "2dd341f8-cb65-4f47-aa08-2acd1ac35087" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatsId", "cinemaRoomId", "isMiddle", "isTaken", "seatsNumber" },
                values: new object[,]
                {
                    { "6a9f1eab-64bb-4745-ba07-97e343a43900", "6d4a7444-ed65-4906-81ba-3236980544a1", false, false, "B1" },
                    { "7d385243-3c6d-4137-ba5b-125cf4a8ea67", "02be2fc9-7db4-463b-8c14-f2eccc9a27af", true, false, "C1" },
                    { "8aad038e-2599-4589-b110-613b6d7f768f", "6d4a7444-ed65-4906-81ba-3236980544a1", true, false, "A2" },
                    { "c3ad3f2d-b220-482b-b97f-dd8991e744d5", "6d4a7444-ed65-4906-81ba-3236980544a1", true, false, "A1" },
                    { "d0cc32c1-3a3f-4358-b184-3bb31fba6f5e", "1faff209-1204-4500-a0a5-57d5e7e763cf", true, false, "D1" },
                    { "dc91f0cc-6f03-45dd-9084-b6565de8f4db", "02be2fc9-7db4-463b-8c14-f2eccc9a27af", false, false, "C2" },
                    { "ddcb6e5a-d800-4a57-b263-4ee54f9749c0", "1faff209-1204-4500-a0a5-57d5e7e763cf", false, false, "D2" },
                    { "eddc3e49-124b-4f7f-8962-2444df3e579e", "6d4a7444-ed65-4906-81ba-3236980544a1", false, false, "B2" }
                });

            migrationBuilder.InsertData(
                table: "cinemaMovieInformation",
                columns: new[] { "cinemaId", "movieId" },
                values: new object[,]
                {
                    { "60a38b4c-a233-42bd-a91b-2f06eb78e4c4", "0fd06f66-9112-4cc4-9aeb-f0a96bb73f51" },
                    { "6150789a-662c-4db2-83c2-45fd5ffb6fb9", "0fd06f66-9112-4cc4-9aeb-f0a96bb73f51" },
                    { "6150789a-662c-4db2-83c2-45fd5ffb6fb9", "ddaf57a9-b032-4a16-a437-f992db311123" }
                });

            migrationBuilder.InsertData(
                table: "movieGenreInformation",
                columns: new[] { "movieGenreId", "movieId" },
                values: new object[,]
                {
                    { "10d1643d-0728-4812-9f23-6763eaa87ec0", "0fd06f66-9112-4cc4-9aeb-f0a96bb73f51" },
                    { "b09a62b0-9ff5-4ab6-a6c0-0914960d5cc7", "0fd06f66-9112-4cc4-9aeb-f0a96bb73f51" },
                    { "b09a62b0-9ff5-4ab6-a6c0-0914960d5cc7", "ddaf57a9-b032-4a16-a437-f992db311123" }
                });

            migrationBuilder.InsertData(
                table: "movieSchedule",
                columns: new[] { "movieScheduleId", "cinemaRoomId", "movieId", "showDateTime" },
                values: new object[,]
                {
                    { "36a6f8f2-fbcb-4c35-9f65-497de967b186", "6d4a7444-ed65-4906-81ba-3236980544a1", "0fd06f66-9112-4cc4-9aeb-f0a96bb73f51", new DateTime(2025, 6, 5, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "69aae031-21f0-41a1-92c6-cd1385b850de", "6d4a7444-ed65-4906-81ba-3236980544a1", "ddaf57a9-b032-4a16-a437-f992db311123", new DateTime(2025, 6, 5, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { "b184edd0-568e-4fb0-b8f7-fd5b99f7c7f2", "1faff209-1204-4500-a0a5-57d5e7e763cf", "0fd06f66-9112-4cc4-9aeb-f0a96bb73f51", new DateTime(2025, 6, 6, 11, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_cleaningStatus_cinemaRoomId",
                table: "cleaningStatus",
                column: "cinemaRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_cleaningStatus_userInformationuserId",
                table: "cleaningStatus",
                column: "userInformationuserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cleaningStatus");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "41486d7b-88de-47e2-9aaa-c9707c8e6ce7");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "4a015649-2ec0-4776-8ee8-6694bfc98c54");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "6a9f1eab-64bb-4745-ba07-97e343a43900");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "7d385243-3c6d-4137-ba5b-125cf4a8ea67");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "8aad038e-2599-4589-b110-613b6d7f768f");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "c3ad3f2d-b220-482b-b97f-dd8991e744d5");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "d0cc32c1-3a3f-4358-b184-3bb31fba6f5e");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "dc91f0cc-6f03-45dd-9084-b6565de8f4db");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "ddcb6e5a-d800-4a57-b263-4ee54f9749c0");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "eddc3e49-124b-4f7f-8962-2444df3e579e");

            migrationBuilder.DeleteData(
                table: "cinemaMovieInformation",
                keyColumns: new[] { "cinemaId", "movieId" },
                keyValues: new object[] { "60a38b4c-a233-42bd-a91b-2f06eb78e4c4", "0fd06f66-9112-4cc4-9aeb-f0a96bb73f51" });

            migrationBuilder.DeleteData(
                table: "cinemaMovieInformation",
                keyColumns: new[] { "cinemaId", "movieId" },
                keyValues: new object[] { "6150789a-662c-4db2-83c2-45fd5ffb6fb9", "0fd06f66-9112-4cc4-9aeb-f0a96bb73f51" });

            migrationBuilder.DeleteData(
                table: "cinemaMovieInformation",
                keyColumns: new[] { "cinemaId", "movieId" },
                keyValues: new object[] { "6150789a-662c-4db2-83c2-45fd5ffb6fb9", "ddaf57a9-b032-4a16-a437-f992db311123" });

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "f30816cf-9519-4198-9707-06860d7d2eb9");

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "fb5f120e-a69d-4df0-b048-9dcaad789261");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "700355b6-8b87-4411-a86b-0786a4df55f5");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "b9f55917-5d1e-4bba-a41d-536860e15849");

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "10d1643d-0728-4812-9f23-6763eaa87ec0", "0fd06f66-9112-4cc4-9aeb-f0a96bb73f51" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "b09a62b0-9ff5-4ab6-a6c0-0914960d5cc7", "0fd06f66-9112-4cc4-9aeb-f0a96bb73f51" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "b09a62b0-9ff5-4ab6-a6c0-0914960d5cc7", "ddaf57a9-b032-4a16-a437-f992db311123" });

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "36a6f8f2-fbcb-4c35-9f65-497de967b186");

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "69aae031-21f0-41a1-92c6-cd1385b850de");

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "b184edd0-568e-4fb0-b8f7-fd5b99f7c7f2");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "1494b18c-bdcd-4985-a905-c065ed9c0f04");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "2d9f9cfe-0364-4a6a-9445-0846e35d40cb");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "860902ce-d76d-4339-80e0-d21b6aa7997d");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "b8fc6e32-7350-4ff3-af69-eaa805695cbd");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "0e73a120-1b4c-4fb8-827c-5484ebca3c44");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "2608e42d-a808-4f6b-a834-81241cb0e05f");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "4cb1d82c-ec82-4902-af84-8040862a4dfe");

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "45b367d8-9bdc-4589-8b57-9eee358f014b", "0f43dc88-a427-4360-a16d-42cac375046e" });

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "62a9a81b-b226-4f6b-9212-a629c41f162e", "2dd341f8-cb65-4f47-aa08-2acd1ac35087" });

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "112a64b4-aa15-4d63-94bb-25de3ec8893d");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "9563d067-07f4-4d8f-a98a-f19388fecfd8");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "02be2fc9-7db4-463b-8c14-f2eccc9a27af");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "1faff209-1204-4500-a0a5-57d5e7e763cf");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "6d4a7444-ed65-4906-81ba-3236980544a1");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "10d1643d-0728-4812-9f23-6763eaa87ec0");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "b09a62b0-9ff5-4ab6-a6c0-0914960d5cc7");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "0fd06f66-9112-4cc4-9aeb-f0a96bb73f51");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "ddaf57a9-b032-4a16-a437-f992db311123");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "45b367d8-9bdc-4589-8b57-9eee358f014b");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "62a9a81b-b226-4f6b-9212-a629c41f162e");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "0f43dc88-a427-4360-a16d-42cac375046e");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "2dd341f8-cb65-4f47-aa08-2acd1ac35087");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "a7417183-2193-4977-9a41-a89419da4bce");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "f45dfec0-295e-4c7c-9ea8-1ed09a4acf9e");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "60a38b4c-a233-42bd-a91b-2f06eb78e4c4");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "6150789a-662c-4db2-83c2-45fd5ffb6fb9");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "316ec4b2-87cf-4b6f-9a3f-45717069ba26");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "7b52efc6-9ff1-4e28-932e-a2df9c39049c");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "7bfa77f1-3257-46bc-9016-d65fdc098fa2");

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
        }
    }
}
