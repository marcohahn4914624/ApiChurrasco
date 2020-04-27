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
    public class ConvidadoController : Controller
    {
        private readonly IConvidadoRepositorio _convidadoRepositorio;
        public ConvidadoController(IConvidadoRepositorio funcConvidado)
        {
            _convidadoRepositorio = funcConvidado;
        }

        [HttpGet]
        public IEnumerable<Convidado> GetAll()
        {
            return _convidadoRepositorio.GetAll();
        }


        [HttpPost]
        public IActionResult Create([FromBody] Convidado convidado)
        {
            if (convidado == null)
                return BadRequest();
            var _conv = _convidadoRepositorio.FindConvidado(Convert.ToInt32(convidado.ID_FUNCIONARIO));

            if (_conv != null)
            {
                var retorno = "Funcionário com um comvidado já cadastrado";
                return new ObjectResult(retorno);
            }
            _convidadoRepositorio.Add(convidado);

            return CreatedAtRoute("GetFuncionario", new { id = convidado.ID }, convidado);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCancelado(long id, [FromBody] Convidado convidado)
        {
            if (convidado == null)
                return BadRequest();

            var _convidado = _convidadoRepositorio.Find(id);

            if (_convidado == null)
                return NotFound();

            _convidado.CANCELADO = "S";

            _convidadoRepositorio.Update(_convidado);

            return new NoContentResult();
        }
    }
}