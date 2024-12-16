namespace Salus_Core.Dominio
{
    public class ContaBanariaBanco : ContaBancaria
    {
        private string descBanco;
        private int codBanco;

        public ContaBanariaBanco() : base()
        {
            descBanco = string.Empty;
            codBanco = 0;
        }

        public string DescBanco
        {
            get
            {
                return descBanco;
            }

            set
            {
                descBanco = value;
            }
        }

        public int CodBanco
        {
            get
            {
                return codBanco;
            }

            set
            {
                codBanco = value;
            }
        }
    }
}
