using Microsoft.Identity.Client;
using Salus_Core.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Salus_Core.DAL
{
    public class BaixaDAL : InterfaceDAL<Baixa>
    {
        public void Editar(Baixa obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Baixa obj)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Baixa obj)
        {
            throw new NotImplementedException();
        }

        public List<BaixaXML> ListaBaixaXML(int empresa, DateTime date, int os) 
        {
            return new List<BaixaXML>();

        }

        public List<Baixa> Listar()
        {
            throw new NotImplementedException();
        }

        public int RetornaMaxCodigo()
        {
            throw new NotImplementedException();
        }

        public List<Baixa> SelecionarPorCodigo(Baixa obj)
        {
            throw new NotImplementedException();
        }
        public List<BaixaServico> ListaBaixaServicoXML(int cod)
        {
            throw new NotImplementedException();
        }

        public string IsNullValue(string s)
        {
            throw new NotImplementedException();
        }
    }
}
