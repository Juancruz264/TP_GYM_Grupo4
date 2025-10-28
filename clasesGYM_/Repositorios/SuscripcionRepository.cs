using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clasesGYM_;

namespace clasesGYM_.Repositorios
{
    public class SuscripcionRepository
    {
        // METODO: Crear nueva suscripcion en la base de datos
        public static void AgregarSuscripcion(Suscripcion suscripcion)
        {
            using (var context = new AplicationDbContext())
            {
                context.Suscripciones.Add(suscripcion);
                context.SaveChanges();
            }
        }


        // METODO: Obtener todas las suscripciones disponibles
        public static List<Suscripcion> ObtenerSuscripciones()
        {
            using (var context = new AplicationDbContext())
            {
                return context.Suscripciones.ToList();
            }
        }

        // METODO: Obtener una suscripcion especifica por su ID
        public static Suscripcion ObtenerSuscripcion(int suscripcionId)
        {
            using (var context = new AplicationDbContext())
            {
                return context.Suscripciones.Find(suscripcionId);
            }
        }

        // METODO: Eliminar una suscripcion de la base de datos por ID
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

        // METODO: Actualizar los datos de una suscripcion existente
        public static void ActualizarSuscripcion(Suscripcion suscripcion)
        {
            using (var context = new AplicationDbContext())
            {
                var suscripcionExistente = context.Suscripciones.Find(suscripcion.Id);
                if (suscripcionExistente != null)
                {
                    suscripcionExistente.Nombre = suscripcion.Nombre;
                    suscripcionExistente.Precio = suscripcion.Precio;
                    context.SaveChanges();
                }
            }
        }

    }
}
