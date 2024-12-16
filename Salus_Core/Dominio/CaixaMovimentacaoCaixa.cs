namespace Salus_Core.Dominio
{
    public class CaixaMovimentacaoCaixa : MovimentacaoCaixa
    {
        #region Atriutos
        private int? numeroCaixa;
        private string strTipoMovimento;
        #endregion

        #region Construtor
        public CaixaMovimentacaoCaixa() : base()
        {
            numeroCaixa = 0;
            strTipoMovimento = "";
        }


        #endregion

        #region Propriedades
        public int? NumeroCaixa
        {
            get
            {
                return numeroCaixa;
            }

            set
            {
                numeroCaixa = value;
            }
        }

        public string StrTipoMovimento
        {
            get
            {
                return strTipoMovimento;
            }

            set
            {
                strTipoMovimento = value;
            }
        }
        #endregion

    }
}