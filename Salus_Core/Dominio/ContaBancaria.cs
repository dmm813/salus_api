using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("ContaBancaria")]
    public class ContaBancaria
    {
        #region atributos
        private int idContaBancaria;
        private int idEmpresa;
        private int idBanco;
        private int codContaBancaria;
        private string descConta;
        private string agencia;
        private string conta;
        private DateTime dataAtivacao;
        private double saldoInicio;
        private bool exclusao;


        #endregion

        #region consturores
        public ContaBancaria()
        {
            idContaBancaria = 0;
            idBanco = 0;
            idEmpresa = 0;
            codContaBancaria = 0;
            descConta = string.Empty;
            agencia = string.Empty;
            conta = string.Empty;
            dataAtivacao = new DateTime();
            saldoInicio = 0;
            exclusao = false;
        }
        public ContaBancaria(int cod)
        {
            idContaBancaria = 0;
            idBanco = 0;
            idEmpresa = 0;
            codContaBancaria = cod;
            descConta = string.Empty;
            agencia = string.Empty;
            conta = string.Empty;
            dataAtivacao = new DateTime();
            saldoInicio = 0;
            exclusao = false;
        }
        public ContaBancaria(string des)
        {
            idContaBancaria = 0;
            idBanco = 0;
            idEmpresa = 0;
            codContaBancaria = 0;
            descConta = des;
            agencia = string.Empty;
            conta = string.Empty;
            dataAtivacao = new DateTime();
            saldoInicio = 0;
            exclusao = false;
        }
        #endregion

        [Column]
        [Key]
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
        [Column]
        [ForeignKey("Banco")]
        public int IdBanco
        {
            get
            {
                return idBanco;
            }

            set
            {
                idBanco = value;
            }
        }
        [Column]
        public int CodContaBancaria
        {
            get
            {
                return codContaBancaria;
            }

            set
            {
                codContaBancaria = value;
            }
        }
        [Column]
        public string DescConta
        {
            get
            {
                return descConta;
            }

            set
            {
                descConta = value;
            }
        }
        [Column]
        public string Agencia
        {
            get
            {
                return agencia;
            }

            set
            {
                agencia = value;
            }
        }
        [Column]
        public string Conta
        {
            get
            {
                return conta;
            }

            set
            {
                conta = value;
            }
        }
        [Column(TypeName = "date")]
        public DateTime DataAtivacao
        {
            get
            {
                return dataAtivacao;
            }

            set
            {
                dataAtivacao = value;
            }
        }
        [Column(TypeName = "decimal")]
        public double SaldoInicio
        {
            get
            {
                return saldoInicio;
            }

            set
            {
                saldoInicio = value;
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
        public int IdEmpresa
        {
            get
            {
                return idEmpresa;
            }

            set
            {
                idEmpresa = value;
            }
        }
    }
}
