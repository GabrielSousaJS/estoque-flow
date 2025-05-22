using EstoqueFlow.Application.ViewModel.Fornecedores;

namespace EstoqueFlow.Application.UseCases.Fornecedores.Atualizar;

public interface IAtualizarFornecedorRepository
{
    Task Executar(int id, FornecedorRequest request);
}
