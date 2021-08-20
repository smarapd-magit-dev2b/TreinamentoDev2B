using Commom.Dto.Teacher;
using Commom.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Service.AplicationService.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interface.Api
{
    [ApiController]
    [Route("[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherAplicationService _teacherAplicationService;

        public TeacherController(ITeacherAplicationService teacherAplicationService) => _teacherAplicationService = teacherAplicationService;

        [HttpGet]
        [SwaggerResponse(200, "successfully get teachers", typeof(IEnumerable<TeacherGetDto>))]
        public IActionResult GetAll()
        {
            try
            {
                IEnumerable<TeacherGetDto> dtos = _teacherAplicationService.GetAll();

                return Ok(dtos);
            }
            catch (DomainException de)
            {
                return Conflict(de.Message);
            }
        }

        [HttpPost]
        [SwaggerResponse(200, "successfully registered teacher", typeof(int))]
        [SwaggerResponse(400, "bad request")]
        [SwaggerResponse(409, "domain exception", typeof(string))]
        public async Task<IActionResult> Post([FromBody] TeacherPostDto dto)
        {
            try
            {
                int id = await _teacherAplicationService.Post(dto);

                return Ok(id);
            }
            catch (DomainException de)
            {
                return Conflict(de.Message);
            }
        }

        [HttpPut("{id:int}")]
        [SwaggerResponse(200, "teacher updated successfully", typeof(int))]
        [SwaggerResponse(400, "bad request")]
        [SwaggerResponse(409, "domain exception", typeof(string))]
        public async Task<IActionResult> Put(int id, [FromBody] TeacherPutDto dto)
        {
            try
            {
                await _teacherAplicationService.Put(id, dto);

                return Ok(id);
            }
            catch (DomainException de)
            {
                return Conflict(de.Message);
            }
        }

        [HttpDelete("{id:int}")]
        [SwaggerResponse(200, "successfully get teachers", typeof(int))]
        [SwaggerResponse(409, "domain exception", typeof(string))]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _teacherAplicationService.Delete(id);

                return Ok(id);
            }
            catch (DomainException de)
            {
                return Conflict(de.Message);
            }
        }
    }
}
