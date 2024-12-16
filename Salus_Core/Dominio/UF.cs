using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("UF")]
    public class UF
    {
        #region Atributos
        private int idUF;
        private int codUF;
        private string estado;
        private string siglaUF;
        private int idPais;
        #endregion

        #region Construtor
        public UF()
        {
            this.idUF = 0;
            this.codUF = 0;
            this.estado = "";
            this.siglaUF = "";
            this.idPais = 0;

        }
        #endregion

        #region Propriedades
        [Column]
        [Key]
        public int IdUF { get { return this.idUF; } set { this.idUF = value; } }
        [Column]
        public int CodUF { get { return this.codUF; } set { this.codUF = value; } }
        [Column]
        public string Estado { get { return this.estado; } set { this.estado = value; } }
        [Column(TypeName = "uf")]
        public string SiglaUF { get { return this.siglaUF; } set { this.siglaUF = value; } }
        [Column]
        public int IdPais { get { return this.idPais; } private set { this.idPais = value; } }
        #endregion
    }
}
