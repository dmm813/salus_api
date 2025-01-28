using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("Servico")]
    public class Servico
    {
        #region Atributos
        private int idServico;
        private int codServico;
        private string descricao;
        private double valor;
        #endregion

        #region Construtor
        public Servico()
        {
            this.idServico = 0;
            this.codServico = 0;
            this.descricao = "";
            this.valor = 0;
        }
        public Servico(string descricao)
        {
            this.idServico = 0;
            this.codServico = 0;
            this.descricao = descricao;
            this.valor = 0;
        }

        #endregion

        #region Propriedades
        [Column]
        [Key]
        public int IdServico { get { return this.idServico; } set { this.idServico = value; } }
        [Column(name: "codServico")]
        public int CodServico { get { return this.codServico; } set { this.codServico = value; } }
        [Column]
        public string DescServico { get { return this.descricao; } set { this.descricao = value; } }
        #endregion

        [Column(TypeName = "decimal(10,2)")]
        public double Valor { get { return this.valor; } set { this.valor = value; } }

    }
}
