using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apichurrasco.Models;

namespace apichurrasco.Repositorio 
{
    public class GastoRepositorio : IGastoRepositorio
    {
        private readonly GastoDbContext _context;
        public GastoRepositorio(GastoDbContext ctx)
        {
            _context = ctx;
        }

        public IEnumerable<Gasto> GetAll()
        {
            return _context.Gastos.ToList();
        }

        
    }
}
