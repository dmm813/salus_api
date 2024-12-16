namespace Salus_Core.Util
{
    public static class Listas
    {
        public enum nivelUsuario
        {
            usuario = 1,
            gerente,
            administardor
        }


        public enum tipoCliente
        {
            CLIENTE = 1,
            FORNECEDOR = 2
        }

        public enum grauInstrucao
        {
            FUNDAMENTAL_INCOMPLETO = 1,
            FUNDAMENTAL_COMPLETO,
            MEDIO_INCOMPLETO,
            MEDIO_COMPLETO,
            SUPERIOR_INCOMPLETO,
            SUPERIOR_COMPLETO,
            ESPECIALISTA,
            MESTRE,
            DOUTOR
        }

        public enum regimeEmpresa
        {
            SIMPLES = 1,
            LUCRO_PRESUMIDO,
            LUCRO_REAL

        }

        public enum tipoUsuario
        {
            CLIENTE = 1,
            FORNECEDOR,
            FUNCIONARIO
        }
        public enum TipoCheque
        {
            RECEBIDO = 1,
            EMITIDO
        }
        public enum SituacaoCheque
        {

            DEPOSITADO = 1,
            DEVOLVIDO,
            SACADO,
            TROCADO,
            PAGAMENTO_FORNECEDOR


        }
        public enum StatusCheque
        {
            BAIXADO = 1,
            ABERTO,
            REPASSADO
        }

        public enum CondPagamento
        {
            À_VISTA = 1,
            À_PRAZO

        }

        public enum ServEmail
        {
            GMAIL = 1,
            HOTMAIL_OUTLOOK,
            AOL,
            UOL,
            TERRA
        }
        public static string GetCodigoServico()
        {
            return "9609-2/99";
        }

        public enum Portas
        {
            USB = 1,
            COM1,
            COM2,
            COM3,
            COM4,
            LPT1,
            LPT2,

        }
        public enum tipoMovCaixa
        {
            SANGRIA = 1,
            PAGAMENTO,
            PROLABORE,
            VENDA,
            ORDEMSERVICO,
            DEPOSITO,
            BAIXA


        }

        public enum ImpBematech
        {
            MP4200THFI = 7,
            EPSONTMT20 = 1
        }
        public enum NaturezaOperacaoNFSE
        {

        }
        public enum TipoLancamento
        {
            CREDITO = 1,
            DEBITO
        }
        public enum TipoDocumento
        {
            BOLETO = 1,
            PROMISSORIA,
            NOTA_FISCAL,
            CHEQUE,
            CARNE,
            FATURADA
        }
        public enum TipoMovimentoEstoque
        {
            ENTRADA = 0,
            SAIDA
        }
        public enum UnidadeMedida
        {
            KG = 1,
            G,
            MT,
            CM,
            L
        }

    }
}