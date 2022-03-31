namespace Arquitetura.Fundamentos.SOLID.OCP.SolucaoExtensionMethods
{
    public static class DebitoContaPoupanca
    {
        public static string DebitarContaPoupanca(this DebitoConta debitoConta)
        {
            //Lógica de negócio para debitar a conta poupança
            return debitoConta.FormatarTransacao();
        }
    }
}
