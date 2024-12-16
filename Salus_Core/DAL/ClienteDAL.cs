using Salus_Core.SC_DAO;
using Salus_Core.Dominio;
using Salus_Core.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salus_Core.DAL
{
    public class ClienteDAL : InterfaceDAL<Cliente>
    {
        private string _consulta = string.Empty;
        private ConexaoDAL _conexaoDAL = new ConexaoDAL();
        public void Editar(Cliente obj)
        {
            try
            {
                _consulta = "UPDATE [dbo].[Cliente]" +
                    "   SET [nome] = " + obj.Nome +
                    "      ,[dataCadastro] = " + obj.DataCadastro +
                    "      ,[docIdentidade] = " + obj.DocIdentidade +
                    "      ,[cpf_cnpj] = " + obj.CPFCNPJ +
                    "      ,[CEP] = " + obj.CEP +
                    "      ,[endereco] = " + obj.Rua +
                    "      ,[numero] = " + obj.Numero +
                    "      ,[complemento] = " + obj.Complemento +
                    "      ,[bairro] = " + obj.Bairro +
                    "      ,[idMunicipio] = " + obj.IdMunicipio +
                    "      ,[telefoneCel] = " + obj.TelefoneCel +
                    "      ,[telefoneResidencial] = " + obj.TelefoneResidencial +
                    "      ,[telefoneComercial] = " + obj.TelefoneComercial +
                    "      ,[email] = " + obj.Email +
                    "      ,[ativo] = " + obj.Ativo +
                    "      ,[exclusao] = " +
                    "      ,[idEmpresa] = " +
                    " WHERE codcliente = " + obj.CodCliente;

                if (ConexaoDAL.ExecutarConsulta(_consulta))
                {
                    ControleLog.InsereLog(1, "ClIENTE", "SUCESSO", DateTime.Now);
                }
            }
            catch(Exception ex)
            {
                ControleLog.InsereLog(1, "ClIENTE", ex.Message, DateTime.Now);
                return;
            }
           
        }

        public void Excluir(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Cliente obj)
        {
            try
            {
                _consulta = "INSERT INTO [dbo].[Cliente] " +
                    "([codCliente]," +
                    "[nome]," +
                    "[dataCadastro]," +
                    "[docIdentidade]," +
                    "[cpf_cnpj]," +
                    "[CEP]," +
                    "[endereco]," +
                    "[numero]," +
                    "[complemento]," +
                    "[bairro]," +
                    "[idMunicipio]," +
                    "[telefoneCel]," +
                    "[telefoneResidencial]," +
                    "[telefoneComercial]," +
                    "[email]," +
                    "[ativo]," +
                    "[credito]," +
                    "[creditoUtilizado]," +
                    "[desconto]," +
                    "[exclusao]," +
                    "[idEmpresa]," +
                    "[planoFamilia])  VALUES (" +
                    obj.CodCliente + ", " +
                    obj.Nome + ", " +
                    obj.DataCadastro + ", " +
                    obj.DocIdentidade + ", " +
                    obj.CPFCNPJ + ", " +
                    obj.CEP + ", " +
                    obj.Rua + ", " +
                    obj.Numero + ", " +
                    obj.Complemento + ", " +
                    obj.Bairro + ", " +
                    obj.IdMunicipio + ", " +
                    obj.TelefoneCel + ", " +
                    obj.TelefoneCel + ", " +
                    obj.TelefoneResidencial + ", " +
                    obj.TelefoneComercial + ", " +
                    obj.Email + ", " +
                    obj.Ativo + ", 0,0,0" +
                    obj.Exclusao + ", " +
                    obj.IdEmpresa + ", 0" +
                    ") ";
                if (ConexaoDAL.ExecutarConsulta(_consulta))
                {
                    ControleLog.InsereLog(1, "ClIENTE","SUCESSO", DateTime.Now);
                }

            }
            catch (Exception ex)
            {
                ControleLog.InsereLog(1, "ClIENTE", ex.Message, DateTime.Now);
                return;
            }
        }

        public List<Cliente> Listar()
        {
            List<Cliente> retorno = new List<Cliente>();
            _consulta = "select * Cliente where exclusao = 0 and Ativo = 1";
            try
            {
                DataTable tabela = _conexaoDAL.GetResultado(_consulta);
                foreach (DataRow dr in tabela.Rows)
                {
                    retorno.Add(
                        new Cliente
                        {
                            IdCliente = int.Parse(dr["idCliente"].ToString()),
                            CodCliente = int.Parse(dr["codCliente"].ToString()),
                            Nome = dr["nome"].ToString(),
                        }
                    );
                }
            }
            catch (Exception ex)
            {
               
                ControleLog.InsereLog(1, "ClIENTE", ex.Message, DateTime.Now);
                
            }
            return retorno;
           

        }

        public int RetornaMaxCodigo()
        {
            throw new NotImplementedException();
        }

        public List<Cliente> SelecionarPorCodigo(Cliente obj)
        {
            throw new NotImplementedException();
        }
        public List<Cliente> ListaClienteXML(int codEmpresa)
        {
            throw new NotImplementedException();
        }
        public ClienteMunicipioUF SelecionaClienteMuncipioUFPorID(int cod)
        {
            throw new NotImplementedException();
        }
    }
}
