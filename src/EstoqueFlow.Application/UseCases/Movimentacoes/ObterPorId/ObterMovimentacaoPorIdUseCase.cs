using EstoqueFlow.Application.Mappings;
using EstoqueFlow.Application.ViewModel.Movimentacoes;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Application.UseCases.Movimentacoes.ObterPorId;

public class ObterMovimentacaoPorIdUseCase(IMovimentacaoRepository movimentacaoRepository) : IObterMovimentacaoPorIdUseCase
{
    public async Task<MovimentacaoResponse> Executar(int id)
    {
        var movimentacao = await movimentacaoRepository.ObterPorId(id) ??
            throw new Exception("Movimentação não encontrada");

        return movimentacao.ToDto();
    }
}
