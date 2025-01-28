using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Salus_Core.Dominio
{
    [Table("Caixa")]
    public class Caixa
    {
        #region Propriedades
        private int idCaixa;
        private int idEmpresa;
        private int idUsuario;
        private int numeroCaixa;
        private DateTime dataAbertura;
        private string horaAbertura;
        private double valorAbertura;
        private DateTime? dataFechamento;
        private string horaFechamento;
        private double? valorFechamento;
        private string status;
        #endregion

        #region Construtores
        public Caixa()
        {
            this.idCaixa = 0;
            this.idEmpresa = 0;
            this.idUsuario = 0;
            this.numeroCaixa = 0;
            this.dataAbertura = new DateTime();
            this.horaAbertura = string.Empty;
            this.valorAbertura = 0;
            this.dataFechamento = new DateTime();
            this.horaFechamento = string.Empty;
            this.valorFechamento = 0;
            this.status = "A";
        }
        #endregion

        #region Propriedades
        [Column]
        [Key]
        public int IDCaixa { get { return this.idCaixa; } set { this.idCaixa = value; } }
        [Column]
        [ForeignKey("Empresa")]
        public int IDEmpresa { get { return this.idEmpresa; } set { this.idEmpresa = value; } }
        [Column]
        [ForeignKey("Usuario")]
        public int IDUsuario { get { return this.idUsuario; } set { this.idUsuario = value; } }
        [Column]
        public int NumeroCaixa { get { return this.numeroCaixa; } set { this.numeroCaixa = value; } }
        [Column(TypeName = "datetime")]
        public DateTime DataAbertura { get { return this.dataAbertura; } set { this.dataAbertura = value; } }
        [Column]
        public string HoraAbertura { get { return this.horaAbertura; } set { this.horaAbertura = value; } }
        [Column(TypeName = "decimal(10,2)")]
        public double ValorAbertura { get { return this.valorAbertura; } set { this.valorAbertura = value; } }
        [Column(TypeName = "datetime")]
        public DateTime? DataFechamento { get { return this.dataFechamento; } set { this.dataFechamento = value; } }
        [Column]
        public string HoraFechamento { get { return this.horaFechamento; } set { this.horaFechamento = value; } }
        [Column(TypeName = "decimal(10,2)")]
        public double? ValorFechamento { get { return this.valorFechamento; } set { this.valorFechamento = value; } }
        [Column(TypeName = "char")]
        public string Status { get { return this.status; } set { this.status = value; } }
        #endregion
    }


}
