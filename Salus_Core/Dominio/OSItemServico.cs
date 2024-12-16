namespace Salus_Core.Dominio
{
    public class OSItemServico : OrdemServicoItem
    {
        #region atributos
        private int codServico;
        private string descServico;
        private double valor;
        #endregion

        #region construtor
        public OSItemServico() :
            base()
        {
            this.codServico = 0;
            this.descServico = "";
            this.valor = 0;
        }
        #endregion

        #region Propriedades
        public int CodServico { get { return this.codServico; } set { this.codServico = value; } }
        public string DescServico { get { return this.descServico; } set { this.descServico = value; } }
        public double ValorServico { get { return this.valor; } set { this.valor = value; } }
        #endregion
    }
}
