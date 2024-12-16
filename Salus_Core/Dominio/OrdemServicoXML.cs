using System.Collections.Generic;

namespace Salus_Core.Dominio
{
    public class OrdemServicoXML : OrdemServico
    {
        #region atributos
        private List<OrdemServicoItem> itens = new List<OrdemServicoItem>();
        private List<BaixaXML> listBaixas = new List<BaixaXML>();
        #endregion

        public OrdemServicoXML()
        {
            itens = new List<OrdemServicoItem>();
            listBaixas = new List<BaixaXML>();
        }

        public List<OrdemServicoItem> Itens
        {
            get
            {
                return itens;
            }

            set
            {
                itens = value;
            }
        }

        public List<BaixaXML> ListBaixas
        {
            get
            {
                return listBaixas;
            }

            set
            {
                listBaixas = value;
            }
        }
    }
}
