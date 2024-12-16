using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("Municipio")]
    public class Municipio
    {
        #region Atributo
        private int idMunicipio;
        private int idUF;
        private int codMunicipio;
        private string municicpio;
        private string uf;
        #endregion

        #region Contrutor
        public Municipio()
        {
            this.idMunicipio = 0;
            this.idUF = 0;
            this.codMunicipio = 0;
            this.municicpio = "";
            this.uf = "";
        }
        public Municipio(string nome)
        {
            this.idMunicipio = 0;
            this.idUF = 0;
            this.codMunicipio = 0;
            this.municicpio = nome;
            this.uf = "";
        }

        #endregion

        #region propriedade
        [Column]
        [Key]
        public int IdMunicipio { get { return this.idMunicipio; } set { this.idMunicipio = value; } }
        [Column]
        public int IdUF { get { return this.idUF; } set { this.idUF = value; } }
        [Column]
        public int CodMunicipio { get { return this.codMunicipio; } set { this.codMunicipio = value; } }
        [Column(name: "municipio")]
        public string NomeMunicipio { get { return this.municicpio; } set { this.municicpio = value; } }
        [Column]
        public string UF { get { return this.uf; } set { this.uf = value; } }
        #endregion
    }
}
