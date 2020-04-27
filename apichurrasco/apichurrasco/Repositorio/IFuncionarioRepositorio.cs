using apichurrasco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apichurrasco.Repositorio
{
    public interface IFuncionarioRepositorio
    {
        void Add(Funcionario func);
        IEnumerable<Funcionario> GetAll();
        Funcionario Find(long id);
        void Update(Funcionario func);
        
    }
}
