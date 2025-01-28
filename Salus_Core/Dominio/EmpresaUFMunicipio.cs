namespace Salus_Core.Dominio
{
    public class EmpresaUFMunicipio : Empresa
    {
        #region atriburtos
        private int codMuncicipio;
        private string muncipio;
        private string uf;
        #endregion
        #region contrutor
        public EmpresaUFMunicipio() : base()
        {
            this.muncipio = "";
            this.uf = "";
        }
        #endregion

        #region Propriedades
        public string Muni { get { return this.muncipio; } set { this.muncipio = value; } }
        public string SiglaUF { get { return this.uf; } set { this.uf = value; } }
        #endregion
        public int CodMucicipio { get { return this.codMuncicipio; } set { this.codMuncicipio = value; } }
    }
}
