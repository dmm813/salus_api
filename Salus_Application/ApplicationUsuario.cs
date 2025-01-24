using Salus_Core.Dominio;
using Salus_Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salus_Application
{
    public class ApplicationUsuario:IApplication<Usuario>
    {
        UsuarioDAL serviceUser = new UsuarioDAL();

        public void Insert(Usuario obj)
        {
            serviceUser.Inserir(obj);
        }
    }
}
