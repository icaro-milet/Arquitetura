namespace Arquitetura.Fundamentos.DesignPatterns.Creatinal.FactoryMethod.Pizzaria
{
    internal class PizzaMussarelaSP : Pizza
    {
        public PizzaMussarelaSP()
        {
            Nome = "Pizza de Mussarela Paulista";
            massa = "Fina SP";
            molho = "Molho SP";
            ingredientes.Add("Queijo SP");
            ingredientes.Add("Requeijão SP");
        }
    }
}
