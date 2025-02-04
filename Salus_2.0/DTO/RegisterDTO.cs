using Salus_2._0.Enums;
using System.ComponentModel.DataAnnotations;

namespace Salus_2._0.DTO
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "O campo usuário é obrigatório")]
        public required string Usuario {  get; set; }
        [Required(ErrorMessage = "O campo email é obrigatório"), EmailAddress(ErrorMessage = "Email inválido!")]
        public required string Email { get; set; }
        [Required(ErrorMessage = "O campo senha é obrigatório")]
        public required string Senha { get; set; }
        [Compare("Senha", ErrorMessage = "Senhas não coincidem!")]
        public required string ConfirmaSenha { get; set; }
        [Required(ErrorMessage = "O campo cargo é obrigatório")]
        public NivelAcessoEnum Cargo { get; set; }
    }
}
