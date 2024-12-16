using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Salus_Core.Dominio
{
    [Table("MovimentacaoCaixa")]
    public class MovimentacaoCaixa
    {
        #region Atributos
        private int idMovimentacaoCaixa;
        private int idCaixa;
        private double valor;
        private DateTime data;
        private string obs;
        private int tipo;
        private string status;


        #endregion

        #region construtores
        public MovimentacaoCaixa()
        {
            idMovimentacaoCaixa = 0;
            idCaixa = 0;
            valor = 0;
            data = new DateTime();
            obs = "";
            tipo = 0;
            status = "E";

        }
        #endregion

        [Column]
        [Key]
        public int IdMovimentacaoCaixa
        {
            get
            {
                return idMovimentacaoCaixa;
            }

            set
            {
                idMovimentacaoCaixa = value;
            }
        }
        [Column]
        public int IdCaixa
        {
            get
            {
                return idCaixa;
            }

            set
            {
                idCaixa = value;
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

        [Column(TypeName = "datetime")]
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
        [Column]
        public int Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }
        [Column]
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
    }
}
