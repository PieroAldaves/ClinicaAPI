using System.Collections.Generic;
using Clinica.Entity;
using Clinica.Repository;

namespace Clinica.Service.implementation
{
    public class ReservaService : IReservaService
    {
        private IReservaRepository reservaRepository;
        public ReservaService(IReservaRepository reservaRepository)
        {
            this.reservaRepository=reservaRepository;
        }

        public bool Delete(int id)
        {
            return reservaRepository.Delete(id);
        }

        public Reserva Get(int id)
        {
            return reservaRepository.Get(id);
        }

        public IEnumerable<Reserva> GetAll()
        {
            return reservaRepository.GetAll();
        }

        public bool Save(Reserva entity)
        {
            return reservaRepository.Save(entity);
        }

        public bool Update(Reserva entity)
        {
            return reservaRepository.Update(entity);
        }
    }

}