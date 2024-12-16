using System.Collections.Generic;

namespace Salus_Core.Dominio
{
    public class ClienteXML : Cliente
    {
        private List<OrdemServicoXML> listaOSXML = new List<OrdemServicoXML>();
        private List<VendaXML> listaVendasXML = new List<VendaXML>();

        public ClienteXML() : base()
        {
            listaOSXML = new List<OrdemServicoXML>();
            listaVendasXML = new List<VendaXML>();

        }

        public List<OrdemServicoXML> ListaOSXML
        {
            get
            {
                return listaOSXML;
            }

            set
            {
                listaOSXML = value;
            }
        }

        public List<VendaXML> ListaVendasXML
        {
            get
            {
                return listaVendasXML;
            }

            set
            {
                listaVendasXML = value;
            }
        }
    }
}
