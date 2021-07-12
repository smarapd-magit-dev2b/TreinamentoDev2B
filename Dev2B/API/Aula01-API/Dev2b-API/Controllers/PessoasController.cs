using Application;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev2b_API.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class PessoasController : ControllerBase {
        private readonly IPessoaService pessoaService;

        public PessoasController(IPessoaService pessoaService) {
            this.pessoaService = pessoaService;
        }

        [HttpPost]
        public IActionResult Post([FromBody]Pessoa pessoa) {
            try {
                pessoaService.AdicionarPessoa(pessoa);
                return Ok();
            }
            catch (Exception ex) {

                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public IActionResult Put([FromBody]Pessoa pessoa) {
            try {
                pessoaService.AtualizarPessoa(pessoa);
                return Ok();
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
        }
    }
}
