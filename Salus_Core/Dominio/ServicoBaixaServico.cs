namespace Salus_Core.Dominio
{
    class ServicoBaixaServico : BaixaServico
    {
        #region atributos
        private int codServico;
        private string descServico;
        #endregion

        #region construtor
        public ServicoBaixaServico() : base()
        {
            this.codServico = 0;
            this.descServico = "";
        }
        #endregion

        #region
        public int CODServico { get { return this.codServico; } set { this.codServico = value; } }
        public string Servico { get { return this.descServico; } set { this.descServico = value; } }
        #endregion 
    }
}
