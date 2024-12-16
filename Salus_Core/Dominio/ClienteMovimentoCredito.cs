namespace Salus_Core.Dominio
{
    public class ClienteMovimentoCredito : MovimentoCreditoCliente
    {
        #region atributos
        private int codCliente;
        private string nomeCliente;
        private string tipoMovimentoExtenso;
        #endregion

        #region Construtor
        public ClienteMovimentoCredito() : base()
        {
            this.codCliente = 0;
            this.nomeCliente = "";
            this.tipoMovimentoExtenso = "";
        }


        #endregion

        #region Propriedades
        public int CodCliente
        {
            get
            {
                return codCliente;
            }

            set
            {
                codCliente = value;
            }
        }

        public string NomeCliente
        {
            get
            {
                return nomeCliente;
            }

            set
            {
                nomeCliente = value;
            }
        }

        public string TipoMovimentoExtenso
        {
            get
            {
                return tipoMovimentoExtenso;
            }

            set
            {
                tipoMovimentoExtenso = value;
            }
        }


        #endregion


    }
}
