using EstoqueFlow.Application.ViewModel.Fornecedores;

namespace EstoqueFlow.Application.UseCases.Fornecedores.ObterTodos;

public interface IObterTodosFornecedoresUseCase
{
    Task<IEnumerable<FornecedorResponse>> Executar();
}
