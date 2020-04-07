namespace Clinica.Entity
{
    public class Turno
    {

        public int TurnoId { get; set; }    

        public int Constante { get; set; }    

        public System.DateTime FechaHoraInicio { get; set; }

        public System.DateTime FechaHoraFin { get; set; }

        public bool Disponible { get; set; }

        public Horario Horario { get; set; }

        public int HorarioId { get; set; }


    }
}