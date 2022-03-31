namespace Arquitetura.Fundamentos.SOLID.OCP.SolucaoExtensionMethods
{
    public static class DebitoContaCorrente
    {
        public static string DebitarContaCorrente(this DebitoConta debitoConta)
        {
            //Lógica de negócio para debitar conta corrente
            return debitoConta.FormatarTransacao();
        }
    }
}
