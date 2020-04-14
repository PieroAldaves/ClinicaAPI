using System.Collections.Generic;
using Clinica.Entity;
using Clinica.Repository.ViewModel;

namespace Clinica.Service
{
    public interface ITurnoService: IService<Turno>
    {
        IEnumerable<TurnoViewModel> GetTurnosDisponibles();
    }
    
}