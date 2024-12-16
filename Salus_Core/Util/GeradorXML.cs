using Microsoft.Win32;
using Salus_Core.SC_DAO;
using Salus_Core.Dominio;
using System;
using System.Xml.Linq;

namespace Salus_Core.Util
{
    public class GeradorXML
    {
        #region atributos

        #endregion
        public static void GeraXML(OrdemServico os)
        {

    //        RegistryKey reg = Registry.CurrentUser.OpenSubKey("nfse");

    //        try
    //        {
    //            XNamespace n = "http://www.abrasf.org.br/ABRASF/arquivos/nfse.xsd";
    //            XDocument doc = new XDocument(
    //                 new XElement(n + "SDTRecepcaoRPSEnvioV2",

    //                 new XElement("LoteRps",
    //                    new XAttribute("id", "lote"),
    //                     new XElement("NumeroLote", 1),
    //                     new XElement("InscricaoMunicipal", reg.GetValue("InscricaoMunicipal")),
    //                     new XElement("QuantidadeRps", 1),
    //                 new XElement("ListaRps",
    //                    new XElement("Rps",
    //                        new XElement("InfRps",
    //                            new XAttribute("id", "rps:" + os.CodOrdemServico.ToString() + reg.GetValue("Serie")),
    //                            new XElement("IdentificacaoRps",
    //                                new XElement("Numero", os.CodOrdemServico),
    //                                new XElement("Serie", reg.GetValue("Serie")),
    //                                new XElement("Tipo", 1)
    //                                ),
    //                            new XElement("DataEmissao", DateTime.Now.ToString("s")),
    //                            new XElement("NaturezaOperacao", 3),
    //                            new XElement("RegimeEspecialTributacao", 6),
    //                            new XElement("OpitanteSimplesNacional", reg.GetValue("OptanteSimples")),
    //                            new XElement("IncentivadorCultural", reg.GetValue("IncCult")),
    //                            new XElement("Status", 1),
    //                            new XElement("Servico",
    //                                new XElement("Valores"),
    //                                    new XElement("ValorServicos", (os.Valor - (os.ValorDesconto + os.Credito)).ToString().Replace(",", "."))),
    //                                    new XElement("ValorPis", 0),
    //                                    new XElement("ValorCofins", 0),
    //                                    new XElement("ValorIr", 0),
    //                                    new XElement("ValorCsll", 0),
    //                                    new XElement("IssRetido", 0),
    //                                    new XElement("ValorIss", 0),
    //                                    new XElement("OutrasRetencoes", 0),
    //                                    new XElement("BaseCalculo", (os.Valor - (os.ValorDesconto + os.Credito)).ToString().Replace(",", ".")),
    //                                    new XElement("Aliquota", 0),
    //                               new XElement("ItemListaServico", "14.10"),
    //                               new XElement("CodigoCnae", "9601701"),
    //                               new XElement("Descricao", "Nota fiscal referenci a os de n." + os.CodOrdemServico),
    //                               new XElement("CodigoMunicipio", "9")
    //                               ),
    //                           new XElement("Prestador",
    //                               new XElement("Cnpj", ""),
    //                               new XElement("InscricaoMunicipal", reg.GetValue("InscricaoMunicipal")
    //                               )
    //                               ),
    //                           new XElement("Tomador",
    //                               new XElement("IdentificacaoTomador",
    //                                   new XElement("CpfCnpj",
    //                                       new XElement(TagCPFCNPj(GetClienteEndereco(os.IdCliente).CPFCNPJ), GetClienteEndereco(os.IdCliente).CPFCNPJ)
    //                                       )
    //                                       ),
    //                                   new XElement("InscricaoMunicipal"),
    //                                   new XElement("RazaoSocial", GetClienteEndereco(os.IdCliente).Nome),
    //                                   new XElement("Endereco",
    //                                       new XElement("Endereco", GetClienteEndereco(os.IdCliente).Rua),
    //                                       new XElement("Numero", GetClienteEndereco(os.IdCliente).Numero),
    //                                       new XElement("Complemento", GetClienteEndereco(os.IdCliente).Complemento),
    //                                       new XElement("Bairro", GetClienteEndereco(os.IdCliente).Bairro),
    //                                       new XElement("CodigoMunicipio", GetClienteEndereco(os.IdCliente).CODMunicipio),
    //                                       new XElement("Uf", GetClienteEndereco(os.IdCliente).SiglaUF),
    //                                       new XElement("Cep", GetClienteEndereco(os.IdCliente).CEP)
    //                                      )
    //                                    )
    //                                  )
    //                                )
    //                               )
    //                              )
    //                             );


    //            doc.Save(@"C:\\Salus\\nfse\\" + os.DataInicio.Year + (os.CodOrdemServico, 11) + ".xml");

    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Não foi possível gerar o arquivo RPS da OS nº " + (os.CodOrdemServico) + " " + ex.Message);
    //        }
    //    }
    //    //private static Empresa GetEmpresa(int cod)
    //    //{
    //    //    return new EmpresaDAL().SelecionarPorCodigo(new Empresa(cod))[0];
    //    //}
    //    //private static EmpresaUFMunicipio GetEmpresaEndereco(int cod)
    //    //{
    //    //    return new EmpresaDAL().SelecionarEmpresaUFMuncicipoPorEmpresa(new Empresa(cod))[0];
    //    //}
    //    //private static ClienteMunicipioUF GetClienteEndereco(int cod)
    //    //{
    //    //    return new DALCliente().SelecionaClienteMuncipioUFPorID(cod)[0];
    //    //}
    //    private static string TagCPFCNPj(string documento)
    //    {
    //        if (documento.Length > 11)
    //        {
    //            return "Cnpj";
    //        }
    //        else
    //        {
    //            return "Cpf";
    //        }
       }

    }
}
