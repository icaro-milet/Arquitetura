namespace Arquitetura.Fundamentos.DesignPatterns.Creatinal.FactoryMethod.Pizzaria
{
    public class PizzaMussarelaPE : Pizza
    {
        public PizzaMussarelaPE()
        {
            Nome = "Pizza de Mussarela Pernambucana";
            massa = "Fina PE";
            molho = "Molho PE";
            ingredientes.Add("Queijo PE");
            ingredientes.Add("Requeijão PE");
        }
    }
}
