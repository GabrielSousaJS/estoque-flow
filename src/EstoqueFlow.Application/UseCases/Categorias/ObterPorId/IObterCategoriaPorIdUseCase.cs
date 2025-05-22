using EstoqueFlow.Application.ViewModel.Categorias;

namespace EstoqueFlow.Application.UseCases.Categorias.ObterPorId;

public interface IObterCategoriaPorIdUseCase
{
    Task<CategoriaResponse> Executar(int id);
}
