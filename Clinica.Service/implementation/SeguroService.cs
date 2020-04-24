using System.Collections.Generic;
using Clinica.Entity;
using Clinica.Repository;

namespace Clinica.Service.implementation
{
    public class SeguroService : ISeguroService
    {
        private ISeguroRepository seguroRepository;
        public SeguroService(ISeguroRepository seguroRepository)
        {
            this.seguroRepository=seguroRepository;
        }

        public bool Cargar()
        {
            return seguroRepository.Cargar();
        }

        public bool Delete(int id)
        {
            return seguroRepository.Delete(id);
        }

        public Seguro Get(int id)
        {
            return seguroRepository.Get(id);
        }

        public IEnumerable<Seguro> GetAll()
        {
            return seguroRepository.GetAll();
        }

        public bool Save(Seguro entity)
        {
            return seguroRepository.Save(entity);
        }

        public bool Update(Seguro entity)
        {
            return seguroRepository.Update(entity);
        }
    }

}