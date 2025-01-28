namespace Salus_Core.Dominio
{
    public class PlanoClientePlano : ClientePlano
    {
        private double valor;
        private string descPlano;

        public PlanoClientePlano() : base()
        {
            valor = 0;
            descPlano = string.Empty;
        }

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

        public string DescPlano
        {
            get
            {
                return descPlano;
            }

            set
            {
                descPlano = value;
            }
        }
    }
}
