using Salus_Core.DAL;
using Salus_Core.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


namespace Salus_Core.Util
{
    public class FilalXML
    {
        #region atributos
        private EmpresaDAL DALEmpresa = new EmpresaDAL();
        private CaixaDAL DALCaixa = new CaixaDAL();
        private BaixaDAL DALBaixa = new BaixaDAL();
        private VendaDAL DALVenda = new VendaDAL();
        private OrdemServicoDAL DALOrdemServico = new OrdemServicoDAL();
        private ClienteDAL DALCliente = new ClienteDAL();
        private List<ClienteXML> listClientes = new List<ClienteXML>();
        private List<CaixaXML> listCaixa = new List<CaixaXML>();

        #endregion

        private List<VendaXML> Vendas(DateTime data, int codcli)
        {
            List<VendaXML> retorno = new List<VendaXML>();
            //try
            //{
            //    var interador = DALVenda.ListaVendaXML(Properties.Settings.Default.empativa, data, codcli);
            //    foreach (Venda v in interador)
            //    {
            //        VendaXML vx = new VendaXML();
            //        vx.IdCaixa = v.IdCaixa;
            //        vx.IdEmpresa = v.IdEmpresa;
            //        vx.IdCliente = v.IdCliente;
            //        vx.NumeroVenda = v.NumeroVenda;
            //        vx.Data = v.Data;
            //        vx.Desconto = v.Desconto;
            //        vx.Exclusao = v.Exclusao;
            //        vx.Valor = v.Valor;
            //        vx.ItensVenda = DALVenda.ListaVendaItemXML(v.NumeroVenda);
            //        vx.ParcelasVenda = DALVenda.ListaPacelaVendaXML(v.NumeroVenda);
            //        vx.ListFormaPagamento = DALVenda.ListaFormaPagamentoVendaXML(v.NumeroVenda);
            //        retorno.Add(vx);
            //    }

            //}catch
            //{
            //    FormBase.ErroBanco("erro na criação do xml!");
            //    ControleLog.InsereLog(5, "XMLVenda", "Erro na criação do filalXML!", DateTime.Now);
            //}
            return retorno;
        }
        private List<BaixaXML> Baixas(int emp, DateTime data, int codos)
        {
            List<BaixaXML> retorno = new List<BaixaXML>();
            try
            {
                var interador = DALBaixa.ListaBaixaXML(emp, data, codos);
                foreach (Baixa b in interador)
                {
                    BaixaXML bx = new BaixaXML();
                    bx.IdCaixa = b.IdCaixa;
                    bx.IDFormaPagamento = b.IDFormaPagamento;
                    bx.IdOrdemServico = b.IdOrdemServico;
                    bx.IDUsuario = b.IDUsuario;
                    bx.QTDEPecas = b.QTDEPecas;
                    bx.CODBaixa = b.CODBaixa;
                    bx.DataBaixa = b.DataBaixa;
                    bx.Desconto = b.Desconto;
                    bx.Valor = b.Valor;
                    bx.Itens = DALBaixa.ListaBaixaServicoXML(bx.CODBaixa);
                    retorno.Add(bx);
                }


            }
            catch
            {
               ControleLog.InsereLog(5, "Baixas", "Erro na criação do filialXML!", DateTime.Now);

            }
            return retorno;
        }
        private List<OrdemServicoXML> OrdensServico(int codEmp, DateTime date, int codCli)
        {
            List<OrdemServicoXML> retorno = new List<OrdemServicoXML>();
            try
            {
                var interador = DALOrdemServico.ListaOrdemServicoXML(codEmp, date, codCli);
                foreach (OrdemServico o in interador)
                {
                    OrdemServicoXML ox = new OrdemServicoXML();
                    ox.CodOrdemServico = o.CodOrdemServico;
                    ox.DataInicio = o.DataInicio;
                    ox.DataFim = o.DataFim;
                    ox.HoraInicio = o.HoraInicio;
                    ox.HoraFim = o.HoraFim;
                    ox.IdEmpresa = o.IdEmpresa;
                    ox.Valor = o.Valor;
                    ox.ValorPeso = o.ValorPeso;
                    ox.ValorDesconto = o.ValorDesconto;
                    ox.Status = o.Status;
                    ox.QTDEPecas = o.QTDEPecas;
                    ox.PesoPecas = o.PesoPecas;
                    ox.Status = o.Status;
                    ox.OBSOS = o.OBSOS;
                    ox.Itens = DALOrdemServico.ListaOrdemServicoItemXML(o.CodOrdemServico);
                    ox.ListBaixas = Baixas(codEmp, date, o.CodOrdemServico);
                    retorno.Add(ox);
                }

            }
            catch
            {
               ControleLog.InsereLog(5, "OrdemServico", "Erro na criação do filialXML", DateTime.Now);
            }
            return retorno;
        }
        private List<ClienteXML> Clientes(int codEmp, DateTime date)
        {
            List<ClienteXML> retorno = new List<ClienteXML>();
            try
            {
                var interador = DALCliente.ListaClienteXML(codEmp);
                foreach (Cliente cli in interador)
                {
                    ClienteXML cx = new ClienteXML();
                    cx.CodCliente = cli.CodCliente;
                    cx.Nome = cli.Nome;
                    cx.Rua = cli.Rua;
                    cx.Numero = cli.Numero;
                    cx.IdMunicipio = cli.IdMunicipio;
                    cx.IdEmpresa = cli.IdEmpresa;
                    cx.TelefoneCel = cli.TelefoneCel;
                    cx.TelefoneComercial = cli.TelefoneComercial;
                    cx.TelefoneResidencial = cli.TelefoneResidencial;
                    cx.Credito = cli.Credito;
                    cx.CreditoUtilizado = cli.CreditoUtilizado;
                    cx.Desconto = cli.Desconto;
                    cx.CEP = cli.CEP;
                    cx.Complemento = cli.Complemento;
                    cx.DocIdentidade = cli.DocIdentidade;
                    cx.CPFCNPJ = cli.CPFCNPJ;
                    cx.DataCadastro = cli.DataCadastro;
                    cx.Email = cli.Email;
                    cx.ListaOSXML = OrdensServico(codEmp, date, cli.CodCliente);
                    cx.ListaVendasXML = Vendas(date, cli.CodCliente);
                    retorno.Add(cx);
                }

            }
            catch
            {
                
                ControleLog.InsereLog(5, "ordemservico", "Erro na criação do filialXML", DateTime.Now);
            }
            return retorno;

        }
        private List<CaixaXML> Caixas(int codEmpresa, DateTime data)
        {
            List<CaixaXML> retorno = new List<CaixaXML>();
            try
            {
                var interador = DALCaixa.ListaCaixaXML(codEmpresa, data);
                foreach (Caixa c in interador)
                {
                    CaixaXML cax = new CaixaXML();
                    cax.NumeroCaixa = c.NumeroCaixa;
                    cax.DataAbertura = c.DataAbertura;
                    cax.HoraAbertura = c.HoraAbertura;
                    cax.ValorAbertura = c.ValorAbertura;
                    cax.DataFechamento = c.DataFechamento;
                    cax.HoraFechamento = c.HoraFechamento;
                    cax.ValorFechamento = c.ValorFechamento;
                    cax.IDEmpresa = c.IDEmpresa;
                    cax.IDUsuario = c.IDUsuario;
                    retorno.Add(cax);
                }
            }
            catch
            {
                ControleLog.InsereLog(5, "caixa", "Erro na criação de filalXML!", DateTime.Now);
            }
            return retorno;

        }

