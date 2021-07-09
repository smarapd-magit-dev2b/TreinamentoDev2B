using Commom.Dto;
using Commom.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Service.AplicationService.Interfaces;
using System;

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
                return BadRequest(ne.Message);
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
                return BadRequest(ne.Message);
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
                return BadRequest(ne.Message);
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
                return BadRequest(ne.Message);
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
                return Ok($"Pessoa com o Código {_pessoaAplicationService.PutUsuario(codigo, true)} foi ativada com Sucesso");
            }
            catch (NegocioException ne)
            {
                return BadRequest(ne.Message);
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
                return Ok($"Pessoa com o Código {_pessoaAplicationService.PutUsuario(codigo, false)} foi desativada com Sucesso");
            }
            catch (NegocioException ne)
            {
                return BadRequest(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest("Erro inesperado");
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok($"Pessoa com o Código {_pessoaAplicationService.DeletePorCodigo(id)} deletada com Sucesso");
            }
            catch (NegocioException ne)
            {
                return BadRequest(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest("Erro inesperado");
            }
        }
    }
}
