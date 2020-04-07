using System.Collections.Generic;

namespace Clinica.Entity
{
    public class HorarioSeguro
    {

        public int HorarioSeguroId { get; set; }    

        public Horario Horario { get; set; }

        public int HorarioId {get; set;}

        public Seguro Seguro { get; set; }    

        public int SeguroId { get; set; }

    }
}