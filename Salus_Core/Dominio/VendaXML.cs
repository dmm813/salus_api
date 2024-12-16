using System.Collections.Generic;

namespace Salus_Core.Dominio
{
    public class VendaXML : Venda
    {
        #region atributos
        private List<VendaItem> itensVenda = new List<VendaItem>();
        private List<FormaPagamentoVenda> listFormaPagamento = new List<FormaPagamentoVenda>();
        private List<Parcela> parcelasVenda = new List<Parcela>();
        #endregion

        #region construtores
        public VendaXML()
        {
            itensVenda = new List<VendaItem>();
            listFormaPagamento = new List<FormaPagamentoVenda>();
            parcelasVenda = new List<Parcela>();
        }

        public List<VendaItem> ItensVenda
        {
            get
            {
                return itensVenda;
            }

            set
            {
                itensVenda = value;
            }
        }

        public List<FormaPagamentoVenda> ListFormaPagamento
        {
            get
            {
                return listFormaPagamento;
            }

            set
            {
                listFormaPagamento = value;
            }
        }

        public List<Parcela> ParcelasVenda
        {
            get
            {
                return parcelasVenda;
            }

            set
            {
                parcelasVenda = value;
            }
        }
        #endregion

    }
}
