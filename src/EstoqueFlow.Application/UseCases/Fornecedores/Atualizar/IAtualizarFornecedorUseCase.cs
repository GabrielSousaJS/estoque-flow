using EstoqueFlow.Application.ViewModel.Fornecedores;

namespace EstoqueFlow.Application.UseCases.Fornecedores.Atualizar;

public interface IAtualizarFornecedorUseCase
{
    Task Executar(int id, FornecedorRequest request);
}
