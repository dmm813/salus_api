using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("BaixaServico")]
    public class BaixaServico
    {
        #region Atributos
        private int idBaixaServico;
        private int idBaixa;
        private int idServico;
        private double qtdeBaixa;
        #endregion

        #region Construtores
        public BaixaServico()
        {
            this.idBaixaServico = 0;
            this.idBaixa = 0;
            this.idServico = 0;
            this.qtdeBaixa = 0;
        }
        #endregion

        #region Propriedades
        [Column]
        [Key]
        public int IDBaixaServico { get { return this.idBaixaServico; } set { this.idBaixaServico = value; } }
        [Column]
        [ForeignKey("Baixa")]
        public int IDBaixa { get { return this.idBaixa; } set { this.idBaixa = value; } }
        [Column]
        [ForeignKey("Servico")]
        public int IDServico { get { return this.idServico; } set { this.idServico = value; } }
        [Column(TypeName = "decimal(10,2)")]
        public double QTDEBaixa { get { return this.qtdeBaixa; } set { this.qtdeBaixa = value; } }

        #endregion

    }
}
