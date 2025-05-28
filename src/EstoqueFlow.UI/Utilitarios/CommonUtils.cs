using EstoqueFlow.Application.UseCases.Categorias.ObterPorId;
using EstoqueFlow.Application.UseCases.Fornecedores.ObterPorId;
using EstoqueFlow.Application.UseCases.Produtos.ObterPorId;
using EstoqueFlow.Application.UseCases.Usuarios.ObterPorId;

namespace EstoqueFlow.UI.Utilitarios;

public class CommonUtils
{
    public static async Task<object> CarregarDadosParaAtualizar<T>(int id, T useCase)
    {
        if (useCase is IObterFornecedorPorIdUseCase fornecedorUseCase)
        {
            return await fornecedorUseCase.Executar(id);
        }
        else if (useCase is IObterCategoriaPorIdUseCase categoriaUseCase)
        {
            return await categoriaUseCase.Executar(id);
        }
        else if (useCase is IObterProdutoPorIdUseCase produtoUseCase)
        {
            return await produtoUseCase.Executar(id);
        } else if (useCase is IObterUsuarioPorIdUseCase usuarioUseCase)
        {
            return await usuarioUseCase.Executar(id);
        }

        throw new InvalidOperationException("O caso de uso não existe.");
    }
}
