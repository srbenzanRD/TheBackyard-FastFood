using System.Collections.Generic;
using System.Reflection.Emit;

namespace TheBackyard_FastFood.Data.Entities
{
    public class Clientes
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }

        public ICollection<Pedidos> Pedidos { get; set; }
    }
    public class ClienteContext : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>()
                .HasMany(c => c.Pedidos)
                .WithOne(p => p.Cliente);
        }
    }
}
