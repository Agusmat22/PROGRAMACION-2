using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

/* CREAR DB Y TABLAS EN SQL SERVER PARA MI PC  
NOMBRE DE LA BASE DE DATOS=  Pix
 

CREATE TABLE Producto(
id INT,
nombre VARCHAR(20),
precio FLOAT
CONSTRAINT pk_id PRIMARY KEY (id)
);

INSERT INTO Producto (id,nombre,precio) VALUES (1,'Oreo',222),(2,'Chocolinas',199)

CREATE TABLE Bondola(
id_bondola INT,
cantidad INT,
id_producto INT,
CONSTRAINT pk_id_bondola PRIMARY KEY (id_bondola),
FOREIGN KEY (id_producto) REFERENCES Producto(id)
); 
 
*/


namespace primeraPagina.Models
{
    public partial class PixContext : DbContext
    {
        public PixContext()
        {
        }

        public PixContext(DbContextOptions<PixContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bondola> Bondolas { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=PC094;Database=Pix;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bondola>(entity =>
            {
                entity.HasKey(e => e.IdBondola)
                    .HasName("pk_id_bondola");

                entity.ToTable("Bondola");

                entity.Property(e => e.IdBondola)
                    .ValueGeneratedNever()
                    .HasColumnName("id_bondola");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.IdProducto).HasColumnName("id_producto");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.Bondolas)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK__Bondola__id_prod__398D8EEE");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.ToTable("Producto");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Precio).HasColumnName("precio");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
