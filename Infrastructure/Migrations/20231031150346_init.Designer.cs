﻿// <auto-generated />
using System;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(TryOutContext))]
    [Migration("20231031150346_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("Domain.Entities.Formato", b =>
                {
                    b.Property<string>("DescripcionFormato")
                        .HasColumnType("TEXT");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Unidad")
                        .HasColumnType("TEXT");

                    b.HasKey("DescripcionFormato");

                    b.ToTable("Formatos");
                });

            modelBuilder.Entity("Domain.Entities.Maquina", b =>
                {
                    b.Property<string>("NumMaquina")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("NumMaquina");

                    b.ToTable("Maquinas");
                });

            modelBuilder.Entity("Domain.Entities.Parada", b =>
                {
                    b.Property<Guid>("NumParada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Causa")
                        .HasColumnType("TEXT");

                    b.Property<string>("Encargado")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EsExterna")
                        .HasColumnType("INTEGER");

                    b.Property<TimeOnly>("HoraFin")
                        .HasColumnType("TEXT");

                    b.Property<TimeOnly>("HoraInicio")
                        .HasColumnType("TEXT");

                    b.Property<int>("Numprueba")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PruebaNumprueba")
                        .HasColumnType("INTEGER");

                    b.HasKey("NumParada");

                    b.HasIndex("PruebaNumprueba");

                    b.ToTable("Paradas");
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.Property<string>("NombreProducto")
                        .HasColumnType("TEXT");

                    b.Property<string>("Marca")
                        .HasColumnType("TEXT");

                    b.HasKey("NombreProducto");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Domain.Entities.ProductoFormato", b =>
                {
                    b.Property<string>("NombreProducto")
                        .HasColumnType("TEXT");

                    b.Property<string>("DescripcionFormato")
                        .HasColumnType("TEXT");

                    b.Property<string>("FormatoDescripcionFormato")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductoNombreProducto")
                        .HasColumnType("TEXT");

                    b.HasKey("NombreProducto", "DescripcionFormato");

                    b.HasIndex("FormatoDescripcionFormato");

                    b.HasIndex("ProductoNombreProducto");

                    b.ToTable("ProductosFormato");
                });

            modelBuilder.Entity("Domain.Entities.ProductoMaquina", b =>
                {
                    b.Property<string>("NumMaquina")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreProducto")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaquinaNumMaquina")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductoNombreProducto")
                        .HasColumnType("TEXT");

                    b.HasKey("NumMaquina", "NombreProducto");

                    b.HasIndex("MaquinaNumMaquina");

                    b.HasIndex("ProductoNombreProducto");

                    b.ToTable("ProductoSMaquinas");
                });

            modelBuilder.Entity("Domain.Entities.Prueba", b =>
                {
                    b.Property<int>("Numprueba")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescripcionFormato")
                        .HasColumnType("TEXT");

                    b.Property<string>("Encargado")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("TEXT");

                    b.Property<string>("FormatoDescripcionFormato")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaquinaNumMaquina")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumMaquina")
                        .HasColumnType("TEXT");

                    b.Property<string>("Observacion")
                        .HasColumnType("TEXT");

                    b.Property<int>("VelocidadTeoria")
                        .HasColumnType("INTEGER");

                    b.HasKey("Numprueba");

                    b.HasIndex("FormatoDescripcionFormato");

                    b.HasIndex("MaquinaNumMaquina");

                    b.ToTable("Pruebas");
                });

            modelBuilder.Entity("Domain.Entities.Resultado", b =>
                {
                    b.Property<Guid>("IdResultado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("CantBuenas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantBuenasEnCajaMalas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantMalas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantMalasEnCajaBuenas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantScrap")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Numprueba")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdResultado");

                    b.HasIndex("Numprueba")
                        .IsUnique();

                    b.ToTable("Resultados");
                });

            modelBuilder.Entity("Domain.Entities.Parada", b =>
                {
                    b.HasOne("Domain.Entities.Prueba", "Prueba")
                        .WithMany("Paradas")
                        .HasForeignKey("PruebaNumprueba");

                    b.Navigation("Prueba");
                });

            modelBuilder.Entity("Domain.Entities.ProductoFormato", b =>
                {
                    b.HasOne("Domain.Entities.Formato", "Formato")
                        .WithMany("ProductosFormatos")
                        .HasForeignKey("FormatoDescripcionFormato");

                    b.HasOne("Domain.Entities.Producto", "Producto")
                        .WithMany("ProductosFormatos")
                        .HasForeignKey("ProductoNombreProducto");

                    b.Navigation("Formato");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Domain.Entities.ProductoMaquina", b =>
                {
                    b.HasOne("Domain.Entities.Maquina", "Maquina")
                        .WithMany("ProductosMaquinas")
                        .HasForeignKey("MaquinaNumMaquina");

                    b.HasOne("Domain.Entities.Producto", "Producto")
                        .WithMany("ProductosMaquinas")
                        .HasForeignKey("ProductoNombreProducto");

                    b.Navigation("Maquina");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Domain.Entities.Prueba", b =>
                {
                    b.HasOne("Domain.Entities.Formato", "Formato")
                        .WithMany("Pruebas")
                        .HasForeignKey("FormatoDescripcionFormato");

                    b.HasOne("Domain.Entities.Maquina", "Maquina")
                        .WithMany("Pruebas")
                        .HasForeignKey("MaquinaNumMaquina");

                    b.Navigation("Formato");

                    b.Navigation("Maquina");
                });

            modelBuilder.Entity("Domain.Entities.Resultado", b =>
                {
                    b.HasOne("Domain.Entities.Prueba", "Prueba")
                        .WithOne("Resultado")
                        .HasForeignKey("Domain.Entities.Resultado", "Numprueba")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prueba");
                });

            modelBuilder.Entity("Domain.Entities.Formato", b =>
                {
                    b.Navigation("ProductosFormatos");

                    b.Navigation("Pruebas");
                });

            modelBuilder.Entity("Domain.Entities.Maquina", b =>
                {
                    b.Navigation("ProductosMaquinas");

                    b.Navigation("Pruebas");
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.Navigation("ProductosFormatos");

                    b.Navigation("ProductosMaquinas");
                });

            modelBuilder.Entity("Domain.Entities.Prueba", b =>
                {
                    b.Navigation("Paradas");

                    b.Navigation("Resultado");
                });
#pragma warning restore 612, 618
        }
    }
}
