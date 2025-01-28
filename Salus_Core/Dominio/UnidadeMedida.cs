using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("UnidadeMedida")]
    public class UnidadeMedida
    {
        #region atributos

        private int _idUnidadeMedida;
        private int _codUnidadeMedida;
        private string _descricao;
        private string _sigla;


        #endregion

        #region Propriedade
        [Column]
        [Key]
        public int IdUnidadeMedida { get => _idUnidadeMedida; set => _idUnidadeMedida = value; }
        [Column]
        public int CodUnidadeMedida { get => _codUnidadeMedida; set => _codUnidadeMedida = value; }
        [Column]
        public string Descricao { get => _descricao; set => _descricao = value; }
        [Column]
        public string Sigla { get => _sigla; set => _sigla = value; }
        #endregion

        #region Construtor
        public UnidadeMedida()
        {
            this._idUnidadeMedida = 0;
            this._descricao = "";
            this._sigla = "";
            this._codUnidadeMedida = 0;
        }
        public UnidadeMedida(int codUnidade)
        {
            this._idUnidadeMedida = 0;
            this._descricao = "";
            this._sigla = "";
            this._codUnidadeMedida = codUnidade;

        }
        public UnidadeMedida(string descricao)
        {
            this._idUnidadeMedida = 0;
            this._descricao = descricao;
            this._sigla = "";
            this._codUnidadeMedida = 0;
        }
        #endregion
    }
}