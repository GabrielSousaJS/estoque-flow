using EstoqueFlow.Application.Mappings;
using EstoqueFlow.Application.ViewModel.Usuarios;
using EstoqueFlow.Domain.Repositories;
using EstoqueFlow.Domain.Seguranca.Criptografia;

namespace EstoqueFlow.Application.UseCases.Usuarios.Atualizar;

public class AtualizarUsuarioUseCase(IUsuarioRepository usuarioRepository, ICriptografarSenha criptografarSenha) : IAtualizarUsuarioUseCase
{
    public async Task Executar(int id, AtualizarUsuarioRequest request)
    {
        var usuario = await usuarioRepository.ObterPorId(id);
        var senhaCriptografada = criptografarSenha.Criptografar(request.Senha);

        usuario.AtualizarDados(request.Nome, request.Email, senhaCriptografada);

        await usuarioRepository.Atualizar(usuario);
    }
}
