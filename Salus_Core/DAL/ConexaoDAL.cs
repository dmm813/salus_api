using System.Data;
using Microsoft.Data.SqlClient;
using Salus_Core.Util;
using System;
using WinFormsLibrary1;
using System.IO;

namespace Salus_Core
{
    public class ConexaoDAL
    {
        #region Atributos


        /// <summary>
        /// 
        /// </summary>
        private static string stringDeConexao = Settings.Default.conexao;

        /// <summary>
        /// 
        /// </summary>
        private static SqlConnection conexao = new SqlConnection();

        /// <summary>
        /// 
        /// </summary>
        private static SqlCommand comando = new SqlCommand();

        //private string umNomeConexao = "ConexaoSQL2005";

        #endregion

        #region Propriedades

        public static SqlConnection ConexaoAtiva { get { return conexao; } }

        public static string StrConexao { get { return stringDeConexao; } set { stringDeConexao = value; } }

        //public string NomeConexao { get { return this.umNomeConexao; } set { this.umNomeConexao = value; } }

        #endregion

        #region Métodos Públicos
        /// <summary>
        /// 
        /// </summary>
        public static void Open()
        {
            try
            {
                stringDeConexao = Settings.Default.conexao;
                conexao = new SqlConnection(stringDeConexao);
                conexao.Open();
            }
            catch
            {
                Console.WriteLine("Sua conexão ainda não está configurada!");
            }
        }

        public static void OpenAdmin()
        {
            try
            {
                stringDeConexao = Settings.Default.conexao;
                conexao = new SqlConnection(stringDeConexao);
                conexao.Open();
            }
            catch
            {
                
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        public static bool ExecutarConsulta(String consulta)
        {
            try
            {

                comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = consulta;
                comando.CommandType = CommandType.Text;

                int resultado = comando.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return false;


        }

        public static bool NaoExisteTabelaCampo(String consulta)
        {
            comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = consulta;
            comando.CommandType = CommandType.Text;
            SqlDataReader resultado = comando.ExecuteReader();
            try
            {
                if (!resultado.Read())
                {

                    resultado.Close();
                    return true;

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                resultado.Close();
            }
            resultado.Close();
            return false;



        }

        public static bool ExecutaConsultaEscalar(string consulta)
        {
            try
            {

                comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = consulta;
                comando.CommandType = CommandType.Text;

                var resultado = comando.ExecuteScalar();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            return false;


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        public bool ExecutarConsulta(SqlCommand comando)
        {
            try
            {
                int resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    return true;
                }
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex); 
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable GetResultado()
        {
            DataTable dataTable;
            SqlDataReader dataReader;

            dataTable = new DataTable();
            dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

            dataTable.Load(dataReader, LoadOption.OverwriteChanges);
            dataReader.Close();
            dataReader.Dispose();

            return (dataTable);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable GetResultado(SqlCommand com)
        {
            DataTable dataTable;
            SqlDataReader dataReader;

            comando = com;

            dataTable = new DataTable();
            dataReader = comando.ExecuteReader(CommandBehavior.CloseConnection);

            dataTable.Load(dataReader, LoadOption.OverwriteChanges);
            dataReader.Close();
            dataReader.Dispose();

            return (dataTable);
        }

        public DataTable GetResultado(string consulta)
        {
            DataTable resultado = new DataTable();
            SqlDataReader reader = comando.ExecuteReader();
            try
            {

                comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = consulta;
                comando.CommandType = CommandType.Text;

                reader = comando.ExecuteReader(CommandBehavior.CloseConnection);
                resultado.Load(reader, LoadOption.OverwriteChanges);
                reader.Close();
                reader.Dispose();



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return resultado;
        }
        /// <summary>
        /// 
        /// </summary>
        public static void Close()
        {
            if (conexao.Equals(null) == false)
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }


        #endregion
    }
}
