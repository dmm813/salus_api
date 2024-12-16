using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("ContaSintetica")]
    public class ContaSintetica
    {
        #region atributos
        private int idContaSintetica;
        private string numContaSintetica;
        private string descContaSintetica;


        #endregion

        #region contrutores
        public ContaSintetica()
        {
            idContaSintetica = 0;
            numContaSintetica = string.Empty;
            descContaSintetica = string.Empty;
        }
        public ContaSintetica(string nCt)
        {
            idContaSintetica = 0;
            numContaSintetica = nCt;
            descContaSintetica = string.Empty;
        }
        #endregion

        [Column]
        [Key]
        public int IdContaSintetica
        {
            get
            {
                return idContaSintetica;
            }

            set
            {
                idContaSintetica = value;
            }
        }
        [Column]
        public string NumContaSintetica
        {
            get
            {
                return numContaSintetica;
            }

            set
            {
                numContaSintetica = value;
            }
        }
        [Column]
        public string DescContaSintetica
        {
            get
            {
                return descContaSintetica;
            }

            set
            {
                descContaSintetica = value;
            }
        }
    }
}
