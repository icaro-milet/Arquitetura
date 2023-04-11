namespace Arquitetura.Fundamentos.OOP._7___Heranca_e_Associação
{
    public class Carro
    {
        private int ano;
        private string marca;
        private Motor motor;

        public void Acelerar() 
        {
            motor.Ligar();
            motor.Combustao();
        }
    }
}
