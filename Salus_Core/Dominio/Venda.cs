using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Salus_Core.Dominio
{
    [Table("Venda")]
    public class Venda
    {
        #region Atributos
        private int idVenda;
        private int numeroVenda;
        private int idCliente;
        private int idCaixa;
        private int idEmpresa;
        private DateTime data;
        private double valor;
        private double desconto;
        private bool exclusao;
        #endregion

        #region
        public Venda()
        {
            this.idVenda = 0;
            this.idCliente = 0;
            this.idEmpresa = 0;
            idCaixa = 0;
            this.data = new DateTime();
            this.valor = 0;
            this.desconto = 0;
            this.exclusao = false;
        }
        #endregion

        #region propriedades
        [Column]
        [Key]
        public int IDVenda
        {
            get
            {
                return this.idVenda;
            }
            set
            {
                this.idVenda = value;
            }
        }
        [Column]
        public int NumeroVenda
        {
            get
            {
                return this.numeroVenda;
            }

            set
            {
                this.numeroVenda = value;
            }
        }
        [Column]
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
        public int IdEmpresa
        {
            get
            {
                return idEmpresa;
            }

            set
            {
                idEmpresa = value;
            }
        }

        [Column(TypeName = "datetime(10,2)")]
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
        [Column(TypeName = "decimal(10,2)")]
        public double Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }
        [Column(TypeName = "decimal(10,2)")]

        public double Desconto
        {
            get
            {
                return desconto;
            }

            set
            {
                desconto = value;
            }
        }
        [Column(TypeName = "bit")]
        public bool Exclusao
        {
            get
            {
                return exclusao;
            }

            set
            {
                exclusao = value;
            }
        }
        [Column]
        public int IdCaixa
        {
            get
            {
                return idCaixa;
            }

            set
            {
                idCaixa = value;
            }
        }
        #endregion
    }
}
