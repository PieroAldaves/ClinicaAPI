using Clinica.Entity;

namespace Clinica.Service
{
    public interface IEspecialidadService: IService<Especialidad>
    {
        bool Cargar();
    }
    
}