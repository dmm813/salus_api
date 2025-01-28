using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("EvioOS")]
    public class EnvioOS
    {
        #region atributos
        private int idEnvio;
        private int numeroEnvio;
        private int idOS;
        private int idSetorOrigem;
        private int idSetorDestino;
        private DateTime dataEnvio;
        private int qtdePeca;


        #endregion


        #region Contrutor
        public EnvioOS()
        {
            idEnvio = 0;
            numeroEnvio = 0;
            idOS = 0;
            idSetorOrigem = 0;
            idSetorOrigem = 0;
            dataEnvio = new DateTime();
            qtdePeca = 0;


        }
        public EnvioOS(int n)
        {
            idEnvio = 0;
            numeroEnvio = n;
            idOS = 0;
            idSetorOrigem = 0;
            idSetorOrigem = 0;
            dataEnvio = new DateTime();
            qtdePeca = 0;
        }
        #endregion

        [Column]
        [Key]
        public int IdEnvio
        {
            get
            {
                return idEnvio;
            }

            set
            {
                idEnvio = value;
            }
        }
        [Column]
        public int NumeroEnvio
        {
            get
            {
                return numeroEnvio;
            }

            set
            {
                numeroEnvio = value;
            }
        }
        [Column]
        [ForeignKey("OrdemServico")]
        public int IdOS
        {
            get
            {
                return idOS;
            }

            set
            {
                idOS = value;
            }
        }
        [Column]
        [ForeignKey("SetorOrigem")]
        public int IdSetorOrigem
        {
            get
            {
                return idSetorOrigem;
            }

            set
            {
                idSetorOrigem = value;
            }
        }
        [Column]
        [ForeignKey("SetorDestino")]
        public int IdSetorDestino
        {
            get
            {
                return idSetorDestino;
            }

            set
            {
                idSetorDestino = value;
            }
        }
        [Column(TypeName = "date")]
        public DateTime DataEnvio
        {
            get
            {
                return dataEnvio;
            }

            set
            {
                dataEnvio = value;
            }
        }
        [Column]
        public int QtdePeca
        {
            get
            {
                return qtdePeca;
            }

            set
            {
                qtdePeca = value;
            }
        }
    }
}
