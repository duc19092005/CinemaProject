using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class updatedatacustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "IdentityCode", "Name", "dateOfBirth", "phoneNumber", "userID" },
                values: new object[] { "a1b2c3d4-e5f6-7a8b-c9d0-e1f2a3b4c5e1", "0123456789", "Trần Anh Đức", new DateTime(2005, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "1234567890", "b2c3d4e5-f6a7-8b9c-d0e1-f2a3b4c5d6e7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-e5f6-7a8b-c9d0-e1f2a3b4c5e1");
        }
    }
}
