namespace Clinica.Entity
{
    public class MedicoEspecialidad
    {
        public int MedicoEspecialidadId { get; set; }

        public Medico Medico { get; set; }

        public int MedicoId { get; set; }

        public Especialidad Especialidad { get; set; } 

        public int EspecialidadId { get; set; }


    }
}