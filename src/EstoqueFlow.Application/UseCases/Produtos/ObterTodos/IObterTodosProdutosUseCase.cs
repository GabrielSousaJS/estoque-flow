using EstoqueFlow.Application.ViewModel.Produtos;

namespace EstoqueFlow.Application.UseCases.Produtos.ObterTodos;

public interface IObterTodosProdutosUseCase
{
    Task<IEnumerable<ProdutoResponse>> Executar();
}
