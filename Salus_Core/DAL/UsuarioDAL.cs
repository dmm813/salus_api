using Salus_Core.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salus_Core.DAL
{
    public  class UsuarioDAL:InterfaceDAL<Usuario>
    {
        public List<Usuario> SelecionaUsuarioLoginSenha(Usuario user)
        {
            return new List<Usuario>();
            
        }
        public int RetornaQuantidadeLong(string login)
        {
            return 0;
        }

        public void Inserir(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Editar(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Listar()
        {
            throw new NotImplementedException();
        }

        public List<Usuario> SelecionarPorCodigo(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public int RetornaMaxCodigo()
        {
            throw new NotImplementedException();
        }
    }
}
