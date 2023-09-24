namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero,string nombre) :this(numero)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set 
            { 
                this.Nombre = value;           
            }
        }
        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        public static bool operator ==(Cliente a, Cliente b)
        {
            return a.Numero == b.Numero;
        }

        public static bool operator !=(Cliente a, Cliente b)
        {
            return !(a == b);
        }
    }
}