using EstoqueFlow.Application.ViewModel.Usuarios;
using EstoqueFlow.Domain.Entities;

namespace EstoqueFlow.Application.Mappings;

public static class UsuarioMapping
{
    public static Usuario ToEntidade(this UsuarioRequest from)
    {
        return new Usuario
        {
            Nome = from.Nome,
            Email = from.Email,
        };
    }

    public static UsuarioResponse ToDto(this Usuario from)
    {
        return new UsuarioResponse
        {
            Id = from.Id,
            Nome = from.Nome,
            Email = from.Email,
            Ativo = from.Ativo,
            DataCadastro = from.DataCadastro,
        };
    }
}
