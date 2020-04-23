using Clinica.Entity;

namespace Clinica.Service
{
    public interface IHorarioService: IService<Horario>
    {
        bool CargarHorarios();
    }
    
}