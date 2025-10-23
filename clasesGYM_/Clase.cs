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
        public Horario Horario { get; set; }
        public static List<Clase> ObtenerHorario()
        {
            return new List<Clase>
            {
                new Clase { Nombre = "De 7:00  a 12:00 " },
                new Clase { Nombre = "De 13:00 a 16:00"},
                new Clase { Nombre = "De 16:00 a 20:00"}
            };
        }

    }
}
