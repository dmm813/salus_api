using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Salus_Core.Dominio
{
    [Table("UserAtivo")]
    public class UserAtivo
    {
        #region atributos
        private int idUserAtivo;
        private string ip;
        private DateTime data;
        private string horaInicio;
        private string horaFim;
        private bool ativo;



        #endregion

        #region Construtor
        public UserAtivo()
        {
            this.idUserAtivo = 0;
            this.ip = "";
            this.data = new DateTime();
            this.horaInicio = "";
            this.horaFim = "";
            this.ativo = false;
        }
        #endregion

        #region Propriedades
        [Column]
        [Key]
        public int IdUserAtivo
        {
            get
            {
                return idUserAtivo;
            }

            set
            {
                idUserAtivo = value;
            }
        }
        [Column(TypeName = "varchar")]
        public string Ip
        {
            get
            {
                return ip;
            }

            set
            {
                ip = value;
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
        [Column(TypeName = "varchar")]
        public string HoraInicio
        {
            get
            {
                return horaInicio;
            }

            set
            {
                horaInicio = value;
            }
        }
        [Column(TypeName = "varchar")]
        public string HoraFim
        {
            get
            {
                return horaFim;
            }

            set
            {
                horaFim = value;
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

        #endregion
    }
}
