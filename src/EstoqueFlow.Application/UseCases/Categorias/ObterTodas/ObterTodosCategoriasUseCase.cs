using EstoqueFlow.Application.Mappings;
using EstoqueFlow.Application.ViewModel.Categorias;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Application.UseCases.Categorias.ObterTodas;

public class ObterTodosCategoriasUseCase(ICategoriaRepository categoriaRepository) : IObterTodosCategoriasUseCase
{
    public async Task<IEnumerable<CategoriaResponse>> Executar()
    {
        var categorias = await categoriaRepository.ObterTodos();

        return categorias.Select(c => c.ToDto()).ToList();
    }
}
