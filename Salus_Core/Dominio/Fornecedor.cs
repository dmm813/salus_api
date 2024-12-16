using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio

{
    [Table("Fornecedor")]
    public class Fornecedor
    {

        #region Atributos
        private int idFornecedor;
        private int codFornecedor;
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


        #endregion

        #region Contrutor
        public Fornecedor()
        {
            this.idFornecedor = 0;
            this.codFornecedor = 0;
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

        }
        public Fornecedor(string n)
        {
            this.idFornecedor = 0;
            this.codFornecedor = 0;
            this.nome = n;
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

        }
        public Fornecedor(int cod)
        {
            this.idFornecedor = 0;
            this.codFornecedor = cod;
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

        }
        #endregion

        #region Propriedades

        [Column]
        [Key]
        public int IdFornecedor { get { return this.idFornecedor; } set { this.idFornecedor = value; } }
        [Column]
        public int CodFornecedor { get { return this.codFornecedor; } set { this.codFornecedor = value; } }
        [Column]
        public string Nome { get { return this.nome; } set { this.nome = value; } }
        [Column(TypeName = "datetime")]
        public DateTime DataCadastro { get { return this.dataCadastro; } set { this.dataCadastro = value; } }
        [Column]
        public string DocIdentidade { get { return this.docIdentidade; } set { this.docIdentidade = value; } }
        [Column(TypeName = "cpf_cnpj")]
        public string CPFCNPJ { get { return this.cpf_cnpj; } set { this.cpf_cnpj = value; } }
        [Column]
        public string CEP { get { return this.cep; } set { this.cep = value; } }
        [Column(TypeName = "endereco")]
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

        #endregion
    }
}



