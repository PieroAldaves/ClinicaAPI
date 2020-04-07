using System.Collections.Generic;
using Clinica.Entity;
using Clinica.Repository;

namespace Clinica.Service.implementation
{
    public class HorarioSeguroService : IHorarioSeguroService
    {
        private IHorarioSeguroRepository horarioseguroRepository;
        public HorarioSeguroService(IHorarioSeguroRepository horarioseguroRepository)
        {
            this.horarioseguroRepository=horarioseguroRepository;
        }

        public bool Delete(int id)
        {
            return horarioseguroRepository.Delete(id);
        }

        public HorarioSeguro Get(int id)
        {
            return horarioseguroRepository.Get(id);
        }

        public IEnumerable<HorarioSeguro> GetAll()
        {
            return horarioseguroRepository.GetAll();
        }

        public bool Save(HorarioSeguro entity)
        {
            return horarioseguroRepository.Save(entity);
        }

        public bool Update(HorarioSeguro entity)
        {
            return horarioseguroRepository.Update(entity);
        }
    }

}