using apichurrasco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apichurrasco.Repositorio
{
    public interface IConvidadoRepositorio
    {
        void Add(Convidado convidado);
        IEnumerable<Convidado> GetAll();
        Convidado Find(long id);
        Convidado FindConvidado(long id);
        void Update(Convidado convidado);
    }
}
