namespace Salus_Core.Dominio
{
    public class FinanceiroParticipanteConta : Financeiro
    {
        private int idConta;
        private int idContaBancaria;
        private double valorConta;
        private string statusConta;
        private string strStatusConta;
        private int codParticipante;
        private string nomeParticipante;
        private string tipoConta;
        private string numDespesa;
        private int codCentroCusto;
        private string centroCusto;



        public FinanceiroParticipanteConta()
        {
            idConta = 0;
            idContaBancaria = 0;
            valorConta = 0;
            statusConta = string.Empty;
            strStatusConta = string.Empty;
            codParticipante = 0;
            nomeParticipante = string.Empty;
            numDespesa = string.Empty;
            codCentroCusto = 0;
            centroCusto = string.Empty;
            tipoConta = string.Empty;
        }

        public int IdConta
        {
            get
            {
                return idConta;
            }

            set
            {
                idConta = value;
            }
        }

        public double ValorConta
        {
            get
            {
                return valorConta;
            }

            set
            {
                valorConta = value;
            }
        }

        public string StatusConta
        {
            get
            {
                return statusConta;
            }

            set
            {
                statusConta = value;
            }
        }

        public string StrStatusConta
        {
            get
            {
                return strStatusConta;
            }

            set
            {
                strStatusConta = value;
            }
        }

        public int CodParticipante
        {
            get
            {
                return codParticipante;
            }

            set
            {
                codParticipante = value;
            }
        }

        public string NomeParticipante
        {
            get
            {
                return nomeParticipante;
            }

            set
            {
                nomeParticipante = value;
            }
        }

        public string TipoConta
        {
            get
            {
                return tipoConta;
            }

            set
            {
                tipoConta = value;
            }
        }

        public string NumDespesa
        {
            get
            {
                return numDespesa;
            }

            set
            {
                numDespesa = value;
            }
        }

        public int CodCentroCusto
        {
            get
            {
                return codCentroCusto;
            }

            set
            {
                codCentroCusto = value;
            }
        }

        public string CentroCusto
        {
            get
            {
                return centroCusto;
            }

            set
            {
                centroCusto = value;
            }
        }

        public new int IdContaBancaria
        {
            get
            {
                return idContaBancaria;
            }

            set
            {
                idContaBancaria = value;
            }
        }
    }
}
