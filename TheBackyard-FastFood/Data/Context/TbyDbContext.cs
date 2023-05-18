using Microsoft.EntityFrameworkCore;
using TheBackyard_FastFood.Data.Entities;

namespace TheBackyard_FastFood.Data.Context
{
    public class TbyDbContext : DbContext, ITbyDbContext
    {
        private readonly IConfiguration config;

        public TbyDbContext(IConfiguration config)
        {
            this.config = config;
        }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ServerVersion.AutoDetect(connectionString: config.GetConnectionString(name: "MySQL")));
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
