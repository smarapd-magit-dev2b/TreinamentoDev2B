﻿using System;
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
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var lista = PessoaApplicationService.GetAll();

            return Ok(lista);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
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
                var id = PessoaApplicationService.AddPessoa(pessoa);
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

        [HttpPost("Filho/{id:int}")]
        public IActionResult PostFilhos(int id, [FromBody] PessoaFilhosPutDto pessoa)
        {
            try
            {
                PessoaApplicationService.AddFilho(id, pessoa);
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
                PessoaApplicationService.EditPessoa(id, pessoa);
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
                PessoaApplicationService.DeletePessoa(id);
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

        [HttpPut("EditInfo/{id:int}")]
        public IActionResult Patch(int id, [FromBody] PessoaEditInfoPutDto pessoa)
        {
            try
            {
                PessoaApplicationService.EditInfoPessoa(id, pessoa);
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

        [HttpPut("EnableUser/{id:int}")]
        public IActionResult PutEnableUser(int id)
        {
            try
            {
                PessoaApplicationService.EnableUser(id);
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

        [HttpPut("DisableUser/{id:int}")]
        public IActionResult PutDisableUser(int id)
        {
            try
            {
                PessoaApplicationService.DisableUser(id);
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
