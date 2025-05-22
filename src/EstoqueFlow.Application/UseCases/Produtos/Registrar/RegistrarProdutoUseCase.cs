using EstoqueFlow.Application.Mappings;
using EstoqueFlow.Application.ViewModel.Produtos;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Application.UseCases.Produtos.Registrar;

public class RegistrarProdutoUseCase(IProdutoRepository produtoRepository) : IRegistrarProdutoUseCase
{
    public async Task<ProdutoResponse> Executar(ProdutosRequest request)
    {
        var entidade = request.ToEntidade();

        var produto = await produtoRepository.Adicionar(entidade);

        return produto.ToDto();
    }
}