        public void CriaArquviFilalXMLCompleto(int codEmpresa, DateTime data)
        {
            Empresa emp = new Empresa();
            emp = DALEmpresa.SelecionarPorCodigo(new Empresa(codEmpresa))[0];
            var listcontrole = Clientes(codEmpresa, data);
            foreach (ClienteXML c in listcontrole)
            {
                if (c.ListaOSXML.Count > 0 || c.ListaVendasXML.Count > 0)
                {
                    listClientes.Add(c);
                }
            }

            listCaixa = Caixas(codEmpresa, data);
            try
            {
                XDocument doc = new XDocument(
                    new XElement("Arquivo",
                        new XElement("Empresa",
                            new XElement("idEmpresa", emp.IDEmpresa),
                            new XElement("CodEmpresa", emp.CODEmpresa),
                            new XElement("Caixas", from c in listCaixa
                                                   select new XElement("Caixa",
                                                                            new XElement("numCaixa", c.NumeroCaixa),
                                                                            new XElement("IdEmpresa", c.IDEmpresa),
                                                                            new XElement("idUsuario", c.IDUsuario),
                                                                            new XElement("dataAberura", c.DataAbertura),
                                                                            new XElement("horaAbertura", c.DataAbertura),
                                                                            new XElement("valorAbertura", c.ValorAbertura),
                                                                            new XElement("dataFechamento", c.DataFechamento),
                                                                            new XElement("horaFechamento", c.HoraFechamento),
                                                                            new XElement("valorFechamento", c.ValorFechamento),
                                                                            new XElement("status", c.Status)
                                                                       )
                                          ),
                             new XElement("Clientes", from cli in listClientes
                                                      select new XElement("Cliente",
                                                                             new XElement("codCliente", cli.CodCliente),
                                                                             new XElement("nome", cli.Nome),
                                                                             new XElement("dataCadastro", cli.DataCadastro),
                                                                             new XElement("docIdentidade", cli.DocIdentidade),
                                                                             new XElement("cpfcnpj", cli.CPFCNPJ),
                                                                             new XElement("cep", cli.CEP),
                                                                             new XElement("endereco", cli.Rua),
                                                                             new XElement("numero", cli.Numero),
                                                                             new XElement("complemento", cli.Complemento),
                                                                             new XElement("bairro", cli.Bairro),
                                                                             new XElement("idMunicipio", cli.IdMunicipio),
                                                                             new XElement("telefoneCel", cli.TelefoneCel),
                                                                             new XElement("telefoneresidencial", cli.TelefoneResidencial),
                                                                             new XElement("telefoneComercial", cli.TelefoneComercial),
                                                                             new XElement("email", cli.Email),
                                                                             new XElement("ativo", cli.Ativo),
                                                                             new XElement("credito", cli.Credito),
                                                                             new XElement("creditioUtilizado", cli.CreditoUtilizado),
                                                                             new XElement("desconto", cli.Desconto),
                                                                             new XElement("exclusao", cli.Exclusao),
                                                                             new XElement("idEmpresa", cli.IdEmpresa),
                                                                             new XElement("Movimentacao",
                                                                                                  new XElement("OrdensServico", from os in cli.ListaOSXML
                                                                                                                                orderby os.CodOrdemServico
                                                                                                                                select new XElement("OS",
                                                                                                                                                         new XElement("codOrdemServico", os.CodOrdemServico),
                                                                                                                                                         new XElement("idEmpresa", os.IdEmpresa),
                                                                                                                                                         new XElement("qtdePecas", os.QTDEPecas),
                                                                                                                                                         new XElement("pesoPecas", os.PesoPecas),
                                                                                                                                                         new XElement("dataInicio", os.DataInicio),
                                                                                                                                                         new XElement("dataFinal", os.DataFim),
                                                                                                                                                         new XElement("status", os.Status),
                                                                                                                                                         new XElement("valor", os.Valor),
                                                                                                                                                         new XElement("valoDesconto", os.ValorDesconto),
                                                                                                                                                         new XElement("valorPeso", os.ValorPeso),
                                                                                                                                                         new XElement("horaInicio", os.HoraInicio),
                                                                                                                                                         new XElement("horaFim", os.HoraFim),
                                                                                                                                                         new XElement("credito", os.Credito),
                                                                                                                                                         new XElement("idSetor", os.IdSetor),
                                                                                                                                                         new XElement("exclusao", os.Exclusao),
                                                                                                                                                         new XElement("OrdemServicoItens", from osi in os.Itens
                                                                                                                                                                                           orderby osi.IDOrdemServicoItem
                                                                                                                                                                                           select new XElement("oIten",
                                                                                                                                                                                                                     new XElement("idServico", osi.IDServico),
                                                                                                                                                                                                                     new XElement("qtdeServico", osi.QTDEServico),
                                                                                                                                                                                                                     new XElement("valor", osi.Valor)

                                                                                                                                                                                                              )
                                                                                                                                                                     ),
                                                                                                                                                         new XElement("OrdemServicoBaixas", from b in os.ListBaixas
                                                                                                                                                                                            select new XElement("Baixa",
                                                                                                                                                                                                                       new XElement("idUsuario", b.IDUsuario),
                                                                                                                                                                                                                       new XElement("idFormaPagamento", b.IDFormaPagamento),
                                                                                                                                                                                                                       new XElement("codBaixa", b.CODBaixa),
                                                                                                                                                                                                                       new XElement("dataBaixa", b.DataBaixa),
                                                                                                                                                                                                                       new XElement("qtdePecas", b.QTDEPecas),
                                                                                                                                                                                                                       new XElement("valor", b.Valor),
                                                                                                                                                                                                                       new XElement("desconto", b.Desconto),
                                                                                                                                                                                                                       new XElement("BaixaItens", from bi in b.Itens
                                                                                                                                                                                                                                                  select new XElement("bItem",
                                                                                                                                                                                                                                                                             new XElement("idServico", bi.IDServico),
                                                                                                                                                                                                                                                                             new XElement("qtdeBaixa", bi.QTDEBaixa)
                                                                                                                                                                                                                                                                     )

                                                                                                                                                                                                                                   )
                                                                                                                                                                                                               )
                                                                                                                                                                     )

                                                                                                                                                    )
                                                                                                              ),
                                                                                                  new XElement("Vendas", from v in cli.ListaVendasXML
                                                                                                                         select new XElement("Venda",
                                                                                                                                                     new XElement("numeroVenda", v.IdEmpresa),
                                                                                                                                                     new XElement("idEmpresa", v.IdEmpresa),
                                                                                                                                                     new XElement("data", v.Data),
                                                                                                                                                     new XElement("valor", v.Valor),
                                                                                                                                                     new XElement("desconto", v.Desconto),
                                                                                                                                                     new XElement("exclusao", v.Exclusao),
                                                                                                                                                     new XElement("VendaItens", from vi in v.ItensVenda
                                                                                                                                                                                select new XElement("vItem",
                                                                                                                                                                                                             new XElement("idProduto", vi.IdProduto),
                                                                                                                                                                                                             new XElement("qtde", vi.Qtde),
                                                                                                                                                                                                             new XElement("peso", vi.Peso),
                                                                                                                                                                                                             new XElement("ValorUnitario", vi.ValorUnitario)
                                                                                                                                                                                                   )
                                                                                                                                                                 ),
                                                                                                                                                   new XElement("Pagamento", from fp in v.ListFormaPagamento
                                                                                                                                                                             select new XElement("formaPagamento",
                                                                                                                                                                                                               new XElement("idFormaPagamento", fp.IdFormaPagamento),
                                                                                                                                                                                                               new XElement("parcelas", fp.Parcelas),
                                                                                                                                                                                                               new XElement("valorFormaPagameto", fp.ValorFormaPagamento)
                                                                                                                                                                                               )

                                                                                                                                                               ),
                                                                                                                                                   new XElement("Parcelas", from pa in v.ParcelasVenda
                                                                                                                                                                            orderby pa.NumeroParcela
                                                                                                                                                                            select new XElement("Parcela",
                                                                                                                                                                                                         new XElement("numeroParcela", pa.NumeroParcela),
                                                                                                                                                                                                         new XElement("dataVencimento", pa.DataVencimento),
                                                                                                                                                                                                         new XElement("valorParcela", pa.ValorParcela),
                                                                                                                                                                                                         new XElement("status", pa.Status)
                                                                                                                                                                                               )
                                                                                                                                                               )
                                                                                                                                            )

                                                                                                              )






                                                                                             )
                                      )
                                    )
                                   )
                                   )
                                   );

                doc.Save(@"C:\\Salus\\arquivos\\enviados\\" + data.ToShortDateString() + "FILGE.xml");
                            }
            catch
            {
                
            }
        }
    }
}
