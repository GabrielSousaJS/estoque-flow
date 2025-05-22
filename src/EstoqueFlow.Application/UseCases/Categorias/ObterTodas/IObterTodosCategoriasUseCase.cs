using EstoqueFlow.Application.ViewModel.Categorias;

namespace EstoqueFlow.Application.UseCases.Categorias.ObterTodas;

public interface IObterTodosCategoriasUseCase
{
    Task<IEnumerable<CategoriaResponse>> Executar();
}
