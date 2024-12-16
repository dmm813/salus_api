using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("ClientePlano")]
    public class PlanoCliente
    {
        #region atributos
        private int idClientePlano;
        private int idPlano;
        private int idCliente;
        private DateTime data;
        private bool ativo;
        #endregion

        public PlanoCliente()
        {
            idClientePlano = 0;
            idPlano = 0;
            idCliente = 0;
            data = new DateTime();
            ativo = true;
        }

        [Column]
        [Key]
        public int IdClientePlano
        {
            get
            {
                return idClientePlano;
            }

            set
            {
                idClientePlano = value;
            }
        }
        [Column]
        [ForeignKey("Plano")]
        public int IdPlano
        {
            get
            {
                return idPlano;
            }

            set
            {
                idPlano = value;
            }
        }
        [Column]
        [ForeignKey("Cliente")]
        public int IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
            }
        }
        [Column(TypeName = "date")]
        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool Ativo
        {
            get
            {
                return ativo;
            }

            set
            {
                ativo = value;
            }
        }
    }
}
