using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Formatos",
                columns: table => new
                {
                    DescripcionFormato = table.Column<string>(type: "TEXT", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    Unidad = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formatos", x => x.DescripcionFormato);
                });

            migrationBuilder.CreateTable(
                name: "Maquinas",
                columns: table => new
                {
                    NumMaquina = table.Column<string>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maquinas", x => x.NumMaquina);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    NombreProducto = table.Column<string>(type: "TEXT", nullable: false),
                    Marca = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.NombreProducto);
                });

            migrationBuilder.CreateTable(
                name: "Pruebas",
                columns: table => new
                {
                    Numprueba = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Observacion = table.Column<string>(type: "TEXT", nullable: true),
                    Encargado = table.Column<string>(type: "TEXT", nullable: true),
                    VelocidadTeoria = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DescripcionFormato = table.Column<string>(type: "TEXT", nullable: true),
                    FormatoDescripcionFormato = table.Column<string>(type: "TEXT", nullable: true),
                    NumMaquina = table.Column<string>(type: "TEXT", nullable: true),
                    MaquinaNumMaquina = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pruebas", x => x.Numprueba);
                    table.ForeignKey(
                        name: "FK_Pruebas_Formatos_FormatoDescripcionFormato",
                        column: x => x.FormatoDescripcionFormato,
                        principalTable: "Formatos",
                        principalColumn: "DescripcionFormato");
                    table.ForeignKey(
                        name: "FK_Pruebas_Maquinas_MaquinaNumMaquina",
                        column: x => x.MaquinaNumMaquina,
                        principalTable: "Maquinas",
                        principalColumn: "NumMaquina");
                });

            migrationBuilder.CreateTable(
                name: "ProductosFormato",
                columns: table => new
                {
                    NombreProducto = table.Column<string>(type: "TEXT", nullable: false),
                    DescripcionFormato = table.Column<string>(type: "TEXT", nullable: false),
                    ProductoNombreProducto = table.Column<string>(type: "TEXT", nullable: true),
                    FormatoDescripcionFormato = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosFormato", x => new { x.NombreProducto, x.DescripcionFormato });
                    table.ForeignKey(
                        name: "FK_ProductosFormato_Formatos_FormatoDescripcionFormato",
                        column: x => x.FormatoDescripcionFormato,
                        principalTable: "Formatos",
                        principalColumn: "DescripcionFormato");
                    table.ForeignKey(
                        name: "FK_ProductosFormato_Productos_ProductoNombreProducto",
                        column: x => x.ProductoNombreProducto,
                        principalTable: "Productos",
                        principalColumn: "NombreProducto");
                });

            migrationBuilder.CreateTable(
                name: "ProductoSMaquinas",
                columns: table => new
                {
                    NumMaquina = table.Column<string>(type: "TEXT", nullable: false),
                    NombreProducto = table.Column<string>(type: "TEXT", nullable: false),
                    MaquinaNumMaquina = table.Column<string>(type: "TEXT", nullable: true),
                    ProductoNombreProducto = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoSMaquinas", x => new { x.NumMaquina, x.NombreProducto });
                    table.ForeignKey(
                        name: "FK_ProductoSMaquinas_Maquinas_MaquinaNumMaquina",
                        column: x => x.MaquinaNumMaquina,
                        principalTable: "Maquinas",
                        principalColumn: "NumMaquina");
                    table.ForeignKey(
                        name: "FK_ProductoSMaquinas_Productos_ProductoNombreProducto",
                        column: x => x.ProductoNombreProducto,
                        principalTable: "Productos",
                        principalColumn: "NombreProducto");
                });

            migrationBuilder.CreateTable(
                name: "Paradas",
                columns: table => new
                {
                    NumParada = table.Column<Guid>(type: "TEXT", nullable: false),
                    Causa = table.Column<string>(type: "TEXT", nullable: true),
                    EsExterna = table.Column<bool>(type: "INTEGER", nullable: false),
                    HoraInicio = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    HoraFin = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    Numprueba = table.Column<int>(type: "INTEGER", nullable: false),
                    Encargado = table.Column<string>(type: "TEXT", nullable: true),
                    PruebaNumprueba = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paradas", x => x.NumParada);
                    table.ForeignKey(
                        name: "FK_Paradas_Pruebas_PruebaNumprueba",
                        column: x => x.PruebaNumprueba,
                        principalTable: "Pruebas",
                        principalColumn: "Numprueba");
                });

            migrationBuilder.CreateTable(
                name: "Resultados",
                columns: table => new
                {
                    IdResultado = table.Column<Guid>(type: "TEXT", nullable: false),
                    CantMalas = table.Column<int>(type: "INTEGER", nullable: false),
                    CantBuenas = table.Column<int>(type: "INTEGER", nullable: false),
                    CantScrap = table.Column<int>(type: "INTEGER", nullable: false),
                    CantBuenasEnCajaMalas = table.Column<int>(type: "INTEGER", nullable: false),
                    CantMalasEnCajaBuenas = table.Column<int>(type: "INTEGER", nullable: false),
                    Numprueba = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resultados", x => x.IdResultado);
                    table.ForeignKey(
                        name: "FK_Resultados_Pruebas_Numprueba",
                        column: x => x.Numprueba,
                        principalTable: "Pruebas",
                        principalColumn: "Numprueba",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paradas_PruebaNumprueba",
                table: "Paradas",
                column: "PruebaNumprueba");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosFormato_FormatoDescripcionFormato",
                table: "ProductosFormato",
                column: "FormatoDescripcionFormato");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosFormato_ProductoNombreProducto",
                table: "ProductosFormato",
                column: "ProductoNombreProducto");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoSMaquinas_MaquinaNumMaquina",
                table: "ProductoSMaquinas",
                column: "MaquinaNumMaquina");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoSMaquinas_ProductoNombreProducto",
                table: "ProductoSMaquinas",
                column: "ProductoNombreProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Pruebas_FormatoDescripcionFormato",
                table: "Pruebas",
                column: "FormatoDescripcionFormato");

            migrationBuilder.CreateIndex(
                name: "IX_Pruebas_MaquinaNumMaquina",
                table: "Pruebas",
                column: "MaquinaNumMaquina");

            migrationBuilder.CreateIndex(
                name: "IX_Resultados_Numprueba",
                table: "Resultados",
                column: "Numprueba",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paradas");

            migrationBuilder.DropTable(
                name: "ProductosFormato");

            migrationBuilder.DropTable(
                name: "ProductoSMaquinas");

            migrationBuilder.DropTable(
                name: "Resultados");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Pruebas");

            migrationBuilder.DropTable(
                name: "Formatos");

            migrationBuilder.DropTable(
                name: "Maquinas");
        }
    }
}
