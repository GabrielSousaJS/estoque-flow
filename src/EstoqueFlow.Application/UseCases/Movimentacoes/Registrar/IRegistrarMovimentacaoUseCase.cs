using EstoqueFlow.Application.ViewModel.Movimentacoes;

namespace EstoqueFlow.Application.UseCases.Movimentacoes.Registrar;

public interface IRegistrarMovimentacaoUseCase
{
    Task<MovimentacaoResponse> Executar(MovimentacaoRequest request);
}
