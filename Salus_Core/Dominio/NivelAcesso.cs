using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("NivelAcesso")]
    public class NivelAcesso
    {
        #region Atributos
        private int idNivelAcesso;
        private int codNivelAcesso;
        private string nivelAcesso;
        private bool exclusao;
        #endregion

        #region Construtor
        public NivelAcesso()
        {
            this.idNivelAcesso = 0;
            this.codNivelAcesso = 0;
            this.nivelAcesso = "";
            this.exclusao = false;
        }
        public NivelAcesso(int cod)
        {
            this.idNivelAcesso = 0;
            this.codNivelAcesso = cod;
            this.nivelAcesso = "";
            this.exclusao = false;
        }
        #endregion

        #region Propriedades
        [Column]
        [Key]
        public int IDNivelAcesso { get { return this.idNivelAcesso; } set { this.idNivelAcesso = value; } }
        [Column]
        public int CodNivelAcesso { get { return this.codNivelAcesso; } set { this.codNivelAcesso = value; } }
        [Column(name: "nivelAcesso")]
        public string NVAcesso { get { return this.nivelAcesso; } set { this.nivelAcesso = value; } }
        [Column(name: "bit")]
        public bool Exclusao { get { return this.exclusao; } set { this.exclusao = value; } }
        #endregion
    }
}
