using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Salus_Core.Dominio
{
    [Table("Fornecedor_Insumo")]
    public class FornecedorInsumo
    {
        #region Atributos
        private int idFornecedorInsumo;
        private int idFornecedor;
        private int idInsumo;
        #endregion

        public FornecedorInsumo()
        {
            this.IdFornecedorInsumo = 0;
            this.IdFornecedor = 0;
            this.IdInsumo = 0;
        }
        [Column]
        [Key]
        public int IdFornecedorInsumo { get => idFornecedorInsumo; set => idFornecedorInsumo = value; }
        [Column]
        [ForeignKey("Fornecedor")]
        public int IdFornecedor { get => idFornecedor; set => idFornecedor = value; }
        [Column]
        [ForeignKey("Fornecedor")]
        public int IdInsumo { get => idInsumo; set => idInsumo = value; }
    }
}
