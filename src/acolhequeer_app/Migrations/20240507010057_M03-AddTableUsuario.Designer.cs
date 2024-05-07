﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using acolhequeer.Models;

#nullable disable

namespace acolhequeer_app.Migrations
{
    [DbContext(typeof(AppDbContextt))]
    [Migration("20240507010057_M03-AddTableUsuario")]
    partial class M03AddTableUsuario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Instituicao", b =>
                {
                    b.Property<int>("instituicao_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("instituicao_id"));

                    b.Property<bool>("adm_validacao")
                        .HasColumnType("bit");

                    b.Property<bool>("bool_atd")
                        .HasColumnType("bit");

                    b.Property<string>("cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endereco_bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endereco_cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endereco_cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endereco_estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("endereco_numero")
                        .HasColumnType("int");

                    b.Property<string>("endereco_rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("n_vagas")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pix_doacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("qtd_disponibilidade")
                        .HasColumnType("int");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("instituicao_id");

                    b.ToTable("Instituicao");
                });

            modelBuilder.Entity("acolhequeer.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnoFabricacao")
                        .HasColumnType("int");

                    b.Property<int>("AnoModelo")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Placa")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("acolhequeer_app.Models.Usuario", b =>
                {
                    b.Property<int>("usuario_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("usuario_id"));

                    b.Property<bool>("bool_admin")
                        .HasColumnType("bit");

                    b.Property<int>("cpf")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endereco_bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endereco_cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endereco_cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endereco_estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("endereco_numero")
                        .HasColumnType("int");

                    b.Property<string>("endereco_rua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idade")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome_social")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("telefone")
                        .HasColumnType("int");

                    b.HasKey("usuario_id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
