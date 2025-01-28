using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Salus_Core.Dominio
{
    [Table("ConfigSalus")]
    public class ConfigSalus
    {
        #region  atributos
        private int idConfigSalus;
        private string docCli;
        private DateTime dataInicio;
        private bool manutencionista;
        private int diaVencimentoManutencão;
        private int tolerencia;
        private int nUserSimutaneos;



        #endregion

        #region construtor
        public ConfigSalus()
        {
            this.idConfigSalus = 0;
            this.docCli = "";
            this.dataInicio = new DateTime();
            this.manutencionista = false;
            this.diaVencimentoManutencão = 10;
            this.tolerencia = 5;
            this.nUserSimutaneos = 1;
        }
        #endregion

        #region propriedades
        [Column]
        [Key]
        public int IdConfigSalus
        {
            get
            {
                return idConfigSalus;
            }

            set
            {
                idConfigSalus = value;
            }
        }
        [Column(TypeName = "vachar")]
        public string DocCli
        {
            get
            {
                return docCli;
            }

            set
            {
                docCli = value;
            }
        }
        [Column(TypeName = "date")]
        public DateTime DataInicio
        {
            get
            {
                return dataInicio;
            }

            set
            {
                dataInicio = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool Manutencionista
        {
            get
            {
                return manutencionista;
            }

            set
            {
                manutencionista = value;
            }
        }
        [Column]
        public int DiaVencimentoManutencão
        {
            get
            {
                return diaVencimentoManutencão;
            }

            set
            {
                diaVencimentoManutencão = value;
            }
        }
        [Column]
        public int Tolerencia
        {
            get
            {
                return tolerencia;
            }

            set
            {
                tolerencia = value;
            }
        }
        [Column]
        public int NUserSimutaneos
        {
            get
            {
                return nUserSimutaneos;
            }

            set
            {
                nUserSimutaneos = value;
            }
        }
        #endregion
    }
}
