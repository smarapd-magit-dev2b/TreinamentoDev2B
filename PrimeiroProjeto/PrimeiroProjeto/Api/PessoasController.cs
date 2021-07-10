using Commom.Dto;
using Commom.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Service.AplicationService.Interfaces;
using System;
using System.Collections.Generic;

namespace Interface.Api
{
    [ApiController]
    [Route("[controller]")]
    public class PessoasController : Controller
    {
        private readonly IPessoaAplicationService _pessoaAplicationService;

        public PessoasController(IPessoaAplicationService pessoaAplicationService) => _pessoaAplicationService = pessoaAplicationService;

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_pessoaAplicationService.Get());
            }
            catch (NegocioException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest("Erro inesperado");
            }
        }

        [HttpGet("{codigo:int}")]
        public IActionResult Get(int codigo)
        {
            try
            {
                return Ok(_pessoaAplicationService.GetPorCodigo(codigo));
            }
            catch (NegocioException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest("Erro inesperado");
            }
        }

        [HttpPost()]
        public IActionResult Post([FromBody] PessoaPostDto pessoaDto)
        {
            try
            {
                return Ok($"Pessoa com o Código {_pessoaAplicationService.Post(pessoaDto)} adicionada com Sucesso");
            }
            catch (NegocioException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest("Erro inesperado");
            }
        }

        [HttpPost("{codigo:int}/filho")]
        public IActionResult Post(int codigo, [FromBody] PessoaPostDto pessoaDto)
        {
            try
            {
                return Ok($"Filho com o Código de {_pessoaAplicationService.Post(codigo, pessoaDto)} adicionado a Pessoa de Código {codigo} com sucesso");
            }
            catch (NegocioException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest("Erro inesperado");
            }
        }

        [HttpPost("{codigo:int}/filhos")]
        public IActionResult Post(int codigo, [FromBody] List<PessoaPostDto> pessoasDto)
        {
            try
            {
                _pessoaAplicationService.Post(codigo, pessoasDto);

                return Ok($"Filhos adicionados a Pessoa de Código {codigo} com sucesso");
            }
            catch (NegocioException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest("Erro inesperado");
            }
        }

        [HttpPut("{codigo:int}")]
        public IActionResult Put(int codigo, [FromBody] PessoaPostDto pessoaDto)
        {
            try
            {
                return Ok($"Pessoa com o Código {_pessoaAplicationService.Put(codigo, pessoaDto)} alterada com Sucesso");
            }
            catch (NegocioException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest("Erro inesperado");
            }
        }

        [HttpPut("{codigo:int}/essencial")]
        public IActionResult PutEssencial(int codigo, [FromBody] PessoaPutEssencialDto pessoaDto)
        {
            try
            {
                return Ok($"Pessoa com o Código {_pessoaAplicationService.PutEssencial(codigo, pessoaDto)} atualizada com Sucesso");
            }
            catch (NegocioException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest("Erro inesperado");
            }
        }

        [HttpPut("{codigo:int}/ativar")]
        public IActionResult PutAtivar(int codigo)
        {
            try
            {
                return Ok($"Pessoa com o Código {_pessoaAplicationService.PutUsuarioAtivo(codigo, true)} foi ativada com Sucesso");
            }
            catch (NegocioException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest("Erro inesperado");
            }
        }

        [HttpPut("{codigo:int}/desativar")]
        public IActionResult PutDesativar(int codigo)
        {
            try
            {
                return Ok($"Pessoa com o Código {_pessoaAplicationService.PutUsuarioAtivo(codigo, false)} foi desativada com Sucesso");
            }
            catch (NegocioException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest("Erro inesperado");
            }
        }

        [HttpDelete("{codigo:int}")]
        public IActionResult Delete(int codigo)
        {
            try
            {
                return Ok($"Pessoa com o Código {_pessoaAplicationService.Delete(codigo)} deletada com Sucesso");
            }
            catch (NegocioException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest("Erro inesperado");
            }
        }
    }
}
