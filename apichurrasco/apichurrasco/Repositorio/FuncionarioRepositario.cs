using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apichurrasco.Models;

namespace apichurrasco.Repositorio
{
    public class FuncionarioRepositario : IFuncionarioRepositorio
    {
        private readonly FuncionarioDbContext _context;
        public FuncionarioRepositario(FuncionarioDbContext ctx)
        {
            _context = ctx;
        }
        public void Add(Funcionario func)
        {
            _context.Funcionarios.Add(func);
            _context.SaveChanges();
        }
        public Funcionario Find(long id)
        {
            return _context.Funcionarios.FirstOrDefault(f => f.ID == id);
        }
        public IEnumerable<Funcionario> GetAll()
        {
            return _context.Funcionarios.ToList().Where(f => f.CANCELADO=="N");
        }

        public void Update(Funcionario func)
        {
            _context.Funcionarios.Update(func);
            _context.SaveChanges();
        }
    }
}
