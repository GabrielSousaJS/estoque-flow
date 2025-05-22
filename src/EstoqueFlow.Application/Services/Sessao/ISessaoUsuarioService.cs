using EstoqueFlow.Application.ViewModel.Usuarios;

namespace EstoqueFlow.Application.Services.Sessao;

public interface ISessaoUsuarioService
{
    UsuarioResponse UsuarioAtual { get; }
    void DefinirUsuarioAtual(UsuarioResponse usuario);
    void LimparUsuarioAtual();
}
