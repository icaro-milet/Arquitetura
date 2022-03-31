namespace Arquitetura.Fundamentos.SOLID.LSP.Violacao
{
    public class CalculoArea
    {
        private static void ObterAreaRetangulo(Retangulo retangulo)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do Retangulo");
            Console.WriteLine();
            Console.WriteLine(retangulo.Altura + " * " + retangulo.Largura);
            Console.WriteLine();
            Console.WriteLine(retangulo.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            var quadrado = new Quadrado()
            {
                Altura = 10,
                Largura = 5
            };

            ObterAreaRetangulo(quadrado);
        }
    }
}
