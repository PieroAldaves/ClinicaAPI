using System.Collections.Generic;
using Clinica.Entity;
using Clinica.Repository;

namespace Clinica.Service.implementation
{
    public class RolService : IRolService
    {
        private IRolRepository rolRepository;
        public RolService(IRolRepository rolRepository)
        {
            this.rolRepository=rolRepository;
        }

        public bool Delete(int id)
        {
            return rolRepository.Delete(id);
        }

        public Rol Get(int id)
        {
            return rolRepository.Get(id);
        }

        public IEnumerable<Rol> GetAll()
        {
            return rolRepository.GetAll();
        }

        public bool Save(Rol entity)
        {
            return rolRepository.Save(entity);
        }

        public bool Update(Rol entity)
        {
            return rolRepository.Update(entity);
        }
    }

}