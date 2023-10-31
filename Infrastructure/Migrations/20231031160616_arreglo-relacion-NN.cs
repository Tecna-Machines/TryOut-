using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class arreglorelacionNN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductosFormato_Formatos_FormatoDescripcionFormato",
                table: "ProductosFormato");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductosFormato_Productos_ProductoNombreProducto",
                table: "ProductosFormato");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoSMaquinas_Maquinas_MaquinaNumMaquina",
                table: "ProductoSMaquinas");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoSMaquinas_Productos_ProductoNombreProducto",
                table: "ProductoSMaquinas");

            migrationBuilder.DropIndex(
                name: "IX_ProductoSMaquinas_MaquinaNumMaquina",
                table: "ProductoSMaquinas");

            migrationBuilder.DropIndex(
                name: "IX_ProductoSMaquinas_ProductoNombreProducto",
                table: "ProductoSMaquinas");

            migrationBuilder.DropIndex(
                name: "IX_ProductosFormato_FormatoDescripcionFormato",
                table: "ProductosFormato");

            migrationBuilder.DropIndex(
                name: "IX_ProductosFormato_ProductoNombreProducto",
                table: "ProductosFormato");

            migrationBuilder.DropColumn(
                name: "MaquinaNumMaquina",
                table: "ProductoSMaquinas");

            migrationBuilder.DropColumn(
                name: "ProductoNombreProducto",
                table: "ProductoSMaquinas");

            migrationBuilder.DropColumn(
                name: "FormatoDescripcionFormato",
                table: "ProductosFormato");

            migrationBuilder.DropColumn(
                name: "ProductoNombreProducto",
                table: "ProductosFormato");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoSMaquinas_NombreProducto",
                table: "ProductoSMaquinas",
                column: "NombreProducto");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosFormato_DescripcionFormato",
                table: "ProductosFormato",
                column: "DescripcionFormato");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductosFormato_Formatos_DescripcionFormato",
                table: "ProductosFormato",
                column: "DescripcionFormato",
                principalTable: "Formatos",
                principalColumn: "DescripcionFormato",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductosFormato_Productos_NombreProducto",
                table: "ProductosFormato",
                column: "NombreProducto",
                principalTable: "Productos",
                principalColumn: "NombreProducto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoSMaquinas_Maquinas_NumMaquina",
                table: "ProductoSMaquinas",
                column: "NumMaquina",
                principalTable: "Maquinas",
                principalColumn: "NumMaquina",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoSMaquinas_Productos_NombreProducto",
                table: "ProductoSMaquinas",
                column: "NombreProducto",
                principalTable: "Productos",
                principalColumn: "NombreProducto",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductosFormato_Formatos_DescripcionFormato",
                table: "ProductosFormato");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductosFormato_Productos_NombreProducto",
                table: "ProductosFormato");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoSMaquinas_Maquinas_NumMaquina",
                table: "ProductoSMaquinas");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoSMaquinas_Productos_NombreProducto",
                table: "ProductoSMaquinas");

            migrationBuilder.DropIndex(
                name: "IX_ProductoSMaquinas_NombreProducto",
                table: "ProductoSMaquinas");

            migrationBuilder.DropIndex(
                name: "IX_ProductosFormato_DescripcionFormato",
                table: "ProductosFormato");

            migrationBuilder.AddColumn<string>(
                name: "MaquinaNumMaquina",
                table: "ProductoSMaquinas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductoNombreProducto",
                table: "ProductoSMaquinas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormatoDescripcionFormato",
                table: "ProductosFormato",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductoNombreProducto",
                table: "ProductosFormato",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductoSMaquinas_MaquinaNumMaquina",
                table: "ProductoSMaquinas",
                column: "MaquinaNumMaquina");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoSMaquinas_ProductoNombreProducto",
                table: "ProductoSMaquinas",
                column: "ProductoNombreProducto");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosFormato_FormatoDescripcionFormato",
                table: "ProductosFormato",
                column: "FormatoDescripcionFormato");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosFormato_ProductoNombreProducto",
                table: "ProductosFormato",
                column: "ProductoNombreProducto");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductosFormato_Formatos_FormatoDescripcionFormato",
                table: "ProductosFormato",
                column: "FormatoDescripcionFormato",
                principalTable: "Formatos",
                principalColumn: "DescripcionFormato");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductosFormato_Productos_ProductoNombreProducto",
                table: "ProductosFormato",
                column: "ProductoNombreProducto",
                principalTable: "Productos",
                principalColumn: "NombreProducto");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoSMaquinas_Maquinas_MaquinaNumMaquina",
                table: "ProductoSMaquinas",
                column: "MaquinaNumMaquina",
                principalTable: "Maquinas",
                principalColumn: "NumMaquina");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoSMaquinas_Productos_ProductoNombreProducto",
                table: "ProductoSMaquinas",
                column: "ProductoNombreProducto",
                principalTable: "Productos",
                principalColumn: "NombreProducto");
        }
    }
}
