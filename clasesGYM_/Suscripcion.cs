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
        [Key]
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaVen { get; set; }
        public TipoSuscripcion Tipo { get; set; }
        public Factura FacturaAsociada { get; set; } 
        public EstadoFac EstadoFactura { get; set; }
        public enum TipoSuscripcion { PaseLibre, TresVecesPorSemana, DiaSolo }
        public enum EstadoFac { vencida, pagada, pendiente }
    }
}
