using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesGYM_.Repositorios
{
    public class ClaseRepository
    {
        public static void AgregarClase(Clase clase)
        {
            using (var context = new AplicationDbContext())
            {
                context.Clases.Add(clase);
                context.SaveChanges();
            }
        }
        public static List<Clase> ObtenerClases()
        {
            using (var context = new AplicationDbContext())
            {
                return context.Clases.ToList();
            }
        }
        public static void EliminarClase(int id)
        {
            using (var context = new AplicationDbContext())
            {
                var clase = context.Clases.Find(id);
                if (clase != null)
                {
                    context.Clases.Remove(clase);
                    context.SaveChanges();
                }
            }
        }
        public static void ActualizarClase(int id, Clase nuevaClase)
        {
            using (var context = new AplicationDbContext())
            {
                var claseExistente = context.Clases.Find(id);
                if (claseExistente != null)
                {
                    claseExistente.Nombre = nuevaClase.Nombre;
                    claseExistente.Profesor = nuevaClase.Profesor;
                    claseExistente.HoraInicio = nuevaClase.HoraInicio;
                    claseExistente.HoraFin = nuevaClase.HoraFin;

                    context.SaveChanges();
                }
            }


        }
    }
}
