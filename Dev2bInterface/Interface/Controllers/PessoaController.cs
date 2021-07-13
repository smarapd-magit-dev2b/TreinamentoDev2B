using Common.Dto;
using Common.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Service.ApplicationService.Interfaces;
using System;
using System.Net;

namespace Interface
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

        [HttpPost]
        public IActionResult Adicionar([FromBody] PessoaPostDto pessoa)
        {
            try
            {
                var id = PessoaApplicationService.Cadastrar(pessoa);
                return Ok(id);
            }
            catch (DomainException e)
            {
                return StatusCode((int)HttpStatusCode.Conflict, e.Message);
            }
            catch (Exception)
            {
                return BadRequest("Houve um erro inesperado no servidor. Tente novamente.");
            }
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            var lista = PessoaApplicationService.Listar();
            return Ok(lista);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                PessoaApplicationService.Deletar(id);
                return Ok($"Pessoa de ID:{id} removida com sucesso...");
            }
            catch (DomainException e)
            {
                return StatusCode((int)HttpStatusCode.Conflict, e.Message);
            }
            catch (Exception)
            {
                return BadRequest("Houve um erro inesperado no servidor. Tente novamente.");
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult GetId(int id)
        {
            try
            {
                var listapessoaid = PessoaApplicationService.ListarPessoaPorID(id);
                return Ok(listapessoaid);
            }
            catch (DomainException e)
            {
                return StatusCode((int)HttpStatusCode.Conflict, e.Message);
            }
            catch (Exception)
            {
                return BadRequest("Houve um erro inesperado no servidor. Tente novamente.");
            }
        }

        [HttpPatch("{id:int}")]
        public IActionResult Editar(int id, [FromBody] PessoaPutIdDto pessoaputDto)
        {
            try
            {
                PessoaApplicationService.EditarId(id, pessoaputDto);
                return Ok($"Pessoa com o ID:{id} foi editada com sucesso...");
            }
            catch (DomainException e)
            {
                return StatusCode((int)HttpStatusCode.Conflict, e.Message);
            }
            catch (Exception)
            {
                return BadRequest("Houve um erro inesperado no servidor. Tente novamente.");
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult EditarPutBasic(int id, [FromBody] PessoaPutBasicDto pessoaDto)
        {
            try
            {
                PessoaApplicationService.EditarPutBasicDto(id, pessoaDto);
                return Ok($"Pessoa com o ID:{id} foi editada com sucesso...");
            }
            catch (DomainException e)
            {
                return StatusCode((int)HttpStatusCode.Conflict, e.Message);
            }
            catch (Exception)
            {
                return BadRequest("Houve um erro inesperado no servidor. Tente novamente.");
            }
        }
        [HttpPut("Status/{id:int}")]
        public IActionResult MudarStatusdoUsuario(int id)
        {
            try
            {
                PessoaApplicationService.StatusUsuario(id);
                return Ok($"Status do cadastro ID:{id} foi alterado com sucesso...");
            }
            catch (DomainException e)
            {
                return StatusCode((int)HttpStatusCode.Conflict, e.Message);
            }
            catch (Exception)
            {
                return BadRequest("Houve um erro inesperado no servidor. Tente novamente.");
            }
        }
        [HttpPost("Filhos/{id:int}")]
        public IActionResult AdicionarFilhos(int id, [FromBody] PessoaFilhosDto pessoa)
        {
            try
            {
                PessoaApplicationService.CadastrarFilhos(id, pessoa);
                return Ok("Filho adicionado com sucesso...");
            }
            catch (DomainException e)
            {
                return StatusCode((int)HttpStatusCode.Conflict, e.Message);
            }
            catch (Exception)
            {
                return BadRequest("Houve um erro inesperado no servidor. Tente novamente.");
            }
        }
    }
}