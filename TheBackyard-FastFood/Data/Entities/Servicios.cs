using System.Collections.Generic;
using System.Reflection.Emit;

namespace TheBackyard_FastFood.Data.Entities
{
    public class Servicios
    {
        public int ServicioId { get; set; }
        public string Codigo { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }

        public ICollection<PedidoDetalle> PedidoDetalles { get; set; }
    }
    public class ServicioContext : DbContext
    {
        public DbSet<Servicios> Servicios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Servicios>()
                .HasMany(s => s.PedidoDetalles)
                .WithOne(pd => pd.Servicio);
        }
    }
}
