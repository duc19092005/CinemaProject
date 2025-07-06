using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class Update_lai_Full_DB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movieCommentDetail_userInformation_userId",
                table: "movieCommentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_userInformation_userId",
                table: "Order");

            migrationBuilder.DropTable(
                name: "cleaningStatus");

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "7dbd63fb-0d54-4bdb-81bb-ace99045f8b4");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "4206e605-a0a4-4d53-aad7-88019fef4330");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "c476640f-dff2-4950-bb6b-112b9e486781");

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "173cfea1-facc-4730-952a-1de13ece2552");

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "04fbcc11-19fe-4a40-a1ee-1063ade137d7", "2c76c3d0-d38a-4bcb-9dc0-43cda06ee364" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "284873c8-ccbd-4622-bb54-e8d142613062", "db73e843-a7d2-4247-b862-8f92bddd3429" });

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "a393a74b-a89e-4eae-b20d-af39574f0b75");

            migrationBuilder.DeleteData(
                table: "priceInformationForEachUserFilmType",
                keyColumns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                keyValues: new object[] { "31dfc3fe-1489-4891-a1a4-ebd89e0bcaa6", "68153b4d-cd4d-45cf-9396-00fce798bc60", "46d62d07-de47-4648-92c4-a3eaf05e1f9a" });

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "1df6819e-d8b0-4fd9-966e-5b77f48038c5");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "53c9f27f-fe3e-495d-afd2-5dee20fc9ed7");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "5c270cca-d6a5-4593-8204-f5ea9d93401c");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "795490f5-17a0-464e-96cd-73be04b33222");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "daedaa6a-13c4-435e-a3d8-662b9e88bf43");

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "7404b4cb-db5e-4c19-9d01-6f05f6d167be", "b03dc08c-f241-4349-9906-a264fa180d5e" });

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "b0afaca7-46d1-40ae-989b-e78c30983ba3", "2592425e-ac0d-4799-8f39-8ed63345dc65" });

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "9abdb56a-9030-492c-a698-04828608c554");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "0e44e1de-0577-4375-b51b-518542f5c276");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "04fbcc11-19fe-4a40-a1ee-1063ade137d7");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "284873c8-ccbd-4622-bb54-e8d142613062");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "2c76c3d0-d38a-4bcb-9dc0-43cda06ee364");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "db73e843-a7d2-4247-b862-8f92bddd3429");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "68153b4d-cd4d-45cf-9396-00fce798bc60");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "7404b4cb-db5e-4c19-9d01-6f05f6d167be");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "b0afaca7-46d1-40ae-989b-e78c30983ba3");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "2592425e-ac0d-4799-8f39-8ed63345dc65");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "b03dc08c-f241-4349-9906-a264fa180d5e");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "46d62d07-de47-4648-92c4-a3eaf05e1f9a");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "6c7f6246-edeb-4f2c-a778-513126d70a07");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "4656a562-7a8e-46a8-b086-398c604bb74f");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "fabc1347-1b68-4a18-b73a-0295879fdf1b");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "31dfc3fe-1489-4891-a1a4-ebd89e0bcaa6");

            migrationBuilder.DropColumn(
                name: "IdentityCode",
                table: "userInformation");

            migrationBuilder.DropColumn(
                name: "dateOfBirth",
                table: "userInformation");

            migrationBuilder.DropColumn(
                name: "phoneNumber",
                table: "userInformation");

            migrationBuilder.DropColumn(
                name: "userName",
                table: "userInformation");

            migrationBuilder.DropColumn(
                name: "userPoint",
                table: "userInformation");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Order",
                newName: "customerID");

            migrationBuilder.RenameIndex(
                name: "IX_Order_userId",
                table: "Order",
                newName: "IX_Order_customerID");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "movieCommentDetail",
                newName: "customerID");

            migrationBuilder.RenameIndex(
                name: "IX_movieCommentDetail_userId",
                table: "movieCommentDetail",
                newName: "IX_movieCommentDetail_customerID");

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
                    cinemaID = table.Column<string>(type: "varchar(100)", nullable: false),
                    userID = table.Column<string>(type: "varchar(100)", nullable: false),
                    Id = table.Column<string>(type: "varchar(100)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    phoneNumber = table.Column<string>(type: "varchar(10)", nullable: false),
                    IdentityCode = table.Column<string>(type: "varchar(70)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => new { x.userID, x.cinemaID });
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

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "cinemaId", "cinemaContactHotlineNumber", "cinemaDescription", "cinemaLocation", "cinemaName" },
                values: new object[] { "459275f6-bff5-4ccd-bef8-5f19c9562414", "0901234567", "Rạp chiếu phim hiện đại với nhiều phòng chiếu.", "123 Đường XYZ, TP.HCM", "Rạp Chiếu Phim ABC" });

            migrationBuilder.InsertData(
                table: "HourSchedule",
                columns: new[] { "HourScheduleID", "HourScheduleShowTime" },
                values: new object[,]
                {
                    { "9e91af8e-4e3c-400d-a8e4-bddf4470b143", "10:00" },
                    { "d3475024-e0fc-4ff9-8470-051faba33f3b", "08:00" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "languageId", "languageDetail" },
                values: new object[,]
                {
                    { "238b3a89-30e7-4af0-91c8-62c6a58599f2", "English" },
                    { "d01a000a-965f-4e6b-bf21-1a7a647d4c20", "Vietnamese" }
                });

            migrationBuilder.InsertData(
                table: "foodInformation",
                columns: new[] { "foodInformationId", "foodInformationName", "foodPrice" },
                values: new object[] { "42c89d7a-9da0-480e-9262-968ee0a90ca8", "Popcorn", 50000L });

            migrationBuilder.InsertData(
                table: "movieGenre",
                columns: new[] { "movieGenreId", "movieGenreName" },
                values: new object[,]
                {
                    { "24611f39-53ef-4b7c-98aa-f6bc59404b28", "Comedy" },
                    { "535b5175-34f7-4dca-bb9a-34876cbd3495", "Action" }
                });

            migrationBuilder.InsertData(
                table: "movieVisualFormat",
                columns: new[] { "movieVisualFormatId", "movieVisualFormatName" },
                values: new object[] { "68300fb7-3fe0-41d3-82d9-a64b3a9e70b2", "2D" });

            migrationBuilder.InsertData(
                table: "priceInformation",
                columns: new[] { "priceInformationId", "priceAmount" },
                values: new object[] { "d0dc0cf6-82fc-4298-8a91-b201616bf2c5", 80000L });

            migrationBuilder.InsertData(
                table: "roleInformation",
                columns: new[] { "roleId", "roleName" },
                values: new object[,]
                {
                    { "3e0d9d72-a12b-45a7-a1e7-351f63eb87f5", "MovieManager" },
                    { "4b32405a-3249-4a61-8494-c49bd2958e0e", "Cashier" },
                    { "4f7b02ce-2b56-4926-a92f-99f0ac7b9b01", "TheaterManager" },
                    { "77dd5194-74a4-445f-9f91-a491e7b2b72b", "Customer" },
                    { "987ce41d-78fd-41c0-9238-5ce33d3340c0", "TheaterCleaner" },
                    { "cdc1bb5d-8e04-4b70-8c8d-2eab72bdcf74", "Director" },
                    { "d89cb727-c0d7-4f34-89ab-79d2dcab6344", "FacilitiesManager" }
                });

            migrationBuilder.InsertData(
                table: "userInformation",
                columns: new[] { "userId", "loginUserEmail", "loginUserPassword" },
                values: new object[,]
                {
                    { "99313ba0-36e8-40aa-8147-7c369f16162b", "admin@example.com", "hashed_password_admin" },
                    { "d21cbd3d-df1e-4d2f-9e0e-e3d472933e1a", "user@example.com", "hashed_password_user" }
                });

            migrationBuilder.InsertData(
                table: "userType",
                columns: new[] { "userTypeId", "userTypeDescription" },
                values: new object[] { "4fcbe932-3c72-4d87-922b-a6bef776bc71", "Adult" });

            migrationBuilder.InsertData(
                table: "cinemaRoom",
                columns: new[] { "cinemaRoomId", "cinemaId", "cinemaRoomNumber", "isDeleted", "movieVisualFormatID" },
                values: new object[] { "912b869a-3d00-4da0-9d46-b130a4feb073", "459275f6-bff5-4ccd-bef8-5f19c9562414", 1, false, "68300fb7-3fe0-41d3-82d9-a64b3a9e70b2" });

            migrationBuilder.InsertData(
                table: "movieInformation",
                columns: new[] { "movieId", "ReleaseDate", "isDelete", "languageId", "movieActor", "movieDescription", "movieDirector", "movieDuration", "movieImage", "movieName", "movieTrailerUrl" },
                values: new object[,]
                {
                    { "43d740d2-6db3-4277-8327-fba0780de96d", new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "d01a000a-965f-4e6b-bf21-1a7a647d4c20", "Diễn Viên X, Diễn Viên Y", "Đây là một bộ phim hành động đầy kịch tính.", "Đạo Diễn A", 120, new byte[] { 1, 2, 3 }, "Phim Hành Động 1", "http://trailer.com/phimhanhdong1" },
                    { "63424264-5427-44fb-80dc-def567c5a013", new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "238b3a89-30e7-4af0-91c8-62c6a58599f2", "Actor Z, Actress W", "A funny movie for the whole family.", "Director B", 90, new byte[] { 4, 5, 6 }, "Comedy Film 1", "http://trailer.com/comedyfilm1" }
                });

            migrationBuilder.InsertData(
                table: "priceInformationForEachUserFilmType",
                columns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                values: new object[] { "68300fb7-3fe0-41d3-82d9-a64b3a9e70b2", "d0dc0cf6-82fc-4298-8a91-b201616bf2c5", "4fcbe932-3c72-4d87-922b-a6bef776bc71" });

            migrationBuilder.InsertData(
                table: "userRoleInformation",
                columns: new[] { "roleId", "userId" },
                values: new object[,]
                {
                    { "3e0d9d72-a12b-45a7-a1e7-351f63eb87f5", "99313ba0-36e8-40aa-8147-7c369f16162b" },
                    { "77dd5194-74a4-445f-9f91-a491e7b2b72b", "d21cbd3d-df1e-4d2f-9e0e-e3d472933e1a" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatsId", "cinemaRoomId", "isDelete", "isServed", "isTaken", "seatsNumber" },
                values: new object[,]
                {
                    { "649cb608-74ff-4860-bc93-5339d2a41846", "912b869a-3d00-4da0-9d46-b130a4feb073", false, true, false, "A1" },
                    { "eaaacca9-8e55-4038-be1a-0630d6aef4b4", "912b869a-3d00-4da0-9d46-b130a4feb073", false, true, false, "A2" }
                });

            migrationBuilder.InsertData(
                table: "movieGenreInformation",
                columns: new[] { "movieGenreId", "movieId" },
                values: new object[,]
                {
                    { "535b5175-34f7-4dca-bb9a-34876cbd3495", "43d740d2-6db3-4277-8327-fba0780de96d" },
                    { "24611f39-53ef-4b7c-98aa-f6bc59404b28", "63424264-5427-44fb-80dc-def567c5a013" }
                });

            migrationBuilder.InsertData(
                table: "movieSchedule",
                columns: new[] { "movieScheduleId", "DayInWeekendSchedule", "HourScheduleID", "IsDelete", "ScheduleDate", "cinemaRoomId", "movieId", "movieVisualFormatID" },
                values: new object[] { "3b62e078-bf61-46d2-a354-3c8f4c81c374", "Monday", "d3475024-e0fc-4ff9-8470-051faba33f3b", false, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "912b869a-3d00-4da0-9d46-b130a4feb073", "43d740d2-6db3-4277-8327-fba0780de96d", "68300fb7-3fe0-41d3-82d9-a64b3a9e70b2" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_userID",
                table: "Customers",
                column: "userID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_cinemaID",
                table: "Staff",
                column: "cinemaID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_userID",
                table: "Staff",
                column: "userID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_movieCommentDetail_Customers_customerID",
                table: "movieCommentDetail",
                column: "customerID",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customers_customerID",
                table: "Order",
                column: "customerID",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movieCommentDetail_Customers_customerID",
                table: "movieCommentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customers_customerID",
                table: "Order");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "9e91af8e-4e3c-400d-a8e4-bddf4470b143");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "649cb608-74ff-4860-bc93-5339d2a41846");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "eaaacca9-8e55-4038-be1a-0630d6aef4b4");

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "42c89d7a-9da0-480e-9262-968ee0a90ca8");

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "535b5175-34f7-4dca-bb9a-34876cbd3495", "43d740d2-6db3-4277-8327-fba0780de96d" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "24611f39-53ef-4b7c-98aa-f6bc59404b28", "63424264-5427-44fb-80dc-def567c5a013" });

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "3b62e078-bf61-46d2-a354-3c8f4c81c374");

            migrationBuilder.DeleteData(
                table: "priceInformationForEachUserFilmType",
                keyColumns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                keyValues: new object[] { "68300fb7-3fe0-41d3-82d9-a64b3a9e70b2", "d0dc0cf6-82fc-4298-8a91-b201616bf2c5", "4fcbe932-3c72-4d87-922b-a6bef776bc71" });

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "4b32405a-3249-4a61-8494-c49bd2958e0e");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "4f7b02ce-2b56-4926-a92f-99f0ac7b9b01");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "987ce41d-78fd-41c0-9238-5ce33d3340c0");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "cdc1bb5d-8e04-4b70-8c8d-2eab72bdcf74");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "d89cb727-c0d7-4f34-89ab-79d2dcab6344");

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "3e0d9d72-a12b-45a7-a1e7-351f63eb87f5", "99313ba0-36e8-40aa-8147-7c369f16162b" });

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "77dd5194-74a4-445f-9f91-a491e7b2b72b", "d21cbd3d-df1e-4d2f-9e0e-e3d472933e1a" });

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "d3475024-e0fc-4ff9-8470-051faba33f3b");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "912b869a-3d00-4da0-9d46-b130a4feb073");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "24611f39-53ef-4b7c-98aa-f6bc59404b28");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "535b5175-34f7-4dca-bb9a-34876cbd3495");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "43d740d2-6db3-4277-8327-fba0780de96d");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "63424264-5427-44fb-80dc-def567c5a013");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "d0dc0cf6-82fc-4298-8a91-b201616bf2c5");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "3e0d9d72-a12b-45a7-a1e7-351f63eb87f5");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "77dd5194-74a4-445f-9f91-a491e7b2b72b");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "99313ba0-36e8-40aa-8147-7c369f16162b");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "d21cbd3d-df1e-4d2f-9e0e-e3d472933e1a");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "4fcbe932-3c72-4d87-922b-a6bef776bc71");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "459275f6-bff5-4ccd-bef8-5f19c9562414");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "238b3a89-30e7-4af0-91c8-62c6a58599f2");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "d01a000a-965f-4e6b-bf21-1a7a647d4c20");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "68300fb7-3fe0-41d3-82d9-a64b3a9e70b2");

            migrationBuilder.RenameColumn(
                name: "customerID",
                table: "Order",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_customerID",
                table: "Order",
                newName: "IX_Order_userId");

            migrationBuilder.RenameColumn(
                name: "customerID",
                table: "movieCommentDetail",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_movieCommentDetail_customerID",
                table: "movieCommentDetail",
                newName: "IX_movieCommentDetail_userId");

            migrationBuilder.AddColumn<string>(
                name: "IdentityCode",
                table: "userInformation",
                type: "varchar(70)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "dateOfBirth",
                table: "userInformation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "phoneNumber",
                table: "userInformation",
                type: "varchar(10)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "userName",
                table: "userInformation",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "userPoint",
                table: "userInformation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "cleaningStatus",
                columns: table => new
                {
                    roomID = table.Column<string>(type: "varchar(100)", nullable: false),
                    staffID = table.Column<string>(type: "varchar(100)", nullable: false),
                    startedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cinemaRoomId = table.Column<string>(type: "varchar(100)", nullable: false),
                    userInformationuserId = table.Column<string>(type: "varchar(100)", nullable: false),
                    endedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "cinemaId", "cinemaContactHotlineNumber", "cinemaDescription", "cinemaLocation", "cinemaName" },
                values: new object[] { "6c7f6246-edeb-4f2c-a778-513126d70a07", "0901234567", "Rạp chiếu phim hiện đại với nhiều phòng chiếu.", "123 Đường XYZ, TP.HCM", "Rạp Chiếu Phim ABC" });

            migrationBuilder.InsertData(
                table: "HourSchedule",
                columns: new[] { "HourScheduleID", "HourScheduleShowTime" },
                values: new object[,]
                {
                    { "7dbd63fb-0d54-4bdb-81bb-ace99045f8b4", "10:00" },
                    { "9abdb56a-9030-492c-a698-04828608c554", "08:00" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "languageId", "languageDetail" },
                values: new object[,]
                {
                    { "4656a562-7a8e-46a8-b086-398c604bb74f", "Vietnamese" },
                    { "fabc1347-1b68-4a18-b73a-0295879fdf1b", "English" }
                });

            migrationBuilder.InsertData(
                table: "foodInformation",
                columns: new[] { "foodInformationId", "foodInformationName", "foodPrice" },
                values: new object[] { "173cfea1-facc-4730-952a-1de13ece2552", "Popcorn", 50000L });

            migrationBuilder.InsertData(
                table: "movieGenre",
                columns: new[] { "movieGenreId", "movieGenreName" },
                values: new object[,]
                {
                    { "04fbcc11-19fe-4a40-a1ee-1063ade137d7", "Comedy" },
                    { "284873c8-ccbd-4622-bb54-e8d142613062", "Action" }
                });

            migrationBuilder.InsertData(
                table: "movieVisualFormat",
                columns: new[] { "movieVisualFormatId", "movieVisualFormatName" },
                values: new object[] { "31dfc3fe-1489-4891-a1a4-ebd89e0bcaa6", "2D" });

            migrationBuilder.InsertData(
                table: "priceInformation",
                columns: new[] { "priceInformationId", "priceAmount" },
                values: new object[] { "68153b4d-cd4d-45cf-9396-00fce798bc60", 80000L });

            migrationBuilder.InsertData(
                table: "roleInformation",
                columns: new[] { "roleId", "roleName" },
                values: new object[,]
                {
                    { "1df6819e-d8b0-4fd9-966e-5b77f48038c5", "TheaterCleaner" },
                    { "53c9f27f-fe3e-495d-afd2-5dee20fc9ed7", "TheaterManager" },
                    { "5c270cca-d6a5-4593-8204-f5ea9d93401c", "FacilitiesManager" },
                    { "7404b4cb-db5e-4c19-9d01-6f05f6d167be", "Customer" },
                    { "795490f5-17a0-464e-96cd-73be04b33222", "Director" },
                    { "b0afaca7-46d1-40ae-989b-e78c30983ba3", "MovieManager" },
                    { "daedaa6a-13c4-435e-a3d8-662b9e88bf43", "Cashier" }
                });

            migrationBuilder.InsertData(
                table: "userInformation",
                columns: new[] { "userId", "IdentityCode", "dateOfBirth", "loginUserEmail", "loginUserPassword", "phoneNumber", "userName", "userPoint" },
                values: new object[,]
                {
                    { "2592425e-ac0d-4799-8f39-8ed63345dc65", "123456789012", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", "hashed_password_admin", "0123456789", "Admin User", 0 },
                    { "b03dc08c-f241-4349-9906-a264fa180d5e", "987654321098", new DateTime(1995, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", "hashed_password_user", "0987654321", "Regular User", 0 }
                });

            migrationBuilder.InsertData(
                table: "userType",
                columns: new[] { "userTypeId", "userTypeDescription" },
                values: new object[] { "46d62d07-de47-4648-92c4-a3eaf05e1f9a", "Adult" });

            migrationBuilder.InsertData(
                table: "cinemaRoom",
                columns: new[] { "cinemaRoomId", "cinemaId", "cinemaRoomNumber", "isDeleted", "movieVisualFormatID" },
                values: new object[] { "0e44e1de-0577-4375-b51b-518542f5c276", "6c7f6246-edeb-4f2c-a778-513126d70a07", 1, false, "31dfc3fe-1489-4891-a1a4-ebd89e0bcaa6" });

            migrationBuilder.InsertData(
                table: "movieInformation",
                columns: new[] { "movieId", "ReleaseDate", "isDelete", "languageId", "movieActor", "movieDescription", "movieDirector", "movieDuration", "movieImage", "movieName", "movieTrailerUrl" },
                values: new object[,]
                {
                    { "2c76c3d0-d38a-4bcb-9dc0-43cda06ee364", new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "fabc1347-1b68-4a18-b73a-0295879fdf1b", "Actor Z, Actress W", "A funny movie for the whole family.", "Director B", 90, new byte[] { 4, 5, 6 }, "Comedy Film 1", "http://trailer.com/comedyfilm1" },
                    { "db73e843-a7d2-4247-b862-8f92bddd3429", new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "4656a562-7a8e-46a8-b086-398c604bb74f", "Diễn Viên X, Diễn Viên Y", "Đây là một bộ phim hành động đầy kịch tính.", "Đạo Diễn A", 120, new byte[] { 1, 2, 3 }, "Phim Hành Động 1", "http://trailer.com/phimhanhdong1" }
                });

            migrationBuilder.InsertData(
                table: "priceInformationForEachUserFilmType",
                columns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                values: new object[] { "31dfc3fe-1489-4891-a1a4-ebd89e0bcaa6", "68153b4d-cd4d-45cf-9396-00fce798bc60", "46d62d07-de47-4648-92c4-a3eaf05e1f9a" });

            migrationBuilder.InsertData(
                table: "userRoleInformation",
                columns: new[] { "roleId", "userId" },
                values: new object[,]
                {
                    { "7404b4cb-db5e-4c19-9d01-6f05f6d167be", "b03dc08c-f241-4349-9906-a264fa180d5e" },
                    { "b0afaca7-46d1-40ae-989b-e78c30983ba3", "2592425e-ac0d-4799-8f39-8ed63345dc65" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatsId", "cinemaRoomId", "isDelete", "isServed", "isTaken", "seatsNumber" },
                values: new object[,]
                {
                    { "4206e605-a0a4-4d53-aad7-88019fef4330", "0e44e1de-0577-4375-b51b-518542f5c276", false, true, false, "A2" },
                    { "c476640f-dff2-4950-bb6b-112b9e486781", "0e44e1de-0577-4375-b51b-518542f5c276", false, true, false, "A1" }
                });

            migrationBuilder.InsertData(
                table: "movieGenreInformation",
                columns: new[] { "movieGenreId", "movieId" },
                values: new object[,]
                {
                    { "04fbcc11-19fe-4a40-a1ee-1063ade137d7", "2c76c3d0-d38a-4bcb-9dc0-43cda06ee364" },
                    { "284873c8-ccbd-4622-bb54-e8d142613062", "db73e843-a7d2-4247-b862-8f92bddd3429" }
                });

            migrationBuilder.InsertData(
                table: "movieSchedule",
                columns: new[] { "movieScheduleId", "DayInWeekendSchedule", "HourScheduleID", "IsDelete", "ScheduleDate", "cinemaRoomId", "movieId", "movieVisualFormatID" },
                values: new object[] { "a393a74b-a89e-4eae-b20d-af39574f0b75", "Monday", "9abdb56a-9030-492c-a698-04828608c554", false, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0e44e1de-0577-4375-b51b-518542f5c276", "db73e843-a7d2-4247-b862-8f92bddd3429", "31dfc3fe-1489-4891-a1a4-ebd89e0bcaa6" });

            migrationBuilder.CreateIndex(
                name: "IX_cleaningStatus_cinemaRoomId",
                table: "cleaningStatus",
                column: "cinemaRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_cleaningStatus_userInformationuserId",
                table: "cleaningStatus",
                column: "userInformationuserId");

            migrationBuilder.AddForeignKey(
                name: "FK_movieCommentDetail_userInformation_userId",
                table: "movieCommentDetail",
                column: "userId",
                principalTable: "userInformation",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_userInformation_userId",
                table: "Order",
                column: "userId",
                principalTable: "userInformation",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
