using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesGYM_.Repositorios
{
    public class ClienteRepository
    {
        public static void AgregarCliente(Cliente cliente)
        {
            using (var context = new AplicationDbContext())
            {
                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
        }
    }
}
