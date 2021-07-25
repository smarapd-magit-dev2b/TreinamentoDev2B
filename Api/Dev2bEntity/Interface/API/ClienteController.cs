using System;
using System.Net;
using Common.Dto;
using Common.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Service.ApplicationService.Interfaces;

namespace Interface.API
{
    [ApiController]
    [Route("/api/v1/cliente")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteApplicationService ClienteApplicationService;

        public ClienteController(IClienteApplicationService clienteApplicationService)
        {
            ClienteApplicationService = clienteApplicationService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var clients = ClienteApplicationService.GetAll();
                return Ok(clients);
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
                var client = ClienteApplicationService.GetById(id);
                return Ok(client);
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
        public IActionResult Post([FromBody] ClientePostDto cliente)
        {
            try
            {
                var id = ClienteApplicationService.Post(cliente);
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
        public IActionResult Put(int id, [FromBody] ClientePutDto cliente)
        {
            try
            {
                ClienteApplicationService.Put(id, cliente);
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
                ClienteApplicationService.Delete(id);
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
