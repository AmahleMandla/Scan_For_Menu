using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Scan_For_Menu.Data.Migrations
{
    public partial class addToCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemDescr",
                table: "MenuItem");

            migrationBuilder.AlterColumn<float>(
                name: "ItemPrice",
                table: "MenuItem",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "ItemImage",
                table: "MenuItem",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AddColumn<string>(
                name: "ItemDescr",
                table: "MenuItem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemDescr",
                table: "MenuItem");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemPrice",
                table: "MenuItem",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<byte[]>(
                name: "ItemImage",
                table: "MenuItem",
                type: "varbinary(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ItemDescr",
                table: "MenuItem",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
