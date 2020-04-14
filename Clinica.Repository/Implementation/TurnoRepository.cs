
using System.Collections.Generic;
using System.Linq;
using Clinica.Entity;
using Clinica.Repository.context;
using Clinica.Repository.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Repository.Implementation
{
    public class TurnoRepository : ITurnoRepository
    {

         private ApplicationDbContext context;

        public TurnoRepository (ApplicationDbContext context) {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Turno Get(int id)
        {
            var result = new Turno();
            try
            {
                result = context.turnos.Single(x=> x.TurnoId == id);
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public IEnumerable<Turno> GetAll()
        {
            var result = new List<Turno>();
            try
            {
                result = context.turnos.ToList();
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public IEnumerable<TurnoViewModel> GetTurnosDisponibles()
        {
            var DetallesTurno = context.turnos
            .Include(o => o.Horario)
            .Include(o => o.Horario.MedicoEspecialidad)
            .Include(o => o.Horario.MedicoEspecialidad.Medico)
            .Include(o => o.Horario.MedicoEspecialidad.Especialidad)
            .Include(o => o.Horario.Sede)
            .OrderByDescending(o => o.TurnoId)
            .Take(100)
            .Where(o => o.Disponible == true)
            .ToList();

            return DetallesTurno.Select (o => new TurnoViewModel{
                TurnoId = o.TurnoId,
                FechaHoraInicio = o.FechaHoraInicio,
                FechaHoraFin = o.FechaHoraFin,
                Disponible = o.Disponible,
                MedicoNombre = o.Horario.MedicoEspecialidad.Medico.Name,
                MedicoApellido_Paterno = o.Horario.MedicoEspecialidad.Medico.LastName_Paternal,
                MedicoApellido_Materno = o.Horario.MedicoEspecialidad.Medico.LastName_Maternal,
                EspecialidadName = o.Horario.MedicoEspecialidad.Especialidad.EspecialidadName,
                HorarioDayName = o.Horario.DayName,
                HorarioFecha = o.Horario.HorarioFecha,
                SedeName = o.Horario.Sede.SedeName

            });


        }

        public bool Save(Turno entity)
        {
            try
            {
                entity.Horario = context.horarios.Find(entity.HorarioId);
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
            
                return false;
            }
            return true;
            
        }


        public bool Update(Turno entity)
        {
            throw new System.NotImplementedException();
        }
    }

}
