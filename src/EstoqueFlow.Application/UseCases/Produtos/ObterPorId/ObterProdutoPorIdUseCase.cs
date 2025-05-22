using EstoqueFlow.Application.Mappings;
using EstoqueFlow.Application.ViewModel.Produtos;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Application.UseCases.Produtos.ObterPorId;

public class ObterProdutoPorIdUseCase(IProdutoRepository produtoRepository) : IObterProdutoPorIdUseCase
{
    public async Task<ProdutoResponse> Executar(int id)
    {
        var produto = await produtoRepository.ObterPorId(id) ??
            throw new Exception("Produto não encontrado");

        return produto.ToDto();
    }
}
