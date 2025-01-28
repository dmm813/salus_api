using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("Insumo")]
    public class Insumo
    {
        private int idInsumo;
        private int codInsumo;
        private string descricao;
        private double valor;
        private DateTime dataCadastro;
        private double estoqueMinimo;
        private bool ativo;


        public Insumo()
        {
            this.idInsumo = 0;
            this.CodInsumo = 0;
            this.descricao = "";
            this.Valor = 0;
            this.DataCadastro = new DateTime();
            this.EstoqueMinimo = 0;
            this.Ativo = true;
        }

        [Column(name: "idInsumo")]
        public int IdIn { get => idInsumo; set => idInsumo = value; }
        [Column]
        public int CodInsumo { get => codInsumo; set => codInsumo = value; }
        [Column]
        public string Descricao { get => descricao; set => descricao = value; }
        [Column(name: "valorCompra =",TypeName ="Decimal(10.2)") ]
        public double Valor { get => valor; set => valor = value; }
        [Column(TypeName = "Date")]
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        [Column (name: "estoqueMinimo",TypeName ="Decimal(10,2)")]
        public double EstoqueMinimo { get => estoqueMinimo; set => estoqueMinimo = value; }
        [Column(TypeName = "Bit")]
        public bool Ativo { get => ativo; set => ativo = value; }
    }
}
