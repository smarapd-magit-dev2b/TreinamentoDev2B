using System;
using System.Net;
using Common.Dto;
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

        [HttpPost("{id:int}")]
        public IActionResult PostFilhos(int id, [FromBody] PessoaFilhosPutDto pessoa)
        {
            try
            {
                PessoaApplicationService.AdicionarFilho(id, pessoa);
                return Ok($"Adicionado filho da Pessoa com Id: {id}");
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

        [HttpPatch("{id:int}")]
        public IActionResult Patch(int id, [FromBody] PessoaPatchDto pessoa)
        {
            try
            {
                PessoaApplicationService.AtualizarPessoa(id, pessoa);
                return Ok($"Pessoa atualizada com Id: {id}");
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

        [HttpPatch("ActivateUser/{id:int}")]
        public IActionResult PutUsuarioActivate(int id)
        {
            try
            {
                PessoaApplicationService.AtivarUsuario(id);
                return Ok($"A pessoa com Id: {id} foi ativada.");
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

        [HttpPatch("DeactivateUser/{id:int}")]
        public IActionResult PutUsuarioDeactivate(int id)
        {
            try
            {
                PessoaApplicationService.DesativarUsuario(id);
                return Ok($"A pessoa com Id: {id} foi desativada.");
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
