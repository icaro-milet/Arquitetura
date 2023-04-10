namespace Arquitetura.Fundamentos.DesignPatterns.Creational.FactoryMethod
{
    public class ConcreteVeiculoFactory : VeiculoFactory
    {
        public override IVeiculo ObterVeiculo(string categoria)
        {
            switch (categoria)
            {
                case "Pesado":
                    return new Caminhonete();
                case "Medio":
                    return new Carro();
                case "Leve":
                    return new Moto();
                default:
                    throw new ApplicationException(string.Format("Veiculo '{0}' não pode ser criado", categoria));
            }
        }
    }
}
