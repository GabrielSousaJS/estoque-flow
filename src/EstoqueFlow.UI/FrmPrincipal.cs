using EstoqueFlow.Application.Services.Sessao;
using EstoqueFlow.Application.UseCases.Categorias.Atualizar;
using EstoqueFlow.Application.UseCases.Categorias.ObterPorId;
using EstoqueFlow.Application.UseCases.Categorias.ObterTodas;
using EstoqueFlow.Application.UseCases.Categorias.Registrar;
using EstoqueFlow.Application.UseCases.Fornecedores.Atualizar;
using EstoqueFlow.Application.UseCases.Fornecedores.ObterPorId;
using EstoqueFlow.Application.UseCases.Fornecedores.ObterTodos;
using EstoqueFlow.Application.UseCases.Fornecedores.Registrar;
using EstoqueFlow.Application.UseCases.Movimentacoes.ObterTodos;
using EstoqueFlow.Application.UseCases.Movimentacoes.Registrar;
using EstoqueFlow.Application.UseCases.Produtos.Atualizar;
using EstoqueFlow.Application.UseCases.Produtos.ObterPorId;
using EstoqueFlow.Application.UseCases.Produtos.ObterTodos;
using EstoqueFlow.Application.UseCases.Produtos.Registrar;
using EstoqueFlow.Application.UseCases.Usuarios.Atualizar;
using EstoqueFlow.Application.UseCases.Usuarios.Desativar;
using EstoqueFlow.Application.UseCases.Usuarios.ObterPorId;
using EstoqueFlow.Application.UseCases.Usuarios.ObterTodos;
using EstoqueFlow.Application.ViewModel.Categorias;
using EstoqueFlow.Application.ViewModel.Fornecedores;
using EstoqueFlow.Application.ViewModel.Movimentacoes;
using EstoqueFlow.Application.ViewModel.Produtos;
using EstoqueFlow.Application.ViewModel.Usuarios;
using EstoqueFlow.UI.Utilitarios;

namespace EstoqueFlow.UI;
public partial class FrmPrincipal : Form
{
    private readonly ISessaoUsuarioService _sessaoUsuarioService;
    private readonly IDesativarUsuarioUseCase _desativarUsuarioUseCase;
    private UsuarioResponse usuarioAtual;

    public event Action? AbrirFrmLogin;

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
    private readonly IRegistrarProdutoUseCase _registrarProdutoUseCase;
    private readonly IRegistrarMovimentacaoUseCase _registrarMovimentacaoUseCase;
    #endregion

    #region OBTER DADOS POR ID
    private readonly IObterFornecedorPorIdUseCase _obterFornecedorPorIdUseCase;
    private readonly IObterCategoriaPorIdUseCase _obterCategoriaPorIdUseCase;
    private readonly IObterProdutoPorIdUseCase _obterProdutoPorIdUseCase;
    private readonly IObterUsuarioPorIdUseCase _obterUsuarioPorIdUseCase;
    #endregion

    #region USE CASES PARA ATUALIZAR
    private readonly IAtualizarFornecedorUseCase _atualizarFornecedorUseCase;
    private readonly IAtualizarCategoriaUseCase _atualizarCategoriaUseCase;
    private readonly IAtualizarProdutoUseCase _atualizarProdutoUseCase;
    private readonly IAtualizarUsuarioUseCase _atualizarUsuarioUseCase;
    #endregion

    private string _valorAnterior = string.Empty;

