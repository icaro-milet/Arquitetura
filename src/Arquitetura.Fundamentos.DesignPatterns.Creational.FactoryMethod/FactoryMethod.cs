namespace Arquitetura.Fundamentos.DesignPatterns.Creational.FactoryMethod
{
    public class FactoryMethod
    {
        public static void Execucao()
        {
            var factory = new ConcreteVeiculoFactory();

            var moto = factory.ObterVeiculo("Leve");
            moto.Limite(300);

            var carro = factory.ObterVeiculo("Medio");
            carro.Limite(250);

            var caminhonete = factory.ObterVeiculo("Pesado");
            caminhonete.Limite(180);
        }
    }
}
