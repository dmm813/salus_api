using System.ComponentModel.DataAnnotations;

namespace Salus_2._0.DTO
{
    public class LoginDTO
    {

        [Required(ErrorMessage = "O campo usuário é obrigatório"), EmailAddress(ErrorMessage = "Email inválido!")]
        public required string Email { get; set; }
        [Required(ErrorMessage = "O campo senha é obrigatório")]
        public required string Senha { get; set; }
    }
}
