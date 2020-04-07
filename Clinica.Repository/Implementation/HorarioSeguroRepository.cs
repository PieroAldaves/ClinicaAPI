
using System.Collections.Generic;
using System.Linq;
using Clinica.Entity;
using Clinica.Repository.context;

namespace Clinica.Repository.Implementation
{
    public class HorarioSeguroRepository : IHorarioSeguroRepository
    {

         private ApplicationDbContext context;

        public HorarioSeguroRepository (ApplicationDbContext context) {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public HorarioSeguro Get(int id)
        {
            var result = new HorarioSeguro();
            try
            {
                result = context.horarioseguros.Single(x=> x.HorarioSeguroId == id);
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public IEnumerable<HorarioSeguro> GetAll()
        {
            var result = new List<HorarioSeguro>();
            try
            {
                result = context.horarioseguros.ToList();
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public bool Save(HorarioSeguro entity)
        {

            try
            {
                entity.Horario = context.horarios.Find(entity.HorarioId);
                entity.Seguro = context.seguros.Find(entity.SeguroId);

                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
        }

        public bool Update(HorarioSeguro entity)
        {
            throw new System.NotImplementedException();
        }
    }
}