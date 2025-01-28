using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.SC_DAO
{
    [Table("PagamentoContasPagarParcela")]
    public class PagamentoContasPagarParcela
    {
        #region atributos
        private int idPagamentoContasPagarParcela;
        private int idPagamentoContasPagar;
        private DateTime dataVendimento;
        private int nParcela;
        private double valorParcela;


        #endregion

        #region construtores
        public PagamentoContasPagarParcela()
        {
            idPagamentoContasPagarParcela = 0;
            idPagamentoContasPagar = 0;
            dataVendimento = new DateTime();
            nParcela = 0;
            valorParcela = 0;
        }
        #endregion

        [Column]
        [Key]
        public int IdPagamentoContasPagarParcela
        {
            get
            {
                return idPagamentoContasPagarParcela;
            }

            set
            {
                idPagamentoContasPagarParcela = value;
            }
        }
        [Column]
        [ForeignKey("PagamentoContasPagar")]
        public int IdPagamentoContasPagar
        {
            get
            {
                return idPagamentoContasPagar;
            }

            set
            {
                idPagamentoContasPagar = value;
            }
        }
        [Column(TypeName = "date")]
        public DateTime DataVendimento
        {
            get
            {
                return dataVendimento;
            }

            set
            {
                dataVendimento = value;
            }
        }
        [Column]
        public int NParcela
        {
            get
            {
                return nParcela;
            }

            set
            {
                nParcela = value;
            }
        }
        [Column(TypeName = "decimal(10,2)")]
        public double ValorParcela
        {
            get
            {
                return valorParcela;
            }

            set
            {
                valorParcela = value;
            }
        }
    }
}
