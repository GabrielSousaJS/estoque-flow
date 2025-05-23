using EstoqueFlow.Application.Mappings;
using EstoqueFlow.Application.ViewModel.Fornecedores;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Application.UseCases.Fornecedores.ObterTodos;

public class ObterTodosFornecedoresUseCase(IFornecedorRepository fornecedorRepository) : IObterTodosFornecedoresUseCase
{
    public async Task<IEnumerable<FornecedorResponse>> Executar()
    {
        var fornecedores = await fornecedorRepository.ObterTodos();

        return fornecedores.Select(f => f.ToDto()).ToList();
    }
}
