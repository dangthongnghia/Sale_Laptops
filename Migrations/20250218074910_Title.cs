using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sale_laptop_online.Migrations
{
    /// <inheritdoc />
    public partial class Title : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Battery",
                table: "Laptop",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Laptop",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Laptop",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Battery",
                table: "Laptop");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Laptop");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Laptop");
        }
    }
}
