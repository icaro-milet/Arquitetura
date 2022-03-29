using Arquitetura.Fundamentos.DI.Base;

var controller = new Controller(new RecepcaoService());

string mensagem = controller.Cumprimentar("Icaro");

Console.WriteLine(mensagem);