using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class NewestDatabase : Migration
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
                name: "DayInWeekendSchedule",
                columns: table => new
                {
                    DayInWeekendScheduleID = table.Column<string>(type: "varchar(50)", nullable: false),
                    DayInWeekendScheduleName = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayInWeekendSchedule", x => x.DayInWeekendScheduleID);
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
                    IdentityCode = table.Column<string>(type: "varchar(12)", nullable: false),
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
                name: "cinemaMovieInformation",
                columns: table => new
                {
                    cinemaId = table.Column<string>(type: "varchar(100)", nullable: false),
                    movieId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cinemaMovieInformation", x => new { x.cinemaId, x.movieId });
                    table.ForeignKey(
                        name: "FK_cinemaMovieInformation_Cinema_cinemaId",
                        column: x => x.cinemaId,
                        principalTable: "Cinema",
                        principalColumn: "cinemaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cinemaMovieInformation_movieInformation_movieId",
                        column: x => x.movieId,
                        principalTable: "movieInformation",
                        principalColumn: "movieId",
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
                    movieId = table.Column<string>(type: "varchar(100)", nullable: false),
                    DayInWeekendScheduleID = table.Column<string>(type: "varchar(50)", nullable: false),
                    HourScheduleID = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieSchedule", x => x.movieScheduleId);
                    table.ForeignKey(
                        name: "FK_movieSchedule_DayInWeekendSchedule_DayInWeekendScheduleID",
                        column: x => x.DayInWeekendScheduleID,
                        principalTable: "DayInWeekendSchedule",
                        principalColumn: "DayInWeekendScheduleID",
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
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateIndex(
                name: "IX_cinemaMovieInformation_movieId",
                table: "cinemaMovieInformation",
                column: "movieId");

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
                name: "IX_movieSchedule_cinemaRoomId",
                table: "movieSchedule",
                column: "cinemaRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_movieSchedule_DayInWeekendScheduleID",
                table: "movieSchedule",
                column: "DayInWeekendScheduleID");

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
                name: "cinemaMovieInformation");

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
                name: "DayInWeekendSchedule");

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
