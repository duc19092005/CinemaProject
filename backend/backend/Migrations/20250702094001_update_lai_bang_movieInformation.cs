using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class update_lai_bang_movieInformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movieSchedule_Cinema_cinemaID",
                table: "movieSchedule");

            migrationBuilder.DropTable(
                name: "materialReport");

            migrationBuilder.DropTable(
                name: "modificationRequest");

            migrationBuilder.DropIndex(
                name: "IX_movieSchedule_cinemaID",
                table: "movieSchedule");

            migrationBuilder.DropIndex(
                name: "IX_movieSchedule_cinemaRoomId_cinemaID_ScheduleDate",
                table: "movieSchedule");

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "e2c9789f-f135-496d-a2d4-e0a5ec31eb39");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "c86fa13a-12e6-4ee7-b9a6-48c840d60a4d");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "e7e02423-f9fc-4ece-aad4-e69fb9802e5f");

            migrationBuilder.DeleteData(
                table: "foodInformation",
                keyColumn: "foodInformationId",
                keyValue: "db0c701c-3585-45df-9656-d12a731c4ad4");

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "1b9a3055-4af5-4750-b3d6-815b9876402b", "4baf65a6-4db7-4c30-93d5-afe24315c7ee" });

            migrationBuilder.DeleteData(
                table: "movieGenreInformation",
                keyColumns: new[] { "movieGenreId", "movieId" },
                keyValues: new object[] { "124ae20c-f652-4edb-8420-ba9c2a20ffb6", "67868ce3-b1f7-4bc9-bd39-d6299ea6e0c8" });

            migrationBuilder.DeleteData(
                table: "movieSchedule",
                keyColumn: "movieScheduleId",
                keyValue: "4a8cde71-04d9-4074-a070-5621a0c2dacc");

            migrationBuilder.DeleteData(
                table: "priceInformationForEachUserFilmType",
                keyColumns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                keyValues: new object[] { "9eb8afc1-96f0-4ff8-b9d8-7648fb9f50c2", "1d6927c3-6e36-4a5e-b7e6-227c0ff46341", "2938a87e-8c5d-4d0d-9a24-0ac683afa216" });

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "4cf88c7a-636c-4cdd-8344-458966645676");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "9578b8b8-e960-4949-82a6-c4464d35a9cb");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "a5e81a76-4c30-41e8-b3a2-9644f85c67f6");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "fbc7b03b-3d5f-4dde-b10c-7c707ba19c64");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "fc59cdf4-fd9d-4a11-bbc0-b1c658f9a12f");

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "3025d94e-c32f-429e-8d4d-f77fa80616fc", "d4e55416-dee3-455f-8b3a-fba65cd2576b" });

            migrationBuilder.DeleteData(
                table: "userRoleInformation",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { "3443a8c8-2100-40e1-96f1-c40561914eb1", "61fb08fb-3145-4a4c-b4cd-afd6b39fae33" });

            migrationBuilder.DeleteData(
                table: "HourSchedule",
                keyColumn: "HourScheduleID",
                keyValue: "bf03f24b-3817-4ca9-af00-218b27e3add8");

            migrationBuilder.DeleteData(
                table: "cinemaRoom",
                keyColumn: "cinemaRoomId",
                keyValue: "b8db568f-279f-4721-9b39-011c8fb96655");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "124ae20c-f652-4edb-8420-ba9c2a20ffb6");

            migrationBuilder.DeleteData(
                table: "movieGenre",
                keyColumn: "movieGenreId",
                keyValue: "1b9a3055-4af5-4750-b3d6-815b9876402b");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "4baf65a6-4db7-4c30-93d5-afe24315c7ee");

            migrationBuilder.DeleteData(
                table: "movieInformation",
                keyColumn: "movieId",
                keyValue: "67868ce3-b1f7-4bc9-bd39-d6299ea6e0c8");

            migrationBuilder.DeleteData(
                table: "priceInformation",
                keyColumn: "priceInformationId",
                keyValue: "1d6927c3-6e36-4a5e-b7e6-227c0ff46341");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "3025d94e-c32f-429e-8d4d-f77fa80616fc");

            migrationBuilder.DeleteData(
                table: "roleInformation",
                keyColumn: "roleId",
                keyValue: "3443a8c8-2100-40e1-96f1-c40561914eb1");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "61fb08fb-3145-4a4c-b4cd-afd6b39fae33");

            migrationBuilder.DeleteData(
                table: "userInformation",
                keyColumn: "userId",
                keyValue: "d4e55416-dee3-455f-8b3a-fba65cd2576b");

            migrationBuilder.DeleteData(
                table: "userType",
                keyColumn: "userTypeId",
                keyValue: "2938a87e-8c5d-4d0d-9a24-0ac683afa216");

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "cinemaId",
                keyValue: "78d18c38-e169-4b4b-b35b-b738b2c28f36");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "3bf9deb7-3738-487a-a922-5e7f8d0b80fa");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "languageId",
                keyValue: "de32be34-f888-47df-be2d-44549e61c21d");

            migrationBuilder.DeleteData(
                table: "movieVisualFormat",
                keyColumn: "movieVisualFormatId",
                keyValue: "9eb8afc1-96f0-4ff8-b9d8-7648fb9f50c2");

            migrationBuilder.DropColumn(
                name: "cinemaID",
                table: "movieSchedule");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "movieInformation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                name: "IX_movieSchedule_cinemaRoomId_ScheduleDate",
                table: "movieSchedule",
                columns: new[] { "cinemaRoomId", "ScheduleDate" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_movieSchedule_cinemaRoomId_ScheduleDate",
                table: "movieSchedule");

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
                name: "ReleaseDate",
                table: "movieInformation");

            migrationBuilder.AddColumn<string>(
                name: "cinemaID",
                table: "movieSchedule",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "materialReport",
                columns: table => new
                {
                    materialReportID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cinemaID = table.Column<string>(type: "varchar(100)", nullable: false),
                    cinemaRoomId = table.Column<string>(type: "varchar(100)", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isReported = table.Column<bool>(type: "bit", nullable: false),
                    materialReportName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materialReport", x => x.materialReportID);
                    table.ForeignKey(
                        name: "FK_materialReport_Cinema_cinemaID",
                        column: x => x.cinemaID,
                        principalTable: "Cinema",
                        principalColumn: "cinemaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_materialReport_cinemaRoom_cinemaRoomId",
                        column: x => x.cinemaRoomId,
                        principalTable: "cinemaRoom",
                        principalColumn: "cinemaRoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "modificationRequest",
                columns: table => new
                {
                    modificationRequestID = table.Column<string>(type: "varchar(100)", nullable: false),
                    cinemaID = table.Column<string>(type: "varchar(100)", nullable: false),
                    roomID = table.Column<string>(type: "varchar(100)", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isRequested = table.Column<bool>(type: "bit", nullable: false),
                    materialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modificationRequest", x => x.modificationRequestID);
                    table.ForeignKey(
                        name: "FK_modificationRequest_Cinema_cinemaID",
                        column: x => x.cinemaID,
                        principalTable: "Cinema",
                        principalColumn: "cinemaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_modificationRequest_cinemaRoom_roomID",
                        column: x => x.roomID,
                        principalTable: "cinemaRoom",
                        principalColumn: "cinemaRoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "cinemaId", "cinemaContactHotlineNumber", "cinemaDescription", "cinemaLocation", "cinemaName" },
                values: new object[] { "78d18c38-e169-4b4b-b35b-b738b2c28f36", "0901234567", "Rạp chiếu phim hiện đại với nhiều phòng chiếu.", "123 Đường XYZ, TP.HCM", "Rạp Chiếu Phim ABC" });

            migrationBuilder.InsertData(
                table: "HourSchedule",
                columns: new[] { "HourScheduleID", "HourScheduleShowTime" },
                values: new object[,]
                {
                    { "bf03f24b-3817-4ca9-af00-218b27e3add8", "08:00" },
                    { "e2c9789f-f135-496d-a2d4-e0a5ec31eb39", "10:00" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "languageId", "languageDetail" },
                values: new object[,]
                {
                    { "3bf9deb7-3738-487a-a922-5e7f8d0b80fa", "Vietnamese" },
                    { "de32be34-f888-47df-be2d-44549e61c21d", "English" }
                });

            migrationBuilder.InsertData(
                table: "foodInformation",
                columns: new[] { "foodInformationId", "foodInformationName", "foodPrice" },
                values: new object[] { "db0c701c-3585-45df-9656-d12a731c4ad4", "Popcorn", 50000L });

            migrationBuilder.InsertData(
                table: "movieGenre",
                columns: new[] { "movieGenreId", "movieGenreName" },
                values: new object[,]
                {
                    { "124ae20c-f652-4edb-8420-ba9c2a20ffb6", "Action" },
                    { "1b9a3055-4af5-4750-b3d6-815b9876402b", "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "movieVisualFormat",
                columns: new[] { "movieVisualFormatId", "movieVisualFormatName" },
                values: new object[] { "9eb8afc1-96f0-4ff8-b9d8-7648fb9f50c2", "2D" });

            migrationBuilder.InsertData(
                table: "priceInformation",
                columns: new[] { "priceInformationId", "priceAmount" },
                values: new object[] { "1d6927c3-6e36-4a5e-b7e6-227c0ff46341", 80000L });

            migrationBuilder.InsertData(
                table: "roleInformation",
                columns: new[] { "roleId", "roleName" },
                values: new object[,]
                {
                    { "3025d94e-c32f-429e-8d4d-f77fa80616fc", "MovieManager" },
                    { "3443a8c8-2100-40e1-96f1-c40561914eb1", "Customer" },
                    { "4cf88c7a-636c-4cdd-8344-458966645676", "FacilitiesManager" },
                    { "9578b8b8-e960-4949-82a6-c4464d35a9cb", "Cashier" },
                    { "a5e81a76-4c30-41e8-b3a2-9644f85c67f6", "TheaterManager" },
                    { "fbc7b03b-3d5f-4dde-b10c-7c707ba19c64", "Director" },
                    { "fc59cdf4-fd9d-4a11-bbc0-b1c658f9a12f", "TheaterCleaner" }
                });

            migrationBuilder.InsertData(
                table: "userInformation",
                columns: new[] { "userId", "IdentityCode", "dateOfBirth", "loginUserEmail", "loginUserPassword", "phoneNumber", "userName", "userPoint" },
                values: new object[,]
                {
                    { "61fb08fb-3145-4a4c-b4cd-afd6b39fae33", "987654321098", new DateTime(1995, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@example.com", "hashed_password_user", "0987654321", "Regular User", 0 },
                    { "d4e55416-dee3-455f-8b3a-fba65cd2576b", "123456789012", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", "hashed_password_admin", "0123456789", "Admin User", 0 }
                });

            migrationBuilder.InsertData(
                table: "userType",
                columns: new[] { "userTypeId", "userTypeDescription" },
                values: new object[] { "2938a87e-8c5d-4d0d-9a24-0ac683afa216", "Adult" });

            migrationBuilder.InsertData(
                table: "cinemaRoom",
                columns: new[] { "cinemaRoomId", "cinemaId", "cinemaRoomNumber", "isDeleted", "movieVisualFormatID" },
                values: new object[] { "b8db568f-279f-4721-9b39-011c8fb96655", "78d18c38-e169-4b4b-b35b-b738b2c28f36", 1, false, "9eb8afc1-96f0-4ff8-b9d8-7648fb9f50c2" });

            migrationBuilder.InsertData(
                table: "movieInformation",
                columns: new[] { "movieId", "isDelete", "languageId", "movieActor", "movieDescription", "movieDirector", "movieDuration", "movieImage", "movieName", "movieTrailerUrl" },
                values: new object[,]
                {
                    { "4baf65a6-4db7-4c30-93d5-afe24315c7ee", false, "de32be34-f888-47df-be2d-44549e61c21d", "Actor Z, Actress W", "A funny movie for the whole family.", "Director B", 90, new byte[] { 4, 5, 6 }, "Comedy Film 1", "http://trailer.com/comedyfilm1" },
                    { "67868ce3-b1f7-4bc9-bd39-d6299ea6e0c8", false, "3bf9deb7-3738-487a-a922-5e7f8d0b80fa", "Diễn Viên X, Diễn Viên Y", "Đây là một bộ phim hành động đầy kịch tính.", "Đạo Diễn A", 120, new byte[] { 1, 2, 3 }, "Phim Hành Động 1", "http://trailer.com/phimhanhdong1" }
                });

            migrationBuilder.InsertData(
                table: "priceInformationForEachUserFilmType",
                columns: new[] { "movieVisualFormatId", "priceInformationID", "userTypeId" },
                values: new object[] { "9eb8afc1-96f0-4ff8-b9d8-7648fb9f50c2", "1d6927c3-6e36-4a5e-b7e6-227c0ff46341", "2938a87e-8c5d-4d0d-9a24-0ac683afa216" });

            migrationBuilder.InsertData(
                table: "userRoleInformation",
                columns: new[] { "roleId", "userId" },
                values: new object[,]
                {
                    { "3025d94e-c32f-429e-8d4d-f77fa80616fc", "d4e55416-dee3-455f-8b3a-fba65cd2576b" },
                    { "3443a8c8-2100-40e1-96f1-c40561914eb1", "61fb08fb-3145-4a4c-b4cd-afd6b39fae33" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatsId", "cinemaRoomId", "isDelete", "isServed", "isTaken", "seatsNumber" },
                values: new object[,]
                {
                    { "c86fa13a-12e6-4ee7-b9a6-48c840d60a4d", "b8db568f-279f-4721-9b39-011c8fb96655", false, true, false, "A1" },
                    { "e7e02423-f9fc-4ece-aad4-e69fb9802e5f", "b8db568f-279f-4721-9b39-011c8fb96655", false, true, false, "A2" }
                });

            migrationBuilder.InsertData(
                table: "movieGenreInformation",
                columns: new[] { "movieGenreId", "movieId" },
                values: new object[,]
                {
                    { "1b9a3055-4af5-4750-b3d6-815b9876402b", "4baf65a6-4db7-4c30-93d5-afe24315c7ee" },
                    { "124ae20c-f652-4edb-8420-ba9c2a20ffb6", "67868ce3-b1f7-4bc9-bd39-d6299ea6e0c8" }
                });

            migrationBuilder.InsertData(
                table: "movieSchedule",
                columns: new[] { "movieScheduleId", "DayInWeekendSchedule", "HourScheduleID", "IsDelete", "ScheduleDate", "cinemaID", "cinemaRoomId", "movieId", "movieVisualFormatID" },
                values: new object[] { "4a8cde71-04d9-4074-a070-5621a0c2dacc", "Monday", "bf03f24b-3817-4ca9-af00-218b27e3add8", false, new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "78d18c38-e169-4b4b-b35b-b738b2c28f36", "b8db568f-279f-4721-9b39-011c8fb96655", "67868ce3-b1f7-4bc9-bd39-d6299ea6e0c8", "" });

            migrationBuilder.CreateIndex(
                name: "IX_movieSchedule_cinemaID",
                table: "movieSchedule",
                column: "cinemaID");

            migrationBuilder.CreateIndex(
                name: "IX_movieSchedule_cinemaRoomId_cinemaID_ScheduleDate",
                table: "movieSchedule",
                columns: new[] { "cinemaRoomId", "cinemaID", "ScheduleDate" },
                unique: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_movieSchedule_Cinema_cinemaID",
                table: "movieSchedule",
                column: "cinemaID",
                principalTable: "Cinema",
                principalColumn: "cinemaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
