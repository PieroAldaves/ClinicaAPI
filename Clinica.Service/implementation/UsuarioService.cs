using System.Collections.Generic;
using Clinica.Entity;
using Clinica.Repository;

namespace Clinica.Service.implementation
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository=usuarioRepository;
        }

        public bool Delete(int id)
        {
            return usuarioRepository.Delete(id);
        }

        public Usuario Get(int id)
        {
            return usuarioRepository.Get(id);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return usuarioRepository.GetAll();
        }

        public bool Save(Usuario entity)
        {
            return usuarioRepository.Save(entity);
        }

        public bool Update(Usuario entity)
        {
            return usuarioRepository.Update(entity);
        }
    }

}