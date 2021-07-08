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
                return Ok(_pessoaAplicationService.GetAllDtos());
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

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_pessoaAplicationService.GetDtoPorId(id));
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
                return Ok($"Pessoa com o Id {_pessoaAplicationService.PostDto(pessoaDto)} adicionada com Sucesso");
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

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, [FromBody] PessoaPostDto pessoaDto)
        {
            try
            {
                return Ok($"Pessoa com o Id {_pessoaAplicationService.PutDto(id, pessoaDto)} alterada com Sucesso");
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
