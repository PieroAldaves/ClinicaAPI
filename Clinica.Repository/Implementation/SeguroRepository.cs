
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Clinica.Entity;
using Clinica.Repository.context;
using Newtonsoft.Json;

namespace Clinica.Repository.Implementation
{
    public class Seguropository : ISeguroRepository
    {

         private ApplicationDbContext context;

        public Seguropository (ApplicationDbContext context) {
            this.context = context;
        }

        public bool Cargar()
        {
            try
            {
                 StreamReader r = new StreamReader(@"C:\Desarrollador\CSV2\Seguro.json");
   
                string json = r.ReadToEnd();
                List<Seguro> seguros = JsonConvert.DeserializeObject<List<Seguro>>(json);


                
                foreach (var seguro in seguros)
                {
                    Seguro s1 = new Seguro();
                    s1.SeguroName = seguro.SeguroName;

                    context.Add(s1);
                    context.SaveChanges();

                }
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
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