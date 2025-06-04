using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class FixloibangcleaningStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cleaningStatus_userInformation_userInformationuserId",
                table: "cleaningStatus");

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

            migrationBuilder.AlterColumn<string>(
                name: "userInformationuserId",
                table: "cleaningStatus",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_cleaningStatus_userInformation_userInformationuserId",
                table: "cleaningStatus",
                column: "userInformationuserId",
                principalTable: "userInformation",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cleaningStatus_userInformation_userInformationuserId",
                table: "cleaningStatus");

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

            migrationBuilder.AlterColumn<string>(
                name: "userInformationuserId",
                table: "cleaningStatus",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_cleaningStatus_userInformation_userInformationuserId",
                table: "cleaningStatus",
                column: "userInformationuserId",
                principalTable: "userInformation",
                principalColumn: "userId");
        }
    }
}
