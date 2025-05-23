using EstoqueFlow.Application.Services.Sessao;
using EstoqueFlow.Application.UseCases.Categorias.ObterTodas;
using EstoqueFlow.Application.UseCases.Fornecedores.ObterTodos;
using EstoqueFlow.Application.UseCases.Movimentacoes.ObterTodos;
using EstoqueFlow.Application.UseCases.Produtos.ObterTodos;
using EstoqueFlow.Application.UseCases.Usuarios.ObterTodos;
using EstoqueFlow.UI.Utilitarios;

namespace EstoqueFlow.UI;
public partial class FrmPrincipal : Form
{
    private readonly ISessaoUsuarioService _sessaoUsuarioService;

    #region OBTER TODOS USE CASES
    private readonly IObterTodosFornecedoresUseCase _obterTodosFornecedoresUseCase;
    private readonly IObterTodosCategoriasUseCase _obterTodosCategoriasUseCase;
    private readonly IObterTodosProdutosUseCase _obterTodosProdutosUseCase;
    private readonly IObterTodosMovimentacoesUseCase _obterTodosMovimentacoesUseCase;
    private readonly IObterTodosUsuariosUseCase _obterTodosUsuariosUseCase;
    #endregion

    public FrmPrincipal(
        ISessaoUsuarioService sessaoUsuarioService,
        IObterTodosFornecedoresUseCase obterTodosFornecedoresUseCase,
        IObterTodosCategoriasUseCase obterTodosCategoriasUseCase,
        IObterTodosProdutosUseCase obterTodosProdutosUseCase,
        IObterTodosMovimentacoesUseCase obterTodosMovimentacoesUseCase,
        IObterTodosUsuariosUseCase obterTodosUsuariosUseCase
    )
    {
        _sessaoUsuarioService = sessaoUsuarioService;
        _obterTodosFornecedoresUseCase = obterTodosFornecedoresUseCase;
        _obterTodosCategoriasUseCase = obterTodosCategoriasUseCase;
        _obterTodosProdutosUseCase = obterTodosProdutosUseCase;
        _obterTodosMovimentacoesUseCase = obterTodosMovimentacoesUseCase;
        _obterTodosUsuariosUseCase = obterTodosUsuariosUseCase;
        InitializeComponent();
    }

    #region INICIALIZAÇÃO DE COMPONENTES
    private void FrmPrincipal_Load(object sender, EventArgs e)
    {
        var usuario = _sessaoUsuarioService.UsuarioAtual;

        LblUsuario.Text = usuario != null
            ? $"Usuário: {usuario.Nome}"
            : "Usuário não definido";

        CarregarDadosGridView();
        GuiasInicias();
    }

    private void GuiasInicias()
    {
        TabPrincipal.TabPages.Remove(TbCadastrarFornecedor);
        TabPrincipal.TabPages.Remove(TbCadastrarCategoria);
        TabPrincipal.TabPages.Remove(TbCadastrarProduto);
        TabPrincipal.TabPages.Remove(TbCadastrarMovimentacao);
    }

    #region CARREGAMENTO DE DADOS DO GRIDVIEW
    private void CarregarDadosGridView()
    {
        CarregarDadosFornecedor();
        CarregarDadosCategoria();
        CarregarDadosProduto();
        CarregarDadosMovimentacao();
        CarregarDadosUsuario();
    }

    private async void CarregarDadosFornecedor()
    {
        var fornecedores = await _obterTodosFornecedoresUseCase.Executar();
        DgvFornecedores.DataSource = fornecedores;
        LayoutManager.ConfigurarDataGridView(DgvFornecedores);
    }

    private async void CarregarDadosCategoria()
    {
        var categorias = await _obterTodosCategoriasUseCase.Executar();
        DgvCategorias.DataSource = categorias;
        LayoutManager.ConfigurarDataGridView(DgvCategorias);
    }

    private async void CarregarDadosProduto()
    {
        var produtos = await _obterTodosProdutosUseCase.Executar();
        DgvProdutos.DataSource = produtos;
        LayoutManager.ConfigurarDataGridView(DgvProdutos);
    }

    private async void CarregarDadosMovimentacao()
    {
        var movimentacoes = await _obterTodosMovimentacoesUseCase.Executar();
        DgvMovimentacoes.DataSource = movimentacoes;
        LayoutManager.ConfigurarDataGridView(DgvMovimentacoes);
    }

    private async void CarregarDadosUsuario()
    {
        var usuarios = await _obterTodosUsuariosUseCase.Executar();
        DgvUsuarios.DataSource = usuarios;
        LayoutManager.ConfigurarDataGridView(DgvUsuarios);
    }
    #endregion
    #endregion

    #region FORNECEDOR
    private void BtnAdicionarFornecedor_Click(object sender, EventArgs e)
    {
        LayoutManager.MostraApenasUmaGuia(TabPrincipal, TbCadastrarFornecedor);
    }
    #endregion

    #region CATEGORIA
    private void BtnAdicionarCategoria_Click(object sender, EventArgs e)
    {
        LayoutManager.MostraApenasUmaGuia(TabPrincipal, TbCadastrarCategoria);
    }
    #endregion

    #region PRODUTO
    private void BtnAdicionarProduto_Click(object sender, EventArgs e)
    {
        LayoutManager.MostraApenasUmaGuia(TabPrincipal, TbCadastrarProduto);
    }
    #endregion

    #region MOVIMENTAÇÃO
    private void BtnAdicionarMovimentacao_Click(object sender, EventArgs e)
    {
        LayoutManager.MostraApenasUmaGuia(TabPrincipal, TbCadastrarMovimentacao);
    }
    #endregion

    #region USUÁRIO
    #endregion
}
