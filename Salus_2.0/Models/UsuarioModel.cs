using Salus_2._0.Enums;
using System.ComponentModel.DataAnnotations;

namespace Salus_2._0.Models
{
    public class UsuarioModel
    {
        [Key]
        public int IdUsuario { get; set; }
        public int CodUsuario { get; set; }
        public NivelAcessoEnum IdNivelAcesso { get; set; }
        public required string Login { get; set; }
        public required string Senha { get; set; }
        public bool AcInserir { get; set; }
        public bool AcExcluir { get; set; }
        public bool AcEditar { get; set; }
        public bool Exclusao { get; set; }
    }
}
