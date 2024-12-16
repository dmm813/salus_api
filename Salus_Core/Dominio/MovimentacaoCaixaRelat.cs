using System;

namespace Salus_Core.Dominio
{
    public class MovimentacaoCaixaRelat
    {
        #region atributos
        private DateTime data;
        private int numCaixa;
        private int numMovimento;
        private string tipoMovimento;
        private string formaPagamento;
        private string condPagamento;
        private double valor;


        #endregion

        #region Contrutor
        public MovimentacaoCaixaRelat()
        {
            data = new DateTime();
            numCaixa = 0;
            numMovimento = 0;
            tipoMovimento = string.Empty;
            formaPagamento = string.Empty;
            condPagamento = string.Empty;
            valor = 0;
        }
        #endregion
        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public int NumCaixa
        {
            get
            {
                return numCaixa;
            }

            set
            {
                numCaixa = value;
            }
        }

        public int NumMovimento
        {
            get
            {
                return numMovimento;
            }

            set
            {
                numMovimento = value;
            }
        }

        public string TipoMovimento
        {
            get
            {
                return tipoMovimento;
            }

            set
            {
                tipoMovimento = value;
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

        public double Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public string CondPagamento
        {
            get
            {
                return condPagamento;
            }

            set
            {
                condPagamento = value;
            }
        }
    }
}
