namespace Salus_Core.Dominio
{
    public class BaixaOS : Baixa
    {
        private int codOS;
        private double valorLiquido;
        private string formaPagamentoString;



        public BaixaOS() : base()
        {
            codOS = 0;
            valorLiquido = 0;
            formaPagamentoString = string.Empty;
        }

        public int CodOS
        {
            get
            {
                return codOS;
            }

            set
            {
                codOS = value;
            }
        }

        public double ValorLiquido
        {
            get
            {
                return valorLiquido;
            }

            set
            {
                valorLiquido = value;
            }
        }

        public string FormaPagamentoString
        {
            get
            {
                return formaPagamentoString;
            }

            set
            {
                formaPagamentoString = value;
            }
        }
    }
}
