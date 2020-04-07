
using System.Collections.Generic;
using System.Linq;
using Clinica.Entity;
using Clinica.Repository.context;

namespace Clinica.Repository.Implementation
{
    public class Seguropository : ISeguroRepository
    {

         private ApplicationDbContext context;

        public Seguropository (ApplicationDbContext context) {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Seguro Get(int id)
        {
            var result = new Seguro();
            try
            {
                result = context.seguros.Single(x=> x.SeguroId == id);
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public IEnumerable<Seguro> GetAll()
        {
            var result = new List<Seguro>();
            try
            {
                result = context.seguros.ToList();
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public bool Save(Seguro entity)
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

        public bool Update(Seguro entity)
        {
            throw new System.NotImplementedException();
        }
    }


}