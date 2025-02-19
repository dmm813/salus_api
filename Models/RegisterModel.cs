using Salus_2._0.Enums;

namespace Salus_2._0.Models
{
    public class RegisterModel
    {
        public int Id { get; set; }
        public required string Email { get; set; }
        public required string Usuario { get; set; }
        public NivelAcessoEnum Cargo { get; set; }
        public required byte[] SenhaHash { get; set; }
        public required byte[] SenhaSalt { get; set; }
        public DateTime TokenDataCriacao { get; set; } = DateTime.Now;
    }
}
