using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesGYM_
{
    public class Clase
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public string Profesor { get; set; }
        public TimeOnly HoraInicio { get; set; }
        public TimeOnly HoraFin { get; set; }
        public Dias _Dias { get; set; }

        [Flags]
        public enum Dias
        {
            Ninguno = 0,
            Lunes = 1,
            Martes = 2,
            Miércoles = 4,
            Jueves = 8,
            Viernes = 16,
            Sábado = 32,
            Domingo = 64
        }


    }
}
