
using System.Collections.Generic;
using System.Linq;
using Clinica.Entity;
using Clinica.Repository.context;

namespace Clinica.Repository.Implementation
{
    public class MedicoRepository : IMedicoRepository
    {

         private ApplicationDbContext context;

        public MedicoRepository (ApplicationDbContext context) {
            this.context = context;
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

        public bool Update(Medico entity)
        {
            throw new System.NotImplementedException();
        }
    }

}
