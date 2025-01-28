namespace Salus_Core.Dominio
{
    public class VendaItemPeca : VendaItem
    {
        private int codPeca;
        private string referencia;
        private string descricaoPeca;

        public VendaItemPeca() : base()
        {
            this.codPeca = 0;
            this.Referencia = "";
            this.descricaoPeca = "";
        }

        public int CodPeca
        {
            get
            {
                return this.codPeca;
            }

            set
            {
                this.codPeca = value;
            }
        }

        public string DescricaoPeca
        {
            get
            {
                return this.descricaoPeca;
            }

            set
            {
                this.descricaoPeca = value;
            }
        }

        public string Referencia
        {
            get
            {
                return this.referencia;
            }

            set
            {
                this.referencia = value;
            }
        }
    }
}
