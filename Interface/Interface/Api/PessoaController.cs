using Commom.Dto;
using Microsoft.AspNetCore.Mvc;
using Service.ApplicationService.Interfaces;
using System;

namespace Interface.Api
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaApplicationService PessoaApplicationService;

        public PessoaController(IPessoaApplicationService pessoaApplicationService) => PessoaApplicationService = pessoaApplicationService;

        [HttpPost]
        public IActionResult Post([FromBody] PessoaPostDto pessoa)
        {
            try
            {
                var id = PessoaApplicationService.Adicionarpessoa(pessoa);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll() {
            var lista = PessoaApplicationService.GetAll();
            return Ok(lista);
        }
    }
}
