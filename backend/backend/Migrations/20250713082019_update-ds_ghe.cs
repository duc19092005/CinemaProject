using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class updateds_ghe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "030ad83d-9628-4a5e-9515-fbf51710d4d5");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "0f74e933-01fe-4cb7-af79-2ac23d21c864");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "1b4223f9-2597-4d09-9248-13c2cba14f15");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "246fcee7-13d4-46ca-8bd5-70bd8f3a1a88");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "2e60c88d-6550-4400-912e-fb17d55e428c");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "4161a7d8-8435-4e0d-bda0-8486e761eb5a");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "5294d0e1-31d5-45c9-9a7d-ed2e04284721");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "53d87829-a9ae-4b90-9829-9a8a91cd5a45");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "6b52538f-3bf1-400d-acda-1229c2550ace");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "6d74d5b0-0c6b-410e-9975-eec545617a28");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "719d3123-7e1e-452f-8cc4-193f827fe209");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "9aafad84-181b-438f-b26c-1e93ae09ef21");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "a52a82cf-9ace-449e-8e04-deb5227e9a22");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "af47bb78-a399-40b0-b3ba-a07a36fe837c");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "b5c36431-e498-4def-b5ad-c70267d49eea");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "c3d06288-c05e-40f5-ba16-ac56d269e2dc");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "da1f8742-6d42-4662-98d0-f5e43789e1cb");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "e223566a-8d60-4a55-9090-f2ddeb612b54");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "ee5fbcca-bf10-4dc3-9165-9e549a422f57");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "f0ca2e55-213b-4f39-9d6e-cab89bf39309");

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatsId", "cinemaRoomId", "isDelete", "isTaken", "seatsNumber" },
                values: new object[,]
                {
                    { "a1b2c3d4-e5f6-7a8b-9c0d-1e2f3a4b5c6d", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A3" },
                    { "a3b4c5d6-e7f8-9a0b-1c2d-3e4f5a6b7c8d", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A15" },
                    { "a7b8c9d0-e1f2-3a4b-5c6d-7e8f9a0b1c2d", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A9" },
                    { "a9b0c1d2-e3f4-5f6a-7b8c-9d0e1f2a3b4c", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A21" },
                    { "b0c1d2e3-f4a5-6a7b-8c9d-0e1f2a3b4c5d", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A22" },
                    { "b2c3d4e5-f6a7-8b9c-0d1e-2f3a4b5c6d7e", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A4" },
                    { "b4c5d6e7-f8a9-0b1c-2d3e-4f5a6b7c8d9e", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A16" },
                    { "b8c9d0e1-f2a3-4b5c-6d7e-8f9a0b1c2d3e", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A10" },
                    { "c3d4e5f6-a7b8-9c0d-1e2f-3a4b5c6d7e8f", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A5" },
                    { "c5d6e7f8-a9b0-1c2d-3e4f-5a6b7c8d9e0f", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A17" },
                    { "c9d0e1f2-a3b4-5c6d-7e8f-9a0b1c2d3e4f", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A11" },
                    { "d0e1f2a3-b4c5-6d7e-8f9a-0b1c2d3e4f5a", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A12" },
                    { "d4e5f6a7-b8c9-0d1e-2f3a-4b5c6d7e8f9a", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A6" },
                    { "d6e7f8a9-b0c1-2c3d-4e5f-6a7b8c9d0e1f", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A18" },
                    { "e1f2a3b4-c5d6-7e8f-9a0b-1c2d3e4f5a6b", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A13" },
                    { "e5f6a7b8-c9d0-1e2f-3a4b-5c6d7e8f9a0b", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A7" },
                    { "e7f8a9b0-c1d2-3d4e-5f6a-7b8c9d0e1f2a", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A19" },
                    { "f2a3b4c5-d6e7-8f9a-0b1c-2d3e4f5a6b7c", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A14" },
                    { "f6a7b8c9-d0e1-2f3a-4b5c-6d7e8f9a0b1c", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A8" },
                    { "f8a9b0c1-d2e3-4e5f-6a7b-8c9d0e1f2a3b", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A20" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "a1b2c3d4-e5f6-7a8b-9c0d-1e2f3a4b5c6d");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "a3b4c5d6-e7f8-9a0b-1c2d-3e4f5a6b7c8d");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "a7b8c9d0-e1f2-3a4b-5c6d-7e8f9a0b1c2d");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "a9b0c1d2-e3f4-5f6a-7b8c-9d0e1f2a3b4c");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "b0c1d2e3-f4a5-6a7b-8c9d-0e1f2a3b4c5d");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "b2c3d4e5-f6a7-8b9c-0d1e-2f3a4b5c6d7e");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "b4c5d6e7-f8a9-0b1c-2d3e-4f5a6b7c8d9e");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "b8c9d0e1-f2a3-4b5c-6d7e-8f9a0b1c2d3e");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "c3d4e5f6-a7b8-9c0d-1e2f-3a4b5c6d7e8f");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "c5d6e7f8-a9b0-1c2d-3e4f-5a6b7c8d9e0f");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "c9d0e1f2-a3b4-5c6d-7e8f-9a0b1c2d3e4f");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "d0e1f2a3-b4c5-6d7e-8f9a-0b1c2d3e4f5a");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "d4e5f6a7-b8c9-0d1e-2f3a-4b5c6d7e8f9a");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "d6e7f8a9-b0c1-2c3d-4e5f-6a7b8c9d0e1f");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "e1f2a3b4-c5d6-7e8f-9a0b-1c2d3e4f5a6b");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "e5f6a7b8-c9d0-1e2f-3a4b-5c6d7e8f9a0b");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "e7f8a9b0-c1d2-3d4e-5f6a-7b8c9d0e1f2a");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "f2a3b4c5-d6e7-8f9a-0b1c-2d3e4f5a6b7c");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "f6a7b8c9-d0e1-2f3a-4b5c-6d7e8f9a0b1c");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "seatsId",
                keyValue: "f8a9b0c1-d2e3-4e5f-6a7b-8c9d0e1f2a3b");

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "seatsId", "cinemaRoomId", "isDelete", "isTaken", "seatsNumber" },
                values: new object[,]
                {
                    { "030ad83d-9628-4a5e-9515-fbf51710d4d5", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A22" },
                    { "0f74e933-01fe-4cb7-af79-2ac23d21c864", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A12" },
                    { "1b4223f9-2597-4d09-9248-13c2cba14f15", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A16" },
                    { "246fcee7-13d4-46ca-8bd5-70bd8f3a1a88", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A17" },
                    { "2e60c88d-6550-4400-912e-fb17d55e428c", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A15" },
                    { "4161a7d8-8435-4e0d-bda0-8486e761eb5a", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A4" },
                    { "5294d0e1-31d5-45c9-9a7d-ed2e04284721", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A14" },
                    { "53d87829-a9ae-4b90-9829-9a8a91cd5a45", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A19" },
                    { "6b52538f-3bf1-400d-acda-1229c2550ace", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A20" },
                    { "6d74d5b0-0c6b-410e-9975-eec545617a28", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A7" },
                    { "719d3123-7e1e-452f-8cc4-193f827fe209", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A18" },
                    { "9aafad84-181b-438f-b26c-1e93ae09ef21", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A10" },
                    { "a52a82cf-9ace-449e-8e04-deb5227e9a22", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A9" },
                    { "af47bb78-a399-40b0-b3ba-a07a36fe837c", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A11" },
                    { "b5c36431-e498-4def-b5ad-c70267d49eea", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A8" },
                    { "c3d06288-c05e-40f5-ba16-ac56d269e2dc", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A21" },
                    { "da1f8742-6d42-4662-98d0-f5e43789e1cb", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A13" },
                    { "e223566a-8d60-4a55-9090-f2ddeb612b54", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A5" },
                    { "ee5fbcca-bf10-4dc3-9165-9e549a422f57", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A3" },
                    { "f0ca2e55-213b-4f39-9d6e-cab89bf39309", "6d7e8f9a-0b1c-2d3e-4f5a-6b7c8d9e0f1a", false, false, "A6" }
                });
        }
    }
}
