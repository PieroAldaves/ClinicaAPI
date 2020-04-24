
using Clinica.Entity;

namespace Clinica.Repository
{
    public interface IMedicoRepository: IRepository<Medico>
    {
         bool Cargar();
    }
}