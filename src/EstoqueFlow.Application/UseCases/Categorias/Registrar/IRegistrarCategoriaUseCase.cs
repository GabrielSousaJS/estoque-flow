using EstoqueFlow.Application.ViewModel.Categorias;

namespace EstoqueFlow.Application.UseCases.Categorias.Registrar;

public interface IRegistrarCategoriaUseCase
{
    Task<CategoriaResponse> Executar(CategoriaRequest request);
}
