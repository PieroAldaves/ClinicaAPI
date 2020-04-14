namespace Clinica.Repository.ViewModel
{
    public class TurnoViewModel  
    {

        // Turno

        public int TurnoId { get; set; }
        public System.DateTime FechaHoraInicio { get; set; }

        public System.DateTime FechaHoraFin { get; set; }

        public bool Disponible { get; set; }

        // Medico

        public string MedicoNombre { get; set; }
        public string MedicoApellido_Paterno { get; set; }
        public string MedicoApellido_Materno { get; set; }

        // Especialidad

        public string EspecialidadName { get; set; }


        // Horario
        public string HorarioDayName { get; set; }
        public System.DateTime HorarioFecha { get; set; }


        //Sede

        public string SedeName { get; set; }



    }


}


