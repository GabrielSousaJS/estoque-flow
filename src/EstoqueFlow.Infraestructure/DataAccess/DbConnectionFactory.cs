using Npgsql;
using System.Data;

namespace EstoqueFlow.Infraestructure.DataAccess;

public class DbConnectionFactory
{
    public static IDbConnection GetConnection()
    {
        string connectionString = "Host=localhost;Port=5432;Database=estoque;Username=estoque;Password=estoque.123";
        return new NpgsqlConnection(connectionString);
    }
}
