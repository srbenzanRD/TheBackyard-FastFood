using Microsoft.EntityFrameworkCore;
using TheBackyard_FastFood.Data.Entities;

namespace TheBackyard_FastFood.Data.Context
{
    public interface ITbyDbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}