using Clinica.Entity;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Repository.context
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Dia> dias { get; set; }


        public DbSet<Especialidad> especialidades { get; set; }

        public DbSet<Horario> horarios { get; set; }

        public DbSet<HorarioSeguro> horarioseguros { get; set; }

        public DbSet<Medico> medicos { get; set; }

        public DbSet<MedicoEspecialidad> medicoespecialidades { get; set; }

        public DbSet<Paciente> pacientes { get; set; }

        public DbSet<Reserva> reservas { get; set; }

        public DbSet<Rol> roles  { get; set; }

        public DbSet<Sede> sedes { get; set; }

        public DbSet<Seguro> seguros { get; set; }

        public DbSet<Turno> turnos { get; set; }

        public DbSet<Usuario> usuarios { get; set; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        

    }
}