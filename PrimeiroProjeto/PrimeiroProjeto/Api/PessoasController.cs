using Commom.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Service.AplicationService.Interfaces;
using System;

namespace Interface.Api
{
    [ApiController]
    [Route("[controller]")]
    public class PessoasController : Controller
    {
        private readonly IPessoaAplicationService _pessoaAplicationService;

        public PessoasController(IPessoaAplicationService pessoaAplicationService) => _pessoaAplicationService = pessoaAplicationService;

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_pessoaAplicationService.GetAllDtos());
            }
            catch (NegocioException ne)
            {
                return BadRequest(ne.Message);
            }
            catch (Exception)
            {
                return BadRequest("Erro inesperado");
            }
        }
    }
}
