using EstoqueFlow.Application.Services.Sessao;
using EstoqueFlow.Application.UseCases.Categorias.ObterTodas;
using EstoqueFlow.Application.UseCases.Categorias.Registrar;
using EstoqueFlow.Application.UseCases.Fornecedores.ObterTodos;
using EstoqueFlow.Application.UseCases.Fornecedores.Registrar;
using EstoqueFlow.Application.UseCases.Movimentacoes.ObterTodos;
using EstoqueFlow.Application.UseCases.Produtos.ObterTodos;
using EstoqueFlow.Application.UseCases.Usuarios.ObterTodos;
using EstoqueFlow.Application.ViewModel.Categorias;
using EstoqueFlow.Application.ViewModel.Fornecedores;
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

    #region USE CASES PARA CADASTRO
    private readonly IRegistrarFornecedorUseCase _registrarFornecedorUseCase;
    private readonly IRegistrarCategoriaUseCase _registrarCategoriaUseCase;
    #endregion

    public FrmPrincipal(
        ISessaoUsuarioService sessaoUsuarioService,
        IObterTodosFornecedoresUseCase obterTodosFornecedoresUseCase,
        IObterTodosCategoriasUseCase obterTodosCategoriasUseCase,
        IObterTodosProdutosUseCase obterTodosProdutosUseCase,
        IObterTodosMovimentacoesUseCase obterTodosMovimentacoesUseCase,
        IObterTodosUsuariosUseCase obterTodosUsuariosUseCase,
        IRegistrarFornecedorUseCase registrarFornecedorUseCase,
        IRegistrarCategoriaUseCase registrarCategoriaUseCase
    )
    {
        _sessaoUsuarioService = sessaoUsuarioService;
        _obterTodosFornecedoresUseCase = obterTodosFornecedoresUseCase;
        _obterTodosCategoriasUseCase = obterTodosCategoriasUseCase;
        _obterTodosProdutosUseCase = obterTodosProdutosUseCase;
        _obterTodosMovimentacoesUseCase = obterTodosMovimentacoesUseCase;
        _obterTodosUsuariosUseCase = obterTodosUsuariosUseCase;
        _registrarFornecedorUseCase = registrarFornecedorUseCase;
        _registrarCategoriaUseCase = registrarCategoriaUseCase;
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

    private void BtnCancelarCadastroFornecedor_Click(object sender, EventArgs e)
    {
        LayoutManager.LimparCampos(TbCadastrarFornecedor);
        LayoutManager.RestaurarGuiasRemovidas(TabPrincipal, TbCadastrarFornecedor, TbFornecedores);
    }

    private async void BtnCadastrarFornecedor_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TxtRazaoSocial.Text) ||
            string.IsNullOrWhiteSpace(TxtNomeFantasia.Text) ||
            !Validators.ValidarCnpj(TxtCnpj.Text) ||
            !Validators.ValidarTelefoneFixo(TxtTelefoneFixo.Text) ||
            !Validators.VerificarEmail(TxtEmailFornecedor.Text))
        {
            MessageBox.Show("Verifique os dados e tente novamente", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var request = new FornecedorRequest(razaoSocial: TxtRazaoSocial.Text, nomeFantasia: TxtNomeFantasia.Text, cnpj: TxtCnpj.Text, telefone: TxtTelefoneFixo.Text, email: TxtEmailFornecedor.Text);

        try
        {
            var resposta = await _registrarFornecedorUseCase.Executar(request);

            MessageBox.Show($"Fornecedor {resposta.NomeFantasia} cadastrado com sucesso!");

            LayoutManager.LimparCampos(TbCadastrarFornecedor);

            CarregarDadosFornecedor();
            BtnCancelarCadastroFornecedor_Click(sender, e);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erro ao cadastrar fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Error);

            TxtRazaoSocial.Focus();
        }
    }
    #endregion

    #region CATEGORIA
    private void BtnAdicionarCategoria_Click(object sender, EventArgs e)
    {
        LayoutManager.MostraApenasUmaGuia(TabPrincipal, TbCadastrarCategoria);
    }

    private void BtnCancelarCadastroCategoria_Click(object sender, EventArgs e)
    {
        LayoutManager.LimparCampos(TbCadastrarCategoria);
        LayoutManager.RestaurarGuiasRemovidas(TabPrincipal, TbCadastrarCategoria, TbCategorias);
    }

    private async void BtnCadastrarCategoria_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TxtNomeCategoria.Text))
        {
            MessageBox.Show("Preencha todos os campos obrigatórios.", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var request = new CategoriaRequest(nome: TxtNomeCategoria.Text, descricao: TxtDescricaoCategoria.Text);

        try
        {
            var categoria = await _registrarCategoriaUseCase.Executar(request);

            MessageBox.Show($"Categoria {categoria.Nome} cadastrada com sucesso!");

            LayoutManager.LimparCampos(TbCadastrarCategoria);
            CarregarDadosCategoria();
            BtnCancelarCadastroCategoria_Click(sender, e);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erro ao cadastrar categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            TxtNomeCategoria.Focus();
        }
    }
    #endregion

    #region PRODUTO
    private async void BtnAdicionarProduto_Click(object sender, EventArgs e)
    {
        LayoutManager.MostraApenasUmaGuia(TabPrincipal, TbCadastrarProduto);

        var categorias = await _obterTodosCategoriasUseCase.Executar();
        CbCategoria.PreencherComboBox(categorias, "Nome", "Id");

        var fornecedores = await _obterTodosFornecedoresUseCase.Executar();
        CbFornecedor.PreencherComboBox(fornecedores, "NomeFantasia", "Id");
    }

    private void BtnCancelarCadastroProduto_Click(object sender, EventArgs e)
    {
        LayoutManager.LimparCampos(TbCadastrarProduto);
        LayoutManager.RestaurarGuiasRemovidas(TabPrincipal, TbCadastrarProduto, TbProdutos);
    }
    #endregion

    #region MOVIMENTAÇÃO
    private void BtnAdicionarMovimentacao_Click(object sender, EventArgs e)
    {
        LayoutManager.MostraApenasUmaGuia(TabPrincipal, TbCadastrarMovimentacao);
    }

    private void BtnCancelarCadastroMovimentacao_Click(object sender, EventArgs e)
    {
        LayoutManager.LimparCampos(TbCadastrarMovimentacao);
        LayoutManager.RestaurarGuiasRemovidas(TabPrincipal, TbCadastrarMovimentacao, TbMovimentacoes);
    }
    #endregion

    #region USUÁRIO
    #endregion
}
