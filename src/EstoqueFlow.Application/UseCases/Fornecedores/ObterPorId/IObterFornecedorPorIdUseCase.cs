using EstoqueFlow.Application.ViewModel.Fornecedores;

namespace EstoqueFlow.Application.UseCases.Fornecedores.ObterPorId;

public interface IObterFornecedorPorIdUseCase
{
    Task<FornecedorResponse> Executar(int id);
}
