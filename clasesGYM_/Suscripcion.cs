using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesGYM_
{
    public class Suscripcion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Vigencia { get; set; }

        public static List<Suscripcion> ObtenerTipos()
        {
            return new List<Suscripcion>
            {
                new Suscripcion { Nombre = "Un día libre" },
                new Suscripcion { Nombre = "Tres veces a la semana"},
                new Suscripcion { Nombre = "Pase Libre"}
            };
        }
    }
}