using Salus_Core.DAL;
using Salus_Core.Dominio;
using System;

namespace Salus_Core.Util
{
    public class ControleLog
    {
        #region atributos
        private static UsuarioDAL DALUsuario = new UsuarioDAL();
        private static LogDAL DALLog = new LogDAL();
        #endregion

        public static void InsereLog(int instrucao, string tabela, string erro, DateTime data)
        {
            Usuario user = new Usuario();
            user.Login = "cerberus";//Properties.Settings.Default.loginuser;
            user.Senha = "cerbtec";// Properties.Settings.Default.senhauser;
            if (!user.Login.Equals("cerberus"))
            {
                user = DALUsuario.SelecionaUsuarioLoginSenha(user)[0];
            }
            else
            {
                user.IDUsuario = 1;
            }

            LogSistema log = new LogSistema();
            log.IDUsuario = user.IDUsuario;
            log.Tabela = tabela;
            log.Instrucao = RetornaInstrucao(instrucao);
            log.Data = data;
            log.Erro = erro;

            DALLog.Inserir(log);
        }

        private static string RetornaInstrucao(int ins)
        {
            string retorno = "";

            switch (ins)
            {
                case 1:
                    retorno = "INSERT";
                    break;
                case 2:
                    retorno = "UPDATE";
                    break;
                case 3:
                    retorno = "DELETE";
                    break;
                case 4:
                    retorno = "CREATE";
                    break;
            }
            return retorno;

        }
    }
}

