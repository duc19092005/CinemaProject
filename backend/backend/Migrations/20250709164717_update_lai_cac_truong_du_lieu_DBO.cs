using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class update_lai_cac_truong_du_lieu_DBO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketOrderDetail_priceInformation_priceInformationId",
                table: "TicketOrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_TicketOrderDetail_priceInformationId",
                table: "TicketOrderDetail");

            migrationBuilder.DropColumn(
                name: "priceInformationId",
                table: "TicketOrderDetail");

            migrationBuilder.DropColumn(
                name: "isPay",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "paymentDate",
                table: "Order",
                newName: "paymentRequestCreatedDate");

            migrationBuilder.AddColumn<string>(
                name: "PaymentStatus",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "paymentRequestCreatedDate",
                table: "Order",
                newName: "paymentDate");

            migrationBuilder.AddColumn<string>(
                name: "priceInformationId",
                table: "TicketOrderDetail",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "isPay",
                table: "Order",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_TicketOrderDetail_priceInformationId",
                table: "TicketOrderDetail",
                column: "priceInformationId");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketOrderDetail_priceInformation_priceInformationId",
                table: "TicketOrderDetail",
                column: "priceInformationId",
                principalTable: "priceInformation",
                principalColumn: "priceInformationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
