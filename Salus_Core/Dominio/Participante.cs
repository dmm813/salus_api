namespace Salus_Core.Dominio
{
    public class Participante
    {
        private int id;
        private int codigo;
        private string nome;
        private string contato;



        public Participante()
        {
            id = 0;
            codigo = 0;
            nome = string.Empty;
            contato = string.Empty;
        }
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Contato
        {
            get
            {
                return contato;
            }

            set
            {
                contato = value;
            }
        }
    }
}
