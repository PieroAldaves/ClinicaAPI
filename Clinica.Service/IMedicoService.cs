using Clinica.Entity;

namespace Clinica.Service
{
    public interface IMedicoService: IService<Medico>
    {
        bool Cargar();
    }
    
}