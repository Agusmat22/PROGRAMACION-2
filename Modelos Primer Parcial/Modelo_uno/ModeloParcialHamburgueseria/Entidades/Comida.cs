using System.Text;

namespace Entidades
{
    public abstract class Comida
    {
        public enum EIngredientes
        {
            ADHERESO,
            QUESO=10,
            CEBOLLA=8,
            LECHUGA=7,
            TOMATE=9,
            JAMON=12,
            HUEVO=13,
            PANCETA=15
        }

        protected List<EIngredientes> ingredientes;
        private string nombre;


        protected Comida(string nombre):this(nombre,new List<EIngredientes>())
        {
        }

        protected Comida(string nombre,List<EIngredientes> ingredientes)
        { 
            this.ingredientes = ingredientes;
            this.nombre = nombre;
        }

        //PROPERTY
        public double Costo
        {
            get { return CalcularCosto(); }
        }

        public string Descripcion
        {
            get 
            { 
                if(this.ingredientes.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();

                    foreach (EIngredientes item in ingredientes)
                    {
                        sb.Append(item.ToString() + ", ");
                    }
                    
                    return sb.ToString();
                }
                else
                {
                    return "No hay comida";
                }


            }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        //METODOS

        protected abstract string AgregarIngrediente(EIngredientes ingrediente);

        protected abstract double CalcularCosto();

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Costo: {this.Costo}");
            sb.AppendLine($"Ingredientes: {this.Descripcion}");

            return sb.ToString();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Comida c)
            {          
                return this.Nombre == c.Nombre;                 
            }
            
            return false;
            
        }

        //SOBRECARGA OPEDAROS
        public static bool operator ==(Comida c,EIngredientes ingrediente)
        {
            if (c.ingredientes.Count > 0)
            {
                foreach (EIngredientes item in c.ingredientes)
                {
                    if (item == ingrediente)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator !=(Comida c,EIngredientes ingrediente)
        {
            return !(c == ingrediente); 
        }

        public static string operator +(Comida c,EIngredientes ingrediente)
        {
            return c.AgregarIngrediente(ingrediente);
        }

    }
}