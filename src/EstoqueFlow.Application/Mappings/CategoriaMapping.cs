using EstoqueFlow.Application.ViewModel.Categorias;
using EstoqueFlow.Domain.Entities;

namespace EstoqueFlow.Application.Mappings;

public static class CategoriaMapping
{
    public static Categoria ToEntidade(this CategoriaRequest from)
    {
        return new Categoria
        {
            Nome = from.Nome,
            Descricao = from.Descricao,
        };
    }

    public static CategoriaResponse ToDto(this Categoria from)
    {
        return new CategoriaResponse
        {
            Id = from.Id,
            Nome = from.Nome,
            Descricao = from.Descricao,
        };
    }
}
