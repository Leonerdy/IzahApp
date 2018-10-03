using System.ComponentModel.DataAnnotations;

namespace IzahApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Você deve especificar passwords entre 4 e 8 caracteres")]
        public string Password { get; set; }
    }
}