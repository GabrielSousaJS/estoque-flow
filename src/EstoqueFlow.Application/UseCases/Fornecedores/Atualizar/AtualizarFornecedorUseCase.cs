using EstoqueFlow.Application.Mappings;
using EstoqueFlow.Application.ViewModel.Fornecedores;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Application.UseCases.Fornecedores.Atualizar;

public class AtualizarFornecedorUseCase(IFornecedorRepository fornecedorRepository) : IAtualizarFornecedorRepository
{
    public async Task Executar(int id, FornecedorRequest request)
    {
        var fornecedor = await fornecedorRepository.ObterPorId(id);

        fornecedor.AtualizarDados(request.RazaoSocial, request.NomeFantasia, request.CNPJ, request.Telefone, request.Email);

        await fornecedorRepository.Atualizar(fornecedor);
    }
}
