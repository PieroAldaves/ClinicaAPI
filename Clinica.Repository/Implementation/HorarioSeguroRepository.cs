
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Clinica.Entity;
using Clinica.Repository.context;
using Clinica.Repository.ViewModel;
using Newtonsoft.Json;

namespace Clinica.Repository.Implementation
{
    public class HorarioSeguroRepository : IHorarioSeguroRepository
    {

         private ApplicationDbContext context;

        public HorarioSeguroRepository (ApplicationDbContext context) {
            this.context = context;
        }

        public bool Cargar()
        {
            try
            {
                StreamReader r = new StreamReader(@"C:\Desarrollador\CSV2\HorariosxSeguro\");
   
                string json = r.ReadToEnd();
                List<HorarioSeguro> horarioseguros = JsonConvert.DeserializeObject<List<HorarioSeguro>>(json);


                
                foreach (var horarioseguro in horarioseguros)
                {
                    HorarioSeguro hs1 = new HorarioSeguro();
                    hs1.HorarioId = horarioseguro.HorarioId;
                    hs1.SeguroId = horarioseguro.SeguroId;
                    hs1.Horario = context.horarios.Find(horarioseguro.HorarioId);
                    hs1.Seguro = context.seguros.Find(horarioseguro.SeguroId);


                    context.Add(hs1);
                    context.SaveChanges();

                }
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
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

        public bool SaveHorarioSeguro(HorarioSeguroViewModel entity)
        {
            try
            {
                Seguro S1 = new Seguro();
                S1.SeguroName = entity.SeguroName;

                context.Add(S1);
                context.SaveChanges();

                HorarioSeguro HoSe1 =new HorarioSeguro();
                HoSe1.HorarioId = entity.HorarioId;
                HoSe1.Horario = context.horarios.Find(entity.HorarioId);
                HoSe1.SeguroId = context.seguros.OrderByDescending(o => o.SeguroName ==entity.SeguroName).First().SeguroId;
                HoSe1.Seguro = S1;
                
                context.Add(HoSe1);
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