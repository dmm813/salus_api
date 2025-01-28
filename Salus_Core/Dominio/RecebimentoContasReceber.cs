using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.SC_DAO
{
    [Table("RecebimentoContasReceber")]
    public class RecebimentoContasReceber
    {
        #region atributo
        private int idRecebimentoContasReceber;
        private int idContasReceber;
        private int idFormaPagamento;
        private int condPagamento;
        private double valorRecebimento;
        private DateTime dataRecebimento;


        #endregion

        #region construtore
        public RecebimentoContasReceber()
        {
            idRecebimentoContasReceber = 0;
            idContasReceber = 0;
            idFormaPagamento = 0;
            condPagamento = 0;
            valorRecebimento = 0;
            dataRecebimento = new DateTime();
        }
        #endregion

        [Column]
        [Key]
        public int IdRecebimentoContasReceber
        {
            get
            {
                return idRecebimentoContasReceber;
            }

            set
            {
                idRecebimentoContasReceber = value;
            }
        }
        [Column]
        [ForeignKey("ContasReceber")]
        public int IdContasReceber
        {
            get
            {
                return idContasReceber;
            }

            set
            {
                idContasReceber = value;
            }
        }
        [Column]
        [ForeignKey("FormaPagamento")]
        public int IdFormaPagamento
        {
            get
            {
                return idFormaPagamento;
            }

            set
            {
                idFormaPagamento = value;
            }
        }
        [Column]
        public int CondPagamento
        {
            get
            {
                return condPagamento;
            }

            set
            {
                condPagamento = value;
            }
        }
        [Column(TypeName = "decimal(10,2)")]
        public double ValorRecebimento
        {
            get
            {
                return valorRecebimento;
            }

            set
            {
                valorRecebimento = value;
            }
        }
        [Column(TypeName = "date")]
        public DateTime DataRecebimento
        {
            get
            {
                return dataRecebimento;
            }

            set
            {
                dataRecebimento = value;
            }
        }
    }
}
