
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Clinica.Entity;
using Clinica.Repository.context;
using Newtonsoft.Json;

namespace Clinica.Repository.Implementation
{
    public class MedicoRepository : IMedicoRepository
    {

         private ApplicationDbContext context;

        public MedicoRepository (ApplicationDbContext context) {
            this.context = context;
        }

        public bool Cargar()
        {
            try
            {
                StreamReader r = new StreamReader(@"C:\Desarrollador\CSV\Doctores.json");
   
                string json = r.ReadToEnd();
                List<Medico> medicos = JsonConvert.DeserializeObject<List<Medico>>(json);


                
                foreach (var medico in medicos)
                {
                    Medico m1 = new Medico();
                    m1.Address = medico.Address;
                    m1.Age = medico.Age;
                    m1.City = medico.City;
                    m1.Country = medico.Country;
                    m1.Distrito = medico.Distrito;
                    m1.dni = medico.dni;
                    m1.Email = medico.Email;
                    m1.Gender = medico.Gender;
                    m1.Imagen = medico.Imagen;
                    m1.LastName_Maternal = medico.LastName_Maternal;
                    m1.LastName_Paternal = medico.LastName_Paternal;
                    m1.Name = medico.Name;
                    m1.Phone = m1.Phone;


                    context.Add(m1);
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

        public Medico Get(int id)
        {
            var result = new Medico();
            try
            {
                result = context.medicos.Single(x=> x.MedicoId == id);
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public IEnumerable<Medico> GetAll()
        {
            var result = new List<Medico>();
            try
            {
                result = context.medicos.ToList();
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public bool Save(Medico entity)
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

        public bool Update(Medico entity)
        {
            throw new System.NotImplementedException();
        }
    }

}
