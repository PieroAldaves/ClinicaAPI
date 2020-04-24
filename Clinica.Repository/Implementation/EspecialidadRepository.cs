using System.Collections.Generic;
using System.IO;
using System.Linq;
using Clinica.Entity;
using Clinica.Repository.context;
using Newtonsoft.Json;

namespace Clinica.Repository.Implementation
{
    public class EspecialidadRepository : IEspecialidadRepository
    {

        private ApplicationDbContext context;


        public EspecialidadRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Cargar()
        {
            try
            {
                StreamReader r = new StreamReader(@"C:\Desarrollador\CSV\Datos-Seguro.json");
   
                string json = r.ReadToEnd();
                List<Especialidad> especialidades = JsonConvert.DeserializeObject<List<Especialidad>>(json);


                
                foreach (var especialidad in especialidades)
                {
                    Especialidad e1 = new Especialidad();
                    e1.EspecialidadName = especialidad.EspecialidadName;
                    

                    context.Add(e1);
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