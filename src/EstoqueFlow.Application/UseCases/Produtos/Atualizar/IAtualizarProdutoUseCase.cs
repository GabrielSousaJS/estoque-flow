using EstoqueFlow.Application.ViewModel.Produtos;

namespace EstoqueFlow.Application.UseCases.Produtos.Atualizar;

public interface IAtualizarProdutoUseCase
{
    Task Executar(int id, ProdutosRequest request);
}
