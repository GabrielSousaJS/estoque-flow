using EstoqueFlow.Domain.Entities;

namespace EstoqueFlow.Domain.Repositories;

public interface IProdutoRepository
{
    Task<Produto> Adicionar(Produto produto);
    Task Atualizar(Produto produto);
    Task<IEnumerable<Produto>> ObterTodos();
    Task<Produto> ObterPorId(int id);
}
