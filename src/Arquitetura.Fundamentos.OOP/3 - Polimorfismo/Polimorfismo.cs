namespace Arquitetura.Fundamentos.OOP
{
    public class Carro : Automotivo
    {
        public Carro(string nome, string chassis)
            : base(nome, chassis)
        {

        }

        public Carro()
            :base("Ferrari","XP123456")
        {

        }

        private static void AbrirPorta()
        {

        }
        private static void FecharPorta()
        {

        }

        private static void ColocarChaveIgnicao()
        {

        }

        public void Partir()
        {
            AbrirPorta();
            FecharPorta();
            ColocarChaveIgnicao();
            Ligar();
        }

        public override void Ligar()
        {
            // Verificar se a chave é valida
        }

        public override void Desligar()
        {
            // Resfriar motor
        }
    }
}
