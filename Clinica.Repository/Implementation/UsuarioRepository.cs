
using System.Collections.Generic;
using System.Linq;
using Clinica.Entity;
using Clinica.Repository.context;

namespace Clinica.Repository.Implementation
{
    public class UsuarioRepository : IUsuarioRepository
    {

         private ApplicationDbContext context;

        public UsuarioRepository (ApplicationDbContext context) {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Usuario Get(int id)
        {
            var result = new Usuario();
            try
            {
                result = context.usuarios.Single(x=> x.UsuarioId == id);
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public IEnumerable<Usuario> GetAll()
        {
            var result = new List<Usuario>();
            try
            {
                result = context.usuarios.ToList();
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public bool Save(Usuario entity)
        {
            try
            {
                entity.Rol = context.roles.Find(entity.RolId);
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }

            return true;
        }

        public bool Update(Usuario entity)
        {
            throw new System.NotImplementedException();
        }
    }

}