using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Salus_Core.Dominio
{
    [Table("Empresa")]
    public class Empresa
    {
        #region Atributos
        private int idEmpresa;
        private int codEmpresa;
        private string razaoSocial;
        private string fantasia;
        private string endereco;
        private string bairro;
        private string cep;
        private string complemento;
        private string numero;
        private int idMunicipio;
        private string telefone;
        private string fax;
        private string celular;
        private string email;
        private string cnpj;
        private string ie;
        private DateTime dataCadastro;
        private int idTabelaDePreco;
        private int regime;
        private string obsRomaneio;
        private bool ativo;
        private Image logo;

        #endregion

        #region Construtor
        public Empresa()
        {
            this.idEmpresa = 0;
            this.codEmpresa = 0;
            this.razaoSocial = "";
            this.fantasia = "";
            this.endereco = "";
            this.bairro = "";
            this.cep = "";
            this.complemento = "";
            this.numero = "";
            this.idMunicipio = 0;
            this.telefone = "";
            this.fax = "";
            this.celular = "";
            this.email = "";
            this.cnpj = "";
            this.ie = "";
            this.dataCadastro = new DateTime();
            this.idTabelaDePreco = 0;
            this.regime = 0;
            this.obsRomaneio = "";
            this.ativo = false;
            this.logo = null;

        }
        public Empresa(int cod)
        {
            this.idEmpresa = 0;
            this.codEmpresa = cod;
            this.razaoSocial = "";
            this.fantasia = "";
            this.endereco = "";
            this.bairro = "";
            this.cep = "";
            this.complemento = "";
            this.numero = "";
            this.idMunicipio = 0;
            this.telefone = "";
            this.fax = "";
            this.celular = "";
            this.email = "";
            this.cnpj = "";
            this.ie = "";
            this.dataCadastro = new DateTime();
            this.idTabelaDePreco = 0;
            this.regime = 0;
            this.obsRomaneio = "";
            this.ativo = false;
            this.logo = null;

        }
        public Empresa(string r)
        {
            this.idEmpresa = 0;
            this.codEmpresa = 0;
            this.razaoSocial = string.Empty;
            this.fantasia = r;
            this.endereco = "";
            this.bairro = "";
            this.cep = "";
            this.complemento = "";
            this.numero = "";
            this.idMunicipio = 0;
            this.telefone = "";
            this.fax = "";
            this.celular = "";
            this.email = "";
            this.cnpj = "";
            this.ie = "";
            this.dataCadastro = new DateTime();
            this.idTabelaDePreco = 0;
            this.regime = 0;
            this.obsRomaneio = "";
            this.ativo = false;
            this.logo = null;

        }
        #endregion

        #region Propriedades
        [Column]
        [Key]
        public int IDEmpresa { get { return this.idEmpresa; } set { this.idEmpresa = value; } }
        [Column]
        public int CODEmpresa { get { return this.codEmpresa; } set { this.codEmpresa = value; } }
        [Column]
        public string RazaoSocial { get { return this.razaoSocial; } set { this.razaoSocial = value; } }
        [Column]
        public string Fantasia { get { return this.fantasia; } set { this.fantasia = value; } }
        [Column]
        public string Endereco { get { return this.endereco; } set { this.endereco = value; } }
        [Column]
        public string Bairro { get { return this.bairro; } set { this.bairro = value; } }
        [Column]
        public string CEP { get { return this.cep; } set { this.cep = value; } }
        [Column]
        public string Complemento { get { return this.complemento; } set { this.complemento = value; } }
        [Column]
        public string Numero { get { return this.numero; } set { this.numero = value; } }
        [Column]
        public int IDMunicipio { get { return this.idMunicipio; } set { this.idMunicipio = value; } }
        [Column]
        public string Telefone { get { return this.telefone; } set { this.telefone = value; } }
        [Column]
        public string Fax { get { return this.fax; } set { this.fax = value; } }
        [Column]
        public string Celular { get { return this.celular; } set { this.celular = value; } }
        [Column]
        public string Email { get { return this.email; } set { this.email = value; } }
        [Column]
        public string CNPJ { get { return this.cnpj; } set { this.cnpj = value; } }
        [Column]
        public string IE { get { return this.ie; } set { this.ie = value; } }
        [Column(name: "dataCadastro")]
        public DateTime DTCadastro { get { return this.dataCadastro; } set { this.dataCadastro = value; } }
        [Column]
        public int IDTabelaDePreco { get { return this.idTabelaDePreco; } set { this.idTabelaDePreco = value; } }
        [Column]
        public int Regime { get { return this.regime; } set { this.regime = value; } }
        [Column]
        public string OBSRomaneio { get { return this.obsRomaneio; } set { this.obsRomaneio = value; } }
        [Column]
        public bool Ativo { get { return this.ativo; } set { this.ativo = value; } }
        [Column(TypeName ="image")]
        public Image Logo { get { return this.logo; } set { this.logo = value; } }
        #endregion
    }
}
