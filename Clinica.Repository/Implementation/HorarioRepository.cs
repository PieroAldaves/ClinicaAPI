
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Clinica.Entity;
using Clinica.Repository.context;
using Newtonsoft.Json;

namespace Clinica.Repository.Implementation
{
    public class HorarioRepository : IHorarioRepository
    {

         private ApplicationDbContext context;

        public HorarioRepository (ApplicationDbContext context) {
            this.context = context;
        }



        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Horario Get(int id)
        {   
            var result = new Horario();
            try
            {
                result = context.horarios.Single(x=> x.HorarioId == id);
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public IEnumerable<Horario> GetAll()
        {   
            var result = new List<Horario>();
            try
            {
                result = context.horarios.ToList();
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return result;
        }

        public bool Save(Horario entity)
        {
            
            try
            {

                entity.Sede = context.sedes.Find(entity.SedeId);
                entity.MedicoEspecialidad = context.medicoespecialidades.Find(entity.MedicoEspecialidadId);

                DateTime inicio = entity.FechaHoraInicio;
                DateTime fin = entity.FechaHoraFin;


                context.Add(entity);
                context.SaveChanges();
                
                
                while (inicio < fin)
                {
                    Turno T1 = new Turno();
                    T1.Disponible = true;
                    T1.Constante = 30;
                    T1.FechaHoraInicio = inicio;
                    T1.FechaHoraFin = inicio.AddMinutes(30);
                    T1.HorarioId = context.horarios.OrderByDescending(o => o.HorarioId).First().HorarioId;
                    T1.Horario = entity;

                    context.Add(T1);
                    context.SaveChanges();

                    inicio = inicio.AddMinutes(30);

                }

                

            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
        }


        public bool Update(Horario entity)
        {
            throw new System.NotImplementedException();
        }


        public bool CargarHorarios()
        {
            try
            {
                
                StreamReader r = new StreamReader(@"C:\Desarrollador\CSV\Horarios\");
   
                string json = r.ReadToEnd();
                List<Horario> horarios = JsonConvert.DeserializeObject<List<Horario>>(json);


                
                foreach (var horario in horarios)
                {
                    Horario h1 = new Horario();
                    
                    h1.DayName = horario.DayName;
                    h1.HorarioFecha = horario.HorarioFecha;
                    h1.FechaHoraInicio = horario.FechaHoraInicio;
                    h1.FechaHoraFin = horario.FechaHoraFin;
                    h1.MedicoEspecialidadId = horario.MedicoEspecialidadId;
                    h1.SedeId = horario.SedeId;
                    

                    h1.Sede = context.sedes.Find(horario.SedeId);
                    h1.MedicoEspecialidad = context.medicoespecialidades.Find(horario.MedicoEspecialidadId);

                    DateTime inicio = h1.FechaHoraInicio;
                    DateTime fin = h1.FechaHoraFin;


                    context.Add(h1);
                    context.SaveChanges();
                    
                    
                    while (inicio < fin)
                    {
                        Turno T1 = new Turno();
                        T1.Disponible = true;
                        T1.Constante = 30;
                        T1.FechaHoraInicio = inicio;
                        T1.FechaHoraFin = inicio.AddMinutes(30);
                        T1.HorarioId = context.horarios.OrderByDescending(o => o.HorarioId).First().HorarioId;
                        T1.Horario = h1;

                        context.Add(T1);
                        context.SaveChanges();

                        inicio = inicio.AddMinutes(30);

                    }


                }

            }
            catch (System.Exception)
            {
                
                return false;
            }

            return true;
        }


    }
}