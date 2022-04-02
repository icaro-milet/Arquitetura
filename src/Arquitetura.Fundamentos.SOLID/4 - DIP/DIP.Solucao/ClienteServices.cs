using Arquitetura.Fundamentos.SOLID.DIP.Solucao.Interfaces;

namespace Arquitetura.Fundamentos.SOLID.DIP.Solucao
{
    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailServices _emailServices;

        public ClienteServices(
            IClienteRepository clienteRepository,
            IEmailServices emailServices)
        {
            _clienteRepository = clienteRepository;
            _emailServices = emailServices;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.IsValid())
                return "Dados inválidos";

            _clienteRepository.AdicionarCliente(cliente);

            _emailServices.Enviar("empresa@empresa.com", cliente.Email,
                "Bem-vindo", "Parabéns, cadastro efetuado com sucesso.");

            return "Cliente cadastrado com sucesso.";
        }
    }
}
