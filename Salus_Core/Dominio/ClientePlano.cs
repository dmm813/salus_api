using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;


namespace Salus_Core.Dominio
{
    [Table("ClientePlano")]
    public class ClientePlano
    {
        #region atributos
        private int idClientePlano;
        private int idCliente;
        private int idPlano;
        private DateTime data;
        private bool ativo;


        #endregion

        #region propriedades
        public ClientePlano()
        {
            idClientePlano = 0;
            idCliente = 0;
            idPlano = 0;
            data = new DateTime();
            ativo = true;
        }
        #endregion

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
