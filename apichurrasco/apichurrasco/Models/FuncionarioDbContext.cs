using Microsoft.EntityFrameworkCore;
namespace apichurrasco.Models
{
    public class FuncionarioDbContext : DbContext
    {
        public FuncionarioDbContext(DbContextOptions<FuncionarioDbContext> options)
            : base(options)
        { }
        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
