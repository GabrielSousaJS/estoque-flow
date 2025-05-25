using Dapper;
using EstoqueFlow.Domain.Entities;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Infraestructure.DataAccess.Repositories;

public class ProdutoRepository : IProdutoRepository
{
    public async Task<Produto> Adicionar(Produto produto)
    {
        using var connection = DbConnectionFactory.GetConnection();

        var sql = @"
            INSERT
	            INTO
	            produtos (
		            nome,
		            descricao,
		            preco_compra,
		            preco_venda,
		            estoque_minimo,
		            categoria_id,
		            fornecedor_id
	            )
            VALUES (
	            @Nome,
	            @Descricao,
	            @PrecoCompra,
	            @PrecoVenda,
	            @EstoqueMinimo,
	            @CategoriaId,
	            @FornecedorId
            )
        ";

        await connection.ExecuteAsync(sql, new
        {
            produto.Nome,
            produto.Descricao,
            produto.PrecoCompra,
            produto.PrecoVenda,
            produto.EstoqueMinimo,
            produto.CategoriaId,
            produto.FornecedorId
        });

        return produto;
    }

    public async Task Atualizar(Produto produto)
    {
        using var connection = DbConnectionFactory.GetConnection();

        var sql = @"
            UPDATE produtos
            SET nome = @Nome,
                descricao = @Descricao,
                preco_compra = @PrecoCompra,
                preco_venda = @PrecoVenda,
                estoque_minimo = @EstoqueMinimo,
                categoria_id = @CategoriaId,
                fornecedor_id = @FornecedorId
            WHERE id = @Id
        ";

        await connection.ExecuteAsync(sql, new
        {
            produto.Nome,
            produto.Descricao,
            produto.PrecoCompra,
            produto.PrecoVenda,
            produto.EstoqueMinimo,
            produto.CategoriaId,
            produto.FornecedorId,
            produto.Id
        });
    }

    public async Task AtualizarQuantidade(Produto produto)
    {
        using var connection = DbConnectionFactory.GetConnection();

        var sql = @"
            UPDATE produtos
            SET quantidade = @Quantidade
            WHERE id = @Id
        ";

        await connection.ExecuteAsync(sql, new
        {
            produto.Quantidade,
            produto.Id
        });
    }

    public async Task<Produto?> ObterPorId(int id)
    {
        using var connection = DbConnectionFactory.GetConnection();

        var sql = @"
            SELECT
	            p.id AS Id,
	            p.nome AS Nome,
	            p.descricao AS Descricao,
	            p.preco_compra AS PrecoCompra,
	            p.preco_venda AS PrecoVenda,
	            p.quantidade AS Quantidade,
	            p.estoque_minimo AS EstoqueMinimo,
	            p.categoria_id AS CategoriaId,
	            p.fornecedor_id AS FornecedorId,
	            c.id AS Id,
	            c.nome AS Nome,
	            c.descricao AS Descricao,
	            f.id AS Id,
	            f.razao_social AS RazaoSocial,
	            f.nome_fantasia AS NomeFantasia,
	            f.cnpj AS Cnpj,
	            f.telefone AS Telefone,
	            f.email AS Email
            FROM
	            produtos p
            INNER JOIN categorias c ON
	            p.categoria_id = c.id
            INNER JOIN fornecedores f ON
	            p.fornecedor_id = f.id
            WHERE
	            p.id = @Id
        ";

        var produto = await connection.QueryAsync<Produto, Categoria, Fornecedor, Produto>(
            sql,
            (produto, categoria, fornecedor) =>
            {
                produto.Categoria = categoria;
                produto.Fornecedor = fornecedor;
                return produto;
            },
            param: new { Id = id },
            splitOn: "id,id"
        );

        return produto.FirstOrDefault();
    }

    public async Task<IEnumerable<Produto>> ObterTodos()
    {
        using var connection = DbConnectionFactory.GetConnection();

        var sql = @"
            SELECT
                p.id AS Id,
	            p.nome AS Nome,
	            p.descricao AS Descricao,
	            p.preco_compra AS PrecoCompra,
	            p.preco_venda AS PrecoVenda,
	            p.quantidade AS Quantidade,
	            p.estoque_minimo AS EstoqueMinimo,
	            p.categoria_id AS CategoriaId,
	            p.fornecedor_id AS FornecedorId,
	            c.id AS Id,
	            c.nome AS Nome,
	            c.descricao AS Descricao,
	            f.id AS Id,
	            f.razao_social AS RazaoSocial,
	            f.nome_fantasia AS NomeFantasia,
	            f.cnpj AS Cnpj,
	            f.telefone AS Telefone,
	            f.email AS Email
            FROM produtos p
            INNER JOIN categorias c ON p.categoria_id = c.id
            INNER JOIN fornecedores f ON p.fornecedor_id = f.id
            ORDER BY p.id
        ";

        return await connection.QueryAsync<Produto, Categoria, Fornecedor, Produto>(
            sql,
            (produto, categoria, fornecedor) =>
            {
                produto.Categoria = categoria;
                produto.Fornecedor = fornecedor;
                return produto;
            }
        );
    }
}
