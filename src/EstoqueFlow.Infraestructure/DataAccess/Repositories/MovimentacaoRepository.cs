using Dapper;
using EstoqueFlow.Domain.Entities;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Infraestructure.DataAccess.Repositories;

public class MovimentacaoRepository : IMovimentacaoRepository
{
    public async Task<Movimentacao> Adicionar(Movimentacao movimentacao)
    {
        using var connection = DbConnectionFactory.GetConnection();

        string sql = @"
            INSERT
	            INTO
	            movimentacoes (
		            tipo,
		            quantidade,
		            observacao,
		            produto_id,
		            usuario_id
	            )
            VALUES (
	            @Tipo,
	            @Quantidade,
	            @Observacao,
	            @ProdutoId,
	            @UsuarioId
            )
        ";

        await connection.ExecuteAsync(sql, new
        {
            movimentacao.Tipo,
            movimentacao.Quantidade,
            movimentacao.Observacao,
            movimentacao.ProdutoId,
            movimentacao.UsuarioId
        });

        return movimentacao;
    }

    public async Task<Movimentacao?> ObterPorId(int id)
    {
        using var connection = DbConnectionFactory.GetConnection();

        string sql = @"
           SELECT
	            m.id AS Id,
	            m.tipo AS Tipo,
	            m.quantidade AS Quantidade,
	            m.observacao AS Observacao,
	            m.produto_id AS ProdutoId,
	            m.usuario_id AS UsuarioId,
	            p.id AS Id,
	            p.nome AS Nome,
	            p.descricao AS Descricao,
	            p.preco_compra AS PrecoCompra,
	            p.preco_venda AS PrecoVenda,
	            p.quantidade AS Quantidade,
	            p.estoque_minimo AS EstoqueMinimo,
	            p.categoria_id AS CategoriaId,
	            p.fornecedor_id AS FornecedorId,
	            u.id AS Id,
	            u.nome AS Nome,
	            u.email AS Email,
	            u.ativo AS Ativo,
	            u.data_cadastro AS DataCadastro
            FROM
	            movimentacoes m
            INNER JOIN produtos p ON
	            m.produto_id = p.id
            INNER JOIN usuarios u ON
	            m.usuario_id = u.id
            WHERE
	            m.id = :Id
       ";

        var movimentacao = await connection.QueryAsync<Movimentacao, Produto, Usuario, Movimentacao>(
            sql,
            (movimentacao, produto, usuario) =>
            {
                movimentacao.Produto = produto;
                movimentacao.Usuario = usuario;
                return movimentacao;
            },
            new { Id = id },
            splitOn: "id,id"
        );

        return movimentacao.FirstOrDefault();
    }

    public async Task<IEnumerable<Movimentacao>> ObterTodos()
    {
        using var connection = DbConnectionFactory.GetConnection();

        string sql = @"
           SELECT
	            m.id AS Id,
                m.data AS Data,
	            m.tipo AS Tipo,
	            m.quantidade AS Quantidade,
	            m.observacao AS Observacao,
	            m.produto_id AS ProdutoId,
	            m.usuario_id AS UsuarioId,
	            p.id AS Id,
	            p.nome AS Nome,
	            p.descricao AS Descricao,
	            p.preco_compra AS PrecoCompra,
	            p.preco_venda AS PrecoVenda,
	            p.quantidade AS Quantidade,
	            p.estoque_minimo AS EstoqueMinimo,
	            p.categoria_id AS CategoriaId,
	            p.fornecedor_id AS FornecedorId,
	            u.id AS Id,
	            u.nome AS Nome,
	            u.email AS Email,
	            u.ativo AS Ativo,
	            u.data_cadastro AS DataCadastro
            FROM
	            movimentacoes m
            INNER JOIN produtos p ON
	            m.produto_id = p.id
            INNER JOIN usuarios u ON
	            m.usuario_id = u.id
       ";

        return await connection.QueryAsync<Movimentacao, Produto, Usuario, Movimentacao>(
            sql,
            (movimentacao, produto, usuario) =>
            {
                movimentacao.Produto = produto;
                movimentacao.Usuario = usuario;
                return movimentacao;
            },
            splitOn: "Id,Id"
        );
    }
}
