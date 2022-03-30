namespace Arquitetura.Fundamentos.OOP
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }

        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - Nascimento.Year;

            return idade;
        }
    }
}
