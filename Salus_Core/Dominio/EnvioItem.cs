using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("EnvioItem")]
    public class EnvioItem
    {
        #region atributos
        private int idEnvioItem;
        private int idEnvio;
        private int idMarca;
        private int idCor;
        private int idServico;
        private int qtde;


        #endregion

        #region construtor
        public EnvioItem()
        {
            idEnvioItem = 0;
            idEnvio = 0;
            idMarca = 0;
            idCor = 0;
            idServico = 0;
            qtde = 0;
        }
        #endregion

        [Column]
        [Key]
        public int IdEnvioItem
        {
            get
            {
                return idEnvioItem;
            }

            set
            {
                idEnvioItem = value;
            }
        }
        [Column]
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
        public int IdMarca
        {
            get
            {
                return idMarca;
            }

            set
            {
                idMarca = value;
            }
        }
        [Column]
        public int IdCor
        {
            get
            {
                return idCor;
            }

            set
            {
                idCor = value;
            }
        }
        [Column]
        public int IdServico
        {
            get
            {
                return idServico;

            }

            set
            {
                idServico = value;
            }
        }
        [Column]
        public int Qtde
        {
            get
            {
                return qtde;
            }

            set
            {
                qtde = value;
            }
        }
    }
}
