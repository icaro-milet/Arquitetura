namespace Arquitetura.Fundamentos.OOP
{
    //Herança
    //"é um"
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
    }

    //Composição no lugar da herança
    //"tem um"
    public class Garagem
    {
        private readonly Carro _carro;

        public Garagem(Carro carro)
        {
            _carro = carro;
        }
    }
}
