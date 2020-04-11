
using System.Collections.Generic;

namespace Clinica.Entity
{
    public class Horario
    {
        public int HorarioId { get; set; }

        public string DayName { get; set; }

        public System.DateTime HorarioFecha { get; set; }

        public System.DateTime FechaHoraInicio { get; set; }

        public System.DateTime FechaHoraFin { get; set; }


        public Sede Sede { get; set; }

        public int SedeId { get; set; }

        public List<HorarioSeguro> LosSegurosDelHorario { get; set; } 


        public List<Turno> Turnos { get; set; }

        public MedicoEspecialidad MedicoEspecialidad { get; set; }
        
        public int MedicoEspecilidadId { get; set; }




    }
}