
using Clinica.Entity;
using Clinica.Repository.ViewModel;

namespace Clinica.Repository
{
    public interface IMedicoEspecialidadRepository: IRepository<MedicoEspecialidad>
    {

        bool SaveEspecialidad(MedicoEspecialidadViewModel entity);

        bool Cargar();
    }
    
}