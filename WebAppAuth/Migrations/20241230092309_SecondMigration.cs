using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAppAuth.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "751f7bce-55e4-43e0-9254-0e861839125e", null, "admin", "admin" },
                    { "dd94d8c7-9875-4244-ac0b-72231f92a0a7", null, "seller", "seller" },
                    { "fdb8efcf-10d3-4c69-84b3-94d02fad76e6", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "751f7bce-55e4-43e0-9254-0e861839125e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd94d8c7-9875-4244-ac0b-72231f92a0a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdb8efcf-10d3-4c69-84b3-94d02fad76e6");
        }
    }
}
