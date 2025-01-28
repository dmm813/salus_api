using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("ContasReceber")]
    public class ContasReceber
    {
        #region atributos
        private int idContasReceber;
        private int idCliente;
        private int idFinanceiro;
        private double acrescimo;
        private double desconto;
        private double valor;
        private char status;


        #endregion

        #region construtores
        public ContasReceber()
        {
            idContasReceber = 0;
            idCliente = 0;
            idFinanceiro = 0;
            acrescimo = 0;
            desconto = 0;
            valor = 0;
            status = 'A';
        }
        #endregion

        [Column]
        [Key]
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
        [ForeignKey("Cliente")]
        public int IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
            }
        }
        [Column]
        [ForeignKey("Fnanceiro")]
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
