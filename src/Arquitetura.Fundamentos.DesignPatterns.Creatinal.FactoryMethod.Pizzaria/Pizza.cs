using System.Collections;
using System.Text;

namespace Arquitetura.Fundamentos.DesignPatterns.Creatinal.FactoryMethod.Pizzaria
{
    public abstract class Pizza
    {
        protected string Nome { get; set; }
        protected string massa;
        protected string molho;
        protected ArrayList ingredientes = new ArrayList();

        public string Preparar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Preparando " + Nome + "\n");
            stringBuilder.Append(massa + "\n");
            stringBuilder.Append(molho + "\n");
            stringBuilder.Append("Ingredientes: " + "\n");

            foreach (var ingrediente in ingredientes)
            {
                stringBuilder.Append("\t" + ingrediente + "\n");
            }

            stringBuilder.Append(Cozinhar());
            stringBuilder.Append(Fatiar());

            return stringBuilder.ToString();
        }

        public virtual string Cozinhar()
        {
            return "Cozinhar por 25 minutos \n";
        }

        public virtual string Fatiar()
        {
            return "Fatiar a pizza em 8 pedaços \n";
        }
    }
}
