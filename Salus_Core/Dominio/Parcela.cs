using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Salus_Core.Dominio
{
    [Table("Parcela")]
    public class Parcela
    {
        #region atributo
        private int idParcela;
        private int idVenda;
        private int numeroParcela;
        private DateTime dataVencimento;
        private double valorParcela;
        private string status;


        #endregion

        #region Construtor
        public Parcela()
        {
            this.idParcela = 0;
            this.idVenda = 0;
            this.numeroParcela = 0;
            this.dataVencimento = new DateTime();
            this.valorParcela = 0;
            this.status = "";
        }
        #endregion

        #region Propriedades
        [Column]
        [Key]
        public int IdParcela
        {
            get
            {
                return idParcela;
            }

            set
            {
                idParcela = value;
            }
        }
        [Column]
        [ForeignKey("Venda")]
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
        [Column]
        public int NumeroParcela
        {
            get
            {
                return numeroParcela;
            }

            set
            {
                numeroParcela = value;
            }
        }
        [Column(TypeName = "datetime")]
        public DateTime DataVencimento
        {
            get
            {
                return dataVencimento;
            }

            set
            {
                dataVencimento = value;
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
        [Column(TypeName = "char")]
        public string Status
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

        #endregion
    }
}
