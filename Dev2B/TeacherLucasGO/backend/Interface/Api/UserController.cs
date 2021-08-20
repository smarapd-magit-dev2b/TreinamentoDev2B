using Commom.Dto.User;
using Commom.Exceptions.User;
using Microsoft.AspNetCore.Mvc;
using Service.AplicationService.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace Interface.Api
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserAplicationService _userAplicationService;

        public UserController(IUserAplicationService userAplicationService) => _userAplicationService = userAplicationService;

        [HttpPost]
        [SwaggerResponse(200, "Authorized User", typeof(bool))]
        [SwaggerResponse(401, "Unauthorized User", typeof(string))]
        [SwaggerResponse(403, "Unauthorized User", typeof(string))]
        public async Task<IActionResult> Post([FromBody] UserPostDto dto)
        {
            try
            {
                bool exist = await _userAplicationService.Post(dto);

                return Ok(exist);
            }
            catch (UserUnauthorizedException uu)
            {
                return Unauthorized(uu.Message);
            }
            catch (UserForbiddenException uf)
            {
                return Forbid(uf.Message);
            }
        }
    }
}
