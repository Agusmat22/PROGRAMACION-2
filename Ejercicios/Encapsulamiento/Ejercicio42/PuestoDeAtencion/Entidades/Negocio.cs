using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            caja = new PuestoAtencion(PuestoAtencion.EPuesto.Caja1); //Instancio el objeto y le asigno la caja
            clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre): this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get 
            {
                if (clientes.Count > 0)
                {
                    return clientes.Dequeue(); //RETORNA UN CLIENTE ELIMINANDOLO
                }

                return null;
            }

            set //agrega clientes a la cola
            {
                _ = this + value; // el guion bajo es para descartar el retorno el la sobrecarga, y el this invoca al objeto propio dicho, ESTO USANDO LA SOBRECARGA +

            }
        }

        public int ClientesPendientes
        {
            get { return clientes.Count; }
        }

        public static bool operator ==(Negocio negocio, Cliente cliente)
        {
            if (negocio.clientes.Count > 0)
            {
                foreach (Cliente item in negocio.clientes)
                {
                    if (cliente == item)
                    {
                        return true;
                    }


                }
            }

            return false;
        }

        public static bool operator!=(Negocio negocio, Cliente cliente)
        {
            return !(negocio == cliente);
        }

        public static bool operator+(Negocio negocio, Cliente cliente)
        {
            if (negocio != cliente)
            {
                negocio.clientes.Enqueue(cliente); //AGREGA UN CLIENTE
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool operator ~(Negocio negocio)
        {
            if (negocio.clientes.Count > 0)
            {
                return negocio.caja.Atender(negocio.Cliente); // LLAMO AL LA PROPIEDAD Y A MEDIDA QUE LOS ATIENDE SE VAN ELIMINANDO
                
            }

            return false;
        }
    }
}
