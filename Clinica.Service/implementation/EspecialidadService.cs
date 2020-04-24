using System.Collections.Generic;
using Clinica.Entity;
using Clinica.Repository;

namespace Clinica.Service.implementation
{
    public class EspecialidadService : IEspecialidadService
    {
        private IEspecialidadRepository especialidadRepository;
        public EspecialidadService(IEspecialidadRepository especialidadRepository)
        {
            this.especialidadRepository=especialidadRepository;
        }

        public bool Cargar()
        {
            return especialidadRepository.Cargar();
        }

        public bool Delete(int id)
        {
            return especialidadRepository.Delete(id);
        }

        public Especialidad Get(int id)
        {
            return especialidadRepository.Get(id);
        }

        public IEnumerable<Especialidad> GetAll()
        {
            return especialidadRepository.GetAll();
        }

        public bool Save(Especialidad entity)
        {
            return especialidadRepository.Save(entity);
        }

        public bool Update(Especialidad entity)
        {
            return especialidadRepository.Update(entity);
        }
    }

}