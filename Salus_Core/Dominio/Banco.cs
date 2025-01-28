using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("Banco")]
    public class Banco
    {
        #region Atributos
        private int idbanco;
        private int codbanco;
        private string banco;
        #endregion

        #region Construtor
        public Banco()
        {
            this.idbanco = 0;
            this.codbanco = 0;
            this.banco = "";
        }
        public Banco(string n)
        {
            this.idbanco = 0;
            this.codbanco = 0;
            this.banco = n;
        }
        public Banco(int cod)
        {
            this.idbanco = cod;
            this.codbanco = 0;
            this.banco = "";
        }
        #endregion

        #region Propriedades
        [Column]
        [Key]
        public int IDBanco { get { return this.idbanco; } set { this.idbanco = value; } }
        [Column]
        public int CodBanco { get { return this.codbanco; } set { this.codbanco = value; } }
        [Column("banco")]
        public string NomeBanco { get { return this.banco; } set { this.banco = value; } }
        #endregion
    }
}
