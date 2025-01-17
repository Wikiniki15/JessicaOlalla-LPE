﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JessicaOlalla_LPE.Migrations
{
    [DbContext(typeof(EquipoContext))]
    partial class EquipoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JessicaOlalla_LPE.Models.Equipo", b =>
                {
                    b.Property<int>("Id_Equipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Equipo"));

                    b.Property<bool>("Acepta_Extranjeros")
                        .HasColumnType("bit");

                    b.Property<string>("Ciudad_Equipo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("EstadioId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre_Equipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Titulos")
                        .HasColumnType("int");

                    b.HasKey("Id_Equipo");

                    b.HasIndex("EstadioId");

                    b.ToTable("Equipo");
                });

            modelBuilder.Entity("JessicaOlalla_LPE.Models.Estadio", b =>
                {
                    b.Property<int>("Id_Estadio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Estadio"));

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<string>("Ciudad_Estadio")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombre_Estadio")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id_Estadio");

                    b.ToTable("Estadio");
                });

            modelBuilder.Entity("JessicaOlalla_LPE.Models.Jugador", b =>
                {
                    b.Property<int>("Id_Jugador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Jugador"));

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre_Jugador")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Posicion")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id_Jugador");

                    b.HasIndex("EquipoId");

                    b.ToTable("Jugador");
                });

            modelBuilder.Entity("JessicaOlalla_LPE.Models.Equipo", b =>
                {
                    b.HasOne("JessicaOlalla_LPE.Models.Estadio", "estadio")
                        .WithMany()
                        .HasForeignKey("EstadioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("estadio");
                });

            modelBuilder.Entity("JessicaOlalla_LPE.Models.Jugador", b =>
                {
                    b.HasOne("JessicaOlalla_LPE.Models.Equipo", "equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("equipo");
                });
#pragma warning restore 612, 618
        }
    }
}
