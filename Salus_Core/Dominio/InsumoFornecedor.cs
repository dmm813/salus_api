namespace Salus_Core.Dominio
{
    public class InsumoFornecedor : Insumo
    {
        private int codFornecedor;
        private string nomeFornecedor;

        public int CodFornecedor { get => codFornecedor; set => codFornecedor = value; }
        public string NomeFornecedor { get => nomeFornecedor; set => nomeFornecedor = value; }

        public InsumoFornecedor() : base()
        {
            this.codFornecedor = 0;
            this.nomeFornecedor = "";
        }
    }
}
