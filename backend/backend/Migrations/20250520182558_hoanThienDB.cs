using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class hoanThienDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "foodInformation",
                columns: table => new
                {
                    foodInformationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    foodInformationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_foodInformation", x => x.foodInformationId);
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

            migrationBuilder.CreateIndex(
                name: "IX_orderDetailFood_foodInformationId",
                table: "orderDetailFood",
                column: "foodInformationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orderDetailFood");

            migrationBuilder.DropTable(
                name: "foodInformation");
        }
    }
}
