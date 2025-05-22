using EstoqueFlow.Application.ViewModel.Produtos;

namespace EstoqueFlow.Application.UseCases.Produtos.ObterPorId;

public interface IObterProdutoPorIdUseCase
{
    Task<ProdutoResponse> Executar(int id);
}
