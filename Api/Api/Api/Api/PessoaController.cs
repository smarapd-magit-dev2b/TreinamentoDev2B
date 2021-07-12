using Common.Dto;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Service.ApplicationService.Interface;
using System;

namespace Interface.Api
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaApplicationService PessoaApplicationService;

        public PessoaController(IPessoaApplicationService pessoaApplicationService)
        {
            PessoaApplicationService = pessoaApplicationService;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            var lista = PessoaApplicationService.GetAll();
            return Ok(lista);
        }

        [HttpGet]
        [Route("GetAllCpf")]
        public IActionResult GetAllCpf()
        {
            var lista = PessoaApplicationService.GetAllCpf();
            return Ok(lista);
        }

        [HttpPost]
        public IActionResult Post([FromBody] PessoaPostDto pessoa)
        {
            try
            {
                var id = PessoaApplicationService.AdicionarPessoa(pessoa);
                return Ok(id);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

    }
}
