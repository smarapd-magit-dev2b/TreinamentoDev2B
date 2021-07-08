using Dev2bDomain.Entities;
using Dev2bServices.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Dev2bWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] ClienteEntity cliente)
        {
            try
            {
                _clienteService.AdicionarCliente(cliente);

                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
