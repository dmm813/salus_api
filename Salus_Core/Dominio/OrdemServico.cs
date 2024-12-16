using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("OrdemServico")]
    public class OrdemServico
    {
        #region Atributos
        private int idOrdemServico;
        private int idCliente;
        private int idEmpresa;
        private int idSetor;
        private int codOrdemServico;
        private double qtdePecas;
        private double pesoPecas;
        private DateTime dataInicio;
        private DateTime dataFim;
        private string horaInicio;
        private string horaFim;
        private string status;
        private double valor;
        private double valorDesconto;
        private double valorPeso;
        private double credito;
        private bool exclusao;
        private string obsOS;
        private int cabide;
        #endregion

        #region Construtor
        public OrdemServico()
        {
            this.idOrdemServico = 0;
            this.idCliente = 0;
            this.idEmpresa = 0;
            this.idSetor = 0;
            this.codOrdemServico = 0;
            this.qtdePecas = 0;
            this.pesoPecas = 0;
            this.dataFim = new DateTime();
            this.dataInicio = new DateTime();
            this.horaInicio = "";
            this.horaFim = "";
            this.status = "A";
            this.valor = 0.0;
            this.valorDesconto = 0.0;
            this.valorPeso = 0;
            this.credito = 0;
            this.exclusao = false;
            this.obsOS = "";
            this.cabide = 0;
        }
        public OrdemServico(int num)
        {
            this.idOrdemServico = 0;
            this.idCliente = 0;
            this.idEmpresa = 0;
            this.idSetor = 0;
            this.codOrdemServico = num;
            this.qtdePecas = 0;
            this.pesoPecas = 0;
            this.dataFim = new DateTime();
            this.dataInicio = new DateTime();
            this.horaInicio = "";
            this.horaFim = "";
            this.status = "A";
            this.valor = 0.0;
            this.valorDesconto = 0.0;
            this.valorPeso = 0;
            this.credito = 0;
            this.exclusao = false;
            this.obsOS = "";
            this.cabide = 0;
        }
        #endregion

        #region propriedades
        [Column]
        [Key]
        public int IdOrdemServico { get { return this.idOrdemServico; } set { this.idOrdemServico = value; } }
        [Column]
        public int IdCliente { get { return this.idCliente; } set { this.idCliente = value; } }
        [Column]
        public int IdEmpresa { get { return this.idEmpresa; } set { this.idEmpresa = value; } }
        [Column]
        public int IdSetor { get { return this.idSetor; } set { this.idSetor = value; } }
        [Column(TypeName = "int")]
        public int CodOrdemServico { get { return this.codOrdemServico; } set { this.codOrdemServico = value; } }
        [Column(TypeName = "Decimal(10,2)")]
        public double QTDEPecas { get { return this.qtdePecas; } set { this.qtdePecas = value; } }
        [Column(TypeName = "Decimal(10,2)")]
        public double PesoPecas { get { return this.pesoPecas; } set { this.pesoPecas = value; } }
        [Column(TypeName = "smalldatetime")]
        public DateTime DataInicio { get { return this.dataInicio; } set { this.dataInicio = value; } }
        [Column(name: "dataFinal",TypeName = "smalldatetime")]
        public DateTime DataFim { get { return this.dataFim; } set { this.dataFim = value; } }
        [Column]
        public string HoraInicio { get { return this.horaInicio; } set { this.horaInicio = value; } }
        [Column]
        public string OBSOS { get { return this.obsOS; } set { this.obsOS = value; } }
        [Column]
        public string HoraFim { get { return this.horaFim; } set { this.horaFim = value; } }
        [Column(TypeName = "char")]
        public string Status { get { return this.status; } set { this.status = value; } }
        [Column(TypeName = "Decimal(10,2)")]
        public double Valor { get { return this.valor; } set { this.valor = value; } }
        [Column(TypeName = "Decimal(10,2)")]
        public double ValorDesconto { get { return this.valorDesconto; } set { this.valorDesconto = value; } }
        [Column(TypeName = "Decimal(10,2)")]
        public double ValorPeso { get { return this.valorPeso; } set { this.valorPeso = value; } }
        [Column(TypeName = "Decimal(10,2)")]
        public double Credito { get { return this.credito; } set { this.credito = value; } }
        [Column(TypeName = "bit")]
        public bool Exclusao { get { return this.exclusao; } set { this.exclusao = value; } }
        [Column]
        public int Cabide
        {
            get
            {
                return cabide;
            }

            set
            {
                cabide = value;
            }
        }
        #endregion
    }
}
