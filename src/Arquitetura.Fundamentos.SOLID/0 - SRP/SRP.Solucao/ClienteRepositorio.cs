using System.Data;
using System.Data.SqlClient;

namespace Arquitetura.Fundamentos.SOLID.SRP.Solucao
{
    public class ClienteRepositorio
    {
        public void AdicionarCliente(Cliente cliente)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MinhaConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL, CPF, DATACADASTRO) " +
                    "VALUES (@nome, @email, @cpf, @datacadastro)";

                cmd.Parameters.AddWithValue("nome", cliente.Nome);
                cmd.Parameters.AddWithValue("email", cliente.Email);
                cmd.Parameters.AddWithValue("cpf", cliente.CPF);
                cmd.Parameters.AddWithValue("datacadastro", cliente.Cadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
