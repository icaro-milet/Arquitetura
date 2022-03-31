namespace Arquitetura.Fundamentos.SOLID.OCP.Solucao
{
    public class DebitoContaPoupanca : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            //Validar aniversário da conta
            //Debitar conta poupança
            return FormatarTransacao();
        }
    }
}
