using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class db_update : Migration
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
                    foodInformationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    foodPrice = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_foodInformation", x => x.foodInformationId);
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
                name: "priceInformation",
                columns: table => new
                {
                    priceInformationId = table.Column<string>(type: "varchar(100)", nullable: false),
                    priceAmount = table.Column<long>(type: "bigint", nullable: false),
                    userTypeId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_priceInformation", x => x.priceInformationId);
                    table.ForeignKey(
                        name: "FK_priceInformation_userType_userTypeId",
                        column: x => x.userTypeId,
                        principalTable: "userType",
                        principalColumn: "userTypeId",
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
                    showDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cinemaRoomId = table.Column<string>(type: "varchar(100)", nullable: false),
                    movieId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieSchedule", x => x.movieScheduleId);
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
                name: "orderDetailFood",
                columns: table => new
                {
                    orderId = table.Column<string>(type: "varchar(100)", nullable: false),
                    foodInformationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    quanlity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderDetailFood", x => new { x.orderId, x.foodInformationId });
                    table.ForeignKey(
                        name: "FK_orderDetailFood_Order_orderId",
                        column: x => x.orderId,
                        principalTable: "Order",
                        principalColumn: "orderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orderDetailFood_foodInformation_foodInformationId",
                        column: x => x.foodInformationId,
                        principalTable: "foodInformation",
                        principalColumn: "foodInformationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orderDetail",
                columns: table => new
                {
                    orderId = table.Column<string>(type: "varchar(100)", nullable: false),
                    seatsId = table.Column<string>(type: "varchar(100)", nullable: false),
                    priceInformationId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderDetail", x => new { x.orderId, x.seatsId, x.priceInformationId });
                    table.ForeignKey(
                        name: "FK_orderDetail_Order_orderId",
                        column: x => x.orderId,
                        principalTable: "Order",
                        principalColumn: "orderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orderDetail_Seats_seatsId",
                        column: x => x.seatsId,
                        principalTable: "Seats",
                        principalColumn: "seatsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orderDetail_priceInformation_priceInformationId",
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
                column: "cinemaId",
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
                name: "IX_movieSchedule_cinemaRoomId",
                table: "movieSchedule",
                column: "cinemaRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_movieSchedule_movieId",
                table: "movieSchedule",
                column: "movieId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_userId",
                table: "Order",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_orderDetail_priceInformationId",
                table: "orderDetail",
                column: "priceInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_orderDetail_seatsId",
                table: "orderDetail",
                column: "seatsId");

            migrationBuilder.CreateIndex(
                name: "IX_orderDetailFood_foodInformationId",
                table: "orderDetailFood",
                column: "foodInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_priceInformation_userTypeId",
                table: "priceInformation",
                column: "userTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_cinemaRoomId",
                table: "Seats",
                column: "cinemaRoomId");

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
                name: "movieGenreInformation");

            migrationBuilder.DropTable(
                name: "movieSchedule");

            migrationBuilder.DropTable(
                name: "orderDetail");

            migrationBuilder.DropTable(
                name: "orderDetailFood");

            migrationBuilder.DropTable(
                name: "userRoleInformation");

            migrationBuilder.DropTable(
                name: "movieGenre");

            migrationBuilder.DropTable(
                name: "movieInformation");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "priceInformation");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "foodInformation");

            migrationBuilder.DropTable(
                name: "roleInformation");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "cinemaRoom");

            migrationBuilder.DropTable(
                name: "userType");

            migrationBuilder.DropTable(
                name: "userInformation");

            migrationBuilder.DropTable(
                name: "Cinema");
        }
    }
}
