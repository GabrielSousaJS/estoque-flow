using EstoqueFlow.Application.ViewModel.Movimentacoes;

namespace EstoqueFlow.Application.UseCases.Movimentacoes.ObterPorId;

public interface IObterMovimentacaoPorIdUseCase
{
    Task<MovimentacaoResponse> Executar(int id);
}
