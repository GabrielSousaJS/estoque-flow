using EstoqueFlow.Application.ViewModel.Categorias;

namespace EstoqueFlow.Application.UseCases.Categorias.Atualizar;

public interface IAtualizarCategoriaUseCase
{
    Task Executar(int id, CategoriaRequest request);
}
