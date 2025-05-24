using EstoqueFlow.Domain.Entities;

namespace EstoqueFlow.Domain.Repositories;

public interface IFornecedorRepository
{
    Task<Fornecedor> Adicionar(Fornecedor fornecedor);
    Task Atualizar(Fornecedor fornecedor);
    Task<IEnumerable<Fornecedor>> ObterTodos();
    Task<Fornecedor> ObterPorId(int id);
    Task<Fornecedor?> ObterFornecedorPorCnpj(string cnpj);
    Task<Fornecedor?> ObterFornecedorPorEmail(string email);
}
