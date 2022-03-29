using Arquitetura.Fundamentos.Lifetime.DI.Services.Interfaces;

namespace Arquitetura.Fundamentos.Lifetime.DI.Services
{
    public class Operation : IOperationTransient, IOperationSingleton, IOperationScoped
    {
        public Operation()
        {
            OperationId = Guid.NewGuid().ToString();
        }

        public string OperationId { get; }
    }
}
