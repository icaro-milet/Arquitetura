namespace Arquitetura.Fundamentos.OOP
{
    public class Funcionario : Pessoa
    {
        public DateTime Admissao { get; set; }
        public string Registro { get; set; }
    }

    public class Processo
    {
        public void Executar()
        {
            var funcionario = new Funcionario()
            {
                Nome = "Marcos",
                Nascimento = new DateTime(1980, 4, 20),
                Admissao = DateTime.Now,
                Registro = "123"
            };
        }
    }
}
