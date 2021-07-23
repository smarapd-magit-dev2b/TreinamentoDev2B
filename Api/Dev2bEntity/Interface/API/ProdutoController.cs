using System;
using System.Net;
using Common.Dto;
using Common.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Service.ApplicationService.Interfaces;

namespace Interface.API
{
    [ApiController]
    [Route("/api/v1/produto")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoApplicationService ProdutoApplicationService;

        public ProdutoController(IProdutoApplicationService produtoApplicationService)
        {
            ProdutoApplicationService = produtoApplicationService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var products = ProdutoApplicationService.GetAll();
                return Ok(products);
            }
            catch (DomainException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var products = ProdutoApplicationService.GetById(id);
                return Ok(products);
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
        public IActionResult Post([FromBody] ProdutoPostDto produto)
        {
            try
            {
                var id = ProdutoApplicationService.Post(produto);
                return Ok(id);
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
        public IActionResult Put(int id, [FromBody] ProdutoPutDto cliente)
        {
            try
            {
                ProdutoApplicationService.Put(id, cliente);
                return Ok(id);
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
                ProdutoApplicationService.Delete(id);
                return Ok(id);
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
