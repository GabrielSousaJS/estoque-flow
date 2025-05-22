using EstoqueFlow.Application.Mappings;
using EstoqueFlow.Application.ViewModel.Categorias;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Application.UseCases.Categorias.ObterPorId;

public class ObterCategoriaPorIdUseCase(ICategoriaRepository categoriaRepository) : IObterCategoriaPorIdUseCase
{
    public async Task<CategoriaResponse> Executar(int id)
    {
        var categoria = await categoriaRepository.ObterPorId(id);

        return categoria.ToDto();
    }
}
