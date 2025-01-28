using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("Marca")]
    public class Marca
    {
        #region Atributos
        private int idMarca;
        private int codMarca;
        private string nome;


        #endregion

        #region construtor
        public Marca()
        {
            idMarca = 0;
            codMarca = 0;
            nome = string.Empty;
        }
        public Marca(int cod)
        {
            idMarca = 0;
            codMarca = cod;
            nome = string.Empty;
        }

        public Marca(string s)
        {
            idMarca = 0;
            codMarca = 0;
            nome = s;
        }

        #endregion

        #region propriedades
        [Column]
        [Key]
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
        public int CodMarca
        {
            get
            {
                return codMarca;
            }

            set
            {
                codMarca = value;
            }
        }
        [Column]
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }
        #endregion
    }
}
