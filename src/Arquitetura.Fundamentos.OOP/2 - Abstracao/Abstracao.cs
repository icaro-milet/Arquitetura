namespace Arquitetura.Fundamentos.OOP
{
    public abstract class Automotivo
    {
        private readonly string _nome;
        private readonly string _chassis;

        public Automotivo(string nome, string chassis)
        {
            _nome = nome;
            _chassis = chassis;
        }

        public abstract void Ligar();
        public abstract void Desligar();
    }
}
