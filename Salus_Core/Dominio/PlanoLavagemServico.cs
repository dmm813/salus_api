using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("PlanoLavagemServico")]
    public class PlanoLavagemServico
    {
        #region atributos
        private int idPlanoLavagemServico;
        private int idPlanoLavagem;
        private int idServico;


        #endregion

        #region contrutor
        public PlanoLavagemServico()
        {
            this.idPlanoLavagemServico = 0;
            this.IdPlanoLavagem = 0;
            this.idServico = 0;
        }
        #endregion

        #region propriedades
        [Column]
        [Key]
        public int IdPlanoLavagemServico
        {
            get
            {
                return idPlanoLavagemServico;
            }

            set
            {
                idPlanoLavagemServico = value;
            }
        }
        [Column]
        public int IdPlanoLavagem
        {
            get
            {
                return idPlanoLavagem;
            }

            set
            {
                idPlanoLavagem = value;
            }
        }
        [Column]
        public int IdServico
        {
            get
            {
                return idServico;
            }

            set
            {
                idServico = value;
            }
        }
        #endregion
    }
}
