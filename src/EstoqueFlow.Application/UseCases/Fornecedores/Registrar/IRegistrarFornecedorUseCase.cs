using EstoqueFlow.Application.ViewModel.Fornecedores;

namespace EstoqueFlow.Application.UseCases.Fornecedores.Registrar;

public interface IRegistrarFornecedorUseCase
{
    Task<FornecedorResponse> Executar(FornecedorRequest request);
}
