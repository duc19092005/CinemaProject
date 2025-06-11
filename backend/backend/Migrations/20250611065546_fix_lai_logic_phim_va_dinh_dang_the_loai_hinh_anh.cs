using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class fix_lai_logic_phim_va_dinh_dang_the_loai_hinh_anh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movieInformation_movieVisualFormat_movieVisualFormatId",
                table: "movieInformation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderDetail",
                table: "orderDetail");

            migrationBuilder.DropIndex(
                name: "IX_orderDetail_seatsId",
                table: "orderDetail");

            migrationBuilder.DropIndex(
                name: "IX_movieInformation_movieVisualFormatId",
                table: "movieInformation");

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

            migrationBuilder.DropColumn(
                name: "movieVisualFormatId",
                table: "movieInformation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderDetail",
                table: "orderDetail",
                columns: new[] { "seatsId", "movieScheduleID" });

            migrationBuilder.CreateTable(
                name: "movieVisualFormatDetail",
                columns: table => new
                {
                    movieId = table.Column<string>(type: "varchar(100)", nullable: false),
                    movieVisualFormatId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieVisualFormatDetail", x => new { x.movieId, x.movieVisualFormatId });
                    table.ForeignKey(
                        name: "FK_movieVisualFormatDetail_movieInformation_movieId",
                        column: x => x.movieId,
                        principalTable: "movieInformation",
                        principalColumn: "movieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movieVisualFormatDetail_movieVisualFormat_movieVisualFormatId",
                        column: x => x.movieVisualFormatId,
                        principalTable: "movieVisualFormat",
                        principalColumn: "movieVisualFormatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "cinemaId", "cinemaContactHotlineNumber", "cinemaDescription", "cinemaLocation", "cinemaName", "isSupportedIMAX" },
                values: new object[,]
                {
                    { "3254e5a3-cb1d-45c2-996c-bc33860735e5", "0907654321", "Comfortable seating and great sound system.", "12 Cantavil", "Lotte Cinema Cantavil", false },
                    { "b2630aae-dbb9-484a-8f79-739f4a59c503", "0901234567", "A modern cinema with multiple screens.", "19 Cao Thang", "Mega GS Cao Thang", false }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "languageId", "languageDetail" },
                values: new object[,]
                {
                    { "3554de3e-5218-474b-b33f-bf945a5ee9cd", "English" },
                    { "8e9fe372-2805-4684-9c78-7d70c738633c", "Vietnamese" },
                    { "ffaaa0f3-d3d5-4fb5-b5ab-e8c8d95616db", "Korean" }
                });

            migrationBuilder.InsertData(
                table: "foodInformation",
                columns: new[] { "foodInformationId", "foodInformationName", "foodPrice" },
                values: new object[,]
                {
                    { "761bfbed-9895-4eec-9896-e726cd5c18d7", "Coca-Cola", 30000L },
                    { "9b820f95-5680-405d-b525-e82f88052abf", "Popcorn Medium", 50000L }
                });

            migrationBuilder.InsertData(
                table: "movieGenre",
                columns: new[] { "movieGenreId", "movieGenreName" },
                values: new object[,]
                {
                    { "18cef6c0-7505-408d-9430-3c69668d901d", "Action" },
                    { "c48b7434-d458-4585-8d25-b7a8d37122ca", "Drama" },
                    { "cc36fa8c-0f84-4057-86d1-6153dcabba5b", "Horror" },
                    { "e1349368-604c-4be9-a172-1ad2bc2b6990", "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "movieVisualFormat",
                columns: new[] { "movieVisualFormatId", "movieVisualFormatName" },
                values: new object[,]
                {
                    { "04b58e6a-d65c-43b9-a4f1-3d97a4cd9a09", "IMAX" },
                    { "c1a47ecd-9823-444b-9f66-4c51fcd06e92", "3D" },
                    { "f8624e60-1587-4ed6-aadd-c102bd1c445d", "2D" }
                });

            migrationBuilder.InsertData(
                table: "priceInformation",
                columns: new[] { "priceInformationId", "priceAmount" },
                values: new object[,]
                {
                    { "4693cc5e-919f-4e36-a2a2-1724dfa99336", 45000L },
                    { "bb67604c-7415-4367-8273-96031e8fba85", 70000L }
                });

            migrationBuilder.InsertData(
                table: "roleInformation",
                columns: new[] { "roleId", "roleName" },
                values: new object[,]
                {
                    { "0a6a39c5-4fbd-47e9-bf8e-539febaf7c0b", "Customer" },
                    { "0a80ebf7-b7a8-4c3d-8c42-2deadd79577a", "Director" },
                    { "13ccbb3c-9d09-42b8-9df0-918677713ffc", "Ticket Inspector Staff" },
                    { "500fa21c-f78b-4e00-85fb-ab4cc3e90fe5", "Cashier Staff" },
                    { "a38659aa-cb71-42c8-a9e0-4f060d543297", "Cleaning Staff" }
                });

            migrationBuilder.InsertData(
                table: "userInformation",
                columns: new[] { "userId", "IdentityCode", "dateOfBirth", "loginUserEmail", "loginUserPassword", "phoneNumber", "userName", "userPoint" },
                values: new object[,]
                {
                    { "075e5d13-b126-474a-bbd7-c2ba365bfe02", "123456789012", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", "password123", "0912345678", "Admin User", 1000 },
                    { "e8b8cf78-64a4-4054-ac10-c88eb35fbb8e", "012345678901", new DateTime(1995, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "customer1@example.com", "password123", "0987654321", "Nguyen Van A", 250 }
                });

            migrationBuilder.InsertData(
                table: "userType",
                columns: new[] { "userTypeId", "userTypeDescription" },
                values: new object[,]
                {
                    { "127bd770-c39f-4f2f-97df-c8911513ffab", "Adult" },
                    { "6616e04b-4220-4efd-a27c-5d4ee528d25d", "Child" },
                    { "9a86e2d8-f82e-4460-b6ce-cf5f606dfa9c", "Senior" },
                    { "afb20919-ae85-4d3b-89d8-21e73d8e6439", "Student" }
                });

            migrationBuilder.InsertData(
                table: "cinemaRoom",
                columns: new[] { "cinemaRoomId", "cinemaId", "cinemaRoomNumber", "isIMAXRoom" },
                values: new object[,]
                {
                    { "14610f15-7b6b-47ed-8d22-e3f5c7f5ed37", "b2630aae-dbb9-484a-8f79-739f4a59c503", 1, false },
                    { "16185d00-56e7-4dcb-875c-0960102cc04c", "b2630aae-dbb9-484a-8f79-739f4a59c503", 2, false },
                    { "b46bc121-d0fb-451a-a173-4917404006ef", "3254e5a3-cb1d-45c2-996c-bc33860735e5", 1, false }
                });

            migrationBuilder.InsertData(
                table: "movieInformation",
                columns: new[] { "movieId", "languageId", "movieActor", "movieDescription", "movieDirector", "movieDuration", "movieImage", "movieName", "movieTrailerUrl" },
                values: new object[,]
                {
                    { "89a9c79e-2684-4f8c-b30b-c916b1b845c7", "3554de3e-5218-474b-b33f-bf945a5ee9cd", "Rebecca Hall, Brian Tyree Henry, Dan Stevens", "Godzilla and Kong must unite to fight a colossal undiscovered threat hidden within our world.", "Adam Wingard", 115, new byte[] { 103, 111, 100, 122, 105, 108, 108, 97, 120, 107, 111, 110, 103, 95, 105, 109, 97, 103, 101, 95, 112, 108, 97, 99, 101, 104, 111, 108, 100, 101, 114 }, "Godzilla x Kong: The New Empire", "https://www.youtube.com/watch?v=EOk9z-WbN5o" },
                    { "abc1f58a-d70c-4918-9ac3-9925e2ba8a53", "3554de3e-5218-474b-b33f-bf945a5ee9cd", "Timothée Chalamet, Zendaya, Rebecca Ferguson", "Paul Atreides unites with Chani and the Fremen while seeking revenge against those who destroyed his family.", "Denis Villeneuve", 166, new byte[] { 100, 117, 110, 101, 50, 95, 105, 109, 97, 103, 101, 95, 112, 108, 97, 99, 101, 104, 111, 108, 100, 101, 114 }, "Dune: Part Two", "https://www.youtube.com/watch?v=Way9Dexny3w" }
                });

            migrationBuilder.InsertData(
                table: "userRoleInformation",
                columns: new[] { "roleId", "userId" },
                values: new object[,]
                {
                    { "0a6a39c5-4fbd-47e9-bf8e-539febaf7c0b", "e8b8cf78-64a4-4054-ac10-c88eb35fbb8e" },
                    { "0a80ebf7-b7a8-4c3d-8c42-2deadd79577a", "075e5d13-b126-474a-bbd7-c2ba365bfe02" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatsId", "cinemaRoomId", "isMiddle", "isTaken", "seatsNumber" },
                values: new object[,]
                {
                    { "0977245c-1e6f-48dc-8116-f9f542f8f4e5", "b46bc121-d0fb-451a-a173-4917404006ef", false, false, "D2" },
                    { "1b495104-b4aa-4f41-a36c-46032d99bfa1", "14610f15-7b6b-47ed-8d22-e3f5c7f5ed37", true, false, "A2" },
                    { "4808b47a-c740-4a57-9f09-eef29b5a9d40", "14610f15-7b6b-47ed-8d22-e3f5c7f5ed37", false, false, "B1" },
                    { "778e2e82-ee8b-4340-be9c-e13134b4b655", "16185d00-56e7-4dcb-875c-0960102cc04c", false, false, "C2" },
                    { "8104ec2b-929e-48f3-8ac5-3de5ea3dc850", "14610f15-7b6b-47ed-8d22-e3f5c7f5ed37", false, false, "B2" },
                    { "9d63e8d5-0415-4b06-a273-202496bb9736", "14610f15-7b6b-47ed-8d22-e3f5c7f5ed37", true, false, "A1" },
                    { "dc903da8-c9da-463e-839d-15fbf1b05388", "16185d00-56e7-4dcb-875c-0960102cc04c", true, false, "C1" },
                    { "dd8f16bc-4a6e-41bf-9d34-8b615e52294e", "b46bc121-d0fb-451a-a173-4917404006ef", true, false, "D1" }
                });

            migrationBuilder.InsertData(
                table: "cinemaMovieInformation",
                columns: new[] { "cinemaId", "movieId" },
                values: new object[,]
                {
                    { "3254e5a3-cb1d-45c2-996c-bc33860735e5", "abc1f58a-d70c-4918-9ac3-9925e2ba8a53" },
                    { "b2630aae-dbb9-484a-8f79-739f4a59c503", "89a9c79e-2684-4f8c-b30b-c916b1b845c7" },
                    { "b2630aae-dbb9-484a-8f79-739f4a59c503", "abc1f58a-d70c-4918-9ac3-9925e2ba8a53" }
                });

            migrationBuilder.InsertData(
                table: "movieGenreInformation",
                columns: new[] { "movieGenreId", "movieId" },
                values: new object[,]
                {
                    { "18cef6c0-7505-408d-9430-3c69668d901d", "89a9c79e-2684-4f8c-b30b-c916b1b845c7" },
                    { "18cef6c0-7505-408d-9430-3c69668d901d", "abc1f58a-d70c-4918-9ac3-9925e2ba8a53" },
                    { "c48b7434-d458-4585-8d25-b7a8d37122ca", "abc1f58a-d70c-4918-9ac3-9925e2ba8a53" }
                });

            migrationBuilder.InsertData(
                table: "movieSchedule",
                columns: new[] { "movieScheduleId", "cinemaRoomId", "movieId", "showDateTime" },
                values: new object[,]
                {
                    { "0f53e717-b0a4-4644-bea5-c7c57283a086", "14610f15-7b6b-47ed-8d22-e3f5c7f5ed37", "abc1f58a-d70c-4918-9ac3-9925e2ba8a53", new DateTime(2025, 6, 5, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "7ab3e2a2-a237-467d-a881-c53cb4b37af9", "14610f15-7b6b-47ed-8d22-e3f5c7f5ed37", "89a9c79e-2684-4f8c-b30b-c916b1b845c7", new DateTime(2025, 6, 5, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { "ed76d002-e703-49f6-8394-24e8b00e6884", "b46bc121-d0fb-451a-a173-4917404006ef", "abc1f58a-d70c-4918-9ac3-9925e2ba8a53", new DateTime(2025, 6, 6, 11, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_orderDetail_orderId",
                table: "orderDetail",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_movieVisualFormatDetail_movieVisualFormatId",
                table: "movieVisualFormatDetail",
                column: "movieVisualFormatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movieVisualFormatDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderDetail",
                table: "orderDetail");

            migrationBuilder.DropIndex(
                name: "IX_orderDetail_orderId",
                table: "orderDetail");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "8e9fe372-2805-4684-9c78-7d70c738633c");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "ffaaa0f3-d3d5-4fb5-b5ab-e8c8d95616db");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "0977245c-1e6f-48dc-8116-f9f542f8f4e5");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "1b495104-b4aa-4f41-a36c-46032d99bfa1");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "4808b47a-c740-4a57-9f09-eef29b5a9d40");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "778e2e82-ee8b-4340-be9c-e13134b4b655");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "8104ec2b-929e-48f3-8ac5-3de5ea3dc850");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "9d63e8d5-0415-4b06-a273-202496bb9736");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "dc903da8-c9da-463e-839d-15fbf1b05388");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "dd8f16bc-4a6e-41bf-9d34-8b615e52294e");

            migrationBuilder.DeleteData(
                table: "cinemaMovieInformation",
                keyColumns: new[] { "cinemaId", "movieId" },
                keyValues: new object[] { "3254e5a3-cb1d-45c2-996c-bc33860735e5", "abc1f58a-d70c-4918-9ac3-9925e2ba8a53" });

            migrationBuilder.DeleteData(
                table: "cinemaMovieInformation",
                keyColumns: new[] { "cinemaId", "movieId" },
                keyValues: new object[] { "b2630aae-dbb9-484a-8f79-739f4a59c503", "89a9c79e-2684-4f8c-b30b-c916b1b845c7" });

            migrationBuilder.DeleteData(
                table: "cinemaMovieInformation",
                keyColumns: new[] { "cinemaId", "movieId" },
                keyValues: new object[] { "b2630aae-dbb9-484a-8f79-739f4a59c503", "abc1f58a-d70c-4918-9ac3-9925e2ba8a53" });

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "761bfbed-9895-4eec-9896-e726cd5c18d7");

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "9b820f95-5680-405d-b525-e82f88052abf");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "cc36fa8c-0f84-4057-86d1-6153dcabba5b");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "e1349368-604c-4be9-a172-1ad2bc2b6990");

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "18cef6c0-7505-408d-9430-3c69668d901d", "89a9c79e-2684-4f8c-b30b-c916b1b845c7" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "18cef6c0-7505-408d-9430-3c69668d901d", "abc1f58a-d70c-4918-9ac3-9925e2ba8a53" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "c48b7434-d458-4585-8d25-b7a8d37122ca", "abc1f58a-d70c-4918-9ac3-9925e2ba8a53" });

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "0f53e717-b0a4-4644-bea5-c7c57283a086");

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "7ab3e2a2-a237-467d-a881-c53cb4b37af9");

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "ed76d002-e703-49f6-8394-24e8b00e6884");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "04b58e6a-d65c-43b9-a4f1-3d97a4cd9a09");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "c1a47ecd-9823-444b-9f66-4c51fcd06e92");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "f8624e60-1587-4ed6-aadd-c102bd1c445d");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "4693cc5e-919f-4e36-a2a2-1724dfa99336");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "bb67604c-7415-4367-8273-96031e8fba85");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "13ccbb3c-9d09-42b8-9df0-918677713ffc");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "500fa21c-f78b-4e00-85fb-ab4cc3e90fe5");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "a38659aa-cb71-42c8-a9e0-4f060d543297");

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "0a6a39c5-4fbd-47e9-bf8e-539febaf7c0b", "e8b8cf78-64a4-4054-ac10-c88eb35fbb8e" });

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "0a80ebf7-b7a8-4c3d-8c42-2deadd79577a", "075e5d13-b126-474a-bbd7-c2ba365bfe02" });

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "127bd770-c39f-4f2f-97df-c8911513ffab");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "6616e04b-4220-4efd-a27c-5d4ee528d25d");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "9a86e2d8-f82e-4460-b6ce-cf5f606dfa9c");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "afb20919-ae85-4d3b-89d8-21e73d8e6439");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "14610f15-7b6b-47ed-8d22-e3f5c7f5ed37");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "16185d00-56e7-4dcb-875c-0960102cc04c");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "b46bc121-d0fb-451a-a173-4917404006ef");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "18cef6c0-7505-408d-9430-3c69668d901d");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "c48b7434-d458-4585-8d25-b7a8d37122ca");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "89a9c79e-2684-4f8c-b30b-c916b1b845c7");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "abc1f58a-d70c-4918-9ac3-9925e2ba8a53");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "0a6a39c5-4fbd-47e9-bf8e-539febaf7c0b");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "0a80ebf7-b7a8-4c3d-8c42-2deadd79577a");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "075e5d13-b126-474a-bbd7-c2ba365bfe02");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "e8b8cf78-64a4-4054-ac10-c88eb35fbb8e");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "3254e5a3-cb1d-45c2-996c-bc33860735e5");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "b2630aae-dbb9-484a-8f79-739f4a59c503");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "3554de3e-5218-474b-b33f-bf945a5ee9cd");

            migrationBuilder.AddColumn<string>(
                name: "movieVisualFormatId",
                table: "movieInformation",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderDetail",
                table: "orderDetail",
                columns: new[] { "orderId", "seatsId", "priceInformationId", "movieScheduleID" });

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
                name: "IX_orderDetail_seatsId",
                table: "orderDetail",
                column: "seatsId");

            migrationBuilder.CreateIndex(
                name: "IX_movieInformation_movieVisualFormatId",
                table: "movieInformation",
                column: "movieVisualFormatId");

            migrationBuilder.AddForeignKey(
                name: "FK_movieInformation_movieVisualFormat_movieVisualFormatId",
                table: "movieInformation",
                column: "movieVisualFormatId",
                principalTable: "movieVisualFormat",
                principalColumn: "movieVisualFormatId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
