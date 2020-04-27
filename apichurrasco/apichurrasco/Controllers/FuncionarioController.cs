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
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioRepositorio _funcionarioRepositorio;
        private readonly IConvidadoRepositorio _convidadoRepositorio;

        public FuncionarioController(IFuncionarioRepositorio funcRepo)
        {
            _funcionarioRepositorio = funcRepo;
        }

        

        [HttpGet]
        public IEnumerable<Funcionario> GetAll()
        {
            return _funcionarioRepositorio.GetAll();
        }
        



        [HttpGet("{id}", Name = "GetFuncionario")]

        public IActionResult GetById(long id)
        {
            var funcionario = _funcionarioRepositorio.Find(id);
            if (funcionario == null)
                return NotFound();

            return new ObjectResult(funcionario);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Funcionario funcionario)
        {
            if (funcionario == null)
                return BadRequest();

            _funcionarioRepositorio.Add(funcionario);

            return CreatedAtRoute("GetFuncionario", new { id = funcionario.ID }, funcionario);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCancelado(long id,[FromBody] Funcionario funcionario)
        {
            if (funcionario == null )
                return BadRequest();

            var _funcionario = _funcionarioRepositorio.Find(id);

            if (_funcionario == null)
                return NotFound();

            _funcionario.CANCELADO = "S";

            _funcionarioRepositorio.Update(_funcionario);

            return new NoContentResult();
        }
    }
}