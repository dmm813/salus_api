using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("ConfigMenuAcesso")]
    public class ConfigMenuAcesso
    {
        #region Atributos
        private int idConfigMenuAcesso;
        private int idNivelAcesso;
        private bool mnuCadastro;
        private bool mnuCadEmpresa;
        private bool mnuCadCliente;
        private bool mnuCadFornecedor;
        private bool mnuCadServico;
        private bool mnuCadMarca;
        private bool mnuCadCor;
        private bool mnuCadSetor;
        private bool mnuCadPlano;

        private bool mnuMovimentacao;
        private bool mnuMovOS;
        private bool mnuMovEnvioOS;
        private bool mnuMovBaixa;
        private bool mnuMovCaixa;
        private bool mnuMovAberturaCaixa;
        private bool mnuMovLacamentoCaixa;
        private bool mnuMovFechamentoCaixa;
        private bool mnuMovVenda;

        private bool mnuFinanceiro;
        private bool mnuFinFormaPgto;
        private bool mnuFinContas;
        private bool mnuFinPlanoContas;
        private bool mnuFinLancamentoContas;
        private bool mnuFinBancos;

        private bool mnuConsulta;
        private bool mnuConMovimentacaoPlano;
        private bool mnuConAgendaOS;
        private bool mnuConBaixaOS;
        private bool mnuConMovimentoCaixa;
        private bool mnuConClientesInativos;

        private bool mnuConfiguracoes;
        private bool mnuConfBancoDados;
        private bool mnuConfPerfil;
        private bool mnuConfUsuario;
        private bool mnuConfImpressora;
        private bool mnuConfNFSE;

        private bool mnuRelatorios;
        private bool mnuRelDemonstrativoPorPeriodo;
        private bool mnuRelCliente;
        private bool mnuRelCliCredSintetico;
        private bool mnuRelPlanoPorCliente;
        private bool mnuRelCliInatividade;
        private bool mnuRelClieInativadeSintetico;
        private bool mnuRelOS;
        private bool mnuRelOSAbertasPorPeriodo;
        private bool mnuRelOSAnalitico;

        private bool mnuUtilitarios;
        private bool mnuUtiEnvioArquivo;
        private bool mnuUtiCreditoUsuaraio;



        #endregion

        #region Cosntrutor
        public ConfigMenuAcesso()
        {
            this.IdConfigMenuAcesso = 0;
            this.idNivelAcesso = 0;
            this.mnuCadastro = true;
            this.mnuCadEmpresa = true;
            this.mnuCadCliente = true;
            this.mnuCadFornecedor = true;
            this.mnuCadServico = true;
            this.mnuCadMarca = true;
            this.mnuCadCor = true;
            this.mnuCadSetor = true;
            this.mnuCadPlano = true;

            this.mnuMovimentacao = true;
            this.mnuMovOS = true;
            this.mnuMovEnvioOS = true;
            this.mnuMovBaixa = true;
            this.mnuMovCaixa = true;
            this.mnuMovAberturaCaixa = true;
            this.mnuMovLacamentoCaixa = true;
            this.mnuMovFechamentoCaixa = true;
            this.mnuMovVenda = true;

            this.mnuFinanceiro = true;
            this.mnuFinFormaPgto = true;
            this.mnuFinContas = true;
            this.mnuFinPlanoContas = true;
            this.mnuFinLancamentoContas = true;
            this.mnuFinBancos = true;

            this.mnuConsulta = true;
            this.mnuConMovimentacaoPlano = true;
            this.mnuConAgendaOS = true;
            this.mnuConBaixaOS = true;
            this.mnuConMovimentoCaixa = true;
            this.mnuConClientesInativos = true;

            this.mnuConfiguracoes = true;
            this.mnuConfBancoDados = true;
            this.MnuConfPerfil1 = true;
            this.mnuConfUsuario = true;
            this.mnuConfImpressora = true;
            this.mnuConfNFSE = true;

            this.mnuRelatorios = true;
            this.mnuRelDemonstrativoPorPeriodo = true;
            this.mnuRelCliente = true;
            this.mnuRelCliCredSintetico = true;
            this.mnuRelPlanoPorCliente = true;
            this.mnuRelCliInatividade = true;
            this.mnuRelClieInativadeSintetico = true;
            this.mnuRelOS = true;
            this.mnuRelOSAbertasPorPeriodo = true;
            this.mnuRelOSAnalitico = true;

            this.mnuUtilitarios = true;
            this.mnuUtiEnvioArquivo = true;
            this.mnuUtiCreditoUsuaraio = true;


        }
        #endregion

        #region Propriedades
        [Column]
        [Key]
        public int IdConfigMenuAcesso
        {
            get
            {
                return idConfigMenuAcesso;
            }

            set
            {
                idConfigMenuAcesso = value;
            }
        }
        [Column]
        [ForeignKey("NivelAcesso")]
        public int IdNivelAcesso
        {
            get
            {
                return idNivelAcesso;
            }

            set
            {
                idNivelAcesso = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuCadastro
        {
            get
            {
                return mnuCadastro;
            }

            set
            {
                mnuCadastro = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuCadEmpresa
        {
            get
            {
                return mnuCadEmpresa;
            }

            set
            {
                mnuCadEmpresa = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuCadCliente
        {
            get
            {
                return mnuCadCliente;
            }

            set
            {
                mnuCadCliente = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuCadFornecedor
        {
            get
            {
                return mnuCadFornecedor;
            }

            set
            {
                mnuCadFornecedor = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuCadServico
        {
            get
            {
                return mnuCadServico;
            }

            set
            {
                mnuCadServico = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuCadMarca
        {
            get
            {
                return mnuCadMarca;
            }

            set
            {
                mnuCadMarca = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuCadCor
        {
            get
            {
                return mnuCadCor;
            }

            set
            {
                mnuCadCor = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuCadSetor
        {
            get
            {
                return mnuCadSetor;
            }

            set
            {
                mnuCadSetor = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuCadPlano
        {
            get
            {
                return mnuCadPlano;
            }

            set
            {
                mnuCadPlano = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuMovimentacao
        {
            get
            {
                return mnuMovimentacao;
            }

            set
            {
                mnuMovimentacao = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuMovOS
        {
            get
            {
                return mnuMovOS;
            }

            set
            {
                mnuMovOS = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuMovEnvioOS
        {
            get
            {
                return mnuMovEnvioOS;
            }

            set
            {
                mnuMovEnvioOS = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuMovBaixa
        {
            get
            {
                return mnuMovBaixa;
            }

            set
            {
                mnuMovBaixa = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuMovCaixa
        {
            get
            {
                return mnuMovCaixa;
            }

            set
            {
                mnuMovCaixa = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuMovAberturaCaixa
        {
            get
            {
                return mnuMovAberturaCaixa;
            }

            set
            {
                mnuMovAberturaCaixa = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuMovLacamentoCaixa
        {
            get
            {
                return mnuMovLacamentoCaixa;
            }

            set
            {
                mnuMovLacamentoCaixa = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuMovFechamentoCaixa
        {
            get
            {
                return mnuMovFechamentoCaixa;
            }

            set
            {
                mnuMovFechamentoCaixa = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuMovVenda
        {
            get
            {
                return mnuMovVenda;
            }

            set
            {
                mnuMovVenda = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuFinanceiro
        {
            get
            {
                return mnuFinanceiro;
            }

            set
            {
                mnuFinanceiro = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuFinFormaPgto
        {
            get
            {
                return mnuFinFormaPgto;
            }

            set
            {
                mnuFinFormaPgto = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuFinContas
        {
            get
            {
                return mnuFinContas;
            }

            set
            {
                mnuFinContas = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuFinPlanoContas
        {
            get
            {
                return mnuFinPlanoContas;
            }

            set
            {
                mnuFinPlanoContas = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuFinLancamentoContas
        {
            get
            {
                return mnuFinLancamentoContas;
            }

            set
            {
                mnuFinLancamentoContas = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuConsulta
        {
            get
            {
                return mnuConsulta;
            }

            set
            {
                mnuConsulta = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuConMovimentacaoPlano
        {
            get
            {
                return mnuConMovimentacaoPlano;
            }

            set
            {
                mnuConMovimentacaoPlano = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuConAgendaOS
        {
            get
            {
                return mnuConAgendaOS;
            }

            set
            {
                mnuConAgendaOS = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuConBaixaOS
        {
            get
            {
                return mnuConBaixaOS;
            }

            set
            {
                mnuConBaixaOS = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuConMovimentoCaixa
        {
            get
            {
                return mnuConMovimentoCaixa;
            }

            set
            {
                mnuConMovimentoCaixa = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuConClientesInativos
        {
            get
            {
                return mnuConClientesInativos;
            }

            set
            {
                mnuConClientesInativos = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuConfiguracoes
        {
            get
            {
                return mnuConfiguracoes;
            }

            set
            {
                mnuConfiguracoes = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuConfBancoDados
        {
            get
            {
                return mnuConfBancoDados;
            }

            set
            {
                mnuConfBancoDados = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuConfPerfil
        {
            get
            {
                return mnuConfUsuario;
            }

            set
            {
                mnuConfUsuario = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuConfUsuario
        {
            get
            {
                return mnuConfUsuario;
            }

            set
            {
                mnuConfUsuario = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuConfImpressora
        {
            get
            {
                return mnuConfImpressora;
            }

            set
            {
                mnuConfImpressora = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuConfNFSE
        {
            get
            {
                return mnuConfNFSE;
            }

            set
            {
                mnuConfNFSE = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuRelatorios
        {
            get
            {
                return mnuRelatorios;
            }

            set
            {
                mnuRelatorios = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuRelDemonstrativoPorPeriodo
        {
            get
            {
                return mnuRelDemonstrativoPorPeriodo;
            }

            set
            {
                mnuRelDemonstrativoPorPeriodo = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuRelCliente
        {
            get
            {
                return mnuRelCliente;
            }

            set
            {
                mnuRelCliente = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuRelCliCredSintetico
        {
            get
            {
                return mnuRelCliCredSintetico;
            }

            set
            {
                mnuRelCliCredSintetico = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuRelPlanoPorCliente
        {
            get
            {
                return mnuRelPlanoPorCliente;
            }

            set
            {
                mnuRelPlanoPorCliente = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuRelCliInatividade
        {
            get
            {
                return mnuRelCliInatividade;
            }

            set
            {
                mnuRelCliInatividade = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuRelClieInativadeSintetico
        {
            get
            {
                return mnuRelClieInativadeSintetico;
            }

            set
            {
                mnuRelClieInativadeSintetico = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuRelOS
        {
            get
            {
                return mnuRelOS;
            }

            set
            {
                mnuRelOS = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuRelOSAbertasPorPeriodo
        {
            get
            {
                return mnuRelOSAbertasPorPeriodo;
            }

            set
            {
                mnuRelOSAbertasPorPeriodo = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuRelOSAnalitico
        {
            get
            {
                return mnuRelOSAnalitico;
            }

            set
            {
                mnuRelOSAnalitico = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuUtilitarios
        {
            get
            {
                return mnuUtilitarios;
            }

            set
            {
                mnuUtilitarios = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuUtiEnvioArquivo
        {
            get
            {
                return mnuUtiEnvioArquivo;
            }

            set
            {
                mnuUtiEnvioArquivo = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuUtiCretiroUsuaraio
        {
            get
            {
                return mnuUtiCreditoUsuaraio;
            }

            set
            {
                mnuUtiCreditoUsuaraio = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool MnuFinBancos
        {
            get
            {
                return mnuFinBancos;
            }

            set
            {
                mnuFinBancos = value;
            }
        }

        public bool MnuConfPerfil1 { get => mnuConfPerfil; set => mnuConfPerfil = value; }



        #endregion

    }
}
