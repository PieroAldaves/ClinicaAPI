
using System.Collections.Generic;
using System.Linq;
using Clinica.Entity;
using Clinica.Repository.context;

namespace Clinica.Repository.Implementation
{
    public class ReservaRepository : IReservaRepository
    {

         private ApplicationDbContext context;

        public ReservaRepository (ApplicationDbContext context) {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Reserva Get(int id)
        {
            var result = new Reserva();
            try
            {
                result = context.reservas.Single(x=> x.ReservaId == id);
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public IEnumerable<Reserva> GetAll()
        {
            var result = new List<Reserva>();
            try
            {
                result = context.reservas.ToList();
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public bool Save(Reserva entity)
        {
            try
            {
                entity.Paciente = context.pacientes.Find(entity.PacienteId);
                entity.Medico = context.medicos.Find(entity.MedicoId);
                entity.Especialidad = context.especialidades.Find(entity.EspecialidadId);
                entity.Horario = context.horarios.Find(entity.HorarioId);
                entity.Turno = context.turnos.Find(entity.TurnoId);
                entity.Seguro = context.seguros.Find(entity.SeguroId);
                entity.Sede = context.sedes.Find(entity.SedeId);

                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;

            }
            return true;
        }

        public bool Update(Reserva entity)
        {
            throw new System.NotImplementedException();
        }
    }


}
