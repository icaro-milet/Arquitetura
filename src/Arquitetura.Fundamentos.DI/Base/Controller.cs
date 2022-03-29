using Arquitetura.Fundamentos.DI.Base.Interfaces;

namespace Arquitetura.Fundamentos.DI.Base
{
    public class Controller
    {
        private readonly IRecepcaoService _recepcaoService;

        public Controller(IRecepcaoService recepcaoService)
        {
            _recepcaoService = recepcaoService;
        }

        public string Cumprimentar(string saudacao)
        {
            return _recepcaoService.Saudar(saudacao);
        }
    }
}
