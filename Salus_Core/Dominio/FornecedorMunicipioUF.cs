namespace Salus_Core.Dominio
{
    public class FornecedorMunicipioUF : Fornecedor
    {
        #region atributo
        private int codMunicipio;
        private string municipio;
        private int codUF;
        private string siglaUF;
        #endregion

        #region Construtor
        public FornecedorMunicipioUF() : base()
        {
            this.codMunicipio = 0;
            this.municipio = "";
            this.codUF = 0;
            this.siglaUF = "";
        }
        #endregion

        #region Propriedades
        public int CODMunicipio { get { return this.codMunicipio; } set { this.codMunicipio = value; } }
        public string Municipio { get { return this.municipio; } set { this.municipio = value; } }
        public int CODUF { get { return this.codUF; } set { this.codUF = value; } }
        public string SiglaUF { get { return this.siglaUF; } set { this.siglaUF = value; } }
        #endregion
    }
}
