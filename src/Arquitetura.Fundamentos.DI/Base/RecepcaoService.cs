using Arquitetura.Fundamentos.DI.Base.Interfaces;

namespace Arquitetura.Fundamentos.DI.Base
{
    public class RecepcaoService : IRecepcaoService
    {
        public string Saudar(string nome) => $"Olá {nome}";

    }
}
