
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

        public  void Inserir(Usuario obj)
        {
            try
            {
                var cod = this.RetornaMaxCodigo() + 1;

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
                    "(" + cod +
                      ", '" + obj.Login + "'" +
                      ", '" + obj.Senha +"'" +
                      ", " + Convert.ToInt32(obj.Exclusao) +
                      ", " + Convert.ToInt32(obj.AcInserir) +
                      ", " + Convert.ToInt32(obj.AcExcluir) +
                      ", " + Convert.ToInt32(obj.AcEditar) +
                      ", " + Convert.ToInt32(obj.IDNivelAcesso) +
                    ")";
                ConexaoDAL.Open();


                if (ConexaoDAL.ExecutarConsulta(_consulta))
                {
                    Console.WriteLine("Sucesso");// ControleLog.InsereLog(1, "USUARIO", "SUCESSO", DateTime.Now);
                }
                ConexaoDAL.Close();
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Erro" + ex); //ControleLog.InsereLog(1, "USUARIO", ex.Message, DateTime.Now);
                return;
            }

        }

        public void Editar(Usuario obj)
        {
            try
            {
                _consulta = "UPDATE [dbo].[Usuario] " +
                               "SET [login] = " + obj.Login +
                                  ", [senha] = '" + obj.Senha + "'" +
                                  ", [exclusao] = '" + Convert.ToInt32(obj.Exclusao) +
                                  ", [acInserir] = " + Convert.ToInt32(obj.AcInserir) +
                                  ", [acExcluir] = " + Convert.ToInt32(obj.AcExcluir) +
                                  ", [acEditar] = " + Convert.ToInt32(obj.AcEditar) +
                                  ", [idNivelAcesso] = " + Convert.ToInt32(obj.IDNivelAcesso) +
                             "WHERE codUsuario = " + Convert.ToInt32(obj.CODUsuario);
                if (ConexaoDAL.ExecutarConsulta(_consulta))
                {
                    Console.WriteLine("Sucesso");//ControleLog.InsereLog(2, "USUARIO", "SUCESSO", DateTime.Now);
                }
            }
                
            catch (Exception ex)
            {

                Console.WriteLine("Erro" + ex);// ControleLog.InsereLog(2, "USUARIO", ex.Message, DateTime.Now);
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
                _consulta = "select max(codusuario) as maxcod from Usuario";
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
