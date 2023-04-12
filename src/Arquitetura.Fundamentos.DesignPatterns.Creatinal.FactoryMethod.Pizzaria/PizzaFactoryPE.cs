namespace Arquitetura.Fundamentos.DesignPatterns.Creatinal.FactoryMethod.Pizzaria
{
    public class PizzaFactoryPE : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            if (tipo.Equals("M"))
                return new PizzaMussarelaPE();
            else
                return null;
        }
    }
}
