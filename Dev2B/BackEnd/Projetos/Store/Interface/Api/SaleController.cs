using Commom.Dto.Sale;
using Commom.Dto.SaleItem;
using Commom.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Service.AplicationService.Interfaces;
using System;
using System.Collections.Generic;

namespace Interface.Api
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class SaleController : ControllerBase
    {
        private const string _error = "Unexpected error";
        private readonly ISaleAplicationService _saleAplicationService;

        public SaleController(ISaleAplicationService saleAplicationService) => _saleAplicationService = saleAplicationService;

        #region Get
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                IEnumerable<SaleGetDto> dtos = _saleAplicationService.Get();

                return Ok(dtos);
            }
            catch (DomainException de)
            {
                return Conflict(de.Message);
            }
            catch (Exception)
            {
                return BadRequest(_error);
            }
        }
        #endregion

        #region Post
        [HttpPost("{customerId:int}")]
        public IActionResult Post(int customerId, IEnumerable<SaleItemPostDto> dtos)
        {
            try
            {
                int id = _saleAplicationService.Post(customerId, dtos);

                return Ok(id);
            }
            catch (DomainException de)
            {
                return Conflict(de.Message);
            }
            catch (Exception)
            {
                return BadRequest(_error);
            }
        }
        #endregion
    }
}
