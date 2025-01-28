using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table(name: "Log_Sistema")]
    public class LogSistema
    {
        #region atributos
        private int idLog;
        private int idUsuario;
        private DateTime data;
        private string instrucao;
        private string tabela;
        private string erro;
        #endregion

        #region Construtor
        public LogSistema()
        {
            this.idLog = 0;
            this.idUsuario = 0;
            this.data = new DateTime();
            this.instrucao = "";
            this.tabela = "";
            this.erro = "";
        }
        #endregion

        #region Propriedades
        [Column]
        [Key]
        public int IDLog { get { return this.idLog; } set { this.idLog = value; } }
        [Column]
        public int IDUsuario { get { return this.idUsuario; } set { this.idUsuario = value; } }
        [Column(TypeName = "smalldatetime")]
        public DateTime Data { get { return this.data; } set { this.data = value; } }
        [Column]
        public string Instrucao { get { return this.instrucao; } set { this.instrucao = value; } }
        [Column]
        public string Tabela { get { return this.tabela; } set { this.tabela = value; } }
        [Column]
        public string Erro { get { return this.erro; } set { this.erro = value; } }
        #endregion
    }
}
