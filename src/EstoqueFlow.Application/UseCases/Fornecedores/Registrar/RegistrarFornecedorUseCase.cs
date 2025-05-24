using EstoqueFlow.Application.Mappings;
using EstoqueFlow.Application.ViewModel.Fornecedores;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Application.UseCases.Fornecedores.Registrar;

public class RegistrarFornecedorUseCase(IFornecedorRepository fornecedorRepository) : IRegistrarFornecedorUseCase
{
    public async Task<FornecedorResponse> Executar(FornecedorRequest request)
    {
        await ValidarCadastro(request);

        var entidade = request.ToEntidade();

        var fornecedor = await fornecedorRepository.Adicionar(entidade);

        return fornecedor.ToDto();
    }

    private async Task ValidarCadastro(FornecedorRequest request)
    {
        var fornecedorPorCnpj = await fornecedorRepository.ObterFornecedorPorCnpj(request.CNPJ);

        if (fornecedorPorCnpj is not null)
        {
            throw new Exception($"Fornecedor com CNPJ {request.CNPJ} já cadastrado.");
        }

        var fornecedorPorEmail = await fornecedorRepository.ObterFornecedorPorEmail(request.Email);

        if (fornecedorPorEmail is not null)
        {
            throw new Exception($"Fornecedor com e-mail {request.Email} já cadastrado.");
        }
    }
}
