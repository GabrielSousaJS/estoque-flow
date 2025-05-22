using EstoqueFlow.Application.Mappings;
using EstoqueFlow.Application.ViewModel.Produtos;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Application.UseCases.Produtos.ObterTodos;

public class ObterTodosProdutosUseCase(IProdutoRepository produtoRepository) : IObterTodosProdutosUseCase
{
    public async Task<IEnumerable<ProdutoResponse>> Executar()
    {
        var produtos = await produtoRepository.ObterTodos();

        return produtos.Select(p => p.ToDto());
    }
}
