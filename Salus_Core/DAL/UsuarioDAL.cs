using Salus_Core.Dominio;
using Salus_Core.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Salus_Core.DAL
{
    public class UsuarioDAL : InterfaceDAL<Usuario>
    {
        private string _consulta = "";
        private ConexaoDAL _conexaoDAL = new ConexaoDAL();
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
            try
            {

                _consulta = "INSERT INTO [dbo].[Usuario]" +
                    "       ([codUsuario]," +
                    "       [login]," +
                    "       [senha]," +
                    "       [exclusao]," +
                    "       [acInserir]," +
                    "       [acExcluir]," +
                    "       [acEditar]," +
                    "       [idNivelAcesso])" +
                    "VALUES" +
                    "(" + this.RetornaMaxCodigo() + 1 +
                      "," + obj.Login +
                      "," + obj.Senha +
                      "," + obj.Exclusao +
                      "," + obj.AcInserir +
                      "," + obj.AcExcluir +
                      "," + obj.AcEditar +
                      "," + obj.IDNivelAcesso+
                    ")";
                ConexaoDAL.Open();
                if (ConexaoDAL.ExecutarConsulta(_consulta))
                {
                    Console.WriteLine("Sei La");// ControleLog.InsereLog(1, "USUARIO", "SUCESSO", DateTime.Now);
                }
                ConexaoDAL.Close();
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Sei La"); //ControleLog.InsereLog(1, "USUARIO", ex.Message, DateTime.Now);
                return;
            }

        }

        public void Editar(Usuario obj)
        {
            try
            {
                _consulta = "UPDATE [dbo].[Usuario] " +
                               "SET [login] = " + obj.Login +
                                  ",[senha] = " + obj.Senha +
                                  ",[exclusao] = " + obj.Exclusao +
                                  ",[acInserir] = " + obj.AcInserir +
                                  ",[acExcluir] = " + obj.AcExcluir +
                                  ",[acEditar] = " + obj.AcEditar +
                                  ",[idNivelAcesso] = " + obj.IDNivelAcesso +
                             "WHERE codUsuario = " + obj.CODUsuario;
                if (ConexaoDAL.ExecutarConsulta(_consulta))
                {
                    ControleLog.InsereLog(2, "USUARIO", "SUCESSO", DateTime.Now);
                }
            }
                
            catch (Exception ex)
            {

                ControleLog.InsereLog(2, "USUARIO", ex.Message, DateTime.Now);
                return;
            }

        }
        public void Excluir(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Listar()
        {
            List<Usuario> retorno = new List<Usuario> ();
            try
            {

            }
            catch (Exception ex)
            {

                ControleLog.InsereLog(2, "USUARIO", ex.Message, DateTime.Now);
                
            }
            return retorno;

        }

        public List<Usuario> SelecionarPorCodigo(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public int RetornaMaxCodigo()
        {
            int retorno = 0;

            try
            {
                _consulta = "select Max(codUsuario) as mascod from Usuario";
                ConexaoDAL.Open();
                DataTable tabela = _conexaoDAL.GetResultado(_consulta);
                foreach (DataRow dr in tabela.Rows) 
                {
                    retorno = int.Parse(IsNullValue(dr["maxcod"].ToString()));
                }
                if (ConexaoDAL.ExecutarConsulta(_consulta))
                {
                    //ControleLog.InsereLog(2, "USUARIO", "SUCESSO", DateTime.Now);
                }
                ConexaoDAL.Close();
            }

            catch (Exception ex)
            {

                ControleLog.InsereLog(2, "USUARIO", ex.Message, DateTime.Now);
                
            }
            return retorno;
        }

        public string IsNullValue(string? s)
        {
            return string.IsNullOrWhiteSpace(s) ? " " : s;
        }
    }
}
