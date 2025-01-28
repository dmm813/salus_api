using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.SC_DAO
{
    public class PagamentoContasPaga
    {
        #region atributos
        private int idPagamentoContasPagar;
        private int idContaPagar;
        private int idFormaPagamento;
        private int condPagamento;
        private double valorPagamento;
        private DateTime dataPagamento;


        #endregion

        #region construtores
        public PagamentoContasPaga()
        {
            idPagamentoContasPagar = 0;
            idContaPagar = 0;
            idFormaPagamento = 0;
            condPagamento = 0;
            valorPagamento = 0;
            dataPagamento = new DateTime();
        }
        #endregion

        [Column]
        [Key]
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
        [Column]
        public int IdContaPagar
        {
            get
            {
                return idContaPagar;
            }

            set
            {
                idContaPagar = value;
            }
        }
        [Column]
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
        public double ValorPagamento
        {
            get
            {
                return valorPagamento;
            }

            set
            {
                valorPagamento = value;
            }
        }
        [Column(TypeName = "date")]
        public DateTime DataPagamento
        {
            get
            {
                return dataPagamento;
            }

            set
            {
                dataPagamento = value;
            }
        }
    }
}
