// See https://aka.ms/new-console-template for more information
using Arquitetura.Fundamentos.DesignPatterns.Creatinal.FactoryMethod.Pizzaria;

Console.WriteLine("============ P I Z Z A R I A ============");
Console.WriteLine("Informe o local 'P' Pernambuco 'S' São Paulo");
var localEscolhido = Console.ReadLine().ToUpper();

Console.WriteLine("Escolha tipo de pizza 'M' para Mussarela");
var pizzaEscolhida = Console.ReadLine().ToUpper();

try
{
	PizzaFactoryMethod pizzaria = PizzaSimpleFactory.CriarPizzaria(localEscolhido);

	var pizza = pizzaria.MontarPizza(pizzaEscolhida);

    Console.WriteLine(pizza.Preparar());
    Console.WriteLine("\nPizza concluída com sucesso");
}
catch (Exception ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}

Console.ReadLine();
