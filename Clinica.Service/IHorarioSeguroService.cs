using Clinica.Entity;
using Clinica.Repository.ViewModel;

namespace Clinica.Service
{
    public interface IHorarioSeguroService: IService<HorarioSeguro>
    {
        bool SaveHorarioSeguro (HorarioSeguroViewModel entity);
    }
    
}