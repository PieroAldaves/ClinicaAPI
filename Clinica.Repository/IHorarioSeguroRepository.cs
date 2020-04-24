
using Clinica.Entity;
using Clinica.Repository.ViewModel;

namespace Clinica.Repository
{
    public interface IHorarioSeguroRepository: IRepository<HorarioSeguro>
    {
        bool SaveHorarioSeguro (HorarioSeguroViewModel entity);

        bool Cargar();
    }
}