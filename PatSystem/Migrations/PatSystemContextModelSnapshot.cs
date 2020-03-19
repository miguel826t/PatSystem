﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PatSystem.Data;

namespace PatSystem.Migrations
{
    [DbContext(typeof(PatSystemContext))]
    partial class PatSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PatSystem.Models.Curriculo.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AreaAtuacao")
                        .IsRequired()
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("EnsinoMedio")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<int>("TlFixo")
                        .HasColumnType("int");

                    b.Property<int>("TlMovel")
                        .HasColumnType("int");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("PatSystem.Models.Curriculo.Curriculo", b =>
                {
                    b.Property<int>("CurriculoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<string>("CursoSuperiorSN")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CursoTecnicoSN")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("IdiomaSN")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CurriculoID");

                    b.HasIndex("ClienteID");

                    b.ToTable("Curriculo");
                });

            modelBuilder.Entity("PatSystem.Models.Curriculo.Cursos.CursoSuperior", b =>
                {
                    b.Property<int>("CurriculoID")
                        .HasColumnType("int");

                    b.Property<int>("CursoSuperiorId")
                        .HasColumnType("int");

                    b.Property<string>("Instituicao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Modalidade")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CurriculoID", "CursoSuperiorId");

                    b.ToTable("CursoSuperior");
                });

            modelBuilder.Entity("PatSystem.Models.Curriculo.Cursos.CursoTecnico", b =>
                {
                    b.Property<int>("CurriculoID")
                        .HasColumnType("int");

                    b.Property<int>("CursoTecnicoId")
                        .HasColumnType("int");

                    b.Property<string>("Instituicao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Modalidade")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CurriculoID", "CursoTecnicoId");

                    b.ToTable("CursoTecnico");
                });

            modelBuilder.Entity("PatSystem.Models.Curriculo.Experiencia", b =>
                {
                    b.Property<int>("CurriculoID")
                        .HasColumnType("int");

                    b.Property<int>("ExperienciaId")
                        .HasColumnType("int");

                    b.Property<double?>("Anos")
                        .HasColumnType("double");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NomeEmpresa")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UltimoCargo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CurriculoID", "ExperienciaId");

                    b.ToTable("Experiencia");
                });

            modelBuilder.Entity("PatSystem.Models.Curriculo.Idioma", b =>
                {
                    b.Property<int>("CurriculoID")
                        .HasColumnType("int");

                    b.Property<int>("IdiomaId")
                        .HasColumnType("int");

                    b.Property<int?>("AnosCursados")
                        .HasColumnType("int");

                    b.Property<string>("Instituicao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("NivelFluencia")
                        .HasColumnType("int");

                    b.Property<int>("Nome")
                        .HasColumnType("int");

                    b.HasKey("CurriculoID", "IdiomaId");

                    b.ToTable("Idioma");
                });

            modelBuilder.Entity("PatSystem.Models.SegDesemprego.Cbo", b =>
                {
                    b.Property<int>("CodCboId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("CodCboId");

                    b.ToTable("Cbo");
                });

            modelBuilder.Entity("PatSystem.Models.SegDesemprego.Empresa", b =>
                {
                    b.Property<string>("EmpresaId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("Segmento")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("EmpresaId");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("PatSystem.Models.SegDesemprego.Seguro", b =>
                {
                    b.Property<double>("SeguroId")
                        .HasColumnType("double");

                    b.Property<int>("CodCboid")
                        .HasColumnType("int");

                    b.Property<string>("CodSeguro")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("EmpresaId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("SeguroId");

                    b.HasIndex("CodCboid");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Seguro");
                });

            modelBuilder.Entity("PatSystem.Models.Curriculo.Curriculo", b =>
                {
                    b.HasOne("PatSystem.Models.Curriculo.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PatSystem.Models.Curriculo.Cursos.CursoSuperior", b =>
                {
                    b.HasOne("PatSystem.Models.Curriculo.Curriculo", "Curriculo")
                        .WithMany()
                        .HasForeignKey("CurriculoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PatSystem.Models.Curriculo.Cursos.CursoTecnico", b =>
                {
                    b.HasOne("PatSystem.Models.Curriculo.Curriculo", "Curriculo")
                        .WithMany()
                        .HasForeignKey("CurriculoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PatSystem.Models.Curriculo.Experiencia", b =>
                {
                    b.HasOne("PatSystem.Models.Curriculo.Curriculo", "Curriculo")
                        .WithMany()
                        .HasForeignKey("CurriculoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PatSystem.Models.Curriculo.Idioma", b =>
                {
                    b.HasOne("PatSystem.Models.Curriculo.Curriculo", "Curriculo")
                        .WithMany()
                        .HasForeignKey("CurriculoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PatSystem.Models.SegDesemprego.Seguro", b =>
                {
                    b.HasOne("PatSystem.Models.SegDesemprego.Cbo", "CodCbo")
                        .WithMany()
                        .HasForeignKey("CodCboid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PatSystem.Models.SegDesemprego.Empresa", "Cnpj")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
