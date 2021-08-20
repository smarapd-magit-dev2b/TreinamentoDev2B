using System.ComponentModel.DataAnnotations;

namespace Commom.Dto.User
{
    public class UserPostDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
