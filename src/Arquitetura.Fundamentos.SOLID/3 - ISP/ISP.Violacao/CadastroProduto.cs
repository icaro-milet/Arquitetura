namespace Arquitetura.Fundamentos.SOLID.ISP.Violacao
{
    public class CadastroProduto : ICadastro
    {
        public void EnviarEmail()
        {
            // Produto não tem e-mail. O que faço agora?
            throw new NotImplementedException("Esse método não serve para nada.");
        }

        public void SalvarBanco()
        {
            //Insert na tabela produto
        }

        public void ValidarDados()
        {
            //Validar valor
        }
    }
}
