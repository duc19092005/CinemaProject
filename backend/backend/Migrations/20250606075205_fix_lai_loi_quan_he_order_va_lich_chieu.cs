using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class fix_lai_loi_quan_he_order_va_lich_chieu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_orderDetail",
                table: "orderDetail");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "ae3f1f55-b58e-4398-b235-3ee82cb320d2");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "e149bd99-7ed1-41ee-ba53-17c5f2f91714");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "00935bc3-b521-4122-832d-4f46d46985da");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "0d14a2a2-cb4a-48cf-b669-0e7a204b87b9");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "4a78b5c3-b0f0-421b-89ae-72570a57cfb1");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "4ce82280-2a0c-46b5-b03e-f9e8e8b5d2fc");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "6f705707-d837-4ed3-b48d-ae003829efc6");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "7bd45a73-c5f8-498d-8155-d3a994b910c5");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "7daff206-bc8a-41ca-8f20-0b9a5d139955");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "d16517fd-6050-4e0a-a2fd-c6b5cf5c1e38");

            migrationBuilder.DeleteData(
                table: "cinemaMovieInformation",
                keyColumns: new[] { "cinemaId", "movieId" },
                keyValues: new object[] { "bb877280-1e43-4688-a8d8-ffea6ad704e3", "1ee11070-8614-485e-a78b-097eaf5a911f" });

            migrationBuilder.DeleteData(
                table: "cinemaMovieInformation",
                keyColumns: new[] { "cinemaId", "movieId" },
                keyValues: new object[] { "fbb36064-97d1-42b3-9b16-116cf149a173", "1ee11070-8614-485e-a78b-097eaf5a911f" });

            migrationBuilder.DeleteData(
                table: "cinemaMovieInformation",
                keyColumns: new[] { "cinemaId", "movieId" },
                keyValues: new object[] { "fbb36064-97d1-42b3-9b16-116cf149a173", "e69ba869-b158-44c7-9e7b-362c5c39e472" });

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "1e3e3b07-f107-4e7d-869d-9dc0159f2fbf");

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "c31c896d-719a-4647-878f-be5cad82bf90");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "7620804f-95fc-4f57-96a4-f333dc548190");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "d3489fc0-c68f-4860-96b8-0e6bf3e5f3a0");

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "409b5f12-64d3-4aa0-9d4e-5ec8aa671a66", "1ee11070-8614-485e-a78b-097eaf5a911f" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "be7947f6-8c78-4953-8347-bd718551b92f", "1ee11070-8614-485e-a78b-097eaf5a911f" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "be7947f6-8c78-4953-8347-bd718551b92f", "e69ba869-b158-44c7-9e7b-362c5c39e472" });

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "16245ed3-72f6-42ad-8886-45e2e0435255");

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "27290a34-6c38-48d4-8ec2-c8e2db54b21e");

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "9e69c976-0f3c-4381-a01a-5accd3774306");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "1e36b18b-1058-4f05-8835-fe96f38d95b7");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "b4545c0e-5f5d-404b-9e74-d5ca230710f1");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "c8ca4b47-2ec9-4536-a245-4ea9667235b7");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "db4be463-1bfb-4711-8948-42f2aedab6a4");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "3f88697f-e37a-4dc0-97dd-26e56d9da990");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "b31d6065-8e16-4d7a-a4f1-f371b525afea");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "e3edf2a3-fd9c-4c07-b6c7-f9c4ccf9bb2d");

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "d4131d23-8063-49ef-8bcb-9c0a7783c543", "d9712b0c-73c0-4288-8b84-fcd433c680c7" });

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "f57b7595-8680-4073-b8ff-92edb9fbee9f", "e6501a9e-72b4-46dc-8c92-fb0aa4d6f75c" });

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "644448a9-868c-4ddb-8734-878f04999fe3");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "e2f5b154-071a-4063-96f5-8c08f3c67c3a");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "127b0c72-1cef-4429-9813-ae4981df5387");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "9ff1eaed-9274-4948-a410-dd31cdc541c2");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "b76ce9fa-f53f-4826-bf97-9e4e4193d235");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "409b5f12-64d3-4aa0-9d4e-5ec8aa671a66");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "be7947f6-8c78-4953-8347-bd718551b92f");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "1ee11070-8614-485e-a78b-097eaf5a911f");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "e69ba869-b158-44c7-9e7b-362c5c39e472");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "d4131d23-8063-49ef-8bcb-9c0a7783c543");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "f57b7595-8680-4073-b8ff-92edb9fbee9f");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "d9712b0c-73c0-4288-8b84-fcd433c680c7");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "e6501a9e-72b4-46dc-8c92-fb0aa4d6f75c");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "d5628a2e-58dd-40ac-99ea-cbc2dda2fe45");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "ef2d1927-4f0e-4de4-9a77-4f3ed2b5e288");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "bb877280-1e43-4688-a8d8-ffea6ad704e3");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "fbb36064-97d1-42b3-9b16-116cf149a173");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "93731062-2181-4307-9f43-3fb10ff4e52d");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "67db943a-36a6-48ee-9411-3eab5d7aabdd");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "f2780c75-dbf2-4d82-b834-d18b241ae0bf");

            migrationBuilder.AddColumn<string>(
                name: "movieScheduleID",
                table: "orderDetail",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "isIMAXRoom",
                table: "cinemaRoom",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isSupportedIMAX",
                table: "Cinema",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderDetail",
                table: "orderDetail",
                columns: new[] { "orderId", "seatsId", "priceInformationId", "movieScheduleID" });

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
                name: "IX_orderDetail_movieScheduleID",
                table: "orderDetail",
                column: "movieScheduleID");

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetail_movieSchedule_movieScheduleID",
                table: "orderDetail",
                column: "movieScheduleID",
                principalTable: "movieSchedule",
                principalColumn: "movieScheduleId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderDetail_movieSchedule_movieScheduleID",
                table: "orderDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderDetail",
                table: "orderDetail");

            migrationBuilder.DropIndex(
                name: "IX_orderDetail_movieScheduleID",
                table: "orderDetail");

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
                name: "movieScheduleID",
                table: "orderDetail");

            migrationBuilder.DropColumn(
                name: "isIMAXRoom",
                table: "cinemaRoom");

            migrationBuilder.DropColumn(
                name: "isSupportedIMAX",
                table: "Cinema");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderDetail",
                table: "orderDetail",
                columns: new[] { "orderId", "seatsId", "priceInformationId" });

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "cinemaId", "cinemaContactHotlineNumber", "cinemaDescription", "cinemaLocation", "cinemaName" },
                values: new object[,]
                {
                    { "bb877280-1e43-4688-a8d8-ffea6ad704e3", "0907654321", "Comfortable seating and great sound system.", "12 Cantavil", "Lotte Cinema Cantavil" },
                    { "fbb36064-97d1-42b3-9b16-116cf149a173", "0901234567", "A modern cinema with multiple screens.", "19 Cao Thang", "Mega GS Cao Thang" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "languageId", "languageDetail" },
                values: new object[,]
                {
                    { "93731062-2181-4307-9f43-3fb10ff4e52d", "English" },
                    { "ae3f1f55-b58e-4398-b235-3ee82cb320d2", "Korean" },
                    { "e149bd99-7ed1-41ee-ba53-17c5f2f91714", "Vietnamese" }
                });

            migrationBuilder.InsertData(
                table: "foodInformation",
                columns: new[] { "foodInformationId", "foodInformationName", "foodPrice" },
                values: new object[,]
                {
                    { "1e3e3b07-f107-4e7d-869d-9dc0159f2fbf", "Popcorn Medium", 50000L },
                    { "c31c896d-719a-4647-878f-be5cad82bf90", "Coca-Cola", 30000L }
                });

            migrationBuilder.InsertData(
                table: "movieGenre",
                columns: new[] { "movieGenreId", "movieGenreName" },
                values: new object[,]
                {
                    { "409b5f12-64d3-4aa0-9d4e-5ec8aa671a66", "Drama" },
                    { "7620804f-95fc-4f57-96a4-f333dc548190", "Horror" },
                    { "be7947f6-8c78-4953-8347-bd718551b92f", "Action" },
                    { "d3489fc0-c68f-4860-96b8-0e6bf3e5f3a0", "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "movieVisualFormat",
                columns: new[] { "movieVisualFormatId", "movieVisualFormatName" },
                values: new object[,]
                {
                    { "1e36b18b-1058-4f05-8835-fe96f38d95b7", "IMAX" },
                    { "67db943a-36a6-48ee-9411-3eab5d7aabdd", "2D" },
                    { "f2780c75-dbf2-4d82-b834-d18b241ae0bf", "3D" }
                });

            migrationBuilder.InsertData(
                table: "roleInformation",
                columns: new[] { "roleId", "roleName" },
                values: new object[,]
                {
                    { "3f88697f-e37a-4dc0-97dd-26e56d9da990", "Cleaning Staff" },
                    { "b31d6065-8e16-4d7a-a4f1-f371b525afea", "Cashier Staff" },
                    { "d4131d23-8063-49ef-8bcb-9c0a7783c543", "Customer" },
                    { "e3edf2a3-fd9c-4c07-b6c7-f9c4ccf9bb2d", "Ticket Inspector Staff" },
                    { "f57b7595-8680-4073-b8ff-92edb9fbee9f", "Director" }
                });

            migrationBuilder.InsertData(
                table: "userInformation",
                columns: new[] { "userId", "IdentityCode", "dateOfBirth", "loginUserEmail", "loginUserPassword", "phoneNumber", "userName", "userPoint" },
                values: new object[,]
                {
                    { "d9712b0c-73c0-4288-8b84-fcd433c680c7", "012345678901", new DateTime(1995, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer1@example.com", "password123", "0987654321", "Nguyen Van A", 250 },
                    { "e6501a9e-72b4-46dc-8c92-fb0aa4d6f75c", "123456789012", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", "password123", "0912345678", "Admin User", 1000 }
                });

            migrationBuilder.InsertData(
                table: "userType",
                columns: new[] { "userTypeId", "userTypeDescription" },
                values: new object[,]
                {
                    { "644448a9-868c-4ddb-8734-878f04999fe3", "Student" },
                    { "d5628a2e-58dd-40ac-99ea-cbc2dda2fe45", "Child" },
                    { "e2f5b154-071a-4063-96f5-8c08f3c67c3a", "Senior" },
                    { "ef2d1927-4f0e-4de4-9a77-4f3ed2b5e288", "Adult" }
                });

            migrationBuilder.InsertData(
                table: "cinemaRoom",
                columns: new[] { "cinemaRoomId", "cinemaId", "cinemaRoomNumber" },
                values: new object[,]
                {
                    { "127b0c72-1cef-4429-9813-ae4981df5387", "bb877280-1e43-4688-a8d8-ffea6ad704e3", 1 },
                    { "9ff1eaed-9274-4948-a410-dd31cdc541c2", "fbb36064-97d1-42b3-9b16-116cf149a173", 1 },
                    { "b76ce9fa-f53f-4826-bf97-9e4e4193d235", "fbb36064-97d1-42b3-9b16-116cf149a173", 2 }
                });

            migrationBuilder.InsertData(
                table: "movieInformation",
                columns: new[] { "movieId", "languageId", "movieActor", "movieDescription", "movieDirector", "movieDuration", "movieImage", "movieName", "movieTrailerUrl", "movieVisualFormatId" },
                values: new object[,]
                {
                    { "1ee11070-8614-485e-a78b-097eaf5a911f", "93731062-2181-4307-9f43-3fb10ff4e52d", "Timothée Chalamet, Zendaya, Rebecca Ferguson", "Paul Atreides unites with Chani and the Fremen while seeking revenge against those who destroyed his family.", "Denis Villeneuve", 166, new byte[] { 100, 117, 110, 101, 50, 95, 105, 109, 97, 103, 101, 95, 112, 108, 97, 99, 101, 104, 111, 108, 100, 101, 114 }, "Dune: Part Two", "https://www.youtube.com/watch?v=Way9Dexny3w", "67db943a-36a6-48ee-9411-3eab5d7aabdd" },
                    { "e69ba869-b158-44c7-9e7b-362c5c39e472", "93731062-2181-4307-9f43-3fb10ff4e52d", "Rebecca Hall, Brian Tyree Henry, Dan Stevens", "Godzilla and Kong must unite to fight a colossal undiscovered threat hidden within our world.", "Adam Wingard", 115, new byte[] { 103, 111, 100, 122, 105, 108, 108, 97, 120, 107, 111, 110, 103, 95, 105, 109, 97, 103, 101, 95, 112, 108, 97, 99, 101, 104, 111, 108, 100, 101, 114 }, "Godzilla x Kong: The New Empire", "https://www.youtube.com/watch?v=EOk9z-WbN5o", "f2780c75-dbf2-4d82-b834-d18b241ae0bf" }
                });

            migrationBuilder.InsertData(
                table: "priceInformation",
                columns: new[] { "priceInformationId", "movieVisualFormatId", "priceAmount", "userTypeId" },
                values: new object[,]
                {
                    { "b4545c0e-5f5d-404b-9e74-d5ca230710f1", "67db943a-36a6-48ee-9411-3eab5d7aabdd", 70000L, "d5628a2e-58dd-40ac-99ea-cbc2dda2fe45" },
                    { "c8ca4b47-2ec9-4536-a245-4ea9667235b7", "67db943a-36a6-48ee-9411-3eab5d7aabdd", 100000L, "ef2d1927-4f0e-4de4-9a77-4f3ed2b5e288" },
                    { "db4be463-1bfb-4711-8948-42f2aedab6a4", "f2780c75-dbf2-4d82-b834-d18b241ae0bf", 130000L, "ef2d1927-4f0e-4de4-9a77-4f3ed2b5e288" }
                });

            migrationBuilder.InsertData(
                table: "userRoleInformation",
                columns: new[] { "roleId", "userId" },
                values: new object[,]
                {
                    { "d4131d23-8063-49ef-8bcb-9c0a7783c543", "d9712b0c-73c0-4288-8b84-fcd433c680c7" },
                    { "f57b7595-8680-4073-b8ff-92edb9fbee9f", "e6501a9e-72b4-46dc-8c92-fb0aa4d6f75c" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatsId", "cinemaRoomId", "isMiddle", "isTaken", "seatsNumber" },
                values: new object[,]
                {
                    { "00935bc3-b521-4122-832d-4f46d46985da", "9ff1eaed-9274-4948-a410-dd31cdc541c2", false, false, "B1" },
                    { "0d14a2a2-cb4a-48cf-b669-0e7a204b87b9", "b76ce9fa-f53f-4826-bf97-9e4e4193d235", true, false, "C1" },
                    { "4a78b5c3-b0f0-421b-89ae-72570a57cfb1", "9ff1eaed-9274-4948-a410-dd31cdc541c2", true, false, "A2" },
                    { "4ce82280-2a0c-46b5-b03e-f9e8e8b5d2fc", "9ff1eaed-9274-4948-a410-dd31cdc541c2", true, false, "A1" },
                    { "6f705707-d837-4ed3-b48d-ae003829efc6", "127b0c72-1cef-4429-9813-ae4981df5387", false, false, "D2" },
                    { "7bd45a73-c5f8-498d-8155-d3a994b910c5", "9ff1eaed-9274-4948-a410-dd31cdc541c2", false, false, "B2" },
                    { "7daff206-bc8a-41ca-8f20-0b9a5d139955", "127b0c72-1cef-4429-9813-ae4981df5387", true, false, "D1" },
                    { "d16517fd-6050-4e0a-a2fd-c6b5cf5c1e38", "b76ce9fa-f53f-4826-bf97-9e4e4193d235", false, false, "C2" }
                });

            migrationBuilder.InsertData(
                table: "cinemaMovieInformation",
                columns: new[] { "cinemaId", "movieId" },
                values: new object[,]
                {
                    { "bb877280-1e43-4688-a8d8-ffea6ad704e3", "1ee11070-8614-485e-a78b-097eaf5a911f" },
                    { "fbb36064-97d1-42b3-9b16-116cf149a173", "1ee11070-8614-485e-a78b-097eaf5a911f" },
                    { "fbb36064-97d1-42b3-9b16-116cf149a173", "e69ba869-b158-44c7-9e7b-362c5c39e472" }
                });

            migrationBuilder.InsertData(
                table: "movieGenreInformation",
                columns: new[] { "movieGenreId", "movieId" },
                values: new object[,]
                {
                    { "409b5f12-64d3-4aa0-9d4e-5ec8aa671a66", "1ee11070-8614-485e-a78b-097eaf5a911f" },
                    { "be7947f6-8c78-4953-8347-bd718551b92f", "1ee11070-8614-485e-a78b-097eaf5a911f" },
                    { "be7947f6-8c78-4953-8347-bd718551b92f", "e69ba869-b158-44c7-9e7b-362c5c39e472" }
                });

            migrationBuilder.InsertData(
                table: "movieSchedule",
                columns: new[] { "movieScheduleId", "cinemaRoomId", "movieId", "showDateTime" },
                values: new object[,]
                {
                    { "16245ed3-72f6-42ad-8886-45e2e0435255", "127b0c72-1cef-4429-9813-ae4981df5387", "1ee11070-8614-485e-a78b-097eaf5a911f", new DateTime(2025, 6, 6, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "27290a34-6c38-48d4-8ec2-c8e2db54b21e", "9ff1eaed-9274-4948-a410-dd31cdc541c2", "e69ba869-b158-44c7-9e7b-362c5c39e472", new DateTime(2025, 6, 5, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { "9e69c976-0f3c-4381-a01a-5accd3774306", "9ff1eaed-9274-4948-a410-dd31cdc541c2", "1ee11070-8614-485e-a78b-097eaf5a911f", new DateTime(2025, 6, 5, 10, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
