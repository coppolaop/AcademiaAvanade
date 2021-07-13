using CRUD_Vacinas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Vacinas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CidadesController : ControllerBase
    {
        private static List<Cidade> Cidades { get; set; }

        private List<Cidade> ObterColecaoCidades()
        {
            if (Cidades == null) Cidades = new List<Cidade>();

            return Cidades;
        }

        [HttpGet("")]
        [ProducesResponseType(200)]
        public IActionResult Get()
        {
            var cidades = ObterColecaoCidades().Select(c => new { c.CodCidade, c.Nome });

            return Ok(cidades);
        }

        [HttpGet("{codCidade}")]
        [ProducesResponseType(typeof(Cidade), 200)]
        [ProducesResponseType(404)]
        public IActionResult Get(int codCidade)
        {
            List<Cidade> cidades = ObterColecaoCidades();

            Cidade cidade = cidades.FirstOrDefault(c => c.CodCidade == codCidade);

            if (cidade == null) return NotFound();

            return Ok(cidade);
        }

        [HttpPost("")]
        [ProducesResponseType(200)]
        public IActionResult Post(Cidade cidade)
        {
            List<Cidade> cidades = ObterColecaoCidades();

            cidades.Add(cidade);

            return Ok();
        }

        [HttpDelete("")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult Delete(int codCidade)
        {
            List<Cidade> cidades = ObterColecaoCidades();

            Cidade cidade = cidades.FirstOrDefault(c => c.CodCidade == codCidade);

            if (cidade == null) return NotFound();

            cidades.Remove(cidade);

            return Ok();
        }

        [HttpPut("")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult Update(Cidade cidade)
        {
            List<Cidade> cidades = ObterColecaoCidades();

            Cidade cidadeAntiga = cidades.FirstOrDefault(c => c.CodCidade == cidade.CodCidade);

            if (cidadeAntiga == null) return NotFound();

            cidadeAntiga.Nome = cidade.Nome;

            return Ok();
        }
    }
}
