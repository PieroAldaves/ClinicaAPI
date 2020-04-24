using System.Collections.Generic;
using Clinica.Entity;
using Clinica.Repository;
using Clinica.Repository.ViewModel;

namespace Clinica.Service.implementation
{
    public class MedicoEspecialidadService : IMedicoEspecialidadService
    {
        private IMedicoEspecialidadRepository medicoespecialidadRepository;
        public MedicoEspecialidadService(IMedicoEspecialidadRepository medicoespecialidadRepository)
        {
            this.medicoespecialidadRepository=medicoespecialidadRepository;
        }

        public bool Cargar()
        {
            return medicoespecialidadRepository.Cargar();
        }

        public bool Delete(int id)
        {
            return medicoespecialidadRepository.Delete(id);
        }

        public MedicoEspecialidad Get(int id)
        {
            return medicoespecialidadRepository.Get(id);
        }

        public IEnumerable<MedicoEspecialidad> GetAll()
        {
            return medicoespecialidadRepository.GetAll();
        }

        public bool Save(MedicoEspecialidad entity)
        {
            return medicoespecialidadRepository.Save(entity);
        }

        public bool SaveEspecialidad(MedicoEspecialidadViewModel entity)
        {
            return medicoespecialidadRepository.SaveEspecialidad(entity);
        }

        public bool Update(MedicoEspecialidad entity)
        {
            return medicoespecialidadRepository.Update(entity);
        }
    }

}