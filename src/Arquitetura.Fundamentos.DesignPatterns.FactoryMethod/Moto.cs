namespace Arquitetura.Fundamentos.DesignPatterns.Creational.FactoryMethod
{
    public class Moto : IVeiculo
    {
        public void Limite(int limite)
        {
            Console.WriteLine("Limite de velocidade Moto: " + limite);
        }
    }
}
