using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("VendaItem")]
    public class VendaItem
    {
        #region Atributos
        private int idVendaItem;
        private int idProduto;
        private int idVenda;
        private int qtde;
        private double peso;
        private double valorUnitario;

        #endregion

        #region Construtor
        public VendaItem()
        {
            this.idVendaItem = 0;
            this.idProduto = 0;
            this.idVenda = 0;
            this.qtde = 0;
            this.valorUnitario = 0;
            this.peso = 0;
        }
        #endregion

        #region Propriedades
        [Column]
        [Key]
        public int IdVendaItem
        {
            get
            {
                return this.idVendaItem;
            }

            set
            {
                this.idVendaItem = value;
            }
        }
        [Column]
        public int IdVenda
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
        public int Qtde
        {
            get
            {
                return this.qtde;
            }

            set
            {
                this.qtde = value;
            }
        }
        [Column(TypeName = "decimal(10,2)")]
        public double Peso
        {
            get
            {
                return this.peso;
            }

            set
            {
                this.peso = value;
            }
        }
        [Column(TypeName = "decimal(10,2)")]
        public double ValorUnitario
        {
            get
            {
                return this.valorUnitario;
            }

            set
            {
                this.valorUnitario = value;
            }
        }
        [Column]
        public int IdProduto
        {
            get
            {
                return idProduto;
            }

            set
            {
                idProduto = value;
            }
        }
        #endregion
    }
}