    public FrmPrincipal(
        ISessaoUsuarioService sessaoUsuarioService,
        IObterTodosFornecedoresUseCase obterTodosFornecedoresUseCase,
        IObterTodosCategoriasUseCase obterTodosCategoriasUseCase,
        IObterTodosProdutosUseCase obterTodosProdutosUseCase,
        IObterTodosMovimentacoesUseCase obterTodosMovimentacoesUseCase,
        IObterTodosUsuariosUseCase obterTodosUsuariosUseCase,
        IRegistrarFornecedorUseCase registrarFornecedorUseCase,
        IRegistrarCategoriaUseCase registrarCategoriaUseCase,
        IRegistrarProdutoUseCase registrarProdutoUseCase,
        IRegistrarMovimentacaoUseCase registrarMovimentacaoUseCase,
        IDesativarUsuarioUseCase desativarUsuarioUseCase,
        IObterFornecedorPorIdUseCase obterFornecedorPorIdUseCase,
        IObterCategoriaPorIdUseCase obterCategoriaPorIdUseCase,
        IObterProdutoPorIdUseCase obterProdutoPorIdUseCase,
        IAtualizarFornecedorUseCase atualizarFornecedorUseCase,
        IAtualizarCategoriaUseCase atualizarCategoriaUseCase,
        IAtualizarProdutoUseCase atualizarProdutoUseCase,
        IAtualizarUsuarioUseCase atualizarUsuarioUseCase,
        IObterUsuarioPorIdUseCase obterUsuarioPorIdUseCase

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
        _registrarProdutoUseCase = registrarProdutoUseCase;
        _registrarMovimentacaoUseCase = registrarMovimentacaoUseCase;
        _desativarUsuarioUseCase = desativarUsuarioUseCase;
        _obterFornecedorPorIdUseCase = obterFornecedorPorIdUseCase;
        _obterCategoriaPorIdUseCase = obterCategoriaPorIdUseCase;
        _obterProdutoPorIdUseCase = obterProdutoPorIdUseCase;
        _atualizarFornecedorUseCase = atualizarFornecedorUseCase;
        _atualizarCategoriaUseCase = atualizarCategoriaUseCase;
        _atualizarUsuarioUseCase = atualizarUsuarioUseCase;
        _atualizarProdutoUseCase = atualizarProdutoUseCase;
        _obterUsuarioPorIdUseCase = obterUsuarioPorIdUseCase;

        InitializeComponent();
    }

    #region INICIALIZAÇÃO DE COMPONENTES
    private void FrmPrincipal_Load(object sender, EventArgs e)
    {
        usuarioAtual = _sessaoUsuarioService.UsuarioAtual;

        LblUsuario.Text = usuarioAtual != null
            ? $"Usuário: {usuarioAtual.Nome}"
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
        TabPrincipal.TabPages.Remove(TbAtualizarUsuario);
        TabPrincipal.TabPages.Remove(TbAtualizarFornecedor);
        TabPrincipal.TabPages.Remove(TbAtualizarCategoria);
        TabPrincipal.TabPages.Remove(TbAtualizarProduto);
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
        CarregarDadosFornecedor();
        LayoutManager.LimparCampos(TbCadastrarFornecedor);
        LayoutManager.RestaurarGuiasRemovidas(TabPrincipal, TbCadastrarFornecedor, TbFornecedores);
    }

