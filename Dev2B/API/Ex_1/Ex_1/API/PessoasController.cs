using Commom.Dto;
using Common;
using Common.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_1.API
{
    [ApiController]
    [Route("[controller]")]
    public class PessoasController : Controller
    {

       private readonly IPessoaAplicationService _pessoaAplicationService;

        public PessoasController(IPessoaAplicationService pessoaAplicationService)
        {
            _pessoaAplicationService = pessoaAplicationService;
        }

        //Listar todas as pessoas cadastradas

        [HttpGet]

        public IActionResult Get()
        {
            try
            {
                return Ok(_pessoaAplicationService.Get());
            }
            catch (DomainException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest("Erro inesperado");
            }
        }
        //Buscar dados de uma pessoa pelo Id-----

        [HttpGet("{cod:int}")]

        public IActionResult Get(int cod)
        {
           

            try
            {
                return Ok(_pessoaAplicationService.GetPorCod(cod));
            }
            catch (DomainException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest("Erro inesperado");
            }
        }

       //Cadastrar uma pessoa--------------------
        [HttpPost()]
        public IActionResult Post([FromBody] PessoaPostDto pessoa)
        {
            try
            {
                return Ok(_pessoaAplicationService.Post(pessoa));
            }
            catch (DomainException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest("Erro inesperado");
            }
        }
        //Editar uma pessoa pelo Id passado------
        
        [HttpPut("{codigo:int}")]
        public IActionResult Put(int codigo, [FromBody] PessoaPostDto pessoa)
        {
            try
            {
                return Ok(_pessoaAplicationService.Put(codigo, pessoa));
            }
            catch (DomainException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest("Erro inesperado");
            }
        }
        
        //Atualizar apenas apenas as informações de Nome, Sobrenome e cpf
        
        [HttpPut("{codigo:int}/essencial")]
        public IActionResult PutEssentialPerson(int codigo, [FromBody] PessoaPutEssencialDto pessoa)
        {
            try
            {
                return Ok(_pessoaAplicationService.PutEssentialPerson(codigo, pessoa));
            }
            catch (DomainException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest("Erro inesperado");
            }
        }
        
        // Serviço para Ativar o usuario
        
        [HttpPut("{codigo:int}/ativar")]
        public IActionResult PutAtivar(int codigo)
        {
            try
            {
                return Ok(_pessoaAplicationService.PutStatus(codigo, true));
            }
            catch (DomainException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest("Erro inesperado");
            }
        }
        
        //Serviço para Ativar o usuario
        
        [HttpPut("{codigo:int}/desativar")]
        public IActionResult PutDesativar(int codigo)
        {
            try
            {
                return Ok(_pessoaAplicationService.PutStatus(codigo, false));
            }
            catch (DomainException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest("Erro inesperado");
            }
        }


        //Deletar uma pessoa pelo Id passado-----

        [HttpDelete("{id:int}")]

        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(_pessoaAplicationService.Delete(id));
            }
            catch (DomainException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest("Erro inesperado");
            }

            
            
            
            
    }   }
}
