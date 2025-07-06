using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class updatethem2bangreport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketOrderDetail",
                table: "TicketOrderDetail");

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

            migrationBuilder.DropColumn(
                name: "HourScheduleDate",
                table: "HourSchedule");

            migrationBuilder.AddColumn<bool>(
                name: "isServed",
                table: "Seats",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "DayInWeekendSchedule",
                table: "movieSchedule",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "isDelete",
                table: "movieInformation",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "HourScheduleShowTime",
                table: "HourSchedule",
                type: "varchar(10)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "foodInformationName",
                table: "foodInformation",
                type: "nvarchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketOrderDetail",
                table: "TicketOrderDetail",
                columns: new[] { "seatsId", "movieScheduleID", "orderId" });

            migrationBuilder.CreateTable(
                name: "materialReport",
                columns: table => new
                {
                    materialReportID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    materialReportName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cinemaID = table.Column<string>(type: "varchar(100)", nullable: false),
                    cinemaRoomId = table.Column<string>(type: "varchar(100)", nullable: false),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isReported = table.Column<bool>(type: "bit", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materialReport", x => x.materialReportID);
                    table.ForeignKey(
                        name: "FK_materialReport_Cinema_cinemaID",
                        column: x => x.cinemaID,
                        principalTable: "Cinema",
                        principalColumn: "cinemaId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_materialReport_cinemaRoom_cinemaRoomId",
                        column: x => x.cinemaRoomId,
                        principalTable: "cinemaRoom",
                        principalColumn: "cinemaRoomId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "modificationRequest",
                columns: table => new
                {
                    modificationRequestID = table.Column<string>(type: "varchar(100)", nullable: false),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    materialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    roomID = table.Column<string>(type: "varchar(100)", nullable: false),
                    cinemaID = table.Column<string>(type: "varchar(100)", nullable: false),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isRequested = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modificationRequest", x => x.modificationRequestID);
                    table.ForeignKey(
                        name: "FK_modificationRequest_Cinema_cinemaID",
                        column: x => x.cinemaID,
                        principalTable: "Cinema",
                        principalColumn: "cinemaId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_modificationRequest_cinemaRoom_roomID",
                        column: x => x.roomID,
                        principalTable: "cinemaRoom",
                        principalColumn: "cinemaRoomId",
                        onDelete: ReferentialAction.NoAction);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_materialReport_cinemaID",
                table: "materialReport",
                column: "cinemaID");

            migrationBuilder.CreateIndex(
                name: "IX_materialReport_cinemaRoomId",
                table: "materialReport",
                column: "cinemaRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_modificationRequest_cinemaID",
                table: "modificationRequest",
                column: "cinemaID");

            migrationBuilder.CreateIndex(
                name: "IX_modificationRequest_roomID",
                table: "modificationRequest",
                column: "roomID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "materialReport");

            migrationBuilder.DropTable(
                name: "modificationRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketOrderDetail",
                table: "TicketOrderDetail");

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
                name: "isServed",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "movieInformation");

            migrationBuilder.DropColumn(
                name: "HourScheduleShowTime",
                table: "HourSchedule");

            migrationBuilder.AlterColumn<string>(
                name: "DayInWeekendSchedule",
                table: "movieSchedule",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AddColumn<string>(
                name: "HourScheduleDate",
                table: "HourSchedule",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "foodInformationName",
                table: "foodInformation",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketOrderDetail",
                table: "TicketOrderDetail",
                columns: new[] { "seatsId", "movieScheduleID" });

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
        }
    }
}
