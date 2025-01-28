using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Salus_Core.Dominio
{
    [Table("Cliente")]
    public class Cliente
    {
        #region Atributos
        private int idCliente;
        private int idEmpresa;
        private int codCliente;
        private string nome;
        private DateTime dataCadastro;
        private string docIdentidade;
        private string cpf_cnpj;
        private string cep;
        private string rua;
        private string numero;
        private string complemento;
        private string bairro;
        private int idMunicipio;
        private string telefoneCel;
        private string telefoneResidencial;
        private string telefoneComercial;
        private string email;
        private bool ativo;
        private double credito;
        private double creditoUtilizado;
        private double desconto;
        private bool planoFamilia;
        private bool exclusao;



        #endregion

        #region Contrutor
        public Cliente()
        {
            this.idCliente = 0;
            this.idEmpresa = 0;
            this.codCliente = 0;
            this.nome = "";
            this.dataCadastro = DateTime.Now;
            this.docIdentidade = "";
            this.cpf_cnpj = "";
            this.cep = "";
            this.rua = "";
            this.numero = "";
            this.complemento = "";
            this.bairro = "";
            this.idMunicipio = 0;
            this.telefoneCel = "";
            this.telefoneResidencial = "";
            this.telefoneComercial = "";
            this.email = "";
            this.ativo = true;
            this.credito = 0;
            this.creditoUtilizado = 0;
            this.desconto = 0;
            this.PlanoFamilia = false;
            this.exclusao = false;

        }
        public Cliente(string nome)
        {
            this.idCliente = 0;
            this.codCliente = 0;
            this.nome = nome;
            this.dataCadastro = DateTime.Now;
            this.docIdentidade = "";
            this.cpf_cnpj = "";
            this.cep = "";
            this.rua = "";
            this.numero = "";
            this.complemento = "";
            this.bairro = "";
            this.idMunicipio = 0;
            this.telefoneCel = "";
            this.telefoneResidencial = "";
            this.telefoneComercial = "";
            this.email = "";
            this.ativo = true;
            this.credito = 0;
            this.creditoUtilizado = 0;
            this.desconto = 0;
            this.PlanoFamilia = false;
            this.exclusao = false;
        }
        public Cliente(int cod)
        {
            this.idCliente = 0;
            this.codCliente = cod;
            this.nome = "";
            this.dataCadastro = DateTime.Now;
            this.docIdentidade = "";
            this.cpf_cnpj = "";
            this.cep = "";
            this.rua = "";
            this.numero = "";
            this.complemento = "";
            this.bairro = "";
            this.idMunicipio = 0;
            this.telefoneCel = "";
            this.telefoneResidencial = "";
            this.telefoneComercial = "";
            this.email = "";
            this.ativo = true;
            this.credito = 0;
            this.creditoUtilizado = 0;
            this.desconto = 0;
            this.PlanoFamilia = false;
            this.exclusao = false;
        }

        #endregion

        #region Propriedades

        [Column]
        [Key]
        public int IdCliente { get { return this.idCliente; } set { this.idCliente = value; } }
        [Column]
        public int CodCliente { get { return this.codCliente; } set { this.codCliente = value; } }
        [Column]
        public string Nome { get { return this.nome; } set { this.nome = value; } }
        [Column(TypeName ="datetime")]
        public DateTime DataCadastro { get { return this.dataCadastro; } set { this.dataCadastro = value; } }
        [Column]
        public string DocIdentidade { get { return this.docIdentidade; } set { this.docIdentidade = value; } }
        [Column(name:"cpf_cnpj")]
        public string CPFCNPJ { get { return this.cpf_cnpj; } set { this.cpf_cnpj = value; } }
        [Column]
        public string CEP { get { return this.cep; } set { this.cep = value; } }
        [Column(name: "endereco")]
        public string Rua { get { return this.rua; } set { this.rua = value; } }
        [Column]
        public string Numero { get { return this.numero; } set { this.numero = value; } }
        [Column]
        public string Complemento { get { return this.complemento; } set { this.complemento = value; } }
        [Column]
        public string Bairro { get { return this.bairro; } set { this.bairro = value; } }
        [Column]
        public int IdMunicipio { get { return this.idMunicipio; } set { this.idMunicipio = value; } }
        [Column]
        public string TelefoneCel { get { return this.telefoneCel; } set { this.telefoneCel = value; } }
        [Column]
        public string TelefoneResidencial { get { return this.telefoneResidencial; } set { this.telefoneResidencial = value; } }
        [Column]
        public string TelefoneComercial { get { return this.telefoneComercial; } set { this.telefoneComercial = value; } }
        [Column]
        public string Email { get { return this.email; } set { this.email = value; } }
        [Column(TypeName = "bit")]
        public bool Ativo { get { return this.ativo; } set { this.ativo = value; } }
        [Column(TypeName = "decimal(10,2)")]
        public double Credito { get { return this.credito; } set { this.credito = value; } }
        [Column(TypeName = "decimal(10,2)")]
        public double CreditoUtilizado { get { return this.creditoUtilizado; } set { this.creditoUtilizado = value; } }
        [Column(TypeName = "decimal(10,2)")]
        public double Desconto { get { return this.desconto; } set { this.desconto = value; } }
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
        [Column(TypeName = "bit")]
        public bool PlanoFamilia
        {
            get
            {
                return planoFamilia;
            }

            set
            {
                planoFamilia = value;
            }
        }


        #endregion

    }
}
