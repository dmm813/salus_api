namespace Salus_Core.Dominio
{
    public class VendaCliente : Venda
    {
        #region atributos
        private int codCliente;
        private string nomeCliente;
        #endregion

        #region Construtor
        public VendaCliente() : base()
        {
            this.codCliente = 0;
            this.nomeCliente = "";
        }
        #endregion

        #region propriedade
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
        #endregion
    }
}
