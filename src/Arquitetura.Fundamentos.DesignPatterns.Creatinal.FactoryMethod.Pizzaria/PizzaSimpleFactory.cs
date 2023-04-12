namespace Arquitetura.Fundamentos.DesignPatterns.Creatinal.FactoryMethod.Pizzaria
{
    public class PizzaSimpleFactory
    {
        public static PizzaFactoryMethod CriarPizzaria(string local)
        {
            PizzaFactoryMethod pizzaria;

            switch (local)
            {
                case "P":
                    pizzaria = new PizzaFactoryPE();
                    break;
                case "S":
                    pizzaria = new PizzaFactorySP();
                    break;
                default:
                    throw new ApplicationException($"A pizzaria {local} não válida.");
            }

            return pizzaria;
        }
    }
}
