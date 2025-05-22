using EstoqueFlow.Application.ViewModel.Fornecedores;
using EstoqueFlow.Domain.Entities;

namespace EstoqueFlow.Application.Mappings;

public static class FornecedorMapping
{
    public static Fornecedor ToEntidade(this FornecedorRequest from)
    {
        return new Fornecedor
        {
            RazaoSocial = from.RazaoSocial,
            NomeFantasia = from.NomeFantasia,
            CNPJ = from.CNPJ,
            Telefone = from.Telefone,
            Email = from.Email,
        };
    }

    public static FornecedorResponse ToDto(this Fornecedor from)
    {
        return new FornecedorResponse
        {
            Id = from.Id,
            RazaoSocial = from.RazaoSocial,
            NomeFantasia = from.NomeFantasia,
            CNPJ = from.CNPJ,
            Telefone = from.Telefone,
            Email = from.Email,
        };
    }
}
