using Salus_Core.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salus_Core.DAL
{
    public class OrdemServicoDAL : InterfaceDAL<OrdemServico>
    {
        public void Editar(OrdemServico obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(OrdemServico obj)
        {
            throw new NotImplementedException();
        }

        public void Inserir(OrdemServico obj)
        {
            throw new NotImplementedException();
        }

        public List<OrdemServico> Listar()
        {
            throw new NotImplementedException();
        }

        public int RetornaMaxCodigo()
        {
            throw new NotImplementedException();
        }

        public List<OrdemServico> SelecionarPorCodigo(OrdemServico obj)
        {
            throw new NotImplementedException();
        }
        public List<OrdemServico> ListaOrdemServicoXML(int codEmpresa, DateTime data, int codCliente)
        {
            throw new NotImplementedException();
        }
        public List<OrdemServicoItem> ListaOrdemServicoItemXML(int codOS)
        {
            throw new NotImplementedException();
        }
    }
}
