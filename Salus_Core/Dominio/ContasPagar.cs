using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("ContasPagar")]
    public class ContasPagar
    {
        #region atributos
        private int idContaPagar;
        private int idFinanceiro;
        private int idFornecedor;
        private double acrescimo;
        private double desconto;
        private double valor;
        private char status;


        #endregion

        #region contrutor
        public ContasPagar()
        {
            idContaPagar = 0;
            idFinanceiro = 0;
            idFornecedor = 0;
            acrescimo = 0;
            desconto = 0;
            valor = 0;
            status = 'A';
        }
        #endregion

        [Column]
        [Key]
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
        [ForeignKey("Financeiro")]
        public int IdFinanceiro
        {
            get
            {
                return idFinanceiro;
            }

            set
            {
                idFinanceiro = value;
            }
        }
        [Column]
        public int IdFornecedor
        {
            get
            {
                return idFornecedor;
            }

            set
            {
                idFornecedor = value;
            }
        }
        [Column(TypeName = "decimal(10,2)")]
        public double Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }
        [Column(TypeName = "char")]
        public char Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
        [Column(TypeName = "decimal(10,2)")]
        public double Acrescimo
        {
            get
            {
                return acrescimo;
            }

            set
            {
                acrescimo = value;
            }
        }
        [Column(TypeName = "decimal(10,2)")]
        public double Desconto
        {
            get
            {
                return desconto;
            }

            set
            {
                desconto = value;
            }
        }
    }
}
