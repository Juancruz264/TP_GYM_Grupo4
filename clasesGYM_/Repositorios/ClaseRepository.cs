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
    }
}
