using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Salus_Core.Dominio
{
    [Table("Usuario")]
    public class Usuario
    {
        #region Atributos
        private int idUsuario;
        private int codUsuario;
        private int idNivelAcesso;
        private string login;
        private string senha;
        private bool acInserir;
        private bool acExcluir;
        private bool acEditar;
        private bool exclusao;
        #endregion

        #region Construtor
        public Usuario()
        {
            this.idUsuario = 0;
            this.codUsuario = 0;
            this.idNivelAcesso = 0;
            this.login = "";
            this.acExcluir = true;
            this.acInserir = true;
            this.acEditar = true;
            this.senha = "";

        }
        public Usuario(string log, string pass)
        {
            this.idUsuario = 0;
            this.codUsuario = 0;
            this.idNivelAcesso = 0;
            this.login = log;
            this.senha = pass;

        }
        public Usuario(int cod)
        {
            this.idUsuario = 0;
            this.codUsuario = cod;
            this.idNivelAcesso = 0;
            this.login = "";
            this.senha = "";
        }

        #endregion

        #region propriedades
        [Column]
        [Key]
        public int IDUsuario { get { return this.idUsuario; } set { this.idUsuario = value; } }
        [Column]
        public int CODUsuario { get { return this.codUsuario; } set { this.codUsuario = value; } }
        [Column]
        public int IDNivelAcesso { get { return this.idNivelAcesso; } set { this.idNivelAcesso = value; } }
        [Column]
        public string Login { get { return this.login; } set { this.login = value; } }
        [Column]
        public string Senha { get { return this.senha; } set { this.senha = value; } }
        [Column(TypeName = "bit")]
        public bool Exclusao { get { return this.exclusao; } set { this.exclusao = value; } }
        [Column(TypeName = "bit")]
        public bool AcInserir
        {
            get
            {
                return acInserir;
            }

            set
            {
                acInserir = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool AcExcluir
        {
            get
            {
                return acExcluir;
            }

            set
            {
                acExcluir = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool AcEditar
        {
            get
            {
                return acEditar;
            }

            set
            {
                acEditar = value;
            }
        }
        #endregion
    }
}

