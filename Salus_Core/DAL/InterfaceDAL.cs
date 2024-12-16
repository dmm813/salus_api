using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salus_Core.DAL
{
    public interface InterfaceDAL<T>
    {
        void Inserir(T obj);
        void Editar(T obj);
        void Excluir(T obj);
        List<T> Listar();
        List<T> SelecionarPorCodigo(T obj);
        int RetornaMaxCodigo();
    }
}
