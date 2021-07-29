using Commom.Dto.Customer;
using Commom.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Service.AplicationService.Interfaces;
using System;
using System.Collections.Generic;

namespace Interface.Api
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class CustomerController : ControllerBase
    {
        private const string _error = "Unexpected error";
        private readonly ICustomerAplicationService _customerAplicationService;

        public CustomerController(ICustomerAplicationService customerAplicationService) => _customerAplicationService = customerAplicationService;

        #region Get
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                IEnumerable<CustomerGetDto> dtos = _customerAplicationService.Get();

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

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            try
            {
                CustomerGetDto dto = _customerAplicationService.Get(id);

                return Ok(dto);
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
        [HttpPost]
        public IActionResult Post([FromBody] CustomerPostDto dto)
        {
            try
            {
                int id = _customerAplicationService.Post(dto);

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

        #region Put
        [HttpPut("{id:int}")]
        public IActionResult Put(int id, [FromBody] CustomerPostDto dto)
        {
            try
            {
                _customerAplicationService.Put(id, dto);

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

        #region Delete
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _customerAplicationService.Delete(id);

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
