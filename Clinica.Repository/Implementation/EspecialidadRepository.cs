using System.Collections.Generic;
using System.Linq;
using Clinica.Entity;
using Clinica.Repository.context;

namespace Clinica.Repository.Implementation
{
    public class EspecialidadRepository : IEspecialidadRepository
    {

        private ApplicationDbContext context;


        public EspecialidadRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Especialidad Get(int id)
        {
            var result = new Especialidad();

            try
            {
                result = context.especialidades.Single(x => x.EspecialidadId == id);
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return result;
        }

        public IEnumerable<Especialidad> GetAll()
        {
            var result = new List<Especialidad>(); 
            try
            {
                result = context.especialidades.ToList();
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public bool Save(Especialidad entity)
        {
            try
            {
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }

            return true;
        }

        public bool Update(Especialidad entity)
        {
            throw new System.NotImplementedException();
        }
    }
}