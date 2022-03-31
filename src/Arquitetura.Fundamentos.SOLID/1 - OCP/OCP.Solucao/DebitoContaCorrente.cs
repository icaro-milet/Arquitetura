namespace Arquitetura.Fundamentos.SOLID.OCP.Solucao
{
    public class DebitoContaCorrente : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            //Debitar conta corrente
            return FormatarTransacao();
        }
    }
}
