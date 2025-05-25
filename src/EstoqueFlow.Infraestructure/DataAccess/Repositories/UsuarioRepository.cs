using Dapper;
using EstoqueFlow.Domain.Entities;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Infraestructure.DataAccess.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    public async Task<Usuario> Adicionar(Usuario usuario)
    {
        using var connection = DbConnectionFactory.GetConnection();

        string sql = @"
            INSERT
	            INTO
	            usuarios (
		            nome,
		            email,
		            senha
	            )
            VALUES (
	            @Nome,
	            @Email,
	            @Senha
            )
        ";

        await connection.QueryAsync(sql, new
        {
            usuario.Nome,
            usuario.Email,
            usuario.Senha
        });

        return usuario;
    }

    public async Task Atualizar(Usuario usuario)
    {
        using var connection = DbConnectionFactory.GetConnection();

        string sql = @"
            UPDATE
	            usuarios
            SET
	            nome = @Nome,
	            email = @Email,
	            senha = @Senha
            WHERE
	            id = @Id
        ";

        await connection.ExecuteAsync(sql, new
        {
            usuario.Nome,
            usuario.Email,
            usuario.Senha,
            usuario.Id
        });
    }

    public async Task Desativar(int id)
    {
        using var connection = DbConnectionFactory.GetConnection();

        string sql = @"
            UPDATE usuarios
            SET ativo = false
            WHERE id = @Id
        ";

        await connection.ExecuteAsync(sql, new { Id = id });
    }

    public async Task<bool> ExisteUsuarioAtivoComEmail(string email)
    {
        using var connection = DbConnectionFactory.GetConnection();

        string sql = @"
            SELECT COUNT(*) FROM usuarios
            WHERE email = @Email AND ativo = true
        ";

        var total = await connection.ExecuteScalarAsync<int>(sql, new { email });

        return total > 0;
    }

    public async Task<Usuario> ObterPorId(int id)
    {
        using var connection = DbConnectionFactory.GetConnection();

        string sql = @"
            SELECT
	            id AS Id,
	            nome AS Nome,
	            email AS Email,
	            ativo AS Ativo,
	            data_cadastro AS DataCadastro
            FROM
	            usuarios
            WHERE
	            id = @Id
	            AND ativo = TRUE
        ";

        return await connection.QuerySingleAsync<Usuario>(sql, new { Id = id });
    }

    public async Task<IEnumerable<Usuario>> ObterTodos()
    {
        using var connection = DbConnectionFactory.GetConnection();

        string sql = @"
            SELECT
	            id AS Id,
	            nome AS Nome,
	            email AS Email,
	            ativo AS Ativo,
	            data_cadastro AS DataCadastro
            FROM
	            usuarios
            ORDER BY id
        ";

        return await connection.QueryAsync<Usuario>(sql);
    }

    public async Task<Usuario?> ObterUsuarioPorEmail(string email)
    {
        using var connection = DbConnectionFactory.GetConnection();

        string sql = @"
            SELECT
	            id AS Id,
	            nome AS Nome,
	            email AS Email,
	            senha AS Senha,
	            ativo AS Ativo,
	            data_cadastro AS DataCadastro
            FROM
	            usuarios
            WHERE
	            email = @Email
	            AND ativo = TRUE
        ";

        return await connection.QueryFirstOrDefaultAsync<Usuario>(sql, new { email });
    }
}
