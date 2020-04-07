
using System.Collections.Generic;
using System.Linq;
using Clinica.Entity;
using Clinica.Repository.context;

namespace Clinica.Repository.Implementation
{
    public class MedicoEspecialidadRepository : IMedicoEspecialidadRepository
    {

         private ApplicationDbContext context;

        public MedicoEspecialidadRepository (ApplicationDbContext context) {
            this.context = context;
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

        public bool Update(MedicoEspecialidad entity)
        {
            throw new System.NotImplementedException();
        }
    }
}