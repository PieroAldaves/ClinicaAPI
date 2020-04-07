using System.Collections.Generic;
using Clinica.Entity;
using Clinica.Repository;

namespace Clinica.Service.implementation
{
    public class SedeService : ISedeService
    {
        private ISedeRepository sedeRepository;
        public SedeService(ISedeRepository sedeRepository)
        {
            this.sedeRepository=sedeRepository;
        }

        public bool Delete(int id)
        {
            return sedeRepository.Delete(id);
        }

        public Sede Get(int id)
        {
            return sedeRepository.Get(id);
        }

        public IEnumerable<Sede> GetAll()
        {
            return sedeRepository.GetAll();
        }

        public bool Save(Sede entity)
        {
            return sedeRepository.Save(entity);
        }

        public bool Update(Sede entity)
        {
            return sedeRepository.Update(entity);
        }
    }

}