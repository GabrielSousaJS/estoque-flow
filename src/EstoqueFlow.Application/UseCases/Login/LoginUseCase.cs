using EstoqueFlow.Application.Mappings;
using EstoqueFlow.Application.ViewModel.Login;
using EstoqueFlow.Application.ViewModel.Usuarios;
using EstoqueFlow.Domain.Repositories;
using EstoqueFlow.Domain.Seguranca.Criptografia;

namespace EstoqueFlow.Application.UseCases.Login;

public class LoginUseCase(IUsuarioRepository usuarioRepository, ICriptografarSenha criptografarSenha) : ILoginUseCase
{
    public async Task<UsuarioResponse> Executar(LoginRequest request)
    {
        var usuario = await usuarioRepository.ObterUsuarioPorEmail(request.Email);

        if (usuario is null)
            throw new Exception("E-mail ou senha inválidos.");

        var senhaValida = criptografarSenha.VerificarSenha(request.Senha, usuario.Senha);

        if (!senhaValida)
            throw new Exception("E-mail ou senha inválidos.");

        return usuario.ToDto();
    }
}
