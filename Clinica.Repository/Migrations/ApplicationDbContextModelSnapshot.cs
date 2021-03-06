﻿// <auto-generated />
using System;
using Clinica.Repository.context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Clinica.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Clinica.Entity.Dia", b =>
                {
                    b.Property<int>("DiaId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DiaDate");

                    b.Property<string>("DiaName");

                    b.HasKey("DiaId");

                    b.ToTable("dias");
                });

            modelBuilder.Entity("Clinica.Entity.Especialidad", b =>
                {
                    b.Property<int>("EspecialidadId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EspecialidadName");

                    b.HasKey("EspecialidadId");

                    b.ToTable("especialidades");
                });

            modelBuilder.Entity("Clinica.Entity.Horario", b =>
                {
                    b.Property<int>("HorarioId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DayName");

                    b.Property<DateTime>("FechaHoraFin");

                    b.Property<DateTime>("FechaHoraInicio");

                    b.Property<DateTime>("HorarioFecha");

                    b.Property<int>("MedicoEspecialidadId");

                    b.Property<int>("SedeId");

                    b.HasKey("HorarioId");

                    b.HasIndex("MedicoEspecialidadId");

                    b.HasIndex("SedeId");

                    b.ToTable("horarios");
                });

            modelBuilder.Entity("Clinica.Entity.HorarioSeguro", b =>
                {
                    b.Property<int>("HorarioSeguroId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HorarioId");

                    b.Property<int>("SeguroId");

                    b.HasKey("HorarioSeguroId");

                    b.HasIndex("HorarioId");

                    b.HasIndex("SeguroId");

                    b.ToTable("horarioseguros");
                });

            modelBuilder.Entity("Clinica.Entity.Medico", b =>
                {
                    b.Property<int>("MedicoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Age");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Distrito");

                    b.Property<string>("Email");

                    b.Property<string>("Gender");

                    b.Property<string>("Imagen");

                    b.Property<string>("LastName_Maternal");

                    b.Property<string>("LastName_Paternal");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("dni");

                    b.HasKey("MedicoId");

                    b.ToTable("medicos");
                });

            modelBuilder.Entity("Clinica.Entity.MedicoEspecialidad", b =>
                {
                    b.Property<int>("MedicoEspecialidadId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EspecialidadId");

                    b.Property<int>("MedicoId");

                    b.HasKey("MedicoEspecialidadId");

                    b.HasIndex("EspecialidadId");

                    b.HasIndex("MedicoId");

                    b.ToTable("medicoespecialidades");
                });

            modelBuilder.Entity("Clinica.Entity.Paciente", b =>
                {
                    b.Property<int>("PacienteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Age");

                    b.Property<DateTime>("BornDate");

                    b.Property<string>("City");

                    b.Property<string>("Contraseña");

                    b.Property<string>("Country");

                    b.Property<string>("Distrito");

                    b.Property<string>("Email");

                    b.Property<string>("Genger");

                    b.Property<string>("LastName_Maternal");

                    b.Property<string>("LastName_Paternal");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<int>("UsuarioId");

                    b.Property<string>("dni");

                    b.HasKey("PacienteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("pacientes");
                });

            modelBuilder.Entity("Clinica.Entity.Reserva", b =>
                {
                    b.Property<int>("ReservaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EspecialidadId");

                    b.Property<int>("HorarioId");

                    b.Property<int>("MedicoId");

                    b.Property<int>("PacienteId");

                    b.Property<int>("SedeId");

                    b.Property<int>("SeguroId");

                    b.Property<int>("TurnoId");

                    b.HasKey("ReservaId");

                    b.HasIndex("EspecialidadId");

                    b.HasIndex("HorarioId");

                    b.HasIndex("MedicoId");

                    b.HasIndex("PacienteId");

                    b.HasIndex("SedeId");

                    b.HasIndex("SeguroId");

                    b.HasIndex("TurnoId");

                    b.ToTable("reservas");
                });

            modelBuilder.Entity("Clinica.Entity.Rol", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RolDescription");

                    b.HasKey("RolId");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("Clinica.Entity.Sede", b =>
                {
                    b.Property<int>("SedeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("SedeAddress");

                    b.Property<string>("SedeName");

                    b.Property<string>("latitud");

                    b.Property<string>("longitud");

                    b.HasKey("SedeId");

                    b.ToTable("sedes");
                });

            modelBuilder.Entity("Clinica.Entity.Seguro", b =>
                {
                    b.Property<int>("SeguroId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("SeguroName");

                    b.HasKey("SeguroId");

                    b.ToTable("seguros");
                });

            modelBuilder.Entity("Clinica.Entity.Turno", b =>
                {
                    b.Property<int>("TurnoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Constante");

                    b.Property<bool>("Disponible");

                    b.Property<DateTime>("FechaHoraFin");

                    b.Property<DateTime>("FechaHoraInicio");

                    b.Property<int>("HorarioId");

                    b.HasKey("TurnoId");

                    b.HasIndex("HorarioId");

                    b.ToTable("turnos");
                });

            modelBuilder.Entity("Clinica.Entity.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RolId");

                    b.Property<string>("UserName");

                    b.Property<string>("UserPassword");

                    b.Property<bool>("UsuarioState");

                    b.HasKey("UsuarioId");

                    b.HasIndex("RolId");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("Clinica.Entity.Horario", b =>
                {
                    b.HasOne("Clinica.Entity.MedicoEspecialidad", "MedicoEspecialidad")
                        .WithMany()
                        .HasForeignKey("MedicoEspecialidadId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Clinica.Entity.Sede", "Sede")
                        .WithMany()
                        .HasForeignKey("SedeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Clinica.Entity.HorarioSeguro", b =>
                {
                    b.HasOne("Clinica.Entity.Horario", "Horario")
                        .WithMany("LosSegurosDelHorario")
                        .HasForeignKey("HorarioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Clinica.Entity.Seguro", "Seguro")
                        .WithMany()
                        .HasForeignKey("SeguroId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Clinica.Entity.MedicoEspecialidad", b =>
                {
                    b.HasOne("Clinica.Entity.Especialidad", "Especialidad")
                        .WithMany()
                        .HasForeignKey("EspecialidadId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Clinica.Entity.Medico", "Medico")
                        .WithMany("MedicoEspecialidades")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Clinica.Entity.Paciente", b =>
                {
                    b.HasOne("Clinica.Entity.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Clinica.Entity.Reserva", b =>
                {
                    b.HasOne("Clinica.Entity.Especialidad", "Especialidad")
                        .WithMany()
                        .HasForeignKey("EspecialidadId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Clinica.Entity.Horario", "Horario")
                        .WithMany()
                        .HasForeignKey("HorarioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Clinica.Entity.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Clinica.Entity.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Clinica.Entity.Sede", "Sede")
                        .WithMany()
                        .HasForeignKey("SedeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Clinica.Entity.Seguro", "Seguro")
                        .WithMany()
                        .HasForeignKey("SeguroId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Clinica.Entity.Turno", "Turno")
                        .WithMany()
                        .HasForeignKey("TurnoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Clinica.Entity.Turno", b =>
                {
                    b.HasOne("Clinica.Entity.Horario", "Horario")
                        .WithMany("Turnos")
                        .HasForeignKey("HorarioId")
                        .OnDelete(DeleteBehavior.Cascade);
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
