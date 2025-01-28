using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("MovimentoCredicoCliente")]
    public class MovimentoCreditoCliente
    {
        #region atributos
        private int idMovimentoCreditoCliente;
        private int idCliente;
        private double creditoOld;
        private double valor;
        private char tipoMovimento;
        private string obs;
        private DateTime data;



        #endregion

        #region construtor
        public MovimentoCreditoCliente()
        {
            this.idMovimentoCreditoCliente = 0;
            this.idCliente = 0;
            this.creditoOld = 0;
            this.valor = 0;
            this.tipoMovimento = 'E';
            this.obs = "";
        }
        #endregion

        #region propriedades
        [Column]
        [Key]
        public int IdMovimentoCreditoCliente
        {
            get
            {
                return this.idMovimentoCreditoCliente;
            }

            set
            {
                this.idMovimentoCreditoCliente = value;
            }
        }
        [Column]
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
        [Column(name:"tipo" ,TypeName = "char")]
        public char TipoMovimento
        {
            get
            {
                return tipoMovimento;
            }

            set
            {
                tipoMovimento = value;
            }
        }
        [Column]
        public string Obs
        {
            get
            {
                return obs;
            }

            set
            {
                obs = value;
            }
        }
        [Column(TypeName = "decimal(10,2)")]
        public double CreditoOld
        {
            get
            {
                return creditoOld;
            }

            set
            {
                creditoOld = value;
            }
        }
        [Column(TypeName = "date")]
        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }



        #endregion

    }
}
