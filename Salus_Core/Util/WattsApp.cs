using System;

namespace Salus_Core.Util
{
    public static class WattsApp
    {


        public static void EnviaWatts(string tel, string mens)
        {
            if (FormataTelefone(tel).Length == 14)
            {
                string url = "https://wa.me/" + FormataTelefone(tel) + "?text=" + mens;
                try
                {
                    System.Diagnostics.Process.Start("chrome.exe", url);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
            else
            {
                Console.WriteLine("Telefone inválido!");
            }



        }
        private static string FormataTelefone(string tel)
        {
            string retorno = "";

            if (tel.Length == 9)
            {
                retorno = "55084" + tel;
            }
            else if (tel.Length == 11)
            {
                retorno = "550" + tel;
            }
            else if (tel.Length == 12)
            {
                retorno = "55" + tel;
            }
            else
            {
                retorno = "";
            }
            return retorno;
        }
    }
}
