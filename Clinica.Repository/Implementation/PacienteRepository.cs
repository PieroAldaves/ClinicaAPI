
using System.Collections.Generic;
using System.Linq;
using Clinica.Entity;
using Clinica.Repository.context;

namespace Clinica.Repository.Implementation
{
    public class PacienteRepository : IPacienteRepository
    {

         private ApplicationDbContext context;

        public PacienteRepository (ApplicationDbContext context) {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Paciente Get(int id)
        {
            var result = new Paciente();
            try
            {
                result = context.pacientes.Single(x=> x.PacienteId == id);
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public IEnumerable<Paciente> GetAll()
        {
            var result = new List<Paciente>();
            try
            {
                result = context.pacientes.ToList();
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public bool Save(Paciente entity)
        {
            try
            {
                entity.Usuario = context.usuarios.Find(entity.UsuarioId);
                context.Add(entity);
                context.SaveChanges();

            }
            catch (System.Exception)
            {
                
                return false;
            }

            return true;
        }

        public bool Update(Paciente entity)
        {
            throw new System.NotImplementedException();
        }
    }

}
