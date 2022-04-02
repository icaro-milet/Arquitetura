namespace Arquitetura.Fundamentos.SOLID.DIP.Violacao
{
    public class ClienteServices
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.IsValid())
            {
                return "Dados inválidos.";
            }

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            EmailServices.Enviar("empresa@empresa.com", cliente.Email, "Bem-vindo",
                "Parabéns, cadastro com sucesso.");

            return "Cliente cadastrado com sucesso";
        }
    }
}
