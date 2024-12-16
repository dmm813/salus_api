using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.SC_DAO
{
    [Table("RecebimentoContasReceberParcela")]
    public class RecebimentoContasReceberParcela
    {
        #region atributos
        private int idRecebimentosContasReceberParcela;
        private int idRecebimentoContasReceber;
        private DateTime dataVencimento;
        private int nParcela;
        private double valorParcela;


        #endregion

        #region construtores
        public RecebimentoContasReceberParcela()
        {
            idRecebimentosContasReceberParcela = 0;
            idRecebimentoContasReceber = 0;
            dataVencimento = new DateTime();
            nParcela = 0;
            valorParcela = 0;
        }
        #endregion

        [Column]
        [Key]
        public int IdRecebimentosContasReceberParcela
        {
            get
            {
                return idRecebimentosContasReceberParcela;
            }

            set
            {
                idRecebimentosContasReceberParcela = value;
            }
        }
        [Column]
        [ForeignKey("RecebimentoContasReceber")]
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
        [Column(TypeName = "date")]
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
        [Column]
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
