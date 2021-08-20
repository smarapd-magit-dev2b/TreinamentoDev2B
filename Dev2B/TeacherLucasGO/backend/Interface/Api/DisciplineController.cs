using Microsoft.AspNetCore.Mvc;
using Service.AplicationService.Interfaces;

namespace Interface.Api
{
    [ApiController]
    [Route("[controller]")]
    public class DisciplineController : ControllerBase
    {
        private readonly IDisciplineAplicationService _disciplineAplicationService;

        public DisciplineController(IDisciplineAplicationService disciplineAplicationService) => _disciplineAplicationService = disciplineAplicationService;


    }
}
