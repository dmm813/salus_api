namespace Salus_Core.Dominio
{
    public class OrdemServicoCliente : OrdemServico
    {
        #region Atributo

        private int codCliente;
        private string nomeCliente;
        private string nomeSetor;
        private int codSetor;

        #endregion

        #region Construtor
        public OrdemServicoCliente()
            : base()
        {

            this.codCliente = 0;
            this.nomeCliente = "";
            this.nomeSetor = "";
            this.codSetor = 0;

        }

        #endregion

        #region propriedades       
        public int CodCliente { get { return this.codCliente; } set { this.codCliente = value; } }
        public string NomeCliente { get { return this.nomeCliente; } set { this.nomeCliente = value; } }

        public string NomeSetor { get { return this.nomeSetor; } set { this.nomeSetor = value; } }
        public int CodSetor { get { return this.codSetor; } set { this.codSetor = value; } }
        #endregion
    }
}
