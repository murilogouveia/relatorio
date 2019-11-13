﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using relatorio.Data;

namespace relatorio.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191111224926_version1")]
    partial class version1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("relatorio.Models.Grupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("NumeroGrupo")
                        .HasColumnType("int");

                    b.Property<string>("Responsavel")
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4")
                        .HasMaxLength(80);

                    b.HasKey("Id");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("relatorio.Models.Publicador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Anciao")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("GrupoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4")
                        .HasMaxLength(80);

                    b.Property<bool>("PioneiroAuxiliar")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("PioneiroRegular")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("PublicadorBatizado")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ServoMinisterial")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Sexo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("GrupoId");

                    b.ToTable("Publicadores");
                });

            modelBuilder.Entity("relatorio.Models.Publicador", b =>
                {
                    b.HasOne("relatorio.Models.Grupo", "Grupo")
                        .WithMany()
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}