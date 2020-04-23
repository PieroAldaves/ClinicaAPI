using System.Collections.Generic;
using Clinica.Entity;
using Clinica.Repository;

namespace Clinica.Service.implementation
{
    public class HorarioService : IHorarioService
    {
        private IHorarioRepository horarioRepository;
        public HorarioService(IHorarioRepository horarioRepository)
        {
            this.horarioRepository=horarioRepository;
        }

        public bool CargarHorarios()
        {
            return horarioRepository.CargarHorarios();
        }

        public bool Delete(int id)
        {
            return horarioRepository.Delete(id);
        }

        public Horario Get(int id)
        {
            return horarioRepository.Get(id);
        }

        public IEnumerable<Horario> GetAll()
        {
            return horarioRepository.GetAll();
        }

        public bool Save(Horario entity)
        {
            return horarioRepository.Save(entity);
        }

        public bool Update(Horario entity)
        {
            return horarioRepository.Update(entity);
        }
    }

}