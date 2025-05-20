using Dapper;
using EstoqueFlow.Domain.Entities;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Infraestructure.DataAccess.Repositories;

public class FornecedorRepository : IFornecedorRepository
{
    public async Task<Fornecedor> Adicionar(Fornecedor fornecedor)
    {
        using var connection = DbConnectionFactory.GetConnection();

        var sql = @"
            INSERT
	            INTO
	            fornecedores (
		            razao_social,
		            nome_fantasia,
		            cnpj,
		            telefone,
		            email
	            )
            VALUES (
	            @RazaoSocial,
	            @NomeFantasia,
	            @CNPJ,
	            @Telefone,
	            @Email
            )
        ";

        await connection.ExecuteAsync(sql, new
        {
            fornecedor.RazaoSocial,
            fornecedor.NomeFantasia,
            fornecedor.CNPJ,
            fornecedor.Telefone,
            fornecedor.Email
        });

        return fornecedor;
    }

    public async Task Atualizar(Fornecedor fornecedor)
    {
        using var connection = DbConnectionFactory.GetConnection();

        var sql = @"
            UPDATE
	            fornecedores
            SET
	            razao_social = @RazaoSocial,
	            nome_fantasia = @NomeFantasia,
	            cnpj = @CNPJ,
	            telefone = @Telefone,
	            email = @Email
            WHERE
	            id = @Id
        ";

        await connection.ExecuteAsync(sql, new
        {
            fornecedor.RazaoSocial,
            fornecedor.NomeFantasia,
            fornecedor.CNPJ,
            fornecedor.Telefone,
            fornecedor.Email,
            fornecedor.Id
        });
    }

    public async Task<Fornecedor> ObterPorId(int id)
    {
        using var connection = DbConnectionFactory.GetConnection();

        var sql = @"
            SELECT
	            id AS Id,
	            razao_social AS RazaoSocial,
	            nome_fantasia AS NomeFantasia,
	            cnpj AS Cnpj,
	            telefone AS Telefone,
	            email AS Email
            FROM
	            fornecedores
            WHERE
	            id = @Id
        ";

        return await connection.QuerySingleAsync<Fornecedor>(sql, new { Id = id });
    }

    public async Task<IEnumerable<Fornecedor>> ObterTodos()
    {
        using var connection = DbConnectionFactory.GetConnection();

        var sql = @"
            SELECT
	            id AS Id,
	            razao_social AS RazaoSocial,
	            nome_fantasia AS NomeFantasia,
	            cnpj AS Cnpj,
	            telefone AS Telefone,
	            email AS Email
            FROM
	            fornecedores
        ";

        return await connection.QueryAsync<Fornecedor>(sql);
    }
}
