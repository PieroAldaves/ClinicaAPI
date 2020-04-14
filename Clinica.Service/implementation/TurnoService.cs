using System.Collections.Generic;
using Clinica.Entity;
using Clinica.Repository;
using Clinica.Repository.ViewModel;

namespace Clinica.Service.implementation
{
    public class TurnoService : ITurnoService
    {
        private ITurnoRepository turnoRepository;
        public TurnoService(ITurnoRepository turnoRepository)
        {
            this.turnoRepository=turnoRepository;
        }

        public bool Delete(int id)
        {
            return turnoRepository.Delete(id);
        }

        public Turno Get(int id)
        {
            return turnoRepository.Get(id);
        }

        public IEnumerable<Turno> GetAll()
        {
            return turnoRepository.GetAll();
        }

        public IEnumerable<TurnoViewModel> GetTurnosDisponibles()
        {
            return turnoRepository.GetTurnosDisponibles();
        }

        public bool Save(Turno entity)
        {
            return turnoRepository.Save(entity);
        }

        public bool Update(Turno entity)
        {
            return turnoRepository.Update(entity);
        }
    }

}