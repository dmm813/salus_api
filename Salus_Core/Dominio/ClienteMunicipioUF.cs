namespace Salus_Core.Dominio
{
    public class ClienteMunicipioUF : Cliente
    {
        #region atributo
        private int codMunicipio;
        private int idUF;
        private string municipio;
        private int codUF;
        private string siglaUF;
        #endregion

        #region Construtor
        public ClienteMunicipioUF()
            : base()
        {
            this.codMunicipio = 0;
            this.municipio = "";
            this.idUF = 0;
            this.codUF = 0;
            this.siglaUF = "";
        }
        #endregion

        #region Propriedades
        public int CODMunicipio { get { return this.codMunicipio; } set { this.codMunicipio = value; } }
        public string Municipio { get { return this.municipio; } set { this.municipio = value; } }
        public int CODUF { get { return this.codUF; } set { this.codUF = value; } }
        public int IdUF { get { return this.idUF; } set { this.idUF = value; } }
        public string SiglaUF { get { return this.siglaUF; } set { this.siglaUF = value; } }
        #endregion
    }
}
