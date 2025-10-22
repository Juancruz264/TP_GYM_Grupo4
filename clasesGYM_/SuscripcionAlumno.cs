using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesGYM_
{
    public class SuscripcionAlumno
    {
        public int Id { get; set; }
        public int AlumnoId { get; set; }
        public int SuscripcionId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
