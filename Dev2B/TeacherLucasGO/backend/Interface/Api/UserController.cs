using Commom.Dto.User;
using Microsoft.AspNetCore.Mvc;
using Service.AplicationService.Interfaces;
using System.Collections.Generic;

namespace Interface.Api
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserAplicationService _userAplicationService;

        public UserController(IUserAplicationService userAplicationService) => _userAplicationService = userAplicationService;

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<UserDtoGet> users = _userAplicationService.GetAll();
            return Ok(users);
        }
    }
}
