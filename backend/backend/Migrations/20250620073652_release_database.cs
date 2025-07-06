using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class release_database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cinema",
                columns: table => new
                {
                    cinemaId = table.Column<string>(type: "varchar(100)", nullable: false),
                    cinemaName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    cinemaLocation = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    cinemaDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cinemaContactHotlineNumber = table.Column<string>(type: "varchar(10)", nullable: false),
                    isSupportedIMAX = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinema", x => x.cinemaId);
                });

            migrationBuilder.CreateTable(
                name: "foodInformation",
                columns: table => new
                {
                    foodInformationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    foodInformationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    foodPrice = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_foodInformation", x => x.foodInformationId);
                });

            migrationBuilder.CreateTable(
                name: "HourSchedule",
                columns: table => new
                {
                    HourScheduleID = table.Column<string>(type: "varchar(50)", nullable: false),
                    HourScheduleDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HourSchedule", x => x.HourScheduleID);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    languageId = table.Column<string>(type: "varchar(100)", nullable: false),
                    languageDetail = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.languageId);
                });

            migrationBuilder.CreateTable(
                name: "movieGenre",
                columns: table => new
                {
                    movieGenreId = table.Column<string>(type: "varchar(100)", nullable: false),
                    movieGenreName = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieGenre", x => x.movieGenreId);
                });

            migrationBuilder.CreateTable(
                name: "movieVisualFormat",
                columns: table => new
                {
                    movieVisualFormatId = table.Column<string>(type: "varchar(100)", nullable: false),
                    movieVisualFormatName = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieVisualFormat", x => x.movieVisualFormatId);
                });

            migrationBuilder.CreateTable(
                name: "priceInformation",
                columns: table => new
                {
                    priceInformationId = table.Column<string>(type: "varchar(100)", nullable: false),
                    priceAmount = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_priceInformation", x => x.priceInformationId);
                });

            migrationBuilder.CreateTable(
                name: "roleInformation",
                columns: table => new
                {
                    roleId = table.Column<string>(type: "varchar(100)", nullable: false),
                    roleName = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roleInformation", x => x.roleId);
                });

            migrationBuilder.CreateTable(
                name: "userInformation",
                columns: table => new
                {
                    userId = table.Column<string>(type: "varchar(100)", nullable: false),
                    loginUserEmail = table.Column<string>(type: "varchar(100)", nullable: false),
                    loginUserPassword = table.Column<string>(type: "varchar(100)", nullable: false),
                    dateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    phoneNumber = table.Column<string>(type: "varchar(10)", nullable: false),
                    userName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    IdentityCode = table.Column<string>(type: "varchar(70)", nullable: false),
                    userPoint = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userInformation", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "userType",
                columns: table => new
                {
                    userTypeId = table.Column<string>(type: "varchar(100)", nullable: false),
                    userTypeDescription = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userType", x => x.userTypeId);
                });

            migrationBuilder.CreateTable(
                name: "cinemaRoom",
                columns: table => new
                {
                    cinemaRoomId = table.Column<string>(type: "varchar(100)", nullable: false),
                    cinemaRoomNumber = table.Column<int>(type: "int", nullable: false),
                    isIMAXRoom = table.Column<bool>(type: "bit", nullable: false),
                    cinemaId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cinemaRoom", x => x.cinemaRoomId);
                    table.ForeignKey(
                        name: "FK_cinemaRoom_Cinema_cinemaId",
                        column: x => x.cinemaId,
                        principalTable: "Cinema",
                        principalColumn: "cinemaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "movieInformation",
                columns: table => new
                {
                    movieId = table.Column<string>(type: "varchar(100)", nullable: false),
                    movieName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    movieImage = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    movieDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    movieDirector = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    movieActor = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    movieTrailerUrl = table.Column<string>(type: "varchar(300)", nullable: false),
                    movieDuration = table.Column<int>(type: "int", nullable: false),
                    languageId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieInformation", x => x.movieId);
                    table.ForeignKey(
                        name: "FK_movieInformation_Language_languageId",
                        column: x => x.languageId,
                        principalTable: "Language",
                        principalColumn: "languageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    orderId = table.Column<string>(type: "varchar(100)", nullable: false),
                    paymentMethod = table.Column<string>(type: "varchar(50)", nullable: false),
                    isPay = table.Column<bool>(type: "bit", nullable: false),
                    totalAmount = table.Column<long>(type: "bigint", nullable: false),
                    paymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.orderId);
                    table.ForeignKey(
                        name: "FK_Order_userInformation_userId",
                        column: x => x.userId,
                        principalTable: "userInformation",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "userRoleInformation",
                columns: table => new
                {
                    userId = table.Column<string>(type: "varchar(100)", nullable: false),
                    roleId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userRoleInformation", x => new { x.roleId, x.userId });
                    table.ForeignKey(
                        name: "FK_userRoleInformation_roleInformation_roleId",
                        column: x => x.roleId,
                        principalTable: "roleInformation",
                        principalColumn: "roleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userRoleInformation_userInformation_userId",
                        column: x => x.userId,
                        principalTable: "userInformation",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "cleaningStatus",
                columns: table => new
                {
                    roomID = table.Column<string>(type: "varchar(100)", nullable: false),
                    staffID = table.Column<string>(type: "varchar(100)", nullable: false),
                    startedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cinemaRoomId = table.Column<string>(type: "varchar(100)", nullable: false),
                    userInformationuserId = table.Column<string>(type: "varchar(100)", nullable: false)
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
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    seatsId = table.Column<string>(type: "varchar(100)", nullable: false),
                    seatsNumber = table.Column<string>(type: "varchar(10)", nullable: false),
                    isTaken = table.Column<bool>(type: "bit", nullable: false),
                    isMiddle = table.Column<bool>(type: "bit", nullable: false),
                    cinemaRoomId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.seatsId);
                    table.ForeignKey(
                        name: "FK_Seats_cinemaRoom_cinemaRoomId",
                        column: x => x.cinemaRoomId,
                        principalTable: "cinemaRoom",
                        principalColumn: "cinemaRoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "movieCommentDetail",
                columns: table => new
                {
                    movieId = table.Column<string>(type: "varchar(100)", nullable: false),
                    userId = table.Column<string>(type: "varchar(100)", nullable: false),
                    userCommentDetail = table.Column<string>(type: "nvarchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieCommentDetail", x => new { x.movieId, x.userId });
                    table.ForeignKey(
                        name: "FK_movieCommentDetail_movieInformation_movieId",
                        column: x => x.movieId,
                        principalTable: "movieInformation",
                        principalColumn: "movieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movieCommentDetail_userInformation_userId",
                        column: x => x.userId,
                        principalTable: "userInformation",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "movieGenreInformation",
                columns: table => new
                {
                    movieId = table.Column<string>(type: "varchar(100)", nullable: false),
                    movieGenreId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieGenreInformation", x => new { x.movieId, x.movieGenreId });
                    table.ForeignKey(
                        name: "FK_movieGenreInformation_movieGenre_movieGenreId",
                        column: x => x.movieGenreId,
                        principalTable: "movieGenre",
                        principalColumn: "movieGenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movieGenreInformation_movieInformation_movieId",
                        column: x => x.movieId,
                        principalTable: "movieInformation",
                        principalColumn: "movieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "movieSchedule",
                columns: table => new
                {
                    movieScheduleId = table.Column<string>(type: "varchar(100)", nullable: false),
                    cinemaRoomId = table.Column<string>(type: "varchar(100)", nullable: false),
                    cinemaID = table.Column<string>(type: "varchar(100)", nullable: false),
                    movieId = table.Column<string>(type: "varchar(100)", nullable: false),
                    DayInWeekendSchedule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HourScheduleID = table.Column<string>(type: "varchar(50)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieSchedule", x => x.movieScheduleId);
                    table.ForeignKey(
                        name: "FK_movieSchedule_Cinema_cinemaID",
                        column: x => x.cinemaID,
                        principalTable: "Cinema",
                        principalColumn: "cinemaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movieSchedule_HourSchedule_HourScheduleID",
                        column: x => x.HourScheduleID,
                        principalTable: "HourSchedule",
                        principalColumn: "HourScheduleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movieSchedule_cinemaRoom_cinemaRoomId",
                        column: x => x.cinemaRoomId,
                        principalTable: "cinemaRoom",
                        principalColumn: "cinemaRoomId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_movieSchedule_movieInformation_movieId",
                        column: x => x.movieId,
                        principalTable: "movieInformation",
                        principalColumn: "movieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "movieVisualFormatDetails",
                columns: table => new
                {
                    movieId = table.Column<string>(type: "varchar(100)", nullable: false),
                    movieVisualFormatId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieVisualFormatDetails", x => new { x.movieId, x.movieVisualFormatId });
                    table.ForeignKey(
                        name: "FK_movieVisualFormatDetails_movieInformation_movieId",
                        column: x => x.movieId,
                        principalTable: "movieInformation",
                        principalColumn: "movieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movieVisualFormatDetails_movieVisualFormat_movieVisualFormatId",
                        column: x => x.movieVisualFormatId,
                        principalTable: "movieVisualFormat",
                        principalColumn: "movieVisualFormatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodOrderDetail",
                columns: table => new
                {
                    orderId = table.Column<string>(type: "varchar(100)", nullable: false),
                    foodInformationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    quanlity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodOrderDetail", x => new { x.orderId, x.foodInformationId });
                    table.ForeignKey(
                        name: "FK_FoodOrderDetail_Order_orderId",
                        column: x => x.orderId,
                        principalTable: "Order",
                        principalColumn: "orderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodOrderDetail_foodInformation_foodInformationId",
                        column: x => x.foodInformationId,
                        principalTable: "foodInformation",
                        principalColumn: "foodInformationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TicketOrderDetail",
                columns: table => new
                {
                    movieScheduleID = table.Column<string>(type: "varchar(100)", nullable: false),
                    seatsId = table.Column<string>(type: "varchar(100)", nullable: false),
                    orderId = table.Column<string>(type: "varchar(100)", nullable: false),
                    priceInformationId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketOrderDetail", x => new { x.seatsId, x.movieScheduleID });
                    table.ForeignKey(
                        name: "FK_TicketOrderDetail_Order_orderId",
                        column: x => x.orderId,
                        principalTable: "Order",
                        principalColumn: "orderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketOrderDetail_Seats_seatsId",
                        column: x => x.seatsId,
                        principalTable: "Seats",
                        principalColumn: "seatsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketOrderDetail_movieSchedule_movieScheduleID",
                        column: x => x.movieScheduleID,
                        principalTable: "movieSchedule",
                        principalColumn: "movieScheduleId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TicketOrderDetail_priceInformation_priceInformationId",
                        column: x => x.priceInformationId,
                        principalTable: "priceInformation",
                        principalColumn: "priceInformationId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_cinemaRoom_cinemaId",
                table: "cinemaRoom",
                column: "cinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_cleaningStatus_cinemaRoomId",
                table: "cleaningStatus",
                column: "cinemaRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_cleaningStatus_userInformationuserId",
                table: "cleaningStatus",
                column: "userInformationuserId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodOrderDetail_foodInformationId",
                table: "FoodOrderDetail",
                column: "foodInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_movieCommentDetail_userId",
                table: "movieCommentDetail",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_movieGenreInformation_movieGenreId",
                table: "movieGenreInformation",
                column: "movieGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_movieInformation_languageId",
                table: "movieInformation",
                column: "languageId");

            migrationBuilder.CreateIndex(
                name: "IX_movieSchedule_cinemaID",
                table: "movieSchedule",
                column: "cinemaID");

            migrationBuilder.CreateIndex(
                name: "IX_movieSchedule_cinemaRoomId",
                table: "movieSchedule",
                column: "cinemaRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_movieSchedule_HourScheduleID",
                table: "movieSchedule",
                column: "HourScheduleID");

            migrationBuilder.CreateIndex(
                name: "IX_movieSchedule_movieId",
                table: "movieSchedule",
                column: "movieId");

            migrationBuilder.CreateIndex(
                name: "IX_movieVisualFormatDetails_movieVisualFormatId",
                table: "movieVisualFormatDetails",
                column: "movieVisualFormatId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_userId",
                table: "Order",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_priceInformationForEachUserFilmType_movieVisualFormatId",
                table: "priceInformationForEachUserFilmType",
                column: "movieVisualFormatId");

            migrationBuilder.CreateIndex(
                name: "IX_priceInformationForEachUserFilmType_priceInformationID",
                table: "priceInformationForEachUserFilmType",
                column: "priceInformationID");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_cinemaRoomId",
                table: "Seats",
                column: "cinemaRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketOrderDetail_movieScheduleID",
                table: "TicketOrderDetail",
                column: "movieScheduleID");

            migrationBuilder.CreateIndex(
                name: "IX_TicketOrderDetail_orderId",
                table: "TicketOrderDetail",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketOrderDetail_priceInformationId",
                table: "TicketOrderDetail",
                column: "priceInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_userRoleInformation_userId",
                table: "userRoleInformation",
                column: "userId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cleaningStatus");

            migrationBuilder.DropTable(
                name: "FoodOrderDetail");

            migrationBuilder.DropTable(
                name: "movieCommentDetail");

            migrationBuilder.DropTable(
                name: "movieGenreInformation");

            migrationBuilder.DropTable(
                name: "movieVisualFormatDetails");

            migrationBuilder.DropTable(
                name: "priceInformationForEachUserFilmType");

            migrationBuilder.DropTable(
                name: "TicketOrderDetail");

            migrationBuilder.DropTable(
                name: "userRoleInformation");

            migrationBuilder.DropTable(
                name: "foodInformation");

            migrationBuilder.DropTable(
                name: "movieGenre");

            migrationBuilder.DropTable(
                name: "movieVisualFormat");

            migrationBuilder.DropTable(
                name: "userType");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "movieSchedule");

            migrationBuilder.DropTable(
                name: "priceInformation");

            migrationBuilder.DropTable(
                name: "roleInformation");

            migrationBuilder.DropTable(
                name: "userInformation");

            migrationBuilder.DropTable(
                name: "HourSchedule");

            migrationBuilder.DropTable(
                name: "cinemaRoom");

            migrationBuilder.DropTable(
                name: "movieInformation");

            migrationBuilder.DropTable(
                name: "Cinema");

            migrationBuilder.DropTable(
                name: "Language");
        }
    }
}
