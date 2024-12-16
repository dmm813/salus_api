using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("PlanoMovimentacao")]
    public class PlanoMovimentacao
    {
        #region atributos
        private int idPlanoMovimentacao;
        private int idClientePlano;
        private DateTime dataMovimentacao;
        private double valor;


        #endregion
        #region costrutor
        public PlanoMovimentacao()
        {
            idPlanoMovimentacao = 0;
            idClientePlano = 0;
            dataMovimentacao = new DateTime();
            valor = 0;
        }
        #endregion

        [Column]
        [ForeignKey("ClientePlano")]
        public int IdClientePlano
        {
            get
            {
                return idClientePlano;
            }

            set
            {
                idClientePlano = value;
            }
        }
        [Column(TypeName = "date")]
        public DateTime DataMovimentacao
        {
            get
            {
                return dataMovimentacao;
            }

            set
            {
                dataMovimentacao = value;
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
        [Column]
        [Key]
        public int IDPlanoMovimentacao
        {
            get
            {
                return idPlanoMovimentacao;
            }

            set
            {
                idPlanoMovimentacao = value;
            }
        }
    }
}
