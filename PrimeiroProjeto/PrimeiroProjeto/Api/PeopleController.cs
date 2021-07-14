using Commom.Dto;
using Commom.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Service.AplicationService.Interfaces;
using System;
using System.Collections.Generic;

namespace Interface.Api
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : Controller
    {
        private const string Error = "Unexpected error";
        private readonly IPersonAplicationService _personAplicationService;

        public PeopleController(IPersonAplicationService personAplicationService) => _personAplicationService = personAplicationService;

        #region Get
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<PersonGetDto> people = _personAplicationService.Get();

                return Ok(people);
            }
            catch (DomainException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest(Error);
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            try
            {
                PersonGetDto personDto = _personAplicationService.Get(id);

                return Ok(personDto);
            }
            catch (DomainException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest(Error);
            }
        }
        #endregion

        #region Post
        [HttpPost()]
        public IActionResult Post([FromBody] PersonPostDto personDto)
        {
            try
            {
                int id = _personAplicationService.Post(personDto);

                return Ok(id);
            }
            catch (DomainException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest(Error);
            }
        }

        [HttpPost("{id:int}/sons")]
        public IActionResult Post(int id, [FromBody] List<PersonPostDto> personDto)
        {
            try
            {
                List<int> ids = _personAplicationService.Post(id, personDto);

                return Ok(ids);
            }
            catch (DomainException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest(Error);
            }
        }

        [HttpPost("{id:int}/son")]
        public IActionResult Post(int id, [FromBody] PersonPostDto personDto)
        {
            try
            {
                id = _personAplicationService.Post(id, personDto);

                return Ok(id);
            }
            catch (DomainException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest(Error);
            }
        }
        #endregion

        #region Put
        [HttpPut("{id:int}")]
        public IActionResult Put(int id, [FromBody] PersonPostDto personDto)
        {
            try
            {
                id = _personAplicationService.Put(id, personDto);

                return Ok(id);
            }
            catch (DomainException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest(Error);
            }
        }
        #endregion

        #region Patch
        [HttpPatch("{id:int}/essential")]
        public IActionResult PatchEssential(int id, [FromBody] PersonPatchDtoEssential personDto)
        {
            try
            {
                id = _personAplicationService.PatchEssential(id, personDto);

                return Ok(id);
            }
            catch (DomainException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest(Error);
            }
        }

        [HttpPatch("{id:int}/activate")]
        public IActionResult PatchActivate(int id)
        {
            try
            {
                id = _personAplicationService.PatchStatus(id, true);

                return Ok(id);
            }
            catch (DomainException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest(Error);
            }
        }

        [HttpPatch("{id:int}/disable")]
        public IActionResult PatchDisable(int id)
        {
            try
            {
                id = _personAplicationService.PatchStatus(id, false);

                return Ok(id);
            }
            catch (DomainException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest(Error);
            }
        }
        #endregion

        #region Delete
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                id = _personAplicationService.Delete(id);

                return Ok(id);
            }
            catch (DomainException ne)
            {
                return Conflict(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest(Error);
            }
        }
        #endregion

    }
}
