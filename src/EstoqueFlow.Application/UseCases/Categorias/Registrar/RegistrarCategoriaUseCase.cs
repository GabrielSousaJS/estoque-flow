using EstoqueFlow.Application.Mappings;
using EstoqueFlow.Application.ViewModel.Categorias;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Application.UseCases.Categorias.Registrar;

public class RegistrarCategoriaUseCase(ICategoriaRepository categoriaRepository) : IRegistrarCategoriaUseCase
{
    public async Task<CategoriaResponse> Executar(CategoriaRequest request)
    {
        var entidade = request.ToEntidade();

        var categoria = await categoriaRepository.Adicionar(entidade);

        return categoria.ToDto();
    }
}
