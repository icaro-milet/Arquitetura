namespace Arquitetura.Fundamentos.DesignPatterns.Creational.FactoryMethod
{
    public abstract class VeiculoFactory
    {
        public abstract IVeiculo ObterVeiculo(string categoria);
    }
}
