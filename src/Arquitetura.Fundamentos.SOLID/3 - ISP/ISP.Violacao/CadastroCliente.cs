namespace Arquitetura.Fundamentos.SOLID.ISP.Violacao
{
    public class CadastroCliente : ICadastro
    {
        public void EnviarEmail()
        {
            //Enviar email para cliente
        }

        public void SalvarBanco()
        {
            //Insert na tabela Cliente
        }

        public void ValidarDados()
        {
            //Validar Documento, e-mail e etc.
        }
    }
}
