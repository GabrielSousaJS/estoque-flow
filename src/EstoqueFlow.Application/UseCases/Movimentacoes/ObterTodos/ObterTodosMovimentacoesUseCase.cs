using EstoqueFlow.Application.Mappings;
using EstoqueFlow.Application.ViewModel.Movimentacoes;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Application.UseCases.Movimentacoes.ObterTodos;

public class ObterTodosMovimentacoesUseCase(IMovimentacaoRepository movimentacaoRepository) : IObterTodosMovimentacoesUseCase
{
    public async Task<IEnumerable<MovimentacaoResponse>> Executar()
    {
        var movimentacoes = await movimentacaoRepository.ObterTodos();

        return movimentacoes.Select(m => m.ToDto());
    }
}
