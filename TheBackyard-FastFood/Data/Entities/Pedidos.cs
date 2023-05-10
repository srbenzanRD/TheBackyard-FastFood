using System.Collections.Generic;
using System.Reflection.Emit;

namespace TheBackyard_FastFood.Data.Entities
{
    public class Pedidos
    {
        public int PedidoId { get; set; }
        public string Codigo { get; set; }
        public int ClienteId { get; set; }
        public string DireccionDeEntrega { get; set; }
        public TipoEntrega TipoEntrega { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public decimal Total { get; set; }

        public Clientes Cliente { get; set; }
        public ICollection<PedidoDetalle> PedidoDetalles { get; set; }
    }
    public class PedidoDetalle
    {
        public int PedidoDetalleId { get; set; }
        public int PedidoId { get; set; }
        public int ServicioId { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public Pedidos Pedido { get; set; }
        public Servicios Servicio { get; set; }
    }

    public enum TipoEntrega
    {
        EntregaFisica,
        EntregaDelivery
    }

    public class PedidoContext : DbContext
    {
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<PedidoDetalle> PedidoDetalles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedidos>()
                .HasMany(p => p.PedidoDetalles)
                .WithOne(pd => pd.Pedido);
            modelBuilder.Entity<PedidoDetalle>()
                .HasOne(pd => pd.Servicio)
                .WithMany(s => s.PedidoDetalles);
        }
    }
}
