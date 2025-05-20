using Dapper;
using EstoqueFlow.Domain.Entities;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Infraestructure.DataAccess.Repositories;

public class CategoriaRepository : ICategoriaRepository
{
    public async Task<Categoria> Adicionar(Categoria categoria)
    {
        using var connection = DbConnectionFactory.GetConnection();

        string sql = @"
            INSERT INTO categorias (nome, descricao)
            VALUES (@Nome, @Descricao)
        ";

        await connection.ExecuteAsync(sql, new
        {
            categoria.Nome,
            categoria.Descricao
        });

        return categoria;
    }

    public async Task Atualizar(Categoria categoria)
    {
        using var connection = DbConnectionFactory.GetConnection();

        string sql = @"
            UPDATE categorias
            SET nome = @Nome,
            descricao = @Descricao
            WHERE id = @Id
        ";

        await connection.ExecuteAsync(sql, new
        {
            categoria.Nome,
            categoria.Descricao,
            categoria.Id
        });
    }

    public async Task<Categoria> ObterPorId(int id)
    {
        using var connection = DbConnectionFactory.GetConnection();

        string sql = @"
            SELECT
	            id AS Id,
	            nome AS Nome,
	            descricao AS Descricao
            FROM
	            categorias
            WHERE
	            id = @Id
        ";

        return await connection.QuerySingleAsync<Categoria>(sql, new { Id = id });
    }

    public async Task<IEnumerable<Categoria>> ObterTodos()
    {
        using var connection = DbConnectionFactory.GetConnection();

        string sql = @"
            SELECT
                id AS Id, 
                nome AS Nome,
                descricao AS Descricao 
            FROM categorias
        ";

        return await connection.QueryAsync<Categoria>(sql);
    }

    public async Task Remover(int id)
    {
        using var connection = DbConnectionFactory.GetConnection();

        string sql = @"
            DELETE FROM categorias
            WHERE id = @Id
        ";

        await connection.ExecuteAsync(sql, new { Id = id });
    }
}
