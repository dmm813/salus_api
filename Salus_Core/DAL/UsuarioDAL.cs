
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
            List<Usuario> retorno = new List<Usuario>();
            try
            {
                _consulta = "select * from Usuario where login = '"+ user.Login + "' and senha = '"+user.Senha+"'" ;
                ConexaoDAL.Open();
                DataTable dt = new DataTable();
                foreach (DataRow row in dt.Rows)
                {
                    retorno.Add(new Usuario()
                    {
                        AcEditar = Convert.ToBoolean(row["acEdidar"].ToString()),
                        AcExcluir = Convert.ToBoolean(row["acExcluir"].ToString()),
                        AcInserir = Convert.ToBoolean(row["acInserir"].ToString()),
                        IDUsuario = int.Parse(IsNullValue(row["idUsuario"].ToString())),
                        CODUsuario = int.Parse(IsNullValue(row["codUsuario"].ToString())),
                        Exclusao = Convert.ToBoolean(row["Exclusao"].ToString()),
                        Login = IsNullValue(row["login"].ToString()),
                        Senha = IsNullValue(row["senha"].ToString())
                    });

                }

            }
            catch (Exception ex)
            {

                ControleLog.InsereLog(2, "USUARIO", ex.Message, DateTime.Now);

            }
            return retorno;

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
                _consulta = "select * from Usuario";
                ConexaoDAL.Open();
                DataTable dt = new DataTable();
                foreach (DataRow row in dt.Rows) 
                {
                    retorno.Add(new Usuario()
                    {
                        AcEditar = Convert.ToBoolean(row["acEdidar"].ToString()),
                        AcExcluir = Convert.ToBoolean(row["acExcluir"].ToString()),
                        AcInserir = Convert.ToBoolean(row["acInserir"].ToString()),
                        IDUsuario = int.Parse(IsNullValue(row["idUsuario"].ToString())),
                        CODUsuario = int.Parse(IsNullValue(row["codUsuario"].ToString())),
                        Exclusao = Convert.ToBoolean(row["Exclusao"].ToString()),
                        Login = IsNullValue(row["login"].ToString()),
                        Senha = IsNullValue(row["senha"].ToString())
                    });

                }

            }
            catch (Exception ex)
            {

                ControleLog.InsereLog(2, "USUARIO", ex.Message, DateTime.Now);
                
            }
            return retorno;

        }

        public List<Usuario> SelecionarPorCodigo(Usuario obj)
        {
            List<Usuario> retorno = new List<Usuario>();
            try
            {
                _consulta = "select * from Usuario where codUsuario = " + obj.CODUsuario;
                ConexaoDAL.Open();
                DataTable dt = new DataTable();
                foreach (DataRow row in dt.Rows)
                {
                    retorno.Add(new Usuario()
                    {
                        AcEditar = Convert.ToBoolean(row["acEdidar"].ToString()),
                        AcExcluir = Convert.ToBoolean(row["acExcluir"].ToString()),
                        AcInserir = Convert.ToBoolean(row["acInserir"].ToString()),
                        IDUsuario = int.Parse(IsNullValue(row["idUsuario"].ToString())),
                        CODUsuario = int.Parse(IsNullValue(row["codUsuario"].ToString())),
                        Exclusao = Convert.ToBoolean(row["Exclusao"].ToString()),
                        Login = IsNullValue(row["login"].ToString()),
                        Senha = IsNullValue(row["senha"].ToString())
                    });

                }

            }
            catch (Exception ex)
            {

                ControleLog.InsereLog(2, "USUARIO", ex.Message, DateTime.Now);

            }
            return retorno;
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
