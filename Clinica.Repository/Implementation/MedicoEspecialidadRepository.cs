
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Clinica.Entity;
using Clinica.Repository.context;
using Clinica.Repository.ViewModel;
using Newtonsoft.Json;

namespace Clinica.Repository.Implementation
{
    public class MedicoEspecialidadRepository : IMedicoEspecialidadRepository
    {

         private ApplicationDbContext context;

        public MedicoEspecialidadRepository (ApplicationDbContext context) {
            this.context = context;
        }

        public bool Cargar()
        {
            try
            {
                StreamReader r = new StreamReader(@"C:\Desarrollador\CSV\Med_especialidad.json");
   
                string json = r.ReadToEnd();
                List<MedicoEspecialidad> medicoespecialidades = JsonConvert.DeserializeObject<List<MedicoEspecialidad>>(json);


                
                foreach (var medicoespecialidad in medicoespecialidades)
                {
                    MedicoEspecialidad me1 = new MedicoEspecialidad();
                    me1.EspecialidadId = medicoespecialidad.EspecialidadId;
                    me1.MedicoId = medicoespecialidad.MedicoId;

                    me1.Medico = context.medicos.Find(medicoespecialidad.MedicoId);
                    me1.Especialidad = context.especialidades.Find(medicoespecialidad.EspecialidadId);
                    

                    context.Add(me1);
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

        public MedicoEspecialidad Get(int id)
        {
            var result = new MedicoEspecialidad();
            try
            {
                result = context.medicoespecialidades.Single(x=> x.MedicoEspecialidadId == id);
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public IEnumerable<MedicoEspecialidad> GetAll()
        {
            var result = new List<MedicoEspecialidad>();
            try
            {
                result = context.medicoespecialidades.ToList();
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public bool Save(MedicoEspecialidad entity)
        {
            try
            {
                entity.Medico = context.medicos.Find(entity.MedicoId);
                entity.Especialidad = context.especialidades.Find(entity.EspecialidadId);

                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }
            
            return true;
        }

        public bool SaveEspecialidad(MedicoEspecialidadViewModel entity)
        {
            try
            {
                Especialidad e1 = new Especialidad();
                e1.EspecialidadName = entity.EspecialidadName;

                context.Add(e1);
                context.SaveChanges();

                MedicoEspecialidad medicoespe1 = new MedicoEspecialidad();
                medicoespe1.MedicoId = entity.MedicoId;
                medicoespe1.Medico = context.medicos.Find(entity.MedicoId);
                medicoespe1.EspecialidadId = context.especialidades.OrderByDescending(o => o.EspecialidadId).First().EspecialidadId;
                medicoespe1.Especialidad = e1;

                context.Add(medicoespe1);
                context.SaveChanges();


            }
            catch (System.Exception)
            {
                
                return false;
            }

            return true;
        }

        public bool Update(MedicoEspecialidad entity)
        {
            throw new System.NotImplementedException();
        }
    }
}