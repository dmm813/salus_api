using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salus_Core.Dominio
{
    [Table("PlanoLavagem")]
    public class PlanoLavagem
    {
        #region atributos
        private int idPlanoLavagem;
        private int codPlanoLavagem;
        private string plano;
        private double valor;
        private double desconto;
        private bool planoFamilia;
        private bool exclusao;



        #endregion

        #region Construtor
        public PlanoLavagem()
        {
            this.idPlanoLavagem = 0;
            this.codPlanoLavagem = 0;
            this.plano = "";
            this.valor = 0;
            this.desconto = 0;
            this.PlanoFamilia = false;
            this.exclusao = false;
        }
        public PlanoLavagem(int cod)
        {
            this.idPlanoLavagem = 0;
            this.codPlanoLavagem = cod;
            this.plano = "";
            this.valor = 0;
            this.desconto = 0;
            this.PlanoFamilia = false;
            this.exclusao = false;
        }
        public PlanoLavagem(string p)
        {

            this.idPlanoLavagem = 0;
            this.codPlanoLavagem = 0;
            this.plano = p;
            this.valor = 0;
            this.desconto = 0;
            this.PlanoFamilia = false;
            this.exclusao = false;
        }
        #endregion

        #region Propriedades
        [Column]
        [Key]
        public int IdPlanoLavagem
        {
            get
            {
                return idPlanoLavagem;
            }

            set
            {
                idPlanoLavagem = value;
            }
        }
        [Column]
        public int CodPlanoLavagem
        {
            get
            {
                return codPlanoLavagem;
            }

            set
            {
                codPlanoLavagem = value;
            }
        }
        [Column]
        public string Plano
        {
            get
            {
                return plano;
            }

            set
            {
                plano = value;
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
        [Column(TypeName = "bit")]
        public bool PlanoFamilia
        {
            get
            {
                return planoFamilia;
            }

            set
            {
                planoFamilia = value;
            }
        }
        #endregion
    }
}
