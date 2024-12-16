using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("ordemServicoItem")]
    public class OrdemServicoItem
    {
        #region Atributos
        private int idOrdemServicoItem;
        private int idOrdemServico;
        private int idServico;
        private double qtdeServio;
        private double valor;
        #endregion

        #region Construtor
        public OrdemServicoItem()
        {
            this.idOrdemServico = 0;
            this.idServico = 0;
            this.idOrdemServico = 0;
            this.qtdeServio = 0;
            this.valor = 0;
        }
        #endregion

        #region Propriedades
        [Column]
        [Key]
        public int IDOrdemServicoItem { get { return this.idOrdemServicoItem; } set { this.idOrdemServicoItem = value; } }
        [Column]
        [ForeignKey("OrdemServico")]
        public int IDOrdemServico { get { return this.idOrdemServico; } set { this.idOrdemServico = value; } }
        [Column]
        public int IDServico { get { return this.idServico; } set { this.idServico = value; } }
        [Column(TypeName = "Decimal(10,2)")]
        public double QTDEServico { get { return this.qtdeServio; } set { this.qtdeServio = value; } }
        [Column(TypeName  = "Decimal(10,2)")]
        public double Valor { get { return this.valor; } set { this.valor = value; } }
        #endregion
    }
}
