using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class update_lai_logic_chon_ghe_va_gia_khi_chon_ghe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_priceInformation_movieVisualFormat_movieVisualFormatId",
                table: "priceInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_priceInformation_userType_userTypeId",
                table: "priceInformation");

            migrationBuilder.DropIndex(
                name: "IX_priceInformation_movieVisualFormatId",
                table: "priceInformation");

            migrationBuilder.DropIndex(
                name: "IX_priceInformation_userTypeId",
                table: "priceInformation");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "829fc466-467a-48d1-b15e-094f62ebdb6f");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "b69a2654-a7ac-4c86-881f-d7a3bc35c25e");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "04efd62e-b1c8-4c15-ba35-099fc0a5a23e");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "1a4d8554-83b0-4bed-888a-e2abff6fcc51");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "1ee10d90-962a-4f43-9cbe-02c4198f8fd7");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "4fa895e8-28f9-44d2-8ea2-947c2a876a66");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "5da491a8-031c-4776-9651-2f48ede3da3b");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "9dc6929a-bbe0-43f5-98f5-8ba45c4b36e2");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "c6e53801-9cc5-4d72-8cdd-918524726fe6");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "ec09d81a-923d-44bd-9229-f67c231db9dd");

            migrationBuilder.DeleteData(
                table: "cinemaMovieInformation",
                keyColumns: new[] { "cinemaId", "movieId" },
                keyValues: new object[] { "bb698c11-2563-4a5c-b0b7-6fcaed4f4198", "90a52968-1803-4830-975a-bc6bc2cc1bc4" });

            migrationBuilder.DeleteData(
                table: "cinemaMovieInformation",
                keyColumns: new[] { "cinemaId", "movieId" },
                keyValues: new object[] { "bb698c11-2563-4a5c-b0b7-6fcaed4f4198", "c26bd955-282b-4442-9d16-9260b33e9767" });

            migrationBuilder.DeleteData(
                table: "cinemaMovieInformation",
                keyColumns: new[] { "cinemaId", "movieId" },
                keyValues: new object[] { "dfef449f-fbc9-4c42-bd2e-a03c640e713d", "c26bd955-282b-4442-9d16-9260b33e9767" });

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "70ec52f1-09ec-4737-8609-aebda2d140b5");

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "c8cf534a-5ca9-43c1-a741-de31c904402f");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "a08e36b9-d7c8-441a-8dcf-8da1725fb197");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "bfe5d6f5-7384-486e-9cf8-d7400ad1d3b3");

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "78f46894-626a-4ecd-b1cb-6744f05bdd78", "90a52968-1803-4830-975a-bc6bc2cc1bc4" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "57e7b3d8-52a2-4381-b706-6886a220b5aa", "c26bd955-282b-4442-9d16-9260b33e9767" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "78f46894-626a-4ecd-b1cb-6744f05bdd78", "c26bd955-282b-4442-9d16-9260b33e9767" });

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "412e2f36-4b71-4ce0-a7e9-08c6b8862320");

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "5fbc3459-e3dc-48f5-86e9-ff19a21fd64c");

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "fed5fc2f-ec2c-45e6-9d67-34f2d47d94ae");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "98d710aa-29b9-48c2-a68d-ae7595be3bb6");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "74025653-b274-4b00-b89d-d237befb5d79");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "7c7b52a9-90da-4954-acf5-a0c6e9602972");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "ecd98edd-c55a-4ebc-9447-87033a3e756c");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "8f234bc4-4cf8-4c9c-bc52-3c62b2d1afb0");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "d4d98450-b0f3-4ab4-b06c-3e0c3cd50af2");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "d6227927-eccf-4590-a9a1-0d8f4377eeea");

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "a042270e-6eb0-4fda-892c-c4bdbaf8f760", "f18938fa-2965-4b52-9359-52f3fadfa110" });

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "ba5cbad7-6826-44d6-9138-146fc16e1180", "f464b057-8d9f-448a-a795-af47f90c4aa3" });

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "82af00d6-8b5a-4a31-85cd-a7b225012bc9");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "a0d4198b-c9b3-4c25-afbf-82a726e63474");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "0a91a11d-2fd4-42b9-bbe5-8c4138c5ac12");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "4af944bb-4112-43f3-aee4-9801ad36c41f");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "dd15d331-f2e0-47ee-9f82-7d97842951b5");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "57e7b3d8-52a2-4381-b706-6886a220b5aa");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "78f46894-626a-4ecd-b1cb-6744f05bdd78");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "90a52968-1803-4830-975a-bc6bc2cc1bc4");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "c26bd955-282b-4442-9d16-9260b33e9767");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "a042270e-6eb0-4fda-892c-c4bdbaf8f760");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "ba5cbad7-6826-44d6-9138-146fc16e1180");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "f18938fa-2965-4b52-9359-52f3fadfa110");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "f464b057-8d9f-448a-a795-af47f90c4aa3");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "9b8b9a79-5b46-4e96-9732-6cdf43049d6e");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "e39198f1-60b6-416a-96ad-f15359808202");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "bb698c11-2563-4a5c-b0b7-6fcaed4f4198");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "dfef449f-fbc9-4c42-bd2e-a03c640e713d");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "a5772b69-0596-4d0e-98fc-66d9b033f163");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "81ffdf8f-b3c4-4b10-b9c8-2ebb6727c759");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "fc30fed4-3cce-4388-8797-c134c3b0827c");

            migrationBuilder.DropColumn(
                name: "movieVisualFormatId",
                table: "priceInformation");

            migrationBuilder.DropColumn(
                name: "userTypeId",
                table: "priceInformation");

            migrationBuilder.CreateTable(
                name: "priceInformationForEachUserFilmType",
                columns: table => new
                {
                    userTypeId = table.Column<string>(type: "varchar(100)", nullable: false),
                    movieVisualFormatId = table.Column<string>(type: "varchar(100)", nullable: false),
                    priceInformationID = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_priceInformationForEachUserFilmType", x => new { x.userTypeId, x.movieVisualFormatId, x.priceInformationID });
                    table.ForeignKey(
                        name: "FK_priceInformationForEachUserFilmType_movieVisualFormat_movieVisualFormatId",
                        column: x => x.movieVisualFormatId,
                        principalTable: "movieVisualFormat",
                        principalColumn: "movieVisualFormatId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_priceInformationForEachUserFilmType_priceInformation_priceInformationID",
                        column: x => x.priceInformationID,
                        principalTable: "priceInformation",
                        principalColumn: "priceInformationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_priceInformationForEachUserFilmType_userType_userTypeId",
                        column: x => x.userTypeId,
                        principalTable: "userType",
                        principalColumn: "userTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "cinemaId", "cinemaContactHotlineNumber", "cinemaDescription", "cinemaLocation", "cinemaName", "isSupportedIMAX" },
                values: new object[,]
                {
                    { "6f9ca402-d953-462b-ab12-b28b05a49808", "0901234567", "A modern cinema with multiple screens.", "19 Cao Thang", "Mega GS Cao Thang", false },
                    { "8abd9fb0-1947-42e6-a662-aac5706e98fe", "0907654321", "Comfortable seating and great sound system.", "12 Cantavil", "Lotte Cinema Cantavil", false }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "languageId", "languageDetail" },
                values: new object[,]
                {
                    { "2e2daf74-000b-4ab5-ac6f-f8df49ed5b34", "English" },
                    { "3cdd89a3-6e98-4437-a8df-d5fc859f8f60", "Vietnamese" },
                    { "d156ab5f-dad9-4e78-a576-03bf709b0443", "Korean" }
                });

            migrationBuilder.InsertData(
                table: "foodInformation",
                columns: new[] { "foodInformationId", "foodInformationName", "foodPrice" },
                values: new object[,]
                {
                    { "9cf3f1db-69cf-4f01-a2e4-58781fb1249c", "Coca-Cola", 30000L },
                    { "e11763e8-b991-4099-80cc-a0f95b4272e7", "Popcorn Medium", 50000L }
                });

            migrationBuilder.InsertData(
                table: "movieGenre",
                columns: new[] { "movieGenreId", "movieGenreName" },
                values: new object[,]
                {
                    { "07d8e8f7-e1e2-468d-840b-3487f85d70d3", "Action" },
                    { "14022b98-5fa7-4ce6-b2ec-b957c37f46ef", "Comedy" },
                    { "3bfc07cd-8d34-4410-bcc5-dfb9b874dbd3", "Horror" },
                    { "9c6c54c2-ac9e-475f-bfff-316a92f19fa4", "Drama" }
                });

            migrationBuilder.InsertData(
                table: "movieVisualFormat",
                columns: new[] { "movieVisualFormatId", "movieVisualFormatName" },
                values: new object[,]
                {
                    { "4d5b13c5-729b-41c5-817e-63fad594b511", "3D" },
                    { "73cff8ce-a1c7-4d17-973e-d31af723b8d6", "IMAX" },
                    { "cccf7edc-d930-4265-bc74-95fdf795df0a", "2D" }
                });

            migrationBuilder.InsertData(
                table: "priceInformation",
                columns: new[] { "priceInformationId", "priceAmount" },
                values: new object[,]
                {
                    { "012d26d4-64d8-4be0-a82e-144870612d1e", 70000L },
                    { "e9c3be04-3a96-45d0-8788-aafeee40e212", 45000L }
                });

            migrationBuilder.InsertData(
                table: "roleInformation",
                columns: new[] { "roleId", "roleName" },
                values: new object[,]
                {
                    { "1d77d2f0-600a-4685-95c4-b52356a63b83", "Customer" },
                    { "770ea04c-3df4-4894-b335-4bba0086d50d", "Ticket Inspector Staff" },
                    { "79afc6a3-199d-4e22-9950-fdbaf533057f", "Cashier Staff" },
                    { "a675c84c-1f54-4a85-89e6-7bf17e39fca8", "Cleaning Staff" },
                    { "d68db154-9b91-4add-a7ce-ea3ec61e65de", "Director" }
                });

            migrationBuilder.InsertData(
                table: "userInformation",
                columns: new[] { "userId", "IdentityCode", "dateOfBirth", "loginUserEmail", "loginUserPassword", "phoneNumber", "userName", "userPoint" },
                values: new object[,]
                {
                    { "150f4638-f39e-4c61-bd59-18ec3d90b492", "123456789012", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", "password123", "0912345678", "Admin User", 1000 },
                    { "bfdbb6d6-aba6-44d8-930e-e17d6e7b5d3d", "012345678901", new DateTime(1995, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer1@example.com", "password123", "0987654321", "Nguyen Van A", 250 }
                });

            migrationBuilder.InsertData(
                table: "userType",
                columns: new[] { "userTypeId", "userTypeDescription" },
                values: new object[,]
                {
                    { "5092cc44-56d1-4480-9772-72bfc4b7aa62", "Senior" },
                    { "55e04c66-5e7a-4fbc-98cd-34b04c17a585", "Child" },
                    { "91928de1-daea-4f8f-973f-68b5ba5568ac", "Adult" },
                    { "c9f77688-5df2-4ea8-92d2-9b3172434d18", "Student" }
                });

            migrationBuilder.InsertData(
                table: "cinemaRoom",
                columns: new[] { "cinemaRoomId", "cinemaId", "cinemaRoomNumber", "isIMAXRoom" },
                values: new object[,]
                {
                    { "61b5b1a8-8660-4332-8e96-08de8fa569ee", "6f9ca402-d953-462b-ab12-b28b05a49808", 1, false },
                    { "b19c0048-288d-400a-a9ea-e914667c69e9", "6f9ca402-d953-462b-ab12-b28b05a49808", 2, false },
                    { "f3fa182b-2a5f-4498-9802-b508c0f30957", "8abd9fb0-1947-42e6-a662-aac5706e98fe", 1, false }
                });

            migrationBuilder.InsertData(
                table: "movieInformation",
                columns: new[] { "movieId", "languageId", "movieActor", "movieDescription", "movieDirector", "movieDuration", "movieImage", "movieName", "movieTrailerUrl", "movieVisualFormatId" },
                values: new object[,]
                {
                    { "7ee0a915-9de4-44b2-8ae9-6dfb125e1885", "2e2daf74-000b-4ab5-ac6f-f8df49ed5b34", "Rebecca Hall, Brian Tyree Henry, Dan Stevens", "Godzilla and Kong must unite to fight a colossal undiscovered threat hidden within our world.", "Adam Wingard", 115, new byte[] { 103, 111, 100, 122, 105, 108, 108, 97, 120, 107, 111, 110, 103, 95, 105, 109, 97, 103, 101, 95, 112, 108, 97, 99, 101, 104, 111, 108, 100, 101, 114 }, "Godzilla x Kong: The New Empire", "https://www.youtube.com/watch?v=EOk9z-WbN5o", "4d5b13c5-729b-41c5-817e-63fad594b511" },
                    { "d90614a1-418e-4df4-b536-d9cbfadc5137", "2e2daf74-000b-4ab5-ac6f-f8df49ed5b34", "Timothée Chalamet, Zendaya, Rebecca Ferguson", "Paul Atreides unites with Chani and the Fremen while seeking revenge against those who destroyed his family.", "Denis Villeneuve", 166, new byte[] { 100, 117, 110, 101, 50, 95, 105, 109, 97, 103, 101, 95, 112, 108, 97, 99, 101, 104, 111, 108, 100, 101, 114 }, "Dune: Part Two", "https://www.youtube.com/watch?v=Way9Dexny3w", "cccf7edc-d930-4265-bc74-95fdf795df0a" }
                });

            migrationBuilder.InsertData(
                table: "userRoleInformation",
                columns: new[] { "roleId", "userId" },
                values: new object[,]
                {
                    { "1d77d2f0-600a-4685-95c4-b52356a63b83", "bfdbb6d6-aba6-44d8-930e-e17d6e7b5d3d" },
                    { "d68db154-9b91-4add-a7ce-ea3ec61e65de", "150f4638-f39e-4c61-bd59-18ec3d90b492" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatsId", "cinemaRoomId", "isMiddle", "isTaken", "seatsNumber" },
                values: new object[,]
                {
                    { "0205defa-f115-4812-b381-817cbaca9ea1", "61b5b1a8-8660-4332-8e96-08de8fa569ee", false, false, "B2" },
                    { "098e0dcd-7ff8-45e2-a554-e66ea37d68d9", "f3fa182b-2a5f-4498-9802-b508c0f30957", true, false, "D1" },
                    { "279e7272-551d-457b-b749-47f82da8730d", "61b5b1a8-8660-4332-8e96-08de8fa569ee", true, false, "A2" },
                    { "2d40c43c-b29f-498d-a14d-84a79dbd816f", "b19c0048-288d-400a-a9ea-e914667c69e9", true, false, "C1" },
                    { "60edb564-2ace-4040-9db6-c7a8a899ab92", "61b5b1a8-8660-4332-8e96-08de8fa569ee", true, false, "A1" },
                    { "82729a94-56dd-4205-b9af-1335bcc913e3", "61b5b1a8-8660-4332-8e96-08de8fa569ee", false, false, "B1" },
                    { "c6c80b3e-fdb8-474f-a2ab-e65df51f4f51", "f3fa182b-2a5f-4498-9802-b508c0f30957", false, false, "D2" },
                    { "db657faf-1059-4925-a825-5b37832e3bb3", "b19c0048-288d-400a-a9ea-e914667c69e9", false, false, "C2" }
                });

            migrationBuilder.InsertData(
                table: "cinemaMovieInformation",
                columns: new[] { "cinemaId", "movieId" },
                values: new object[,]
                {
                    { "6f9ca402-d953-462b-ab12-b28b05a49808", "7ee0a915-9de4-44b2-8ae9-6dfb125e1885" },
                    { "6f9ca402-d953-462b-ab12-b28b05a49808", "d90614a1-418e-4df4-b536-d9cbfadc5137" },
                    { "8abd9fb0-1947-42e6-a662-aac5706e98fe", "d90614a1-418e-4df4-b536-d9cbfadc5137" }
                });

            migrationBuilder.InsertData(
                table: "movieGenreInformation",
                columns: new[] { "movieGenreId", "movieId" },
                values: new object[,]
                {
                    { "07d8e8f7-e1e2-468d-840b-3487f85d70d3", "7ee0a915-9de4-44b2-8ae9-6dfb125e1885" },
                    { "07d8e8f7-e1e2-468d-840b-3487f85d70d3", "d90614a1-418e-4df4-b536-d9cbfadc5137" },
                    { "9c6c54c2-ac9e-475f-bfff-316a92f19fa4", "d90614a1-418e-4df4-b536-d9cbfadc5137" }
                });

            migrationBuilder.InsertData(
                table: "movieSchedule",
                columns: new[] { "movieScheduleId", "cinemaRoomId", "movieId", "showDateTime" },
                values: new object[,]
                {
                    { "0ad4b2f0-c434-4e36-9c71-2cde3c752879", "61b5b1a8-8660-4332-8e96-08de8fa569ee", "d90614a1-418e-4df4-b536-d9cbfadc5137", new DateTime(2025, 6, 5, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "c4671773-8394-4719-add3-80888ebc9ce9", "f3fa182b-2a5f-4498-9802-b508c0f30957", "d90614a1-418e-4df4-b536-d9cbfadc5137", new DateTime(2025, 6, 6, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "f6fbb8ac-a9c8-47a4-89a2-b758486f7ebc", "61b5b1a8-8660-4332-8e96-08de8fa569ee", "7ee0a915-9de4-44b2-8ae9-6dfb125e1885", new DateTime(2025, 6, 5, 14, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_priceInformationForEachUserFilmType_movieVisualFormatId",
                table: "priceInformationForEachUserFilmType",
                column: "movieVisualFormatId");

            migrationBuilder.CreateIndex(
                name: "IX_priceInformationForEachUserFilmType_priceInformationID",
                table: "priceInformationForEachUserFilmType",
                column: "priceInformationID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "priceInformationForEachUserFilmType");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "3cdd89a3-6e98-4437-a8df-d5fc859f8f60");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "d156ab5f-dad9-4e78-a576-03bf709b0443");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "0205defa-f115-4812-b381-817cbaca9ea1");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "098e0dcd-7ff8-45e2-a554-e66ea37d68d9");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "279e7272-551d-457b-b749-47f82da8730d");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "2d40c43c-b29f-498d-a14d-84a79dbd816f");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "60edb564-2ace-4040-9db6-c7a8a899ab92");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "82729a94-56dd-4205-b9af-1335bcc913e3");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "c6c80b3e-fdb8-474f-a2ab-e65df51f4f51");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "db657faf-1059-4925-a825-5b37832e3bb3");

            migrationBuilder.DeleteData(
                table: "cinemaMovieInformation",
                keyColumns: new[] { "cinemaId", "movieId" },
                keyValues: new object[] { "6f9ca402-d953-462b-ab12-b28b05a49808", "7ee0a915-9de4-44b2-8ae9-6dfb125e1885" });

            migrationBuilder.DeleteData(
                table: "cinemaMovieInformation",
                keyColumns: new[] { "cinemaId", "movieId" },
                keyValues: new object[] { "6f9ca402-d953-462b-ab12-b28b05a49808", "d90614a1-418e-4df4-b536-d9cbfadc5137" });

            migrationBuilder.DeleteData(
                table: "cinemaMovieInformation",
                keyColumns: new[] { "cinemaId", "movieId" },
                keyValues: new object[] { "8abd9fb0-1947-42e6-a662-aac5706e98fe", "d90614a1-418e-4df4-b536-d9cbfadc5137" });

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "9cf3f1db-69cf-4f01-a2e4-58781fb1249c");

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "e11763e8-b991-4099-80cc-a0f95b4272e7");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "14022b98-5fa7-4ce6-b2ec-b957c37f46ef");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "3bfc07cd-8d34-4410-bcc5-dfb9b874dbd3");

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "07d8e8f7-e1e2-468d-840b-3487f85d70d3", "7ee0a915-9de4-44b2-8ae9-6dfb125e1885" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "07d8e8f7-e1e2-468d-840b-3487f85d70d3", "d90614a1-418e-4df4-b536-d9cbfadc5137" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "9c6c54c2-ac9e-475f-bfff-316a92f19fa4", "d90614a1-418e-4df4-b536-d9cbfadc5137" });

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "0ad4b2f0-c434-4e36-9c71-2cde3c752879");

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "c4671773-8394-4719-add3-80888ebc9ce9");

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "f6fbb8ac-a9c8-47a4-89a2-b758486f7ebc");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "73cff8ce-a1c7-4d17-973e-d31af723b8d6");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "012d26d4-64d8-4be0-a82e-144870612d1e");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "e9c3be04-3a96-45d0-8788-aafeee40e212");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "770ea04c-3df4-4894-b335-4bba0086d50d");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "79afc6a3-199d-4e22-9950-fdbaf533057f");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "a675c84c-1f54-4a85-89e6-7bf17e39fca8");

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "1d77d2f0-600a-4685-95c4-b52356a63b83", "bfdbb6d6-aba6-44d8-930e-e17d6e7b5d3d" });

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "d68db154-9b91-4add-a7ce-ea3ec61e65de", "150f4638-f39e-4c61-bd59-18ec3d90b492" });

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "5092cc44-56d1-4480-9772-72bfc4b7aa62");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "55e04c66-5e7a-4fbc-98cd-34b04c17a585");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "91928de1-daea-4f8f-973f-68b5ba5568ac");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "c9f77688-5df2-4ea8-92d2-9b3172434d18");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "61b5b1a8-8660-4332-8e96-08de8fa569ee");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "b19c0048-288d-400a-a9ea-e914667c69e9");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "f3fa182b-2a5f-4498-9802-b508c0f30957");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "07d8e8f7-e1e2-468d-840b-3487f85d70d3");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "9c6c54c2-ac9e-475f-bfff-316a92f19fa4");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "7ee0a915-9de4-44b2-8ae9-6dfb125e1885");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "d90614a1-418e-4df4-b536-d9cbfadc5137");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "1d77d2f0-600a-4685-95c4-b52356a63b83");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "d68db154-9b91-4add-a7ce-ea3ec61e65de");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "150f4638-f39e-4c61-bd59-18ec3d90b492");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "bfdbb6d6-aba6-44d8-930e-e17d6e7b5d3d");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "6f9ca402-d953-462b-ab12-b28b05a49808");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "8abd9fb0-1947-42e6-a662-aac5706e98fe");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "2e2daf74-000b-4ab5-ac6f-f8df49ed5b34");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "4d5b13c5-729b-41c5-817e-63fad594b511");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "cccf7edc-d930-4265-bc74-95fdf795df0a");

            migrationBuilder.AddColumn<string>(
                name: "movieVisualFormatId",
                table: "priceInformation",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "userTypeId",
                table: "priceInformation",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "cinemaId", "cinemaContactHotlineNumber", "cinemaDescription", "cinemaLocation", "cinemaName", "isSupportedIMAX" },
                values: new object[,]
                {
                    { "bb698c11-2563-4a5c-b0b7-6fcaed4f4198", "0901234567", "A modern cinema with multiple screens.", "19 Cao Thang", "Mega GS Cao Thang", false },
                    { "dfef449f-fbc9-4c42-bd2e-a03c640e713d", "0907654321", "Comfortable seating and great sound system.", "12 Cantavil", "Lotte Cinema Cantavil", false }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "languageId", "languageDetail" },
                values: new object[,]
                {
                    { "829fc466-467a-48d1-b15e-094f62ebdb6f", "Korean" },
                    { "a5772b69-0596-4d0e-98fc-66d9b033f163", "English" },
                    { "b69a2654-a7ac-4c86-881f-d7a3bc35c25e", "Vietnamese" }
                });

            migrationBuilder.InsertData(
                table: "foodInformation",
                columns: new[] { "foodInformationId", "foodInformationName", "foodPrice" },
                values: new object[,]
                {
                    { "70ec52f1-09ec-4737-8609-aebda2d140b5", "Popcorn Medium", 50000L },
                    { "c8cf534a-5ca9-43c1-a741-de31c904402f", "Coca-Cola", 30000L }
                });

            migrationBuilder.InsertData(
                table: "movieGenre",
                columns: new[] { "movieGenreId", "movieGenreName" },
                values: new object[,]
                {
                    { "57e7b3d8-52a2-4381-b706-6886a220b5aa", "Drama" },
                    { "78f46894-626a-4ecd-b1cb-6744f05bdd78", "Action" },
                    { "a08e36b9-d7c8-441a-8dcf-8da1725fb197", "Comedy" },
                    { "bfe5d6f5-7384-486e-9cf8-d7400ad1d3b3", "Horror" }
                });

            migrationBuilder.InsertData(
                table: "movieVisualFormat",
                columns: new[] { "movieVisualFormatId", "movieVisualFormatName" },
                values: new object[,]
                {
                    { "81ffdf8f-b3c4-4b10-b9c8-2ebb6727c759", "2D" },
                    { "98d710aa-29b9-48c2-a68d-ae7595be3bb6", "IMAX" },
                    { "fc30fed4-3cce-4388-8797-c134c3b0827c", "3D" }
                });

            migrationBuilder.InsertData(
                table: "roleInformation",
                columns: new[] { "roleId", "roleName" },
                values: new object[,]
                {
                    { "8f234bc4-4cf8-4c9c-bc52-3c62b2d1afb0", "Cashier Staff" },
                    { "a042270e-6eb0-4fda-892c-c4bdbaf8f760", "Customer" },
                    { "ba5cbad7-6826-44d6-9138-146fc16e1180", "Director" },
                    { "d4d98450-b0f3-4ab4-b06c-3e0c3cd50af2", "Ticket Inspector Staff" },
                    { "d6227927-eccf-4590-a9a1-0d8f4377eeea", "Cleaning Staff" }
                });

            migrationBuilder.InsertData(
                table: "userInformation",
                columns: new[] { "userId", "IdentityCode", "dateOfBirth", "loginUserEmail", "loginUserPassword", "phoneNumber", "userName", "userPoint" },
                values: new object[,]
                {
                    { "f18938fa-2965-4b52-9359-52f3fadfa110", "012345678901", new DateTime(1995, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer1@example.com", "password123", "0987654321", "Nguyen Van A", 250 },
                    { "f464b057-8d9f-448a-a795-af47f90c4aa3", "123456789012", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", "password123", "0912345678", "Admin User", 1000 }
                });

            migrationBuilder.InsertData(
                table: "userType",
                columns: new[] { "userTypeId", "userTypeDescription" },
                values: new object[,]
                {
                    { "82af00d6-8b5a-4a31-85cd-a7b225012bc9", "Senior" },
                    { "9b8b9a79-5b46-4e96-9732-6cdf43049d6e", "Adult" },
                    { "a0d4198b-c9b3-4c25-afbf-82a726e63474", "Student" },
                    { "e39198f1-60b6-416a-96ad-f15359808202", "Child" }
                });

            migrationBuilder.InsertData(
                table: "cinemaRoom",
                columns: new[] { "cinemaRoomId", "cinemaId", "cinemaRoomNumber", "isIMAXRoom" },
                values: new object[,]
                {
                    { "0a91a11d-2fd4-42b9-bbe5-8c4138c5ac12", "dfef449f-fbc9-4c42-bd2e-a03c640e713d", 1, false },
                    { "4af944bb-4112-43f3-aee4-9801ad36c41f", "bb698c11-2563-4a5c-b0b7-6fcaed4f4198", 2, false },
                    { "dd15d331-f2e0-47ee-9f82-7d97842951b5", "bb698c11-2563-4a5c-b0b7-6fcaed4f4198", 1, false }
                });

            migrationBuilder.InsertData(
                table: "movieInformation",
                columns: new[] { "movieId", "languageId", "movieActor", "movieDescription", "movieDirector", "movieDuration", "movieImage", "movieName", "movieTrailerUrl", "movieVisualFormatId" },
                values: new object[,]
                {
                    { "90a52968-1803-4830-975a-bc6bc2cc1bc4", "a5772b69-0596-4d0e-98fc-66d9b033f163", "Rebecca Hall, Brian Tyree Henry, Dan Stevens", "Godzilla and Kong must unite to fight a colossal undiscovered threat hidden within our world.", "Adam Wingard", 115, new byte[] { 103, 111, 100, 122, 105, 108, 108, 97, 120, 107, 111, 110, 103, 95, 105, 109, 97, 103, 101, 95, 112, 108, 97, 99, 101, 104, 111, 108, 100, 101, 114 }, "Godzilla x Kong: The New Empire", "https://www.youtube.com/watch?v=EOk9z-WbN5o", "fc30fed4-3cce-4388-8797-c134c3b0827c" },
                    { "c26bd955-282b-4442-9d16-9260b33e9767", "a5772b69-0596-4d0e-98fc-66d9b033f163", "Timothée Chalamet, Zendaya, Rebecca Ferguson", "Paul Atreides unites with Chani and the Fremen while seeking revenge against those who destroyed his family.", "Denis Villeneuve", 166, new byte[] { 100, 117, 110, 101, 50, 95, 105, 109, 97, 103, 101, 95, 112, 108, 97, 99, 101, 104, 111, 108, 100, 101, 114 }, "Dune: Part Two", "https://www.youtube.com/watch?v=Way9Dexny3w", "81ffdf8f-b3c4-4b10-b9c8-2ebb6727c759" }
                });

            migrationBuilder.InsertData(
                table: "priceInformation",
                columns: new[] { "priceInformationId", "movieVisualFormatId", "priceAmount", "userTypeId" },
                values: new object[,]
                {
                    { "74025653-b274-4b00-b89d-d237befb5d79", "fc30fed4-3cce-4388-8797-c134c3b0827c", 130000L, "9b8b9a79-5b46-4e96-9732-6cdf43049d6e" },
                    { "7c7b52a9-90da-4954-acf5-a0c6e9602972", "81ffdf8f-b3c4-4b10-b9c8-2ebb6727c759", 70000L, "e39198f1-60b6-416a-96ad-f15359808202" },
                    { "ecd98edd-c55a-4ebc-9447-87033a3e756c", "81ffdf8f-b3c4-4b10-b9c8-2ebb6727c759", 100000L, "9b8b9a79-5b46-4e96-9732-6cdf43049d6e" }
                });

            migrationBuilder.InsertData(
                table: "userRoleInformation",
                columns: new[] { "roleId", "userId" },
                values: new object[,]
                {
                    { "a042270e-6eb0-4fda-892c-c4bdbaf8f760", "f18938fa-2965-4b52-9359-52f3fadfa110" },
                    { "ba5cbad7-6826-44d6-9138-146fc16e1180", "f464b057-8d9f-448a-a795-af47f90c4aa3" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatsId", "cinemaRoomId", "isMiddle", "isTaken", "seatsNumber" },
                values: new object[,]
                {
                    { "04efd62e-b1c8-4c15-ba35-099fc0a5a23e", "dd15d331-f2e0-47ee-9f82-7d97842951b5", true, false, "A2" },
                    { "1a4d8554-83b0-4bed-888a-e2abff6fcc51", "dd15d331-f2e0-47ee-9f82-7d97842951b5", false, false, "B1" },
                    { "1ee10d90-962a-4f43-9cbe-02c4198f8fd7", "4af944bb-4112-43f3-aee4-9801ad36c41f", true, false, "C1" },
                    { "4fa895e8-28f9-44d2-8ea2-947c2a876a66", "dd15d331-f2e0-47ee-9f82-7d97842951b5", false, false, "B2" },
                    { "5da491a8-031c-4776-9651-2f48ede3da3b", "dd15d331-f2e0-47ee-9f82-7d97842951b5", true, false, "A1" },
                    { "9dc6929a-bbe0-43f5-98f5-8ba45c4b36e2", "0a91a11d-2fd4-42b9-bbe5-8c4138c5ac12", true, false, "D1" },
                    { "c6e53801-9cc5-4d72-8cdd-918524726fe6", "4af944bb-4112-43f3-aee4-9801ad36c41f", false, false, "C2" },
                    { "ec09d81a-923d-44bd-9229-f67c231db9dd", "0a91a11d-2fd4-42b9-bbe5-8c4138c5ac12", false, false, "D2" }
                });

            migrationBuilder.InsertData(
                table: "cinemaMovieInformation",
                columns: new[] { "cinemaId", "movieId" },
                values: new object[,]
                {
                    { "bb698c11-2563-4a5c-b0b7-6fcaed4f4198", "90a52968-1803-4830-975a-bc6bc2cc1bc4" },
                    { "bb698c11-2563-4a5c-b0b7-6fcaed4f4198", "c26bd955-282b-4442-9d16-9260b33e9767" },
                    { "dfef449f-fbc9-4c42-bd2e-a03c640e713d", "c26bd955-282b-4442-9d16-9260b33e9767" }
                });

            migrationBuilder.InsertData(
                table: "movieGenreInformation",
                columns: new[] { "movieGenreId", "movieId" },
                values: new object[,]
                {
                    { "78f46894-626a-4ecd-b1cb-6744f05bdd78", "90a52968-1803-4830-975a-bc6bc2cc1bc4" },
                    { "57e7b3d8-52a2-4381-b706-6886a220b5aa", "c26bd955-282b-4442-9d16-9260b33e9767" },
                    { "78f46894-626a-4ecd-b1cb-6744f05bdd78", "c26bd955-282b-4442-9d16-9260b33e9767" }
                });

            migrationBuilder.InsertData(
                table: "movieSchedule",
                columns: new[] { "movieScheduleId", "cinemaRoomId", "movieId", "showDateTime" },
                values: new object[,]
                {
                    { "412e2f36-4b71-4ce0-a7e9-08c6b8862320", "0a91a11d-2fd4-42b9-bbe5-8c4138c5ac12", "c26bd955-282b-4442-9d16-9260b33e9767", new DateTime(2025, 6, 6, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "5fbc3459-e3dc-48f5-86e9-ff19a21fd64c", "dd15d331-f2e0-47ee-9f82-7d97842951b5", "c26bd955-282b-4442-9d16-9260b33e9767", new DateTime(2025, 6, 5, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "fed5fc2f-ec2c-45e6-9d67-34f2d47d94ae", "dd15d331-f2e0-47ee-9f82-7d97842951b5", "90a52968-1803-4830-975a-bc6bc2cc1bc4", new DateTime(2025, 6, 5, 14, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_priceInformation_movieVisualFormatId",
                table: "priceInformation",
                column: "movieVisualFormatId");

            migrationBuilder.CreateIndex(
                name: "IX_priceInformation_userTypeId",
                table: "priceInformation",
                column: "userTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_priceInformation_movieVisualFormat_movieVisualFormatId",
                table: "priceInformation",
                column: "movieVisualFormatId",
                principalTable: "movieVisualFormat",
                principalColumn: "movieVisualFormatId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_priceInformation_userType_userTypeId",
                table: "priceInformation",
                column: "userTypeId",
                principalTable: "userType",
                principalColumn: "userTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
