using Commom.Dto.Costummer;
using Commom.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Service.AplicationService.Interfaces;
using System;
using System.Collections.Generic;

namespace Interface.Api
{
    [ApiController]
    [Route("[controller]")]
    public class CostummerController : ControllerBase
    {
        private const string _error = "Unexpected error";
        private readonly ICostummerAplicationService _costummerAplicationService;

        public CostummerController(ICostummerAplicationService costummerAplicationService) => _costummerAplicationService = costummerAplicationService;

        #region Get
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<CostummerGetDto> dtos = _costummerAplicationService.Get();

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
                CostummerGetDto dto = _costummerAplicationService.Get(id);

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
        public IActionResult Post([FromBody] CostummerPostDto dto)
        {
            try
            {
                int id = _costummerAplicationService.Post(dto);

                return Ok(id);
            }
            catch (DomainException de)
            {
                return Conflict(de.Message);
            }
            catch (Exception e)
            {
                return BadRequest(_error);
            }
        }
        #endregion

        #region Put
        [HttpPut("{id:int}")]
        public IActionResult Put(int id, [FromBody] CostummerPostDto dto)
        {
            try
            {
                _costummerAplicationService.Put(id, dto);

                return Ok(id);
            }
            catch (DomainException de)
            {
                return Conflict(de.Message);
            }
            catch (Exception e)
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
                _costummerAplicationService.Delete(id);

                return Ok(id);
            }
            catch (DomainException de)
            {
                return Conflict(de.Message);
            }
            catch (Exception e)
            {
                return BadRequest(_error);
            }
        }
        #endregion
    }
}
