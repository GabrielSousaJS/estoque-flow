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
        var saoPauloTimeZone = TimeZoneInfo.FindSystemTimeZoneById("America/Sao_Paulo");

        return new UsuarioResponse
        {
            Id = from.Id,
            Nome = from.Nome,
            Email = from.Email,
            Ativo = from.Ativo,
            DataCadastro = TimeZoneInfo.ConvertTimeFromUtc(from.DataCadastro, saoPauloTimeZone),
        };
    }
}
