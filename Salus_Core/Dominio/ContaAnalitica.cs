using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("ContaAnalitica")]
    public class ContaAnalitica
    {
        #region atributos
        private int idContaAnalitica;
        private int idContaSintetica;
        private string numContaAnalitica;
        private string descContaAnalitica;


        #endregion

        #region construtores
        public ContaAnalitica()
        {
            idContaAnalitica = 0;
            idContaSintetica = 0;
            numContaAnalitica = string.Empty;
            descContaAnalitica = string.Empty;
        }
        public ContaAnalitica(string nct)
        {
            idContaAnalitica = 0;
            idContaSintetica = 0;
            numContaAnalitica = nct;
            descContaAnalitica = string.Empty;
        }
        #endregion
        [Column]
        [Key]
        public int IdContaAnalitica
        {
            get
            {
                return idContaAnalitica;
            }

            set
            {
                idContaAnalitica = value;
            }
        }
        [Column]
        [ForeignKey("ContaAnlitica")]
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
        public string NumContaAnalitica
        {
            get
            {
                return numContaAnalitica;
            }

            set
            {
                numContaAnalitica = value;
            }
        }
        [Column]
        public string DescContaAnalitica
        {
            get
            {
                return descContaAnalitica;
            }

            set
            {
                descContaAnalitica = value;
            }
        }
    }
}
