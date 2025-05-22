using EstoqueFlow.Application.ViewModel.Usuarios;

namespace EstoqueFlow.Application.Services.Sessao;

public class SessaoUsuarioService : ISessaoUsuarioService
{
    public UsuarioResponse? UsuarioAtual { get; private set; }

    public void DefinirUsuarioAtual(UsuarioResponse usuario)
    {
        UsuarioAtual = usuario;
    }

    public void LimparUsuarioAtual()
    {
        UsuarioAtual = null;
    }
}
