using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("Cor")]
    public class Cor
    {
        #region atributos
        private int idCor;
        private int codCor;
        private string descricaoCor;


        #endregion

        #region construtor
        public Cor()
        {
            idCor = 0;
            codCor = 0;
            descricaoCor = string.Empty;
        }
        public Cor(int cod)
        {
            idCor = 0;
            codCor = cod;
            descricaoCor = string.Empty;
        }
        public Cor(string s)
        {
            idCor = 0;
            codCor = 0;
            descricaoCor = s;
        }
        #endregion

        [Column]
        [Key]
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
        public int CodCor
        {
            get
            {
                return codCor;
            }

            set
            {
                codCor = value;
            }
        }
        [Column(name:"nomeCor")]
        public string DescricaoCor
        {
            get
            {
                return descricaoCor;
            }

            set
            {
                descricaoCor = value;
            }
        }
    }
}
