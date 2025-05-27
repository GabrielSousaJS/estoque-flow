using EstoqueFlow.Application.Mappings;
using EstoqueFlow.Application.ViewModel.Usuarios;
using EstoqueFlow.Domain.Repositories;
using EstoqueFlow.Domain.Seguranca.Criptografia;

namespace EstoqueFlow.Application.UseCases.Usuarios.Registrar;

public class RegistrarUsuarioUseCase(
    IUsuarioRepository usuarioRepository, 
    ICriptografarSenha criptografarSenha
) : IRegistrarUsuarioUseCase
{
    public async Task<UsuarioResponse> Executar(UsuarioRequest request)
    {
        await ValidarDados(request);

        var entidade = request.ToEntidade();
        entidade.Senha = criptografarSenha.Criptografar(request.Senha);

        var usuario = await usuarioRepository.Adicionar(entidade);

        return usuario.ToDto();
    }

    private async Task ValidarDados(UsuarioRequest request)
    {
        var usuarioExistente = await usuarioRepository.ObterUsuarioPorEmail(request.Email);

        if (usuarioExistente is not null)
        { 
            throw new InvalidOperationException("Já existe uma conta ativa com esse e-mail.");
        }
    }
}
