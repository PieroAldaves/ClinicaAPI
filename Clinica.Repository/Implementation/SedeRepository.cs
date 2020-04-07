
using System.Collections.Generic;
using System.Linq;
using Clinica.Entity;
using Clinica.Repository.context;

namespace Clinica.Repository.Implementation
{
    public class SedeRepository : ISedeRepository
    {

         private ApplicationDbContext context;

        public SedeRepository (ApplicationDbContext context) {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Sede Get(int id)
        {
            var result = new Sede();
            try
            {
                result = context.sedes.Single(x=> x.SedeId == id);
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public IEnumerable<Sede> GetAll()
        {
            var result = new List<Sede>();
            try
            {
                result = context.sedes.ToList();
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public bool Save(Sede entity)
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

        public bool Update(Sede entity)
        {
            throw new System.NotImplementedException();
        }
    }



}

