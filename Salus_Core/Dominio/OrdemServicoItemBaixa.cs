namespace Salus_Core.Dominio
{
    public class OrdemServicoItemBaixa : OrdemServicoItem
    {
        #region atributos
        private double qtdeBaixa;
        private int codBaixa;
        private int codServico;
        private int codOrdemServico;
        private string descServico;

        #endregion

        #region construtor
        public OrdemServicoItemBaixa() : base()
        {
            this.qtdeBaixa = 0;
            this.codServico = 0;
            this.codBaixa = 0;
            this.codOrdemServico = 0;
            this.descServico = "";
        }
        #endregion

        #region propriedades
        public double QTDEBaixa { get { return this.qtdeBaixa; } set { this.qtdeBaixa = value; } }
        public int CODServico { get { return this.codServico; } set { this.codServico = value; } }
        public int CODOrdemServico { get { return this.codOrdemServico; } set { this.codOrdemServico = value; } }
        public string DESCServico { get { return this.descServico; } set { this.descServico = value; } }
        public int CODBaixa { get { return this.codBaixa; } set { this.codBaixa = value; } }
        #endregion
    }
}
