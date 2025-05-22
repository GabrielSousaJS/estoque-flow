using EstoqueFlow.Domain.Entities;

namespace EstoqueFlow.Domain.Repositories;

public interface ICategoriaRepository
{
    Task<Categoria> Adicionar(Categoria categoria);
    Task Atualizar(Categoria categoria);
    Task<IEnumerable<Categoria>> ObterTodos();
    Task<Categoria> ObterPorId(int id);
}
