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
        public List <Horario> Horarios { get; set; }
    }
}
