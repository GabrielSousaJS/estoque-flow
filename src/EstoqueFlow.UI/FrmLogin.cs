using EstoqueFlow.Application.Services.Sessao;
using EstoqueFlow.Application.UseCases.Login;
using EstoqueFlow.Application.ViewModel.Login;
using EstoqueFlow.UI.Utilitarios;

namespace EstoqueFlow.UI;
public partial class FrmLogin : Form
{
    private readonly ILoginUseCase _loginUseCase;
    private readonly ISessaoUsuarioService _sessaoUsuarioService;

    public event Action? AbrirFrmCadastrarUsuario;
    public event Action? AbrirFrmPrincipal;

    public FrmLogin(ILoginUseCase loginUseCase, ISessaoUsuarioService sessaoUsuarioService)
    {
        _loginUseCase = loginUseCase;
        _sessaoUsuarioService = sessaoUsuarioService;
        InitializeComponent();
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
            LayoutManager.RealizarClickVisual(BtnEntrar);
        }
    }

    private async void BtnEntrar_Click(object sender, EventArgs e)
    {
        if (!Validators.VerificarEmail(TxtEmail.Text) || string.IsNullOrWhiteSpace(TxtSenha.Text))
        {
            MessageBox.Show("Verifique os dados e tente novamente", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var request = new LoginRequest(email: TxtEmail.Text, senha: TxtSenha.Text);

        try
        {
            var resposta = await _loginUseCase.Executar(request);

            _sessaoUsuarioService.DefinirUsuarioAtual(resposta);

            AbrirFrmPrincipal?.Invoke();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);

            TxtEmail.Focus();
        }
    }

    private void LinkLblCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        AbrirFrmCadastrarUsuario?.Invoke();
    }
}
