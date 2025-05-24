using EstoqueFlow.Application.ViewModel.Produtos;
using EstoqueFlow.Domain.Entities;

namespace EstoqueFlow.Application.Mappings;

public static class ProdutoMapping
{
    public static Produto ToEntidade(this ProdutosRequest from)
    {
        return new Produto
        {
            Nome = from.Nome,
            Descricao = from.Descricao,
            PrecoCompra = from.PrecoCompra,
            PrecoVenda = from.PrecoVenda,
            EstoqueMinimo = from.EstoqueMinimo,
            CategoriaId = from.CategoriaId,
            FornecedorId = from.FornecedorId,
        };
    }

    public  static ProdutoResponse ToNovoProdutoDto(this Produto from)
    {
        return new ProdutoResponse
        {
            Nome = from.Nome,
            Descricao = from.Descricao,
            PrecoCompra = from.PrecoCompra,
            PrecoVenda = from.PrecoVenda,
            Quantidade = from.Quantidade,
            EstoqueMinimo = from.EstoqueMinimo,
            CategoriaId = from.CategoriaId,
            FornecedorId = from.FornecedorId,
        };
    }

    public static ProdutoResponse ToDto(this Produto from)
    {
        return new ProdutoResponse
        {
            Id = from.Id,
            Nome = from.Nome,
            Descricao = from.Descricao,
            PrecoCompra = from.PrecoCompra,
            PrecoVenda = from.PrecoVenda,
            Quantidade = from.Quantidade,
            EstoqueMinimo = from.EstoqueMinimo,
            CategoriaId = from.CategoriaId,
            NomeCategoria = from.Categoria.Nome,
            FornecedorId = from.FornecedorId,
            NomeFantasiaFornecedor = from.Fornecedor.NomeFantasia,
        };
    }
}