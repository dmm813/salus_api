using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("Baixa")]
    public class Baixa
    {
        #region Aributos
        private int idBaixa;
        private int idUsuario;
        private int idOrdemServico;
        private int idFormaPagamento;
        private int codBaixa;
        private DateTime dataBaixa;
        private double qtdePecas;
        private double valor;
        private double desconto;
        private int idCaixa;
        #endregion

        #region
        public Baixa()
        {
            this.idBaixa = 0;
            this.idUsuario = 0;
            this.idOrdemServico = 0;
            this.idFormaPagamento = 0;
            this.codBaixa = 0;
            this.dataBaixa = new DateTime();
            this.qtdePecas = 0;
            this.valor = 0;
            this.desconto = 0;
            idCaixa = 0;


        }
        #endregion

        #region Propriedades
        [Column]
        [Key]
        public int IDBaixa { get { return this.idBaixa; } set { this.idBaixa = value; } }
        [Column]
        [ForeignKey("Usuario")]
        public int IDUsuario { get { return this.idUsuario; } set { this.idUsuario = value; } }
        [Column]
        [ForeignKey("OrdemServico")]
        public int IdOrdemServico { get { return this.idOrdemServico; } set { this.idOrdemServico = value; } }
        [Column]
        public int IDFormaPagamento { get { return this.idFormaPagamento; } set { this.idFormaPagamento = value; } }
        [Column("codBaixa")]
        public int CODBaixa { get { return this.codBaixa; } set { this.codBaixa = value; } }
        [Column(TypeName = "datetime")]
        public DateTime DataBaixa { get { return this.dataBaixa; } set { this.dataBaixa = value; } }
        [Column(name:"qtdePeca", TypeName = "decimal(10,2)")]
        public double QTDEPecas { get { return this.qtdePecas; } set { this.qtdePecas = value; } }
        [Column(TypeName = "decimal(10,2)")]
        public double Valor { get { return this.valor; } set { this.valor = value; } }
        [Column(TypeName = "decimal(10,2)")]
        public double Desconto { get { return this.desconto; } set { this.desconto = value; } }
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
