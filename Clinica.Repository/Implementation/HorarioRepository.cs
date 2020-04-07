
using System.Collections.Generic;
using System.Linq;
using Clinica.Entity;
using Clinica.Repository.context;

namespace Clinica.Repository.Implementation
{
    public class HorarioRepository : IHorarioRepository
    {

         private ApplicationDbContext context;

        public HorarioRepository (ApplicationDbContext context) {
            this.context = context;
        }


        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Horario Get(int id)
        {   
            var result = new Horario();
            try
            {
                result = context.horarios.Single(x=> x.HorarioId == id);
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public IEnumerable<Horario> GetAll()
        {   
            var result = new List<Horario>();
            try
            {
                result = context.horarios.ToList();
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public bool Save(Horario entity)
        {
            
            try
            {
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


        public bool Update(Horario entity)
        {
            throw new System.NotImplementedException();
        }
    }
}