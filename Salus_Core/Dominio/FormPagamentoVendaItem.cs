namespace Salus_Core.Dominio
{
    public class FormaPagamentoVendaItem : FormaPagamentoVenda
    {
        #region Atributo
        private int codFormaPagamento;
        private int idCondicaoPagamento;
        private string formaPagamento;
        #endregion

        #region Contrutor
        public FormaPagamentoVendaItem() : base()
        {
            this.codFormaPagamento = 0;
            this.idCondicaoPagamento = 0;
            this.formaPagamento = "";
        }


        #endregion

        #region propriedade
        public int CodFormaPagamento
        {
            get
            {
                return codFormaPagamento;
            }

            set
            {
                codFormaPagamento = value;
            }
        }

        public string FormaPagamento
        {
            get
            {
                return formaPagamento;
            }

            set
            {
                formaPagamento = value;
            }
        }

        public int IdCondicaoPagamento
        {
            get
            {
                return idCondicaoPagamento;
            }

            set
            {
                idCondicaoPagamento = value;
            }
        }
        #endregion
    }
}
