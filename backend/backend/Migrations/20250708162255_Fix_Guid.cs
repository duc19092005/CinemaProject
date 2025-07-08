using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class Fix_Guid : Migration
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
                    cinemaContactHotlineNumber = table.Column<string>(type: "varchar(10)", nullable: false)
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
                    foodInformationName = table.Column<string>(type: "nvarchar(30)", nullable: false),
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
                    HourScheduleShowTime = table.Column<string>(type: "varchar(10)", nullable: false)
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
                name: "minimumAges",
                columns: table => new
                {
                    minimumAgeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    minimumAgeInfo = table.Column<int>(type: "int", nullable: false),
                    minimumAgeDescription = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_minimumAges", x => x.minimumAgeID);
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
                    loginUserPassword = table.Column<string>(type: "varchar(100)", nullable: false)
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
                name: "movieInformation",
                columns: table => new
                {
                    movieId = table.Column<string>(type: "varchar(100)", nullable: false),
                    minimumAgeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    movieName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    movieImage = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    movieDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    movieDirector = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    movieActor = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    movieTrailerUrl = table.Column<string>(type: "varchar(300)", nullable: false),
                    movieDuration = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isDelete = table.Column<bool>(type: "bit", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_movieInformation_minimumAges_minimumAgeID",
                        column: x => x.minimumAgeID,
                        principalTable: "minimumAges",
                        principalColumn: "minimumAgeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cinemaRoom",
                columns: table => new
                {
                    cinemaRoomId = table.Column<string>(type: "varchar(100)", nullable: false),
                    cinemaRoomNumber = table.Column<int>(type: "int", nullable: false),
                    cinemaId = table.Column<string>(type: "varchar(100)", nullable: false),
                    movieVisualFormatID = table.Column<string>(type: "varchar(100)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_cinemaRoom_movieVisualFormat_movieVisualFormatID",
                        column: x => x.movieVisualFormatID,
                        principalTable: "movieVisualFormat",
                        principalColumn: "movieVisualFormatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", nullable: false),
                    userID = table.Column<string>(type: "varchar(100)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    phoneNumber = table.Column<string>(type: "varchar(10)", nullable: false),
                    IdentityCode = table.Column<string>(type: "varchar(70)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_userInformation_userID",
                        column: x => x.userID,
                        principalTable: "userInformation",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", nullable: false),
                    cinemaID = table.Column<string>(type: "varchar(100)", nullable: false),
                    userID = table.Column<string>(type: "varchar(100)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    phoneNumber = table.Column<string>(type: "varchar(10)", nullable: false),
                    IdentityCode = table.Column<string>(type: "varchar(70)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staff_Cinema_cinemaID",
                        column: x => x.cinemaID,
                        principalTable: "Cinema",
                        principalColumn: "cinemaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staff_userInformation_userID",
                        column: x => x.userID,
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
                name: "movieSchedule",
                columns: table => new
                {
                    movieScheduleId = table.Column<string>(type: "varchar(100)", nullable: false),
                    cinemaRoomId = table.Column<string>(type: "varchar(100)", nullable: false),
                    movieId = table.Column<string>(type: "varchar(100)", nullable: false),
                    movieVisualFormatID = table.Column<string>(type: "varchar(100)", nullable: false),
                    DayInWeekendSchedule = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    HourScheduleID = table.Column<string>(type: "varchar(50)", nullable: false),
                    ScheduleDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieSchedule", x => x.movieScheduleId);
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movieSchedule_movieInformation_movieId",
                        column: x => x.movieId,
                        principalTable: "movieInformation",
                        principalColumn: "movieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movieSchedule_movieVisualFormat_movieVisualFormatID",
                        column: x => x.movieVisualFormatID,
                        principalTable: "movieVisualFormat",
                        principalColumn: "movieVisualFormatId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    seatsId = table.Column<string>(type: "varchar(100)", nullable: false),
                    seatsNumber = table.Column<string>(type: "varchar(10)", nullable: false),
                    isTaken = table.Column<bool>(type: "bit", nullable: false),
                    isDelete = table.Column<bool>(type: "bit", nullable: false),
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
                    customerID = table.Column<string>(type: "varchar(100)", nullable: false),
                    userCommentDetail = table.Column<string>(type: "nvarchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieCommentDetail", x => new { x.movieId, x.customerID });
                    table.ForeignKey(
                        name: "FK_movieCommentDetail_Customers_customerID",
                        column: x => x.customerID,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movieCommentDetail_movieInformation_movieId",
                        column: x => x.movieId,
                        principalTable: "movieInformation",
                        principalColumn: "movieId",
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
                    customerID = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.orderId);
                    table.ForeignKey(
                        name: "FK_Order_Customers_customerID",
                        column: x => x.customerID,
                        principalTable: "Customers",
                        principalColumn: "Id",
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
                    orderId = table.Column<string>(type: "varchar(100)", nullable: false),
                    movieScheduleID = table.Column<string>(type: "varchar(100)", nullable: false),
                    seatsId = table.Column<string>(type: "varchar(100)", nullable: false),
                    priceInformationId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketOrderDetail", x => new { x.seatsId, x.movieScheduleID, x.orderId });
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
                columns: new[] { "cinemaId", "cinemaContactHotlineNumber", "cinemaDescription", "cinemaLocation", "cinemaName" },
                values: new object[] { "2f3a4b5c-6d7e-8f9a-0b1c-2d3e4f5a6b7c", "0901234567", "Rạp chiếu phim hiện đại với nhiều phòng chiếu.", "123 Đường XYZ, TP.HCM", "Rạp Chiếu Phim ABC" });

            migrationBuilder.InsertData(
                table: "HourSchedule",
                columns: new[] { "HourScheduleID", "HourScheduleShowTime" },
                values: new object[,]
                {
                    { "3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d", "08:00" },
                    { "4b5c6d7e-8f9a-0b1c-2d3e-4f5a6b7c8d9e", "10:00" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "languageId", "languageDetail" },
                values: new object[,]
                {
                    { "c3d4e5f6-a7b8-c9d0-e1f2-a3b4c5d6e7f8", "Vietnamese" },
                    { "d4e5f6a7-b8c9-d0e1-f2a3-b4c5d6e7f8a9", "English" }
                });

            migrationBuilder.InsertData(
                table: "foodInformation",
                columns: new[] { "foodInformationId", "foodInformationName", "foodPrice" },
                values: new object[] { "2d3e4f5a-6b7c-8d9e-0f1a-2b3c4d5e6f7a", "Popcorn", 50000L });

            migrationBuilder.InsertData(
                table: "minimumAges",
                columns: new[] { "minimumAgeID", "minimumAgeDescription", "minimumAgeInfo" },
                values: new object[,]
                {
                    { "7a8b9c0d-1e2f-3a4b-5c6d-7e8f9a0b1c2d", "Phim dành cho khán giả từ 13 tuổi trở lên.", 13 },
                    { "8b9c0d1e-2f3a-4b5c-6d7e-8f9a0b1c2d3e", "Phim dành cho khán giả từ 16 tuổi trở lên.", 16 },
                    { "9c0d1e2f-3a4b-5c6d-7e8f-9a0b1c2d3e4f", "Phim dành cho khán giả từ 18 tuổi trở lên.", 18 }
                });

            migrationBuilder.InsertData(
                table: "movieGenre",
                columns: new[] { "movieGenreId", "movieGenreName" },
                values: new object[,]
                {
                    { "e5f6a7b8-c9d0-e1f2-a3b4-c5d6e7f8a9b0", "Action" },
                    { "f6a7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c1", "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "movieVisualFormat",
                columns: new[] { "movieVisualFormatId", "movieVisualFormatName" },
                values: new object[] { "5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f", "2D" });

            migrationBuilder.InsertData(
                table: "priceInformation",
                columns: new[] { "priceInformationId", "priceAmount" },
                values: new object[] { "0b1c2d3e-4f5a-6b7c-8d9e-0f1a2b3c4d5e", 80000L });

            migrationBuilder.InsertData(
                table: "roleInformation",
                columns: new[] { "roleId", "roleName" },
                values: new object[,]
                {
                    { "1a8f7b9c-d4e5-4f6a-b7c8-9d0e1f2a3b4c", "Cashier" },
                    { "2b9c8d0e-f5a6-7b8c-d9e0-1f2a3b4c5d6e", "Customer" },
                    { "3c0d9e1f-a6b7-c8d9-e0f1-2a3b4c5d6e7f", "Director" },
                    { "4d1e0f2a-b7c8-d9e0-f1a2-3b4c5d6e7f8g", "MovieManager" },
                    { "5e2f1a3b-c8d9-e0f1-a2b3-4c5d6e7f8g9h", "TheaterManager" },
                    { "6f3a2b4c-d9e0-f1a2-b3c4-d5e6f7a8b9c0", "FacilitiesManager" }
                });

            migrationBuilder.InsertData(
                table: "userInformation",
                columns: new[] { "userId", "loginUserEmail", "loginUserPassword" },
                values: new object[,]
                {
                    { "a1b2c3d4-e5f6-7a8b-c9d0-e1f2a3b4c5d6", "admin@example.com", "hashed_password_admin" },
                    { "b2c3d4e5-f6a7-8b9c-d0e1-f2a3b4c5d6e7", "user@example.com", "hashed_password_user" }
                });

            migrationBuilder.InsertData(
                table: "userType",
                columns: new[] { "userTypeId", "userTypeDescription" },
                values: new object[] { "1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f", "Adult" });

            migrationBuilder.InsertData(
                table: "cinemaRoom",
                columns: new[] { "cinemaRoomId", "cinemaId", "cinemaRoomNumber", "isDeleted", "movieVisualFormatID" },
                values: new object[] { "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", "2f3a4b5c-6d7e-8f9a-0b1c-2d3e4f5a6b7c", 1, false, "5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f" });

            migrationBuilder.InsertData(
                table: "movieInformation",
                columns: new[] { "movieId", "ReleaseDate", "isDelete", "languageId", "minimumAgeID", "movieActor", "movieDescription", "movieDirector", "movieDuration", "movieImage", "movieName", "movieTrailerUrl" },
                values: new object[,]
                {
                    { "0d1e2f3a-4b5c-6d7e-8f9a-0b1c2d3e4f5a", new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "c3d4e5f6-a7b8-c9d0-e1f2-a3b4c5d6e7f8", "7a8b9c0d-1e2f-3a4b-5c6d-7e8f9a0b1c2d", "Diễn Viên X, Diễn Viên Y", "Đây là một bộ phim hành động đầy kịch tính.", "Đạo Diễn A", 120, "aa.com", "Phim Hành Động 1", "http://trailer.com/phimhanhdong1" },
                    { "1e2f3a4b-5c6d-7e8f-9a0b-1c2d3e4f5a6b", new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "d4e5f6a7-b8c9-d0e1-f2a3-b4c5d6e7f8a9", "9c0d1e2f-3a4b-5c6d-7e8f-9a0b1c2d3e4f", "Actor Z, Actress W", "A funny movie for the whole family.", "Director B", 90, "aa.com.vn", "Comedy Film 1", "http://trailer.com/comedyfilm1" }
                });

            migrationBuilder.InsertData(
                table: "priceInformationForEachUserFilmType",
                columns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                values: new object[] { "5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f", "0b1c2d3e-4f5a-6b7c-8d9e-0f1a2b3c4d5e", "1c2d3e4f-5a6b-7c8d-9e0f-1a2b3c4d5e6f" });

            migrationBuilder.InsertData(
                table: "userRoleInformation",
                columns: new[] { "roleId", "userId" },
                values: new object[,]
                {
                    { "2b9c8d0e-f5a6-7b8c-d9e0-1f2a3b4c5d6e", "b2c3d4e5-f6a7-8b9c-d0e1-f2a3b4c5d6e7" },
                    { "4d1e0f2a-b7c8-d9e0-f1a2-3b4c5d6e7f8g", "a1b2c3d4-e5f6-7a8b-c9d0-e1f2a3b4c5d6" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatsId", "cinemaRoomId", "isDelete", "isTaken", "seatsNumber" },
                values: new object[,]
                {
                    { "8f9a0b1c-2d3e-4f5a-6b7c-8d9e0f1a2b3c", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A1" },
                    { "9a0b1c2d-3e4f-5a6b-7c8d-9e0f1a2b3c4d", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A2" }
                });

            migrationBuilder.InsertData(
                table: "movieGenreInformation",
                columns: new[] { "movieGenreId", "movieId" },
                values: new object[,]
                {
                    { "e5f6a7b8-c9d0-e1f2-a3b4-c5d6e7f8a9b0", "0d1e2f3a-4b5c-6d7e-8f9a-0b1c2d3e4f5a" },
                    { "f6a7b8c9-d0e1-f2a3-b4c5-d6e7f8a9b0c1", "1e2f3a4b-5c6d-7e8f-9a0b-1c2d3e4f5a6b" }
                });

            migrationBuilder.InsertData(
                table: "movieSchedule",
                columns: new[] { "movieScheduleId", "DayInWeekendSchedule", "HourScheduleID", "IsDelete", "ScheduleDate", "cinemaRoomId", "movieId", "movieVisualFormatID" },
                values: new object[] { "7e8f9a0b-1c2d-3e4f-5a6b-7c8d9e0f1a2b", "Monday", "3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d", false, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", "0d1e2f3a-4b5c-6d7e-8f9a-0b1c2d3e4f5a", "5c6d7e8f-9a0b-1c2d-3e4f-5a6b7c8d9e0f" });

            migrationBuilder.CreateIndex(
                name: "IX_cinemaRoom_cinemaId",
                table: "cinemaRoom",
                column: "cinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_cinemaRoom_movieVisualFormatID",
                table: "cinemaRoom",
                column: "movieVisualFormatID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_userID",
                table: "Customers",
                column: "userID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FoodOrderDetail_foodInformationId",
                table: "FoodOrderDetail",
                column: "foodInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_HourSchedule_HourScheduleShowTime",
                table: "HourSchedule",
                column: "HourScheduleShowTime",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Language_languageDetail",
                table: "Language",
                column: "languageDetail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_minimumAges_minimumAgeDescription",
                table: "minimumAges",
                column: "minimumAgeDescription",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_minimumAges_minimumAgeInfo",
                table: "minimumAges",
                column: "minimumAgeInfo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_movieCommentDetail_customerID",
                table: "movieCommentDetail",
                column: "customerID");

            migrationBuilder.CreateIndex(
                name: "IX_movieGenre_movieGenreName",
                table: "movieGenre",
                column: "movieGenreName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_movieGenreInformation_movieGenreId",
                table: "movieGenreInformation",
                column: "movieGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_movieInformation_languageId",
                table: "movieInformation",
                column: "languageId");

            migrationBuilder.CreateIndex(
                name: "IX_movieInformation_minimumAgeID",
                table: "movieInformation",
                column: "minimumAgeID");

            migrationBuilder.CreateIndex(
                name: "IX_movieInformation_movieImage",
                table: "movieInformation",
                column: "movieImage",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_movieInformation_movieName",
                table: "movieInformation",
                column: "movieName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_movieInformation_movieTrailerUrl",
                table: "movieInformation",
                column: "movieTrailerUrl",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_movieSchedule_cinemaRoomId_ScheduleDate",
                table: "movieSchedule",
                columns: new[] { "cinemaRoomId", "ScheduleDate" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_movieSchedule_HourScheduleID",
                table: "movieSchedule",
                column: "HourScheduleID");

            migrationBuilder.CreateIndex(
                name: "IX_movieSchedule_movieId",
                table: "movieSchedule",
                column: "movieId");

            migrationBuilder.CreateIndex(
                name: "IX_movieSchedule_movieVisualFormatID",
                table: "movieSchedule",
                column: "movieVisualFormatID");

            migrationBuilder.CreateIndex(
                name: "IX_movieVisualFormat_movieVisualFormatName",
                table: "movieVisualFormat",
                column: "movieVisualFormatName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_movieVisualFormatDetails_movieVisualFormatId",
                table: "movieVisualFormatDetails",
                column: "movieVisualFormatId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_customerID",
                table: "Order",
                column: "customerID");

            migrationBuilder.CreateIndex(
                name: "IX_priceInformation_priceAmount",
                table: "priceInformation",
                column: "priceAmount",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_priceInformationForEachUserFilmType_movieVisualFormatId",
                table: "priceInformationForEachUserFilmType",
                column: "movieVisualFormatId");

            migrationBuilder.CreateIndex(
                name: "IX_priceInformationForEachUserFilmType_priceInformationID",
                table: "priceInformationForEachUserFilmType",
                column: "priceInformationID");

            migrationBuilder.CreateIndex(
                name: "IX_roleInformation_roleName",
                table: "roleInformation",
                column: "roleName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seats_cinemaRoomId",
                table: "Seats",
                column: "cinemaRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_cinemaID",
                table: "Staff",
                column: "cinemaID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_userID",
                table: "Staff",
                column: "userID",
                unique: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_userType_userTypeDescription",
                table: "userType",
                column: "userTypeDescription",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Staff");

            migrationBuilder.DropTable(
                name: "TicketOrderDetail");

            migrationBuilder.DropTable(
                name: "userRoleInformation");

            migrationBuilder.DropTable(
                name: "foodInformation");

            migrationBuilder.DropTable(
                name: "movieGenre");

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
                name: "Customers");

            migrationBuilder.DropTable(
                name: "HourSchedule");

            migrationBuilder.DropTable(
                name: "cinemaRoom");

            migrationBuilder.DropTable(
                name: "movieInformation");

            migrationBuilder.DropTable(
                name: "userInformation");

            migrationBuilder.DropTable(
                name: "Cinema");

            migrationBuilder.DropTable(
                name: "movieVisualFormat");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "minimumAges");
        }
    }
}
