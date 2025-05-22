using EstoqueFlow.Application.Mappings;
using EstoqueFlow.Application.ViewModel.Fornecedores;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Application.UseCases.Fornecedores.ObterPorId;

public class ObterFornecedorPorIdUseCase(IFornecedorRepository fornecedorRepository) : IObterFornecedorPorIdUseCase
{
    public async Task<FornecedorResponse> Executar(int id)
    {
        var fornecedor = await fornecedorRepository.ObterPorId(id);

        return fornecedor.ToDto();
    }
}
