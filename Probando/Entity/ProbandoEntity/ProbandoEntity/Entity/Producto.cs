using System;
using System.Collections.Generic;

namespace ProbandoEntity.Entity
{
    public partial class Producto
    {
        public Producto()
        {
            Bondolas = new HashSet<Bondola>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public double? Precio { get; set; }

        public virtual ICollection<Bondola> Bondolas { get; set; }
    }
}
