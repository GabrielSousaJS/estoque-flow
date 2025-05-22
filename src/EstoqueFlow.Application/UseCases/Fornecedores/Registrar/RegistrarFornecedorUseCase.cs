using EstoqueFlow.Application.Mappings;
using EstoqueFlow.Application.ViewModel.Fornecedores;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Application.UseCases.Fornecedores.Registrar;

public class RegistrarFornecedorUseCase(IFornecedorRepository fornecedorRepository) : IRegistrarFornecedorUseCase
{
    public async Task<FornecedorResponse> Executar(FornecedorRequest request)
    {
        var entidade = request.ToEntidade();

        var fornecedor = await fornecedorRepository.Adicionar(entidade);

        return fornecedor.ToDto();
    }
}
