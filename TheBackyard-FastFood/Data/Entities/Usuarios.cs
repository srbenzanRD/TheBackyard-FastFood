using System.Collections.Generic;

namespace TheBackyard_FastFood.Data.Entities
{
    public class Usuarios
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
    }
    public class UsuarioContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Tu cadena de conexión aquí");
            }
        }
    }
}