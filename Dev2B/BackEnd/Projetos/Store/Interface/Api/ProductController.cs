using Commom.Dto.Product;
using Commom.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Service.AplicationService.Interfaces;
using System;
using System.Collections.Generic;

namespace Interface.Api
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class ProductController : ControllerBase
    {
        private const string _error = "Unexpected error";
        private readonly IProductAplicationService _productAplicationService;

        public ProductController(IProductAplicationService productAplicationService) => _productAplicationService = productAplicationService;

        #region Get
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                IEnumerable<ProductGetDto> dtos = _productAplicationService.Get();

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
                ProductGetDto dto = _productAplicationService.Get(id);

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
        public IActionResult Post([FromBody] ProductPostDto dto)
        {
            try
            {
                int id = _productAplicationService.Post(dto);

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
        public IActionResult Put(int id, [FromBody] ProductPostDto dto)
        {
            try
            {
                _productAplicationService.Put(id, dto);

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
                _productAplicationService.Delete(id);

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