    private async void BtnCadastrarFornecedor_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TxtRazaoSocial.Text) ||
            string.IsNullOrWhiteSpace(TxtNomeFantasia.Text) ||
            !Validators.ValidarTelefoneFixo(TxtTelefoneFixo.Text) ||
            !Validators.VerificarEmail(TxtEmailFornecedor.Text))
        {
            MessageBox.Show("Verifique os dados e tente novamente", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (!Validators.ValidarCnpj(TxtCnpj.Text))
        {
            MessageBox.Show("O CNPJ é inválido, verifique e tente novamente", "CNPJ incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    #region ATUALIZAR FORNECEDOR
    private void DgvFornecedores_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (DgvFornecedores.CurrentRow is null)
        {
            return;
        }

        var row = DgvFornecedores.CurrentRow;

        int idFornecedor = (int)row.Cells["Id"].Value;

        CarregarDadosFornecedorParaAtualizar(idFornecedor);
        LayoutManager.MostraApenasUmaGuia(TabPrincipal, TbAtualizarFornecedor);
    }

    private async void CarregarDadosFornecedorParaAtualizar(int id)
    {
        var resposta = (FornecedorResponse)await CommonUtils.CarregarDadosParaAtualizar(id, _obterFornecedorPorIdUseCase);

        if (resposta is null)
        {
            MessageBox.Show("Fornecedor não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        TxtIdFornecedor.Text = resposta.Id.ToString();
        TxtRazaoSocialAtualizar.Text = resposta.RazaoSocial;
        TxtNomeFantasiaAtualizar.Text = resposta.NomeFantasia;
        TxtCnpjAtualizar.Text = resposta.CNPJ;
        TxtTelefoneFixoAtualizar.Text = resposta.Telefone;
        TxtEmailFornecedorAtualizar.Text = resposta.Email;
    }

    private void BtnCancelarAtualizacaoFornecedor_Click(object sender, EventArgs e)
    {
        CarregarDadosFornecedor();
        LayoutManager.LimparCampos(TbAtualizarFornecedor);
        LayoutManager.RestaurarGuiasRemovidas(TabPrincipal, TbAtualizarFornecedor, TbFornecedores);
    }

    private async void BtnAtualizarFornecedor_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TxtRazaoSocialAtualizar.Text) ||
            string.IsNullOrWhiteSpace(TxtNomeFantasiaAtualizar.Text) ||
            !Validators.ValidarTelefoneFixo(TxtTelefoneFixoAtualizar.Text) ||
            !Validators.VerificarEmail(TxtEmailFornecedorAtualizar.Text))
        {
            MessageBox.Show("Verifique os dados e tente novamente", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (!Validators.ValidarCnpj(TxtCnpjAtualizar.Text))
        {
            MessageBox.Show("O CNPJ é inválido, verifique e tente novamente", "CNPJ incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var request = new FornecedorRequest(razaoSocial: TxtRazaoSocialAtualizar.Text, nomeFantasia: TxtNomeFantasiaAtualizar.Text, cnpj: TxtCnpjAtualizar.Text, telefone: TxtTelefoneFixoAtualizar.Text, email: TxtEmailFornecedorAtualizar.Text);

        try
        {
            await _atualizarFornecedorUseCase.Executar(int.Parse(TxtIdFornecedor.Text), request);

            MessageBox.Show($"Fornecedor atualizado com sucesso!");

            LayoutManager.LimparCampos(TbAtualizarFornecedor);

            CarregarDadosFornecedor();
            BtnCancelarAtualizacaoFornecedor_Click(sender, e);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erro ao atualizar fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Error);

            TxtRazaoSocialAtualizar.Focus();
        }
    }
    #endregion
    #endregion

    #region CATEGORIA
    private void BtnAdicionarCategoria_Click(object sender, EventArgs e)
    {
        LayoutManager.MostraApenasUmaGuia(TabPrincipal, TbCadastrarCategoria);
    }

    private void BtnCancelarCadastroCategoria_Click(object sender, EventArgs e)
    {
        CarregarDadosCategoria();
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

    #region ATUALIZAR CATEGORIA
    private void DgvCategorias_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (DgvCategorias.CurrentRow is null)
        {
            return;
        }

        var row = DgvCategorias.CurrentRow;

        int idCategoria = (int)row.Cells["Id"].Value;

        CarregarDadosCategoriaParaAtualizar(idCategoria);
        LayoutManager.MostraApenasUmaGuia(TabPrincipal, TbAtualizarCategoria);
    }

    private async void CarregarDadosCategoriaParaAtualizar(int id)
    {
        var resposta = (CategoriaResponse)await CommonUtils.CarregarDadosParaAtualizar(id, _obterCategoriaPorIdUseCase);

        if (resposta is null)
        {
            MessageBox.Show("Categoria não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        TxtIdCategoria.Text = resposta.Id.ToString();
        TxtNomeCategoriaAtualizar.Text = resposta.Nome;
        TxtDescricaoCategoriaAtualizar.Text = resposta.Descricao;
    }

    private void BtnCancelarAtualizacaoCategoria_Click(object sender, EventArgs e)
    {
        CarregarDadosCategoria();
        LayoutManager.LimparCampos(TbAtualizarCategoria);
        LayoutManager.RestaurarGuiasRemovidas(TabPrincipal, TbAtualizarCategoria, TbCategorias);
    }

    private async void BtnAtualizarCategoria_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TxtNomeCategoriaAtualizar.Text))
        {
            MessageBox.Show("Preencha todos os campos obrigatórios.", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var request = new CategoriaRequest(nome: TxtNomeCategoriaAtualizar.Text, descricao: TxtDescricaoCategoriaAtualizar.Text);

        try
        {
            await _atualizarCategoriaUseCase.Executar(int.Parse(TxtIdCategoria.Text), request);

            MessageBox.Show($"Categoria atualizada com sucesso!");

            LayoutManager.LimparCampos(TbAtualizarCategoria);
            CarregarDadosCategoria();
            BtnCancelarAtualizacaoCategoria_Click(sender, e);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erro ao atualizar categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);

            TxtNomeCategoria.Focus();
        }
    }
    #endregion
    #endregion

    #region PRODUTO
    private async void BtnAdicionarProduto_Click(object sender, EventArgs e)
    {
        if (DgvFornecedores.Rows.Count == 0 || DgvCategorias.Rows.Count == 0)
        {
            MessageBox.Show("Cadastre pelo menos um fornecedor e uma categoria antes de cadastrar um produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        LayoutManager.MostraApenasUmaGuia(TabPrincipal, TbCadastrarProduto);

        var categorias = await _obterTodosCategoriasUseCase.Executar();
        CbCategoria.PreencherComboBox(categorias, "Nome", "Id");

        var fornecedores = await _obterTodosFornecedoresUseCase.Executar();
        CbFornecedor.PreencherComboBox(fornecedores, "NomeFantasia", "Id");
    }

    #region VALIDAÇÃO AO DIGITAR
    private void TxtValorCompra_TextChanged(object sender, EventArgs e)
    {
        TxtValorCompra.FormatarTextBoxNumeroDecimal(sender, e, ref _valorAnterior);
    }

    private void TxtValorCompra_KeyPress(object sender, KeyPressEventArgs e)
    {
        Validators.AllowNumber(e);
    }

    private void TxtValorVenda_TextChanged(object sender, EventArgs e)
    {
        TxtValorVenda.FormatarTextBoxNumeroDecimal(sender, e, ref _valorAnterior);
    }

    private void TxtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
    {
        Validators.AllowNumber(e);
    }
    #endregion

    private void BtnCancelarCadastroProduto_Click(object sender, EventArgs e)
    {
        CarregarDadosProduto();
        LayoutManager.LimparCampos(TbCadastrarProduto);
        LayoutManager.RestaurarGuiasRemovidas(TabPrincipal, TbCadastrarProduto, TbProdutos);
    }

    private async void BtnCadastrarProduto_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TxtNomeProduto.Text) ||
            string.IsNullOrWhiteSpace(TxtValorCompra.Text) ||
            string.IsNullOrWhiteSpace(TxtValorVenda.Text))
        {
            MessageBox.Show("Verifique os dados e tente novamente.", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        string valorCompra = TxtValorCompra.Text.Replace("R$ ", "").Replace(".", "").Trim();
        string valorVenda = TxtValorVenda.Text.Replace("R$ ", "").Replace(".", "").Trim();

        try
        {
            decimal precoCompra = decimal.Parse(valorCompra);
            decimal precoVenda = decimal.Parse(valorVenda);

            if (precoCompra <= 0 || precoVenda <= 0)
            {
                MessageBox.Show("Os valores de compra e venda devem ser maiores do que zero.", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var request = new ProdutosRequest(
                nome: TxtNomeProduto.Text,
                descricao: TxtDescricaoProduto.Text,
                precoCompra: precoCompra,
                precoVenda: precoVenda,
                estoqueMinimo: (int)NudEstoqueMinimo.Value,
                categoriaId: (int)CbCategoria.SelectedValue,
                fornecedorId: (int)CbFornecedor.SelectedValue
            );


            var resposta = await _registrarProdutoUseCase.Executar(request);

            MessageBox.Show($"Produto {resposta.Nome} cadastrado com sucesso!");

            LayoutManager.LimparCampos(TbCadastrarProduto);
            CarregarDadosProduto();
            BtnCancelarCadastroProduto_Click(sender, e);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erro ao cadastrar produto", MessageBoxButtons.OK, MessageBoxIcon.Error);

            TxtNomeProduto.Focus();
        }
    }

    #region ATUALIZAR PRODUTO
    private void DgvProdutos_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (DgvProdutos.CurrentRow is null)
        {
            return;
        }

        var row = DgvProdutos.CurrentRow;

        int idProduto = (int)row.Cells["Id"].Value;

        CarregarDadosProdutoParaAtualizar(idProduto);
        LayoutManager.MostraApenasUmaGuia(TabPrincipal, TbAtualizarProduto);
    }

    private async void CarregarDadosProdutoParaAtualizar(int id)
    {
        var resposta = (ProdutoResponse)await CommonUtils.CarregarDadosParaAtualizar(id, _obterProdutoPorIdUseCase);

        if (resposta is null)
        {
            MessageBox.Show("Produto não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        TxtIdProduto.Text = resposta.Id.ToString();
        TxtNomeProdutoAtualizar.Text = resposta.Nome;
        TxtValorCompraAtualizar.Text = resposta.PrecoCompra.ToString();
        TxtValorVendaAtualizar.Text = resposta.PrecoVenda.ToString();
        NudEstoqueMinimoAtualizar.Value = resposta.EstoqueMinimo;
        TxtDescricaoProdutoAtualizar.Text = resposta.Descricao;

        var categorias = await _obterTodosCategoriasUseCase.Executar();
        CbCategoriaAtualizar.PreencherComboBox(categorias, "Nome", "Id");
        CbCategoriaAtualizar.SelectedValue = resposta.CategoriaId;

        var fornecedores = await _obterTodosFornecedoresUseCase.Executar();
        CbFornecedorAtualizar.PreencherComboBox(fornecedores, "NomeFantasia", "Id");
        CbFornecedorAtualizar.SelectedValue = resposta.FornecedorId;
    }

    #region VALIDAÇÃO AO DIGITAR ATUALIZAÇÃO
    private void TxtValorCompraAtualizar_TextChanged(object sender, EventArgs e)
    {
        TxtValorCompraAtualizar.FormatarTextBoxNumeroDecimal(sender, e, ref _valorAnterior);
    }

    private void TxtValorCompraAtualizar_KeyPress(object sender, KeyPressEventArgs e)
    {
        Validators.AllowNumber(e);
    }

    private void TxtValorVendaAtualizar_TextChanged(object sender, EventArgs e)
    {
        TxtValorVendaAtualizar.FormatarTextBoxNumeroDecimal(sender, e, ref _valorAnterior);
    }

    private void TxtValorVendaAtualizar_KeyPress(object sender, KeyPressEventArgs e)
    {
        Validators.AllowNumber(e);
    }
    #endregion

    private void BtnCancelarAtualizacaoProduto_Click(object sender, EventArgs e)
    {
        CarregarDadosProduto();
        LayoutManager.LimparCampos(TbAtualizarProduto);
        LayoutManager.RestaurarGuiasRemovidas(TabPrincipal, TbAtualizarProduto, TbProdutos);
    }

    private async void BtnAtualizarProduto_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TxtNomeProdutoAtualizar.Text) ||
            string.IsNullOrWhiteSpace(TxtValorCompraAtualizar.Text) ||
            string.IsNullOrWhiteSpace(TxtValorVendaAtualizar.Text))
        {
            MessageBox.Show("Verifique os dados e tente novamente.", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        string valorCompra = TxtValorCompraAtualizar.Text.Replace("R$ ", "").Replace(".", "").Trim();
        string valorVenda = TxtValorVendaAtualizar.Text.Replace("R$ ", "").Replace(".", "").Trim();

        try
        {
            decimal precoCompra = decimal.Parse(valorCompra);
            decimal precoVenda = decimal.Parse(valorVenda);

            if (precoCompra <= 0 || precoVenda <= 0)
            {
                MessageBox.Show("Os valores de compra e venda devem ser maiores do que zero.", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var request = new ProdutosRequest(
                nome: TxtNomeProdutoAtualizar.Text,
                descricao: TxtDescricaoProdutoAtualizar.Text,
                precoCompra: precoCompra,
                precoVenda: precoVenda,
                estoqueMinimo: (int)NudEstoqueMinimoAtualizar.Value,
                categoriaId: (int)CbCategoriaAtualizar.SelectedValue,
                fornecedorId: (int)CbFornecedorAtualizar.SelectedValue
            );

            await _atualizarProdutoUseCase.Executar(int.Parse(TxtIdProduto.Text), request);

            MessageBox.Show($"Produto atualizado com sucesso!");

            LayoutManager.LimparCampos(TbAtualizarProduto);
            CarregarDadosProduto();
            BtnCancelarAtualizacaoProduto_Click(sender, e);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erro ao atualizar produto", MessageBoxButtons.OK, MessageBoxIcon.Error);

            TxtNomeProdutoAtualizar.Focus();
        }
    }
    #endregion
    #endregion

    #region MOVIMENTAÇÃO
    private async void BtnAdicionarMovimentacao_Click(object sender, EventArgs e)
    {
        if(DgvProdutos.Rows.Count <= 0)
        {
            MessageBox.Show("Cadastre pelo menos um produto antes de registrar uma movimentação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        CbTipoMovimentacao.PreencherComboBoxTipoMovimentacao();

        var produtos = await _obterTodosProdutosUseCase.Executar();
        CbProdutoMovimentacao.PreencherComboBox(produtos, "Nome", "Id");

        LayoutManager.MostraApenasUmaGuia(TabPrincipal, TbCadastrarMovimentacao);
    }

    private void BtnCancelarCadastroMovimentacao_Click(object sender, EventArgs e)
    {
        CarregarDadosMovimentacao();
        LayoutManager.LimparCampos(TbCadastrarMovimentacao);
        LayoutManager.RestaurarGuiasRemovidas(TabPrincipal, TbCadastrarMovimentacao, TbMovimentacoes);
    }

    private async void BtnCadastrarMovimentacao_Click(object sender, EventArgs e)
    {
        var request = new MovimentacaoRequest(
            tipo: (int)CbTipoMovimentacao.SelectedValue,
            quantidade: (int)NudQuantidade.Value,
            observacao: TxtObservacaoMovimentacao.Text,
            usuarioId: usuarioAtual.Id,
            produtoId: (int)CbProdutoMovimentacao.SelectedValue
        );

        try
        {
            var resposta = await _registrarMovimentacaoUseCase.Executar(request);

            MessageBox.Show($"Movimentação registrada com sucesso!");
            LayoutManager.LimparCampos(TbCadastrarMovimentacao);

            CarregarDadosMovimentacao();
            CarregarDadosProduto();

            BtnCancelarCadastroMovimentacao_Click(sender, e);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erro ao cadastrar movimentação", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    #endregion

    #region USUÁRIO
    private async void BtnDesativarConta_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Tem certeza que deseja desativar a sua conta?", "Desativar conta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
        {
            return;
        }

        try
        {
            await _desativarUsuarioUseCase.Executar(usuarioAtual.Id);

            _sessaoUsuarioService.LimparUsuarioAtual();
            MessageBox.Show("Conta desativada com sucesso!", "Desativar conta");

            AbrirFrmLogin?.Invoke();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erro ao desativar conta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnSair_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Tem certeza que deseja sair da conta?", "Sair", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
        {
            return;
        }

        _sessaoUsuarioService.LimparUsuarioAtual();

        AbrirFrmLogin?.Invoke();
    }

    #region ATUALIZAR USUÁRIO
    private void BtnAtualizarDados_Click(object sender, EventArgs e)
    {
        LayoutManager.MostraApenasUmaGuia(TabPrincipal, TbAtualizarUsuario);

        CarregarDadosUsuarioAtual();
    }

    private async void CarregarDadosUsuarioAtual()
    {
        var resposta = (UsuarioResponse)await CommonUtils.CarregarDadosParaAtualizar(usuarioAtual.Id, _obterUsuarioPorIdUseCase);

        if (resposta is null)
        {
            MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        TxtIdUsuario.Text = resposta.Id.ToString();
        TxtNomeUsuario.Text = resposta.Nome;
        TxtEmailUsuario.Text = resposta.Email;
    }

    private void BtnCancelarAtualizacaoUsuario_Click(object sender, EventArgs e)
    {
        CarregarDadosUsuario();
        LayoutManager.LimparCampos(TbAtualizarUsuario);
        LayoutManager.RestaurarGuiasRemovidas(TabPrincipal, TbAtualizarUsuario, TbUsuarios);
    }

    private async void BtnAtualizarUsuario_Click(object sender, EventArgs e)
    {
        if (!Validators.VerificarNome(TxtNomeUsuario.Text) ||
            !Validators.VerificarEmail(TxtEmailUsuario.Text))
        {
            MessageBox.Show("Verifique os dados e tente novamente.", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var request = new AtualizarUsuarioRequest(usuarioAtual.Id, TxtNomeUsuario.Text, TxtEmailUsuario.Text, TxtSenhaAtual.Text, TxtNovaSenha.Text);

        try
        {
            await _atualizarUsuarioUseCase.Executar(request);

            MessageBox.Show("Usuário atualizado com sucesso!", "Atualização de usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CarregarDadosUsuario();
            LayoutManager.LimparCampos(TbAtualizarUsuario);
            LayoutManager.RestaurarGuiasRemovidas(TabPrincipal, TbAtualizarUsuario, TbUsuarios);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erro ao atualizar usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            TxtNomeUsuario.Focus();
        }
    }
    #endregion
    #endregion
}
