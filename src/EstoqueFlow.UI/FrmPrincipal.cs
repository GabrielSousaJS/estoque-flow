using EstoqueFlow.Application.Services.Sessao;
using EstoqueFlow.Application.UseCases.Usuarios.ObterTodos;

namespace EstoqueFlow.UI;
public partial class FrmPrincipal : Form
{
    private readonly ISessaoUsuarioService _sessaoUsuarioService;
    private readonly IObterTodosUsuariosUseCase _obterTodosUsuariosUseCase;

    #region CARREGAMENTO DE DADOS
    public FrmPrincipal(
        ISessaoUsuarioService sessaoUsuarioService,
        IObterTodosUsuariosUseCase obterTodosUsuariosUseCase
    )
    {
        _sessaoUsuarioService = sessaoUsuarioService;
        _obterTodosUsuariosUseCase = obterTodosUsuariosUseCase;
        InitializeComponent();
    }

    private void FrmPrincipal_Load(object sender, EventArgs e)
    {
        var usuario = _sessaoUsuarioService.UsuarioAtual;

        LblUsuario.Text = usuario != null
            ? $"Usuário: {usuario.Nome}"
            : "Usuário não definido";

        CarregarDadosGridView();
    }

    private async void CarregarDadosGridView()
    {
        var usuarios = await _obterTodosUsuariosUseCase.Executar();
        DgvUsuarios.DataSource = usuarios;
        ConfigurarDataGridView(DgvUsuarios);
    }

    private static void ConfigurarDataGridView(DataGridView dgvConfigurar)
    {
        dgvConfigurar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        int ultimaColunaIndex = dgvConfigurar.Columns.Count - 1;
        if (ultimaColunaIndex >= 0)
        {
            dgvConfigurar.Columns[ultimaColunaIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
    #endregion
}
