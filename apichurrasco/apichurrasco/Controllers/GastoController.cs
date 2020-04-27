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
    public class GastoController : Controller
    {
        private readonly IGastoRepositorio _gastoRepositorio;

        public GastoController(IGastoRepositorio funcGasto)
        {
            _gastoRepositorio = funcGasto;
        }

        [HttpGet("{operacao}", Name = "GetGasto")]

        public IActionResult GetById(string operacao)
        {

            var gasto = _gastoRepositorio.GetAll();
            decimal ValorComida = 0;
            decimal ValorBebida = 0;
            foreach (var item in gasto)
            {
                ValorComida += item.GASTO_COMIDA;
                ValorBebida+= item.GASTO_BEBIDA;
            }
            decimal valorretorno = 0;
            if(operacao=="totalgasto")
                valorretorno = ValorComida + ValorBebida;
            if (operacao == "totalcomida")
                valorretorno = ValorComida ;
            if (operacao == "totalbebida")
                valorretorno = ValorBebida;
           

            if (gasto == null)
                return NotFound();
            

            return new ObjectResult(valorretorno);
        }

        
    }
}