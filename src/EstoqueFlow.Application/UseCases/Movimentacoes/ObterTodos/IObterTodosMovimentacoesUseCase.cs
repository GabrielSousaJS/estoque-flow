using EstoqueFlow.Application.ViewModel.Movimentacoes;

namespace EstoqueFlow.Application.UseCases.Movimentacoes.ObterTodos;

public interface IObterTodosMovimentacoesUseCase
{
    Task<IEnumerable<MovimentacaoResponse>> Executar();
}
