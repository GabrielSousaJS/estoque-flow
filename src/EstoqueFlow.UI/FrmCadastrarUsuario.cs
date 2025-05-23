using EstoqueFlow.Application.Services.Sessao;
using EstoqueFlow.Application.UseCases.Usuarios.Registrar;
using EstoqueFlow.Application.ViewModel.Usuarios;
using EstoqueFlow.UI.Utilitarios;

namespace EstoqueFlow.UI;

public partial class FrmCadastrarUsuario : Form
{
    private readonly IRegistrarUsuarioUseCase _registrarUsuarioUseCase;
    private readonly ISessaoUsuarioService _sessaoUsuarioService;

    public event Action? AbrirFrmLogin;
    public event Action? AbrirFrmPrincipal;

    public FrmCadastrarUsuario(IRegistrarUsuarioUseCase registrarUsuarioUseCase, ISessaoUsuarioService sessaoUsuarioService)
    {
        _registrarUsuarioUseCase = registrarUsuarioUseCase;
        _sessaoUsuarioService = sessaoUsuarioService;
        InitializeComponent();
    }

    private void TxtNome_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            TxtEmail.Focus();
        }
    }

    private void TxtEmail_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            TxtSenha.Focus();
        }
    }

    private void TxtSenha_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            EfeitosVisuais.RealizarClickVisual(BtnCadastrar);
        }
    }

    private async void BtnCadastrar_Click(object sender, EventArgs e)
    {
        if (!Validators.VerificarNome(TxtNome.Text) || !Validators.VerificarEmail(TxtEmail.Text) || string.IsNullOrEmpty(TxtSenha.Text))
        {
            LblMensagemErroCadastro.Visible = true;
            return;
        }

        var viewModel = new UsuarioRequest(nome: TxtNome.Text, email: TxtEmail.Text, senha: TxtSenha.Text);

        try
        {
            var resposta = await _registrarUsuarioUseCase.Executar(viewModel);

            LblMensagemErroCadastro.Visible = false;

            _sessaoUsuarioService.DefinirUsuarioAtual(resposta);

            AbrirFrmPrincipal?.Invoke();
        }
        catch (Exception ex)
        {
            LblMensagemErroCadastro.Visible = true;
            LblMensagemErroCadastro.Text = ex.Message;

            TxtNome.Focus();
        }
    }
}
