using Common.Dto;
using Common.NewFolder;
using Microsoft.AspNetCore.Mvc;
using Service.ApplicationService.Interfaces;

namespace Interface.Api
{
    [ApiController]
    [Route("[controller]")]
    public class PessoasController : ControllerBase
    {
        private readonly IPessoaApplicationService PessoaApplicationService;

        public PessoasController(IPessoaApplicationService pessoaApplicationService)
        {
            PessoaApplicationService = pessoaApplicationService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] PessoaPostDto pessoa)
        {
            try
            {
                var id = PessoaApplicationService.Post(pessoa);

                return Ok(id);
            }
            catch (DomainException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var pessoas = PessoaApplicationService.GetAll();

                return Ok(pessoas);
            }
            catch (DomainException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
