using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Service.ApplicationService.Interface;
using Common.Dto;
using Common.Exception;
using System.Net;

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
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var pessoa = PessoaApplicationService.GetById(id);
            return Ok(pessoa);
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult AddPessoa([FromBody] AddPessoaDto dto)
        {
            try
            {
                PessoaApplicationService.AdicionarPessoa(dto);
                return Ok();
            }
            catch(DomainException ex)
            {
                return StatusCode((int)HttpStatusCode.Conflict, ex.Message);
            }
            catch(Exception ex)
            {
                return BadRequest("Erro inesperado no sistema");
            }
        }
        [HttpPut]
        [Route("Ativar/{id:int}")]
        public IActionResult AtivarUsuario([FromRoute] int id)
        {
            PessoaApplicationService.AtivarUsuario(id);
            return Ok();
        }
        [HttpDelete]
        [Route("Delete/{id:int}")]
        public IActionResult DeletarPessoa([FromRoute] int id)
        {
            try
            {
                PessoaApplicationService.DeletarPessoa(id);
                return Ok();
            }
            catch (DomainException ex)
            {
                return StatusCode((int)HttpStatusCode.Conflict, ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest("Erro inesperado no sistema");
            }
        }
        [HttpPut]
        [Route("EditarNomeSobrenomeCpf/{id:int}")]
        public IActionResult EditarNomeSobrenomeCpf([FromRoute]int id, [FromBody] EditNomeSobrenomeCpfDto dto)
        {
            try
            {
                PessoaApplicationService.EditNomeSobrenomeCpf(id, dto);
                return Ok();
            }
            catch (DomainException ex)
            {
                return StatusCode((int)HttpStatusCode.Conflict, ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest("Erro inesperado no sistema");
            }
        }
        [HttpPut]
        [Route("Editar/{id:int}")]
        public IActionResult EditarPessoa([FromRoute] int id, [FromBody] EditPessoaDto dto)
        {
            try
            {
                PessoaApplicationService.EditPessoa(id, dto);
                return Ok();
            }
            catch (DomainException ex)
            {
                return StatusCode((int)HttpStatusCode.Conflict, ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest("Erro inesperado no sistema");
            }
        }

    }
}
