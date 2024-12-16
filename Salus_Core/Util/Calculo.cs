using System;

namespace Salus_Core.Util
{
    public static class Calculo
    {

        #region Metodos
        public static double ValorDesconto(double perc, double tot)
        {
            return (tot / 100) * perc;
        }

        public static double PercDesconto(double vldesc, double tot)
        {
            return (vldesc * 100) / tot;
        }

        public static int DeltaData(DateTime ini, DateTime fim)
        {
            return DateTime.Compare(ini, fim);
        }

        public static double ConvertPeso(string uc, string ub, double pc, double pb)
        {
            return 0;

        }
        public static string RetornaEspacaURI(string txt, int comp)
        {
            string retorno = string.Empty;
            if (txt.Length < comp)
            {
                int controle = comp - txt.Length;
                for (int i = 0; i < controle; i++)
                {
                    retorno += "%20";
                }

            }
            return retorno;
        }
        #endregion
    }
}

