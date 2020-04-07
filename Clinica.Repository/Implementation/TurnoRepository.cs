
using System.Collections.Generic;
using System.Linq;
using Clinica.Entity;
using Clinica.Repository.context;

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
