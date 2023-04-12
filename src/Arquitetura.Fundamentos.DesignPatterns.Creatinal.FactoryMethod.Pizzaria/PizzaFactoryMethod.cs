namespace Arquitetura.Fundamentos.DesignPatterns.Creatinal.FactoryMethod.Pizzaria
{
    public abstract class PizzaFactoryMethod
    {
        public Pizza MontarPizza(string tipo)
        {
            Pizza pizza;
            pizza = CriarPizza(tipo);
            return pizza;
        }

        protected abstract Pizza CriarPizza(string tipo);
    }
}
