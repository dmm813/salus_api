using Microsoft.Win32;
using System;

namespace Salus_Core.Util
{
    public static class ConfigRegistro
    {
        public static void ConfiguraRegistoNFSE()
        {
            try
            {
                //RegistryKey registro = Registry.CurrentUser.CreateSubKey("nfse");
                //registro.SetValue("Serie", "1");
                //registro.SetValue("OptanteSimples", "1");
                //registro.SetValue("IncCult", "2");
                //registro.SetValue("Status", "1");
                //registro.SetValue("path", "C:\\Salus\\nfse");
                //registro.SetValue("NaturezaOperacao", 3);
                //registro.SetValue("RegistroEspecialTributacao", 6);
                //registro.SetValue("InscricaoMunicipal", "000000000");
                

            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel Configurar Registro de nfse!" + ex.Message);
            }
        }

    }
}
