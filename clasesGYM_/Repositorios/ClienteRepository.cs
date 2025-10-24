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
        public static void EliminarCliente(int clienteId)
        {
            using (var context = new AplicationDbContext())
            {
                var cliente = context.Clientes.Find(clienteId);
                if (cliente != null)
                {
                    context.Clientes.Remove(cliente);
                    context.SaveChanges();
                }
            }
        }
        public static void ActualizarCliente(Cliente cliente)
        {
            using (var context = new AplicationDbContext())
            {
                var clienteExistente = context.Clientes.Find(cliente.Id);
                if (clienteExistente != null)
                {
                    clienteExistente.Nombre = cliente.Nombre;
                    clienteExistente.Apellido = cliente.Apellido;
                    clienteExistente.Direccion = cliente.Direccion;
                    clienteExistente.Telefono = cliente.Telefono;
                    context.SaveChanges();
                }
            }
        }
    }
}
