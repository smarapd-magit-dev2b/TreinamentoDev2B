using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Common.Dto;
using Common.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Service.ApplicationService.Interfaces;

namespace Interface.API
{
    [ApiController]
    [Route("/api/v1/venda")]
    public class VendaController : ControllerBase
    {
        private readonly IVendaApplicationService VendaApplicationService;

        public VendaController(IVendaApplicationService vendaApplicationService)
        {
            VendaApplicationService = vendaApplicationService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var sales = VendaApplicationService.GetAll();
                return Ok(sales);
            }
            catch (DomainException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] VendaPostDto venda)
        {
            try
            {
                var id = VendaApplicationService.Post(venda);
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
