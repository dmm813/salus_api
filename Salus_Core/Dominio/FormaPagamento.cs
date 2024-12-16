using System.ComponentModel.DataAnnotations.Schema;


namespace Salus_Core.Dominio
{
    [Table("FormaPagamento")]
    public class FormaPagamento
    {
        #region Atributos
        private int idFormaPagamento;
        private int idCondPagamento;
        private int codFormaPagamento;
        private string formaPagamento;
        private int codECF;
        private string descricaoECF;
        #endregion

        #region Construtor
        public FormaPagamento()
        {
            this.idFormaPagamento = 0;
            this.idCondPagamento = 0;
            this.codFormaPagamento = 0;
            this.formaPagamento = "";
            this.codECF = 0;
            this.descricaoECF = "";
        }
        public FormaPagamento(int cod)
        {
            this.idFormaPagamento = 0;
            this.idCondPagamento = 0;
            this.codFormaPagamento = cod;
            this.formaPagamento = "";
            this.codECF = 0;
            this.descricaoECF = "";
        }
        public FormaPagamento(string s)
        {
            this.idFormaPagamento = 0;
            this.idCondPagamento = 0;
            this.codFormaPagamento = 0;
            this.formaPagamento = s;
            this.codECF = 0;
            this.descricaoECF = "";
        }

        #endregion

        #region propriedades
        [Column]
        public int IDFormaPagamento { get { return this.idFormaPagamento; } set { this.idFormaPagamento = value; } }
        [Column]
        public int IDCondPagamento { get { return this.idCondPagamento; } set { this.idCondPagamento = value; } }
        [Column]
        public int CodFormaPagamento { get { return this.codFormaPagamento; } set { this.codFormaPagamento = value; } }
        [Column(name: "formaPagamento")]
        public string Descricao { get { return this.formaPagamento; } set { this.formaPagamento = value; } }
        [Column]
        public int CODECF { get { return this.codECF; } set { this.codECF = value; } }
        [Column]
        public string DescricaoECF { get { return this.descricaoECF; } set { this.descricaoECF = value; } }
        #endregion
    }
}
