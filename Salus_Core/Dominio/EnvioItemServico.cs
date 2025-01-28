namespace Salus_Core.Dominio
{
    public class EnvioItemServico : EnvioItem
    {
        private int codServico;
        private string descservico;
        private int codMarca;
        private string descmarca;
        private int codCor;
        private string desccor;
        private string setorOrigem;
        private string setorDestino;



        public EnvioItemServico() : base()
        {
            codServico = 0;
            descservico = string.Empty;
            codMarca = 0;
            descmarca = string.Empty;
            codCor = 0;
            desccor = string.Empty;
            setorOrigem = string.Empty;
            setorDestino = string.Empty;
        }
        public int CodServico
        {
            get
            {
                return codServico;
            }

            set
            {
                codServico = value;
            }
        }



        public int CodMarca
        {
            get
            {
                return codMarca;
            }

            set
            {
                codMarca = value;
            }
        }


        public int CodCor
        {
            get
            {
                return codCor;
            }

            set
            {
                codCor = value;
            }
        }


        public string SetorOrigem
        {
            get
            {
                return setorOrigem;
            }

            set
            {
                setorOrigem = value;
            }
        }

        public string SetorDestino
        {
            get
            {
                return setorDestino;
            }

            set
            {
                setorDestino = value;
            }
        }

        public string Descservico
        {
            get
            {
                return descservico;
            }

            set
            {
                descservico = value;
            }
        }

        public string Descmarca
        {
            get
            {
                return descmarca;
            }

            set
            {
                descmarca = value;
            }
        }

        public string Desccor
        {
            get
            {
                return desccor;
            }

            set
            {
                desccor = value;
            }
        }
    }
}
