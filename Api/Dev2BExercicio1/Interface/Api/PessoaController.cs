using System;
using System.Net;
using Common.Dtos;
using Common.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Service.ApplicationService.Interfaces;

namespace Interface.Controllers
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

        [HttpGet("{id:int}")]
        public IActionResult GetId(int id)
        {
            try
            {
                var lista = PessoaApplicationService.GetPessoaId(id);
                return Ok(lista);
            }
            catch (DomainException de)
            {
                return StatusCode((int)HttpStatusCode.Conflict, de.Message);
            }
            catch (Exception)
            {
                return BadRequest($"Houve um erro inesperado no servidor. Tente novamente.");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] PessoaPostDto pessoa)
        {
            try
            {
                var id = PessoaApplicationService.AdicionarPessoa(pessoa);
                return Ok($"Pessoa adicionada com Id: {id}");
            }
            catch (DomainException de)
            {
                return StatusCode((int)HttpStatusCode.Conflict, de.Message);
            }
            catch (Exception)
            {
                return BadRequest($"Houve um erro inesperado no servidor. Tente novamente.");
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, [FromBody] PessoaPutDto pessoa)
        {
            try
            {
                PessoaApplicationService.EditarPessoa(id, pessoa);
                return Ok($"Pessoa editada com Id: {id}");
            }
            catch (DomainException de)
            {
                return StatusCode((int)HttpStatusCode.Conflict, de.Message);
            }
            catch (Exception)
            {
                return BadRequest($"Houve um erro inesperado no servidor. Tente novamente.");
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                PessoaApplicationService.DeletarPessoa(id);
                return Ok($"Pessoa removida com Id: {id}");
            }
            catch (DomainException de)
            {
                return StatusCode((int)HttpStatusCode.Conflict, de.Message);
            }
            catch (Exception)
            {
                return BadRequest($"Houve um erro inesperado no servidor. Tente novamente.");
            }
        }


    }
}
