namespace Arquitetura.Fundamentos.SOLID.SRP.Solucao
{
    public class ClienteServices
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.IsValid())
            {
                return "Dados inválidos.";
            }

            var repo = new ClienteRepositorio();
            repo.AdicionarCliente(cliente);

            EmailServices.Enviar("empresa@empresa.com", cliente.Email, "Bem-vindo", "Parabéns, está cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}
