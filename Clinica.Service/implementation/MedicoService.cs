using System.Collections.Generic;
using Clinica.Entity;
using Clinica.Repository;

namespace Clinica.Service.implementation
{
    public class MedicoService : IMedicoService
    {
        private IMedicoRepository medicoRepository;
        public MedicoService(IMedicoRepository medicoRepository)
        {
            this.medicoRepository=medicoRepository;
        }

        public bool Cargar()
        {
            return medicoRepository.Cargar();
        }

        public bool Delete(int id)
        {
            return medicoRepository.Delete(id);
        }

        public Medico Get(int id)
        {
            return medicoRepository.Get(id);
        }

        public IEnumerable<Medico> GetAll()
        {
            return medicoRepository.GetAll();
        }

        public bool Save(Medico entity)
        {
            return medicoRepository.Save(entity);
        }

        public bool Update(Medico entity)
        {
            return medicoRepository.Update(entity);
        }
    }

}