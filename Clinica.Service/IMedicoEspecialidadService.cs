using Clinica.Entity;
using Clinica.Repository.ViewModel;

namespace Clinica.Service
{
    public interface IMedicoEspecialidadService: IService<MedicoEspecialidad>
    {
        bool SaveEspecialidad(MedicoEspecialidadViewModel entity);
    }
    
}