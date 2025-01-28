using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("MovimentoEstoque")]
    class MovimentoEstoque
    {
        #region atributos
        private int idEstoque;
        private int idProduto;
        private double qtdeMovimento;
        private char tipoMovimento;
        private DateTime dataMovimento;
        private string descMovimento;

        #endregion

        #region propriedades
        [Column]
        [Key]
        public int IdEstoque { get => idEstoque; set => idEstoque = value; }
        [Column]
        public int IdProduto { get => idProduto; set => idProduto = value; }
        [Column(TypeName = "Decimal(10,2)")]
        public double QtdeMovimento { get => qtdeMovimento; set => qtdeMovimento = value; }
        [Column(TypeName = "char")]
        public char TipoMovimento { get => tipoMovimento; set => tipoMovimento = value; }
        [Column(TypeName = "Date")]
        public DateTime DataMovimento { get => dataMovimento; set => dataMovimento = value; }
        [Column]
        public string DescMovimento { get => descMovimento; set => descMovimento = value; }

       #endregion


    }
}
