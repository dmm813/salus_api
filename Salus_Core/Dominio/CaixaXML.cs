using System.Collections.Generic;

namespace Salus_Core.Dominio
{
    public class CaixaXML : Caixa
    {
        private List<MovimentacaoCaixa> movimentacoes = new List<MovimentacaoCaixa>();

        public CaixaXML() : base()
        {
            movimentacoes = new List<MovimentacaoCaixa>();
        }

        public List<MovimentacaoCaixa> Movimentacoes
        {
            get
            {
                return movimentacoes;
            }

            set
            {
                movimentacoes = value;
            }
        }
    }
}
