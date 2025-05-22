using EstoqueFlow.Application.ViewModel.Categorias;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Application.UseCases.Categorias.Atualizar;

public class AtualizarCategoriaUseCase(ICategoriaRepository categoriaRepository) : IAtualizarCategoriaUseCase
{
    public async Task Executar(int id, CategoriaRequest request)
    {
        var categoria = await categoriaRepository.ObterPorId(id);

        categoria.AtualizarDados(request.Nome, request.Descricao);

        await categoriaRepository.Atualizar(categoria);
    }
}
