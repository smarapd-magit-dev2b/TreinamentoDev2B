﻿using Dev2bDomain.Entities;
using Dev2bServices.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Dev2bWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoasController : ControllerBase
    {
        private readonly IPessoaService _pessoaService;

        public PessoasController(IPessoaService PessoaService) => _pessoaService = PessoaService;

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var clientes = _pessoaService.ObterTodosOsClientes();

                return Ok(clientes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            try
            {
                var cliente = _pessoaService.ObterClientePorId(id);

                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] PessoaEntity cliente)
        {
            try
            {
                _pessoaService.AdicionarCliente(cliente);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, [FromBody] PessoaEntity pessoa)
        {
            try
            {
                _pessoaService.AlterarPessoa(id, pessoa);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _pessoaService.DeletarPessoa(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
