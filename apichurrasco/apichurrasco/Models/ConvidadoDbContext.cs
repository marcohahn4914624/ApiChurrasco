using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace apichurrasco.Models
{
    public class ConvidadoDbContext : DbContext
    {
        public ConvidadoDbContext(DbContextOptions<ConvidadoDbContext> options)
            : base(options)
        { }
        public DbSet<Convidado> Convidados { get; set; }
    }
}
