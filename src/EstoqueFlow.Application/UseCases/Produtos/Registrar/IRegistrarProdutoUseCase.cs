using EstoqueFlow.Application.ViewModel.Produtos;

namespace EstoqueFlow.Application.UseCases.Produtos.Registrar;

public interface IRegistrarProdutoUseCase
{
    Task<ProdutoResponse> Executar(ProdutosRequest request);
}
