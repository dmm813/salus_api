using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("Financeiro")]
    public class Financeiro
    {
        #region atributos
        private int idFinanceiro;
        private int codFinanceiro;
        private int idContaBancaria;
        private int idContaAnalitica;
        private string documento;
        private int tipo;
        private int tipoMovimentacao;
        private DateTime dataLancamento;
        private DateTime dataEmissao;
        private DateTime dataVencimento;
        private string historico;
        private bool exclusao;


        #endregion

        public Financeiro()
        {
            idFinanceiro = 0;
            codFinanceiro = 0;
            idContaBancaria = 0;
            idContaAnalitica = 0;
            documento = string.Empty;
            tipo = 0;
            tipoMovimentacao = 0;
            dataLancamento = new DateTime();
            dataEmissao = new DateTime();
            dataVencimento = new DateTime();
            historico = string.Empty;
            exclusao = false;
        }
        public Financeiro(string doc)
        {

            idFinanceiro = 0;
            codFinanceiro = 0;
            idContaBancaria = 0;
            idContaAnalitica = 0;
            documento = doc;
            tipo = 0;
            tipoMovimentacao = 0;
            dataEmissao = new DateTime();
            dataVencimento = new DateTime();
            historico = string.Empty;
            exclusao = false;
        }
        public Financeiro(int cod)
        {
            idFinanceiro = 0;
            codFinanceiro = cod;
            idContaBancaria = 0;
            idContaAnalitica = 0;
            documento = string.Empty;
            tipo = 0;
            tipoMovimentacao = 0;
            dataEmissao = new DateTime();
            dataVencimento = new DateTime();
            historico = string.Empty;
            exclusao = false;
        }

        [Column]
        [Key]
        public int IdFinanceiro
        {
            get
            {
                return idFinanceiro;
            }

            set
            {
                idFinanceiro = value;
            }
        }


        [Column]
        [ForeignKey("ContaAnalitica")]
        public int IdContaAnalitica
        {
            get
            {
                return idContaAnalitica;
            }

            set
            {
                idContaAnalitica = value;
            }
        }
        [Column]
        public string Documento
        {
            get
            {
                return documento;
            }

            set
            {
                documento = value;
            }
        }
        [Column]
        public int Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }
        [Column]
        public int TipoMovimentacao
        {
            get
            {
                return tipoMovimentacao;
            }

            set
            {
                tipoMovimentacao = value;
            }
        }
        [Column(TypeName = "date")]
        public DateTime DataEmissao
        {
            get
            {
                return dataEmissao;
            }

            set
            {
                dataEmissao = value;
            }
        }
        [Column(TypeName = "date")]
        public DateTime DataVencimento
        {
            get
            {
                return dataVencimento;
            }

            set
            {
                dataVencimento = value;
            }
        }
        [Column]
        public string Historico
        {
            get
            {
                return historico;
            }

            set
            {
                historico = value;
            }
        }
        [Column]
        public int CodFinanceiro
        {
            get
            {
                return codFinanceiro;
            }

            set
            {
                codFinanceiro = value;
            }
        }
        [Column(TypeName = "date")]
        public DateTime DataLancamento
        {
            get
            {
                return dataLancamento;
            }

            set
            {
                dataLancamento = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool Exclusao
        {
            get
            {
                return exclusao;
            }

            set
            {
                exclusao = value;
            }
        }
        [Column]
        public int IdContaBancaria
        {
            get
            {
                return idContaBancaria;
            }

            set
            {
                idContaBancaria = value;
            }
        }
    }
}
