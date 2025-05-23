using EstoqueFlow.Application.Services.Sessao;

namespace EstoqueFlow.UI;
public partial class FrmPrincipal : Form
{
    private readonly ISessaoUsuarioService _sessaoUsuarioService;

    public FrmPrincipal(ISessaoUsuarioService sessaoUsuarioService)
    {
        _sessaoUsuarioService = sessaoUsuarioService;
        InitializeComponent();
    }

    private void FrmPrincipal_Load(object sender, EventArgs e)
    {
        var usuario = _sessaoUsuarioService.UsuarioAtual;

        LblUsuario.Text = usuario != null
            ? $"Usuário: {usuario.Nome}"
            : "Usuário não definido";
    }
}
