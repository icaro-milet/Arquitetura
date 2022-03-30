namespace Arquitetura.Fundamentos.OOP
{
    public class AutomacaoCarro
    {
        public void PilotarCarro()
        {
            var carro = new Carro();

            carro.Ligar();
            carro.Partir();
            carro.Desligar();
        }
    }
}
