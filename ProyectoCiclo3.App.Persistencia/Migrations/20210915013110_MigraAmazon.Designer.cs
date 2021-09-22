﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoCiclo3.App.Persistencia;

namespace ProyectoCiclo3.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20210915013110_MigraAmazon")]
    partial class MigraAmazon
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ProyectoCiclo3.App.Dominio.Encomienda", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("peso")
                        .HasColumnType("int");

                    b.Property<string>("presentacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Encomiendas");
                });

            modelBuilder.Entity("ProyectoCiclo3.App.Dominio.Servicio", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("destino")
                        .HasColumnType("int");

                    b.Property<int>("encomienda")
                        .HasColumnType("int");

                    b.Property<string>("fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("origen")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("ProyectoCiclo3.App.Dominio.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("apellidos")
                        .HasColumnType("int");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
