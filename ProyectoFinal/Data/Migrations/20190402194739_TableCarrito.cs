using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.Data.Migrations
{
    public partial class TableCarrito : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carrito",
                columns: table => new
                {
                    CarritoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sesion = table.Column<string>(nullable: true),
                    Registrado = table.Column<DateTime>(nullable: false),
                    ProductoID = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    Precio = table.Column<decimal>(nullable: false),
                    Descuento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrito", x => x.CarritoID);
                    table.ForeignKey(
                        name: "FK_Carrito_Productos_ProductoID",
                        column: x => x.ProductoID,
                        principalTable: "Productos",
                        principalColumn: "ProductoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carrito_ProductoID",
                table: "Carrito",
                column: "ProductoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carrito");
        }
    }
}
