namespace Clinica.Entity
{
    public class Reserva
    {

        public int ReservaId { get; set; }    

        public Paciente Paciente { get; set; }

        public int PacienteId { get; set; }

        public Medico Medico { get; set; }

        public int MedicoId { get; set; }


        public Especialidad Especialidad { get; set; }

        public int EspecialidadId { get; set; }

        public Horario Horario { get; set; }        

        public int HorarioId { get; set; }

        public Turno Turno { get; set; }    

        public int TurnoId { get; set; }

        public Seguro Seguro { get; set; } 

        public int SeguroId { get; set; }   

    
        public Sede Sede { get; set; }  

        public int SedeId { get; set; }


    }
}