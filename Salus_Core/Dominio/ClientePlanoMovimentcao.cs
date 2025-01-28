namespace Salus_Core.Dominio
{
    class ClientePlanoMovimentacao : PlanoMovimentacao
    {
        #region atributos
        private int codCliente;
        private string nomeCliente;
        private string plano;
        private int codPlano;


        #endregion

        #region contrutor
        public ClientePlanoMovimentacao() : base()
        {
            codCliente = 0;
            nomeCliente = string.Empty;
            plano = string.Empty;
            codPlano = 0;
        }
        #endregion

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

        public string Plano
        {
            get
            {
                return plano;
            }

            set
            {
                plano = value;
            }
        }

        public int CodPlano
        {
            get
            {
                return codPlano;
            }

            set
            {
                codPlano = value;
            }
        }
    }
}
