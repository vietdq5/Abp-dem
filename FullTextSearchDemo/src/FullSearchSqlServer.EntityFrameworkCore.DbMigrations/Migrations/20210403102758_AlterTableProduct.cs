using Microsoft.EntityFrameworkCore.Migrations;

namespace FullSearchSqlServer.Migrations
{
    public partial class AlterTableProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "AppProducts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AppProducts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderMaxQuantity",
                table: "AppProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderMinQuantity",
                table: "AppProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "OriginalPrice",
                table: "AppProducts",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "AppProducts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "AppProducts");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AppProducts");

            migrationBuilder.DropColumn(
                name: "OrderMaxQuantity",
                table: "AppProducts");

            migrationBuilder.DropColumn(
                name: "OrderMinQuantity",
                table: "AppProducts");

            migrationBuilder.DropColumn(
                name: "OriginalPrice",
                table: "AppProducts");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "AppProducts");
        }
    }
}
