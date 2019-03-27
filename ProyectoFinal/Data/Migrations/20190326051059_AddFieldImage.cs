using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.Data.Migrations
{
    public partial class AddFieldImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Productos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Productos");
        }
    }
}
