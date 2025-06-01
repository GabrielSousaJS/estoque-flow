using EstoqueFlow.Application.ViewModel.Movimentacoes;
using EstoqueFlow.Domain.Entities;
using EstoqueFlow.Domain.Entities.Enums;

namespace EstoqueFlow.Application.Mappings;

public static class MovimentacaoMapping
{
    public static Movimentacao ToEntidade(this MovimentacaoRequest from)
    {
        return new Movimentacao
        {
            Tipo = (TipoMovimentacao)from.Tipo,
            Quantidade = from.Quantidade,
            Observacao = from.Observacao,
            UsuarioId = from.UsuarioId,
            ProdutoId = from.ProdutoId,
        };
    }

    public static MovimentacaoResponse ToNovaMovimentacao(this Movimentacao from)
    {
        return new MovimentacaoResponse
        {
            Id = from.Id,
            Data = from.Data,
            Tipo = from.Tipo == TipoMovimentacao.ENTRADA ? "Entrada" : "Saída",
            Quantidade = from.Quantidade,
            Observacao = from.Observacao,
            UsuarioId = from.UsuarioId,
            ProdutoId = from.ProdutoId,
        };
    }

    public static MovimentacaoResponse ToDto(this Movimentacao from)
    {
        var saoPauloTimeZone = TimeZoneInfo.FindSystemTimeZoneById("America/Sao_Paulo");

        return new MovimentacaoResponse
        {
            Id = from.Id,
            Data = TimeZoneInfo.ConvertTimeFromUtc(from.Data, saoPauloTimeZone),
            Tipo = from.Tipo == TipoMovimentacao.ENTRADA ? "Entrada" : "Saída",
            PrecoCompra = from.PrecoCompra,
            PrecoVenda = from.PrecoVenda,
            Quantidade = from.Quantidade,
            Observacao = from.Observacao,
            UsuarioId = from.UsuarioId,
            NomeUsuario = from.Usuario.Nome,
            ProdutoId = from.ProdutoId,
            NomeProduto = from.Produto.Nome,
        };
    }
}
