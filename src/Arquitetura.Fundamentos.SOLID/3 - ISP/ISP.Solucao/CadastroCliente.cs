using Arquitetura.Fundamentos.SOLID.ISP.Solucao.Interfaces;

namespace Arquitetura.Fundamentos.SOLID.ISP.Solucao
{
    public class CadastroCliente : ICadastroCliente
    {
        public void EnviarEmail()
        {
            //Enviar e-mail para cliente
        }

        public void SalvarBanco()
        {
            //Insert na tabela de Cliente
        }

        public void ValidarDados()
        {
            //Validar CPF, E-mail...
        }
    }
}
