using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesGYM_.Repositorios
{
    public class SuscripcionRepository
    {
        public static void AgregarSuscripcion(Suscripcion suscripcion)
        {
            using (var context = new AplicationDbContext())
            {
                context.Suscripciones.Add(suscripcion);
                context.SaveChanges();
            }
        }
        public static List<Suscripcion> ObtenerSuscripciones()
        {
            using (var context = new AplicationDbContext())
            {
                return context.Suscripciones.ToList();
            }
        }
        public static void EliminarSuscripcion(int id)
        {
            using (var context = new AplicationDbContext())
            {
                var suscripcion = context.Suscripciones.Find(id);
                if (suscripcion != null)
                {
                    context.Suscripciones.Remove(suscripcion);
                    context.SaveChanges();
                }
            }
        }
        public static void ActualizarSuscripcion(Suscripcion suscripcion)
        {
            using (var context = new AplicationDbContext())
            {
                context.Suscripciones.Update(suscripcion);
                context.SaveChanges();
            }
        }
    }
}
