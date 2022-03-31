using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Arquitetura.Fundamentos.SOLID.SRP.Violacao
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime Cadastro { get; set; }

        public string AdicionarCliente()
        {
            if (!Email.Contains("@")) 
                return "E-mail inválido.";

            if (CPF.Length != 11)
                return "CPF inválido.";

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MinhaConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL, CPF, DATACADASTRO) " +
                    "VALUES (@nome, @email, @cpf, @datacadastro)";

                cmd.Parameters.AddWithValue("nome", Nome);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("cpf", CPF);
                cmd.Parameters.AddWithValue("datacadastro", Cadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            var mail = new MailMessage("empresa@empresa.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Bem-vindo!";
            mail.Body = "Parabéns! Você está cadastrado.";

            client.Send(mail);

            return "Cliente cadastrado com sucesso.";
        }
    }
}
