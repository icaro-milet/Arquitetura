namespace Arquitetura.Fundamentos.SOLID.SRP.Solucao
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime Cadastro { get; set; }

        public bool IsValid()
        {
            return EmailServices.IsValid(Email) && CPFServices.IsValid(CPF);
        }
    }
}
