using Salus_Core.DAL;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Salus_Core.Util
{
    public static class Validador
    {
        #region Atributos
        private static UsuarioDAL DALUsuario = new UsuarioDAL();
        private static bool sucesso;

        public static bool Sucesso
        {
            get
            {
                return sucesso;
            }

            set
            {
                sucesso = value;
            }
        }
        #endregion


        #region Valida numero/string
        public static bool IsNumeroInteiro(string numero)
        {
            int i = 0;
            return int.TryParse(numero, out i);
        }
        public static bool IsNumeroReal(string numero)
        {
            double i = 0;
            return double.TryParse(numero, out i);
        }

        public static bool IsStringValida(string str)
        {
            return !(String.IsNullOrEmpty(str.Trim()) && String.IsNullOrWhiteSpace(str.Trim()));
        }
        public static bool SoDigitaNumero(string str)
        {
            if (IsStringValida(str))
            {
                if (!IsNumeroReal(str))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool ValidaDiferenca(int ini, int fim)
        {
            return ((ini - fim) >= 0);
        }
        #endregion

        public static bool ValidaPeriodo(DateTime ini, DateTime fim)
        {
            return (int.Parse((fim.Day - ini.Day).ToString()) >= 0);
        }


        public static bool VerificaLista(List<Object> lista)
        {
            return lista.Count >= 0;
        }
        #region valida login usuario
        //public static bool ValidaAdmin(Usuario user)
        //{
        //    if (user.Login.Equals(Properties.Settings.Default.admin) && user.Senha.Equals(Properties.Settings.Default.senha))
        //    {
        //        return true;
        //    }
        //    else if (DALUsuario.SelecionaUsuarioLoginSenha(user).Count > 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        public static bool VerificaLogin(string login)
        {
            if (new UsuarioDAL().RetornaQuantidadeLong(login) > 0)
            {
                return false;
            }
            return true;
        }

        public static bool ConfirmaSenha(string pass, string passConfirm)
        {
            return pass.Equals(passConfirm);
        }


        #endregion


        #region Valida Documento
        public static bool ValidaCPF(string vrCPF)
        {
            if (vrCPF.Equals("11111111111")) return true;

            string valor = vrCPF.Replace(".", "");
            valor = valor.Replace("-", "");
            if (valor.Length != 11)
                return false;
            bool igual = true;
            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;
            if (igual || valor == "12345678909")
                return false;
            int[] numeros = new int[11];
            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(valor[i].ToString());
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];
            int resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false; soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];
            resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else if (numeros[10] != 11 - resultado)
                return false;
            return true;
        }


        public static bool ValidaCNPJ(string vrCNPJ)
        {
            if (vrCNPJ.Equals("11111111111111")) return true;

            string CNPJ = vrCNPJ.Replace(".", "");
            CNPJ = CNPJ.Replace("/", "");
            CNPJ = CNPJ.Replace("-", "");
            int[] digitos, soma, resultado;
            int nrDig;
            string ftmt;
            bool[] CNPJOk;
            ftmt = "6543298765432";
            digitos = new int[14];
            soma = new int[2];
            soma[0] = 0;
            soma[1] = 0;
            resultado = new int[2];
            resultado[0] = 0;
            resultado[1] = 0;
            CNPJOk = new bool[2];
            CNPJOk[0] = false;
            CNPJOk[1] = false;
            try
            {
                for (nrDig = 0; nrDig < 14; nrDig++)
                {
                    digitos[nrDig] = int.Parse(CNPJ.Substring(nrDig, 1));
                    if (nrDig <= 11) soma[0] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig + 1, 1)));
                    if (nrDig <= 12) soma[1] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig, 1)));
                }
                for (nrDig = 0; nrDig < 2; nrDig++)
                {
                    resultado[nrDig] = (soma[nrDig] % 11);
                    if ((resultado[nrDig] == 0) || (resultado[nrDig] == 1))
                        CNPJOk[nrDig] = (digitos[12 + nrDig] == 0);
                    else
                        CNPJOk[nrDig] = (digitos[12 + nrDig] == (11 - resultado[nrDig]));
                }
                return (CNPJOk[0] && CNPJOk[1]);
            }
            catch
            { return false; }
        }
        public static bool ValidarEmail(String email)
        {
            bool emailValido = false;

            //Expressão regular retirada de
            //https://msdn.microsoft.com/pt-br/library/01escwtf(v=vs.110).aspx
            string emailRegex = string.Format("{0}{1}",
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))",
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");

            try
            {
                emailValido = Regex.IsMatch(
                    email,
                    emailRegex);
            }
            catch (RegexMatchTimeoutException)
            {
                emailValido = false;
            }

            return emailValido;
        }
        #endregion


    }
}
