using EstoqueFlow.Domain.Entities;

namespace EstoqueFlow.Domain.Repositories;

public interface IMovimentacaoRepository
{
    Task<Movimentacao> Adicionar(Movimentacao movimentacao);
    Task<IEnumerable<Movimentacao>> ObterTodos();
    Task<Movimentacao> ObterPorId(int id);
}
