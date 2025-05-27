using EstoqueFlow.Application.ViewModel.Usuarios;
using EstoqueFlow.Domain.Entities;
using EstoqueFlow.Domain.Repositories;
using EstoqueFlow.Domain.Seguranca.Criptografia;

namespace EstoqueFlow.Application.UseCases.Usuarios.Atualizar;

public class AtualizarUsuarioUseCase(IUsuarioRepository usuarioRepository, ICriptografarSenha criptografarSenha) : IAtualizarUsuarioUseCase
{
    public async Task Executar(AtualizarUsuarioRequest request)
    {
        var usuario = await ValidarDados(request);

        if (!string.IsNullOrEmpty(request.SenhaAtual) && !string.IsNullOrEmpty(request.SenhaNova))
        {
            var senhaCriptografada = criptografarSenha.Criptografar(request.SenhaNova);

            usuario.AtualizarSenha(senhaCriptografada);

            await usuarioRepository.AtualizarSenha(usuario);
        }

        usuario.AtualizarDados(request.Nome, request.Email);

        await usuarioRepository.Atualizar(usuario);
    }

    private async Task<Usuario> ValidarDados(AtualizarUsuarioRequest request)
    {
        var usuario = await usuarioRepository.ObterPorId(request.Id) ??
            throw new Exception("Usuário não encontrado.");

        if (!string.IsNullOrEmpty(request.SenhaAtual))
        {
            var senhaCorreta = criptografarSenha.VerificarSenha(request.SenhaAtual, usuario.Senha);

            if (!senhaCorreta)
            {
                throw new Exception("A senha atual está incorreta.");
            }
        }

        return usuario;
    }
}
