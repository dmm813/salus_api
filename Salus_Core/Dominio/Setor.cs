using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("Setor")]
    public class Setor
    {
        #region Atributos
        private int idSetor;
        private int codSetor;
        private string descSetor;
        #endregion

        #region construtor
        public Setor()
        {
            this.idSetor = 0;
            this.codSetor = 0;
            this.descSetor = "";
        }
        public Setor(int cod)
        {
            this.idSetor = 0;
            this.codSetor = cod;
            this.descSetor = "";
        }
        public Setor(string desc)
        {
            this.idSetor = 0;
            this.codSetor = 0;
            this.descSetor = desc;
        }
        #endregion

        #region Propriedades
        [Column]
        [Key]
        public int IDSetor { get { return this.idSetor; } set { this.idSetor = value; } }
        [Column]
        public int CODSetor { get { return this.codSetor; } set { this.codSetor = value; } }
        [Column]
        public string DescSetor { get { return this.descSetor; } set { this.descSetor = value; } }
        #endregion
    }
}
