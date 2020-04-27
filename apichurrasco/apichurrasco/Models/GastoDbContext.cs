using Microsoft.EntityFrameworkCore;

namespace apichurrasco.Models
{
    public class GastoDbContext : DbContext
    {
        public GastoDbContext(DbContextOptions<GastoDbContext> options)
            : base(options)
        { }
        public DbSet<Gasto> Gastos { get; set; }
    }
}
