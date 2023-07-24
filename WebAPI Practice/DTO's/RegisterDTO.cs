using System.ComponentModel.DataAnnotations;

namespace WebAPIDApp.DTO_s
{
    public class RegisterDTO
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
