namespace Arquitetura.Fundamentos.DesignPatterns.Creational.FactoryMethod
{
    public class Caminhonete : IVeiculo
    {
        public void Limite(int limite)
        {
            Console.WriteLine("Limite de velocidade Caminhonete: " + limite);
        }
    }
}
