using System.Collections.Generic;

namespace Salus_Core.Dominio
{
    public class BaixaXML : Baixa
    {
        private List<BaixaServico> itens = new List<BaixaServico>();

        public BaixaXML()
        {
            itens = new List<BaixaServico>();
        }

        public List<BaixaServico> Itens
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
    }
}
