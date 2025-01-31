using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Salus_Core.Dominio
{
    [Table("Cliente")]
    public class Cliente
    {
        #region Atributos
        private int _idCliente;
        private int _idEmpresa;
        private int _codCliente;
        private string _nome;
        private DateTime _dataCadastro;
        private string _docIdentidade;
        private string _cpf_cnpj;
        private string _cep;
        private string _rua;
        private string _numero;
        private string _complemento;
        private string _bairro;
        private int _idMunicipio;
        private string _telefoneCel;
        private string _telefoneResidencial;
        private string _telefoneComercial;
        private string _email;
        private bool _ativo;
        private double _credito;
        private double _creditoUtilizado;
        private double _desconto;
        private bool _planoFamilia;
        private bool _exclusao;



        #endregion

        #region Contrutor
        public Cliente()
        {
            this._idCliente = 0;
            this._idEmpresa = 0;
            this._codCliente = 0;
            this._nome = "";
            this._dataCadastro = DateTime.Now;
            this._docIdentidade = "";
            this._cpf_cnpj = "";
            this._cep = "";
            this._rua = "";
            this._numero = "";
            this._complemento = "";
            this._bairro = "";
            this._idMunicipio = 0;
            this._telefoneCel = "";
            this._telefoneResidencial = "";
            this._telefoneComercial = "";
            this._email = "";
            this._ativo = true;
            this._credito = 0;
            this._creditoUtilizado = 0;
            this._desconto = 0;
            this._planoFamilia = false;
            this._exclusao = false;

        }
        public Cliente(string nome)
        {
            this._idCliente = 0;
            this._codCliente = 0;
            this._nome = nome;
            this._dataCadastro = DateTime.Now;
            this._docIdentidade = "";
            this._cpf_cnpj = "";
            this._cep = "";
            this._rua = "";
            this._numero = "";
            this._complemento = "";
            this._bairro = "";
            this._idMunicipio = 0;
            this._telefoneCel = "";
            this._telefoneResidencial = "";
            this._telefoneComercial = "";
            this._email = "";
            this._ativo = true;
            this._credito = 0;
            this._creditoUtilizado = 0;
            this._desconto = 0;
            this._planoFamilia = false;
            this._exclusao = false;
        }
        public Cliente(int cod)
        {
            this._idCliente = 0;
            this._codCliente = cod;
            this._nome = "";
            this._dataCadastro = DateTime.Now;
            this._docIdentidade = "";
            this._cpf_cnpj = "";
            this._cep = "";
            this._rua = "";
            this._numero = "";
            this._complemento = "";
            this._bairro = "";
            this._idMunicipio = 0;
            this._telefoneCel = "";
            this._telefoneResidencial = "";
            this._telefoneComercial = "";
            this._email = "";
            this._ativo = true;
            this._credito = 0;
            this._creditoUtilizado = 0;
            this._desconto = 0;
            this._planoFamilia = false;
            this._exclusao = false;
        }

        #endregion

        #region Propriedades

        [Column]
        [Key]
        public int IdCliente { get { return this._idCliente; } set { this._idCliente = value; } }
        [Column]
        public int CodCliente { get { return this._codCliente; } set { this._codCliente = value; } }
        [Column]
        public string Nome { get { return this._nome; } set { this._nome = value; } }
        [Column(TypeName ="datetime")]
        public DateTime DataCadastro { get { return this._dataCadastro; } set { this._dataCadastro = value; } }
        [Column]
        public string DocIdentidade { get { return this._docIdentidade; } set { this._docIdentidade = value; } }
        [Column(name:"cpf_cnpj")]
        public string CPFCNPJ { get { return this._cpf_cnpj; } set { this._cpf_cnpj = value; } }
        [Column]
        public string CEP { get { return this._cep; } set { this._cep = value; } }
        [Column(name: "endereco")]
        public string Rua { get { return this._rua; } set { this._rua = value; } }
        [Column]
        public string Numero { get { return this._numero; } set { this._numero = value; } }
        [Column]
        public string Complemento { get { return this._complemento; } set { this._complemento = value; } }
        [Column]
        public string Bairro { get { return this._bairro; } set { this._bairro = value; } }
        [Column]
        public int IdMunicipio { get { return this._idMunicipio; } set { this._idMunicipio = value; } }
        [Column]
        public string TelefoneCel { get { return this._telefoneCel; } set { this._telefoneCel = value; } }
        [Column]
        public string TelefoneResidencial { get { return this._telefoneResidencial; } set { this._telefoneResidencial = value; } }
        [Column]
        public string TelefoneComercial { get { return this._telefoneComercial; } set { this._telefoneComercial = value; } }
        [Column]
        public string Email { get { return this._email; } set { this._email = value; } }
        [Column(TypeName = "bit")]
        public bool Ativo { get { return this._ativo; } set { this._ativo = value; } }
        [Column(TypeName = "decimal(10,2)")]
        public double Credito { get { return this._credito; } set { this._credito = value; } }
        [Column(TypeName = "decimal(10,2)")]
        public double CreditoUtilizado { get { return this._creditoUtilizado; } set { this._creditoUtilizado = value; } }
        [Column(TypeName = "decimal(10,2)")]
        public double Desconto { get { return this._desconto; } set { this._desconto = value; } }
        [Column(TypeName = "bit")]
        public bool Exclusao
        {
            get
            {
                return _exclusao;
            }

            set
            {
                _exclusao = value;
            }
        }
        [Column]
        public int IdEmpresa
        {
            get
            {
                return _idEmpresa;
            }

            set
            {
                _idEmpresa = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool PlanoFamilia
        {
            get
            {
                return _planoFamilia;
            }

            set
            {
                _planoFamilia = value;
            }
        }


        #endregion

    }
}
