﻿// <auto-generated />
using Clinica.Repository.context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Clinica.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200403033445_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Clinica.Entity.Rol", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Publish");

                    b.Property<string>("RolDescription");

                    b.HasKey("RolId");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("Clinica.Entity.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RolId");

                    b.Property<string>("UserName");

                    b.Property<string>("UserPassword");

                    b.HasKey("UsuarioId");

                    b.HasIndex("RolId");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("Clinica.Entity.Usuario", b =>
                {
                    b.HasOne("Clinica.Entity.Rol", "Rol")
                        .WithMany("Usuarios")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
