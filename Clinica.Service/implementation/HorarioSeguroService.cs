using System.Collections.Generic;
using Clinica.Entity;
using Clinica.Repository;
using Clinica.Repository.ViewModel;

namespace Clinica.Service.implementation
{
    public class HorarioSeguroService : IHorarioSeguroService
    {
        private IHorarioSeguroRepository horarioseguroRepository;
        public HorarioSeguroService(IHorarioSeguroRepository horarioseguroRepository)
        {
            this.horarioseguroRepository=horarioseguroRepository;
        }

        public bool Cargar()
        {
            return horarioseguroRepository.Cargar();
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

        public bool SaveHorarioSeguro(HorarioSeguroViewModel entity)
        {
            return horarioseguroRepository.SaveHorarioSeguro(entity);
        }

        public bool Update(HorarioSeguro entity)
        {
            return horarioseguroRepository.Update(entity);
        }
    }

}