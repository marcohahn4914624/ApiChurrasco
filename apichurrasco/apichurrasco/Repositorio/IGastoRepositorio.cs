using apichurrasco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apichurrasco.Repositorio
{
    public interface IGastoRepositorio
    {
        IEnumerable<Gasto> GetAll();
      
    }
}
