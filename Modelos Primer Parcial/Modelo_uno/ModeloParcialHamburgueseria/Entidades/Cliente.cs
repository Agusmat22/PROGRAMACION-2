using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private int dni;
        private List<Comida> menu;

        private Cliente(int dni)
        {
            this.dni = dni;
            this.menu = new List<Comida>();
        }

        public static implicit operator Cliente(int numero)
        {
            return new Cliente(numero);
        }

        public static Cliente GetCliente
        {
            get { return new Cliente(1); }
        }

        private double TotalAPagar
        {
            get
            {
                double total = 0;
                if (menu.Count > 0)
                {
                    foreach (Comida item in menu)
                    {
                        total += item.Costo;
                    }
                }
               
                return total;
            }
        }

        public Comida BuscarComida(Comida comida)
        {
            if (menu.Count > 0)
            {
                foreach (Comida item in menu)
                {
                    if (item.Equals(comida))
                    {
                        return item;
                    }
                }
            }

            return null;
        }

        public static Cliente operator +(Cliente cliente, Comida comida)
        {
            if (cliente != comida)
            {
                cliente.menu.Add(comida);
            }

            return cliente;
            
        }

        public static bool operator ==(Cliente cliente, Comida comida)
        {
            foreach (Comida item in cliente.menu)
            {
                if (item.Equals(comida))
                {
                    return true;
                }
            }

            return false;

        }

        public static bool operator !=(Cliente cliente, Comida comida)
        {
            return !(cliente == comida);    
        }

        public static string ImprimirTicket(Cliente cliente)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cliente: {cliente.dni}");
            if (cliente.menu.Count > 0)
            {
                sb.AppendLine($"Menu: ");

                foreach (Comida item in cliente.menu)
                {
                    sb.Append($" {item.Descripcion}, ");                 
                }
            }
            else
            {
                sb.AppendLine($"Menu: NO HAY");

            }
            sb.AppendLine($"Total a pagar: ${cliente.TotalAPagar}");

            return sb.ToString();
        }
    }
}
