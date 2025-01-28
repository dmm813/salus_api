using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("FormaPagamentoVenda")]
    public class FormaPagamentoVenda
    {
        #region Atributos
        private int idFormaPagamentoVenda;
        private int idFormaPagamento;
        private int idVenda;
        private int parcelas;
        private double valorFormaPagamento;


        #endregion

        #region Construtor
        public FormaPagamentoVenda()
        {
            this.idFormaPagamento = 0;
            this.idFormaPagamentoVenda = 0;
            this.idVenda = 0;
            this.parcelas = 0;
            this.valorFormaPagamento = 0;
        }
        #endregion

        #region Propriedades
        [Column("FormaPagamentoVenda")]
        public int IdFormaPagamentoVenda
        {
            get
            {
                return idFormaPagamentoVenda;
            }

            set
            {
                idFormaPagamentoVenda = value;
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
        public int IdVenda
        {
            get
            {
                return idVenda;
            }

            set
            {
                idVenda = value;
            }
        }
        [Column(TypeName = "decimal(10,2)")]
        public double ValorFormaPagamento
        {
            get
            {
                return valorFormaPagamento;
            }

            set
            {
                valorFormaPagamento = value;
            }
        }
        [Column]
        public int Parcelas
        {
            get
            {
                return parcelas;
            }

            set
            {
                parcelas = value;
            }
        }

        #endregion
    }
}
