using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apichurrasco.Models;

namespace apichurrasco.Repositorio
{
    public class ConvidadoRepositario : IConvidadoRepositorio
    {
        private readonly ConvidadoDbContext _context;
        public ConvidadoRepositario(ConvidadoDbContext ctx)
        {
            _context = ctx;
        }
        public void Add(Convidado convidado)
        {
            _context.Convidados.Add(convidado);
            _context.SaveChanges();
        }
        public Convidado Find(long id)
        {
            return _context.Convidados.FirstOrDefault(f => f.ID == id);
        }
        public Convidado FindConvidado(long id)
        {
            return _context.Convidados.FirstOrDefault(f => f.ID_FUNCIONARIO == id);
        }
        public IEnumerable<Convidado> GetAll()
        {
            return _context.Convidados.ToList().Where(f => f.CANCELADO == "N");
        }

        public void Update(Convidado func)
        {
            _context.Convidados.Update(func);
            _context.SaveChanges();
        }
    }
}
