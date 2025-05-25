using EstoqueFlow.Application.Mappings;
using EstoqueFlow.Application.ViewModel.Movimentacoes;
using EstoqueFlow.Domain.Entities;
using EstoqueFlow.Domain.Entities.Enums;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Application.UseCases.Movimentacoes.Registrar;

public class RegistrarMovimentacaoUseCase(
    IMovimentacaoRepository movimentacaoRepository, 
    IProdutoRepository produtoRepository
) : IRegistrarMovimentacaoUseCase
{
    public async Task<MovimentacaoResponse> Executar(MovimentacaoRequest request)
    {
        var entidade = request.ToEntidade();

        await AtualizarQuantidadeProduto(entidade);
        var movimentacao = await movimentacaoRepository.Adicionar(entidade);

        return movimentacao.ToNovaMovimentacao();
    }

    private async Task AtualizarQuantidadeProduto(Movimentacao movimentacao)
    {
        var produto = await produtoRepository.ObterPorId(movimentacao.ProdutoId) ??
            throw new Exception("Produto não encontrado");

        if (movimentacao.Tipo == TipoMovimentacao.ENTRADA)
        {
            produto.Quantidade += movimentacao.Quantidade;
            await produtoRepository.AtualizarQuantidade(produto);

            return;
        }

        if (movimentacao.Quantidade > produto.Quantidade)
            throw new Exception("Quantidade insuficiente em estoque");

        produto.Quantidade -= movimentacao.Quantidade;
        await produtoRepository.AtualizarQuantidade(produto);
    }
}
