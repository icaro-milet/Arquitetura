namespace Arquitetura.Fundamentos.SOLID.OCP.SolucaoExtensionMethods
{
    public static class DebitoContaInvestimento
    {
        public static string DebitarContaInvestimento(this DebitoConta debitoConta)
        {
            //Lógica de negócio para debitar conta investimento
            return debitoConta.FormatarTransacao();
        }
    }
}
