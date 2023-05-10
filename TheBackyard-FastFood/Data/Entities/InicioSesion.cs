using System.Collections.Generic;

namespace TheBackyard_FastFood.Data.Entities
{
    public class InicioSesion
    {
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
    }
    public class InicioSesionContext : DbContext
    {
        public DbSet<InicioSesion> InicioSesiones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Tu cadena de conexión aquí");
            }
        }
    }
}
