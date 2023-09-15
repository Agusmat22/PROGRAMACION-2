using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Veterinaria
    {
        private List<Cliente> listaClientes;

        public Veterinaria()
        {
            listaClientes = new List<Cliente>();    
        }

        public void RegistrarCliente(Cliente cliente)
        {
            listaClientes.Add(cliente);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Cliente cliente in listaClientes)
            {
                sb.AppendLine(cliente.Mostrar());
                sb.AppendLine("Mascotas: \n"+cliente.MostrarMascotas());
            }

            return sb.ToString();   
        }
    }
}
