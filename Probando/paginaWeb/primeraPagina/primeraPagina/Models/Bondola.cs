using System;
using System.Collections.Generic;

namespace primeraPagina.Models
{
    public partial class Bondola
    {
        public int IdBondola { get; set; }
        public int? Cantidad { get; set; }
        public int? IdProducto { get; set; }

        public virtual Producto? IdProductoNavigation { get; set; }
    }
}
