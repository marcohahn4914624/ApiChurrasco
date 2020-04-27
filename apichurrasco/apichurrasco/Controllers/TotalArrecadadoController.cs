using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using apichurrasco.Repositorio;
using apichurrasco.Models;


namespace apichurrasco.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TotalArrecadadoController : Controller
    {
        private readonly IFuncionarioRepositorio _funcionarioRepositorio;
        private readonly IConvidadoRepositorio _convidadoRepositorio;

        public TotalArrecadadoController(IFuncionarioRepositorio funcRepo, IConvidadoRepositorio funcConvidado)
        {
            _funcionarioRepositorio = funcRepo;
            _convidadoRepositorio = funcConvidado;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var TotalArrecadadoBebeFunc = _funcionarioRepositorio.GetAll().Where(f => f.CANCELADO == "N" &&
                                       f.CONSOME_BEBIDA == "S").Count()*20;
            var TotalArrecadadoNBebeFunc = _funcionarioRepositorio.GetAll().Where(f => f.CANCELADO == "N" &&
                                   f.CONSOME_BEBIDA == "N").Count()*10;

            var TotalArrecadadoBebeConv = _convidadoRepositorio.GetAll().Where(c => c.CANCELADO == "N" &&
                                       c.CONSOME_BEBIDAS == "S").Count() * 40;
            var TotalArrecadadoNBebeConv = _convidadoRepositorio.GetAll().Where(c => c.CANCELADO == "N" &&
                                       c.CONSOME_BEBIDAS == "N").Count() * 20;

            return new ObjectResult(TotalArrecadadoBebeFunc+
                                    TotalArrecadadoNBebeFunc+
                                    TotalArrecadadoBebeConv +
                                    TotalArrecadadoNBebeConv 
                                    );
        }

    }
}