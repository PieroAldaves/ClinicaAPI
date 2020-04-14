
using System.Collections.Generic;
using Clinica.Entity;
using Clinica.Repository.ViewModel;

namespace Clinica.Repository
{
    public interface ITurnoRepository: IRepository<Turno>
    {
        IEnumerable<TurnoViewModel> GetTurnosDisponibles();
    }
}