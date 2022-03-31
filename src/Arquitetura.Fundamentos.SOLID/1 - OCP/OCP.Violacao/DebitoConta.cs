namespace Arquitetura.Fundamentos.SOLID.OCP.Violacao
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if (tipoConta == TipoConta.Corrente)
            {
                //Debita conta corrente
            }

            if (tipoConta == TipoConta.Poupanca)
            {
                //Valida aniversário da conta
                //Debita conta poupança
            }
        }
    }
}
