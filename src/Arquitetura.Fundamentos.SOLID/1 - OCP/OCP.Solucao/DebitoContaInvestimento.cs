namespace Arquitetura.Fundamentos.SOLID.OCP.Solucao
{
    public class DebitoContaInvestimento : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            //Debitar conta investimento
            //Isentar taxas
            return FormatarTransacao();
        }
    }
}
