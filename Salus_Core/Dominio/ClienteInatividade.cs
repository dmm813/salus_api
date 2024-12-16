using System;

namespace Salus_Core.Dominio
{
    public class ClienteInatividade : Cliente
    {
        private int inatividade;
        private DateTime dataUltimaAtividade;

        public ClienteInatividade() : base()
        {
            this.inatividade = 0;
        }
        public int Inantividade
        {
            get { return this.inatividade; }

            set { this.inatividade = value; }
        }
        public DateTime DataUltimaAtividade
        {
            get { return this.dataUltimaAtividade; }
            set { this.dataUltimaAtividade = value; }
        }
    }
}
