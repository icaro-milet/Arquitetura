namespace Arquitetura.Fundamentos.DesignPatterns.Creational.FactoryMethod
{
    public class Carro : IVeiculo
    {
        public void Limite(int limite)
        {
            Console.WriteLine("Limite de velocidade Carro: " + limite);
        }
    }
}
