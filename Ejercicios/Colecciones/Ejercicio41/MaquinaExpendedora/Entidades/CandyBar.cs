using System.Text;

namespace Entidades
{
    public class CandyBar
    {
        List<Producto> productos;

        public CandyBar()
        {
            productos = new List<Producto>();
        }

        public Producto this[int indice]  //INDEXADOR
        {
            get
            {
                if (indice <= productos.Count)
                {
                    return productos[indice];
                }
                else
                {
                    return null;
                }
            }

            set
            {
                if (indice >= productos.Count)
                {
                    productos.Add(value);
                }
                else
                {
                    productos[indice] = value; 
                }
            }
        }

        public int CantidadProductos()
        { return productos.Count; }

        
        public string MostrarMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--------------------------------");
            sb.AppendLine("|  Producto     Precio     Item|");
            sb.AppendLine("--------------------------------");
            int cantidadProductos = 0;

            foreach (Producto item in productos)
            {
                sb.AppendLine($"{item.Nombre,+10} {item.Precio,+10} {cantidadProductos++, +8}");
            }

            return sb.ToString();

        }

    }
}