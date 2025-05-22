using EstoqueFlow.Application.ViewModel.Produtos;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Application.UseCases.Produtos.Atualizar;

public class AtualizarProdutoUseCase(IProdutoRepository produtoRepository) : IAtualizarProdutoUseCase
{
    public async Task Executar(int id, ProdutosRequest request)
    {
        var produto = await produtoRepository.ObterPorId(id) ??
            throw new Exception("Produto não encontrado");

        produto.AtualizarDados(
            request.Nome,
            request.Descricao,
            request.PrecoCompra,
            request.PrecoVenda,
            request.EstoqueMinimo,
            request.CategoriaId,
            request.FornecedorId
        );

        await produtoRepository.Atualizar(produto);
    }
}
