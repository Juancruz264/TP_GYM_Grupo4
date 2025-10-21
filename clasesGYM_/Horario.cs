using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesGYM_
{
    public class Horario
    {
        public int Id { get; set; }
        public Dias diasclases { get; set; }
        public TimeOnly HoraInicio { get; set; }
        public TimeOnly HoraFin { get; set; }
        public enum Dias { Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo } 
    }
}
