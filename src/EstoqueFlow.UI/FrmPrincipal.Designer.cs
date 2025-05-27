namespace EstoqueFlow.UI;

partial class FrmPrincipal
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
        LblUsuario = new Label();
        TabPrincipal = new TabControl();
        TbFornecedores = new TabPage();
        BtnAdicionarFornecedor = new Button();
        DgvFornecedores = new DataGridView();
        TbCategorias = new TabPage();
        BtnAdicionarCategoria = new Button();
        DgvCategorias = new DataGridView();
        TbProdutos = new TabPage();
        BtnAdicionarProduto = new Button();
        DgvProdutos = new DataGridView();
        TbMovimentacoes = new TabPage();
        BtnAdicionarMovimentacao = new Button();
        DgvMovimentacoes = new DataGridView();
        TbUsuarios = new TabPage();
        BtnAtualizarDados = new Button();
        BtnDesativarConta = new Button();
        DgvUsuarios = new DataGridView();
        TbCadastrarFornecedor = new TabPage();
        BtnCancelarCadastroFornecedor = new Button();
        TxtTelefoneFixo = new MaskedTextBox();
        TxtCnpj = new MaskedTextBox();
        BtnCadastrarFornecedor = new Button();
        TxtEmailFornecedor = new TextBox();
        TxtNomeFantasia = new TextBox();
        TxtRazaoSocial = new TextBox();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        TbCadastrarCategoria = new TabPage();
        BtnCancelarCadastroCategoria = new Button();
        BtnCadastrarCategoria = new Button();
        TxtNomeCategoria = new TextBox();
        TxtDescricaoCategoria = new TextBox();
        label8 = new Label();
        label7 = new Label();
        TbCadastrarProduto = new TabPage();
        BtnCancelarCadastroProduto = new Button();
        NudEstoqueMinimo = new NumericUpDown();
        BtnCadastrarProduto = new Button();
        CbFornecedor = new ComboBox();
        CbCategoria = new ComboBox();
        TxtValorVenda = new TextBox();
        TxtValorCompra = new TextBox();
        TxtDescricaoProduto = new TextBox();
        TxtNomeProduto = new TextBox();
        label15 = new Label();
        label14 = new Label();
        label13 = new Label();
        label12 = new Label();
        label11 = new Label();
        label10 = new Label();
        label9 = new Label();
        TbCadastrarMovimentacao = new TabPage();
        CbProdutoMovimentacao = new ComboBox();
        label6 = new Label();
        BtnCancelarCadastroMovimentacao = new Button();
        BtnCadastrarMovimentacao = new Button();
        TxtObservacaoMovimentacao = new TextBox();
        label18 = new Label();
        NudQuantidade = new NumericUpDown();
        label17 = new Label();
        CbTipoMovimentacao = new ComboBox();
        label16 = new Label();
        TbAtualizarUsuario = new TabPage();
        BtnAtualizarUsuario = new Button();
        BtnCancelarAtualizacaoUsuario = new Button();
        TxtNovaSenha = new TextBox();
        TxtSenhaAtual = new TextBox();
        TxtEmailUsuario = new TextBox();
        TxtNomeUsuario = new TextBox();
        TxtIdUsuario = new TextBox();
        label23 = new Label();
        label22 = new Label();
        label21 = new Label();
        label20 = new Label();
        label19 = new Label();
        BtnSair = new Button();
        TabPrincipal.SuspendLayout();
        TbFornecedores.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)DgvFornecedores).BeginInit();
        TbCategorias.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)DgvCategorias).BeginInit();
        TbProdutos.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)DgvProdutos).BeginInit();
        TbMovimentacoes.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)DgvMovimentacoes).BeginInit();
        TbUsuarios.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)DgvUsuarios).BeginInit();
        TbCadastrarFornecedor.SuspendLayout();
        TbCadastrarCategoria.SuspendLayout();
        TbCadastrarProduto.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NudEstoqueMinimo).BeginInit();
        TbCadastrarMovimentacao.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NudQuantidade).BeginInit();
        TbAtualizarUsuario.SuspendLayout();
        SuspendLayout();
        // 
        // LblUsuario
        // 
        LblUsuario.AutoSize = true;
        LblUsuario.Location = new Point(3, 10);
        LblUsuario.Name = "LblUsuario";
        LblUsuario.Size = new Size(156, 20);
        LblUsuario.TabIndex = 0;
        LblUsuario.Text = "Usuário: _______________";
        // 
        // TabPrincipal
        // 
        TabPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        TabPrincipal.Controls.Add(TbFornecedores);
        TabPrincipal.Controls.Add(TbCategorias);
        TabPrincipal.Controls.Add(TbProdutos);
        TabPrincipal.Controls.Add(TbMovimentacoes);
        TabPrincipal.Controls.Add(TbUsuarios);
        TabPrincipal.Controls.Add(TbCadastrarFornecedor);
        TabPrincipal.Controls.Add(TbCadastrarCategoria);
        TabPrincipal.Controls.Add(TbCadastrarProduto);
        TabPrincipal.Controls.Add(TbCadastrarMovimentacao);
        TabPrincipal.Controls.Add(TbAtualizarUsuario);
        TabPrincipal.Location = new Point(3, 41);
        TabPrincipal.Name = "TabPrincipal";
        TabPrincipal.SelectedIndex = 0;
        TabPrincipal.Size = new Size(993, 539);
        TabPrincipal.TabIndex = 1;
        // 
        // TbFornecedores
        // 
        TbFornecedores.Controls.Add(BtnAdicionarFornecedor);
        TbFornecedores.Controls.Add(DgvFornecedores);
        TbFornecedores.Location = new Point(4, 29);
        TbFornecedores.Name = "TbFornecedores";
        TbFornecedores.Padding = new Padding(3);
        TbFornecedores.Size = new Size(985, 506);
        TbFornecedores.TabIndex = 0;
        TbFornecedores.Text = "Fornecedores";
        TbFornecedores.UseVisualStyleBackColor = true;
        // 
        // BtnAdicionarFornecedor
        // 
        BtnAdicionarFornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        BtnAdicionarFornecedor.Location = new Point(793, 6);
        BtnAdicionarFornecedor.Name = "BtnAdicionarFornecedor";
        BtnAdicionarFornecedor.Size = new Size(186, 29);
        BtnAdicionarFornecedor.TabIndex = 1;
        BtnAdicionarFornecedor.Text = "Adicionar fornecedor";
        BtnAdicionarFornecedor.UseVisualStyleBackColor = true;
        BtnAdicionarFornecedor.Click += BtnAdicionarFornecedor_Click;
        // 
        // DgvFornecedores
        // 
        DgvFornecedores.AllowUserToAddRows = false;
        DgvFornecedores.AllowUserToDeleteRows = false;
        DgvFornecedores.AllowUserToOrderColumns = true;
        DgvFornecedores.AllowUserToResizeColumns = false;
        DgvFornecedores.AllowUserToResizeRows = false;
        DgvFornecedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        DgvFornecedores.BackgroundColor = Color.White;
        DgvFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DgvFornecedores.GridColor = Color.Black;
        DgvFornecedores.Location = new Point(6, 41);
        DgvFornecedores.Name = "DgvFornecedores";
        DgvFornecedores.ReadOnly = true;
        DgvFornecedores.RowHeadersWidth = 51;
        DgvFornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        DgvFornecedores.Size = new Size(973, 459);
        DgvFornecedores.TabIndex = 0;
        // 
        // TbCategorias
        // 
        TbCategorias.Controls.Add(BtnAdicionarCategoria);
        TbCategorias.Controls.Add(DgvCategorias);
        TbCategorias.Location = new Point(4, 29);
        TbCategorias.Name = "TbCategorias";
        TbCategorias.Padding = new Padding(3);
        TbCategorias.Size = new Size(985, 506);
        TbCategorias.TabIndex = 1;
        TbCategorias.Text = "Categorias";
        TbCategorias.UseVisualStyleBackColor = true;
        // 
        // BtnAdicionarCategoria
        // 
        BtnAdicionarCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        BtnAdicionarCategoria.Location = new Point(793, 6);
        BtnAdicionarCategoria.Name = "BtnAdicionarCategoria";
        BtnAdicionarCategoria.Size = new Size(186, 29);
        BtnAdicionarCategoria.TabIndex = 2;
        BtnAdicionarCategoria.Text = "Adicionar categoria";
        BtnAdicionarCategoria.UseVisualStyleBackColor = true;
        BtnAdicionarCategoria.Click += BtnAdicionarCategoria_Click;
        // 
        // DgvCategorias
        // 
        DgvCategorias.AllowUserToAddRows = false;
        DgvCategorias.AllowUserToDeleteRows = false;
        DgvCategorias.AllowUserToOrderColumns = true;
        DgvCategorias.AllowUserToResizeColumns = false;
        DgvCategorias.AllowUserToResizeRows = false;
        DgvCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        DgvCategorias.BackgroundColor = Color.White;
        DgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DgvCategorias.GridColor = Color.Black;
        DgvCategorias.Location = new Point(6, 41);
        DgvCategorias.Name = "DgvCategorias";
        DgvCategorias.ReadOnly = true;
        DgvCategorias.RowHeadersWidth = 51;
        DgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        DgvCategorias.Size = new Size(973, 459);
        DgvCategorias.TabIndex = 1;
        // 
        // TbProdutos
        // 
        TbProdutos.Controls.Add(BtnAdicionarProduto);
        TbProdutos.Controls.Add(DgvProdutos);
        TbProdutos.Location = new Point(4, 29);
        TbProdutos.Name = "TbProdutos";
        TbProdutos.Padding = new Padding(3);
        TbProdutos.Size = new Size(985, 506);
        TbProdutos.TabIndex = 2;
        TbProdutos.Text = "Produtos";
        TbProdutos.UseVisualStyleBackColor = true;
        // 
        // BtnAdicionarProduto
        // 
        BtnAdicionarProduto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        BtnAdicionarProduto.Location = new Point(793, 6);
        BtnAdicionarProduto.Name = "BtnAdicionarProduto";
        BtnAdicionarProduto.Size = new Size(186, 29);
        BtnAdicionarProduto.TabIndex = 3;
        BtnAdicionarProduto.Text = "Adicionar produto";
        BtnAdicionarProduto.UseVisualStyleBackColor = true;
        BtnAdicionarProduto.Click += BtnAdicionarProduto_Click;
        // 
        // DgvProdutos
        // 
        DgvProdutos.AllowUserToAddRows = false;
        DgvProdutos.AllowUserToDeleteRows = false;
        DgvProdutos.AllowUserToOrderColumns = true;
        DgvProdutos.AllowUserToResizeColumns = false;
        DgvProdutos.AllowUserToResizeRows = false;
        DgvProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        DgvProdutos.BackgroundColor = Color.White;
        DgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DgvProdutos.GridColor = Color.Black;
        DgvProdutos.Location = new Point(6, 41);
        DgvProdutos.Name = "DgvProdutos";
        DgvProdutos.ReadOnly = true;
        DgvProdutos.RowHeadersWidth = 51;
        DgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        DgvProdutos.Size = new Size(973, 459);
        DgvProdutos.TabIndex = 2;
        // 
        // TbMovimentacoes
        // 
        TbMovimentacoes.Controls.Add(BtnAdicionarMovimentacao);
        TbMovimentacoes.Controls.Add(DgvMovimentacoes);
        TbMovimentacoes.Location = new Point(4, 29);
        TbMovimentacoes.Name = "TbMovimentacoes";
        TbMovimentacoes.Padding = new Padding(3);
        TbMovimentacoes.Size = new Size(985, 506);
        TbMovimentacoes.TabIndex = 3;
        TbMovimentacoes.Text = "Movimentações";
        TbMovimentacoes.UseVisualStyleBackColor = true;
        // 
        // BtnAdicionarMovimentacao
        // 
        BtnAdicionarMovimentacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        BtnAdicionarMovimentacao.Location = new Point(793, 6);
        BtnAdicionarMovimentacao.Name = "BtnAdicionarMovimentacao";
        BtnAdicionarMovimentacao.Size = new Size(186, 29);
        BtnAdicionarMovimentacao.TabIndex = 4;
        BtnAdicionarMovimentacao.Text = "Adicionar movimentação";
        BtnAdicionarMovimentacao.UseVisualStyleBackColor = true;
        BtnAdicionarMovimentacao.Click += BtnAdicionarMovimentacao_Click;
        // 
        // DgvMovimentacoes
        // 
        DgvMovimentacoes.AllowUserToAddRows = false;
        DgvMovimentacoes.AllowUserToDeleteRows = false;
        DgvMovimentacoes.AllowUserToOrderColumns = true;
        DgvMovimentacoes.AllowUserToResizeColumns = false;
        DgvMovimentacoes.AllowUserToResizeRows = false;
        DgvMovimentacoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        DgvMovimentacoes.BackgroundColor = Color.White;
        DgvMovimentacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DgvMovimentacoes.GridColor = Color.Black;
        DgvMovimentacoes.Location = new Point(6, 41);
        DgvMovimentacoes.Name = "DgvMovimentacoes";
        DgvMovimentacoes.ReadOnly = true;
        DgvMovimentacoes.RowHeadersWidth = 51;
        DgvMovimentacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        DgvMovimentacoes.Size = new Size(973, 459);
        DgvMovimentacoes.TabIndex = 3;
        // 
        // TbUsuarios
        // 
        TbUsuarios.Controls.Add(BtnAtualizarDados);
        TbUsuarios.Controls.Add(BtnDesativarConta);
        TbUsuarios.Controls.Add(DgvUsuarios);
        TbUsuarios.Location = new Point(4, 29);
        TbUsuarios.Name = "TbUsuarios";
        TbUsuarios.Padding = new Padding(3);
        TbUsuarios.Size = new Size(985, 506);
        TbUsuarios.TabIndex = 4;
        TbUsuarios.Text = "Usuários";
        TbUsuarios.UseVisualStyleBackColor = true;
        // 
        // BtnAtualizarDados
        // 
        BtnAtualizarDados.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        BtnAtualizarDados.Location = new Point(793, 6);
        BtnAtualizarDados.Name = "BtnAtualizarDados";
        BtnAtualizarDados.Size = new Size(186, 29);
        BtnAtualizarDados.TabIndex = 6;
        BtnAtualizarDados.Text = "Atualizar dados";
        BtnAtualizarDados.UseVisualStyleBackColor = true;
        BtnAtualizarDados.Click += BtnAtualizarDados_Click;
        // 
        // BtnDesativarConta
        // 
        BtnDesativarConta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        BtnDesativarConta.Location = new Point(793, 471);
        BtnDesativarConta.Name = "BtnDesativarConta";
        BtnDesativarConta.Size = new Size(186, 29);
        BtnDesativarConta.TabIndex = 5;
        BtnDesativarConta.Text = "Desativar conta";
        BtnDesativarConta.UseVisualStyleBackColor = true;
        BtnDesativarConta.Click += BtnDesativarConta_Click;
        // 
        // DgvUsuarios
        // 
        DgvUsuarios.AllowUserToAddRows = false;
        DgvUsuarios.AllowUserToDeleteRows = false;
        DgvUsuarios.AllowUserToOrderColumns = true;
        DgvUsuarios.AllowUserToResizeColumns = false;
        DgvUsuarios.AllowUserToResizeRows = false;
        DgvUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        DgvUsuarios.BackgroundColor = Color.White;
        DgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DgvUsuarios.GridColor = Color.Black;
        DgvUsuarios.Location = new Point(6, 41);
        DgvUsuarios.Name = "DgvUsuarios";
        DgvUsuarios.ReadOnly = true;
        DgvUsuarios.RowHeadersWidth = 51;
        DgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        DgvUsuarios.Size = new Size(973, 424);
        DgvUsuarios.TabIndex = 4;
        // 
        // TbCadastrarFornecedor
        // 
        TbCadastrarFornecedor.Controls.Add(BtnCancelarCadastroFornecedor);
        TbCadastrarFornecedor.Controls.Add(TxtTelefoneFixo);
        TbCadastrarFornecedor.Controls.Add(TxtCnpj);
        TbCadastrarFornecedor.Controls.Add(BtnCadastrarFornecedor);
        TbCadastrarFornecedor.Controls.Add(TxtEmailFornecedor);
        TbCadastrarFornecedor.Controls.Add(TxtNomeFantasia);
        TbCadastrarFornecedor.Controls.Add(TxtRazaoSocial);
        TbCadastrarFornecedor.Controls.Add(label5);
        TbCadastrarFornecedor.Controls.Add(label4);
        TbCadastrarFornecedor.Controls.Add(label3);
        TbCadastrarFornecedor.Controls.Add(label2);
        TbCadastrarFornecedor.Controls.Add(label1);
        TbCadastrarFornecedor.Location = new Point(4, 29);
        TbCadastrarFornecedor.Name = "TbCadastrarFornecedor";
        TbCadastrarFornecedor.Padding = new Padding(3);
        TbCadastrarFornecedor.Size = new Size(985, 506);
        TbCadastrarFornecedor.TabIndex = 5;
        TbCadastrarFornecedor.Text = "Cadastrar Fornecedor";
        TbCadastrarFornecedor.UseVisualStyleBackColor = true;
        // 
        // BtnCancelarCadastroFornecedor
        // 
        BtnCancelarCadastroFornecedor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        BtnCancelarCadastroFornecedor.Location = new Point(5, 471);
        BtnCancelarCadastroFornecedor.Name = "BtnCancelarCadastroFornecedor";
        BtnCancelarCadastroFornecedor.Size = new Size(139, 29);
        BtnCancelarCadastroFornecedor.TabIndex = 14;
        BtnCancelarCadastroFornecedor.Text = "Cancelar";
        BtnCancelarCadastroFornecedor.UseVisualStyleBackColor = true;
        BtnCancelarCadastroFornecedor.Click += BtnCancelarCadastroFornecedor_Click;
        // 
        // TxtTelefoneFixo
        // 
        TxtTelefoneFixo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        TxtTelefoneFixo.Location = new Point(357, 236);
        TxtTelefoneFixo.Mask = "(00) 0000-0000";
        TxtTelefoneFixo.Name = "TxtTelefoneFixo";
        TxtTelefoneFixo.Size = new Size(271, 27);
        TxtTelefoneFixo.TabIndex = 13;
        // 
        // TxtCnpj
        // 
        TxtCnpj.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        TxtCnpj.Location = new Point(357, 172);
        TxtCnpj.Mask = "00,000,000/0000-00";
        TxtCnpj.Name = "TxtCnpj";
        TxtCnpj.Size = new Size(271, 27);
        TxtCnpj.TabIndex = 12;
        // 
        // BtnCadastrarFornecedor
        // 
        BtnCadastrarFornecedor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        BtnCadastrarFornecedor.Location = new Point(839, 471);
        BtnCadastrarFornecedor.Name = "BtnCadastrarFornecedor";
        BtnCadastrarFornecedor.Size = new Size(139, 29);
        BtnCadastrarFornecedor.TabIndex = 10;
        BtnCadastrarFornecedor.Text = "Cadastrar";
        BtnCadastrarFornecedor.UseVisualStyleBackColor = true;
        BtnCadastrarFornecedor.Click += BtnCadastrarFornecedor_Click;
        // 
        // TxtEmailFornecedor
        // 
        TxtEmailFornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        TxtEmailFornecedor.CharacterCasing = CharacterCasing.Lower;
        TxtEmailFornecedor.Location = new Point(357, 300);
        TxtEmailFornecedor.Name = "TxtEmailFornecedor";
        TxtEmailFornecedor.Size = new Size(271, 27);
        TxtEmailFornecedor.TabIndex = 9;
        // 
        // TxtNomeFantasia
        // 
        TxtNomeFantasia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        TxtNomeFantasia.Location = new Point(357, 107);
        TxtNomeFantasia.Name = "TxtNomeFantasia";
        TxtNomeFantasia.Size = new Size(271, 27);
        TxtNomeFantasia.TabIndex = 6;
        // 
        // TxtRazaoSocial
        // 
        TxtRazaoSocial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        TxtRazaoSocial.Location = new Point(357, 41);
        TxtRazaoSocial.Name = "TxtRazaoSocial";
        TxtRazaoSocial.Size = new Size(271, 27);
        TxtRazaoSocial.TabIndex = 5;
        // 
        // label5
        // 
        label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label5.AutoSize = true;
        label5.Location = new Point(357, 277);
        label5.Name = "label5";
        label5.Size = new Size(52, 20);
        label5.TabIndex = 4;
        label5.Text = "E-mail";
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label4.AutoSize = true;
        label4.Location = new Point(357, 213);
        label4.Name = "label4";
        label4.Size = new Size(97, 20);
        label4.TabIndex = 3;
        label4.Text = "Telefone Fixo";
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label3.AutoSize = true;
        label3.Location = new Point(357, 149);
        label3.Name = "label3";
        label3.Size = new Size(41, 20);
        label3.TabIndex = 2;
        label3.Text = "CNPJ";
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Location = new Point(357, 84);
        label2.Name = "label2";
        label2.Size = new Size(107, 20);
        label2.TabIndex = 1;
        label2.Text = "Nome Fantasia";
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Location = new Point(357, 18);
        label1.Name = "label1";
        label1.Size = new Size(94, 20);
        label1.TabIndex = 0;
        label1.Text = "Razão Social";
        // 
        // TbCadastrarCategoria
        // 
        TbCadastrarCategoria.Controls.Add(BtnCancelarCadastroCategoria);
        TbCadastrarCategoria.Controls.Add(BtnCadastrarCategoria);
        TbCadastrarCategoria.Controls.Add(TxtNomeCategoria);
        TbCadastrarCategoria.Controls.Add(TxtDescricaoCategoria);
        TbCadastrarCategoria.Controls.Add(label8);
        TbCadastrarCategoria.Controls.Add(label7);
        TbCadastrarCategoria.Location = new Point(4, 29);
        TbCadastrarCategoria.Name = "TbCadastrarCategoria";
        TbCadastrarCategoria.Padding = new Padding(3);
        TbCadastrarCategoria.Size = new Size(985, 506);
        TbCadastrarCategoria.TabIndex = 6;
        TbCadastrarCategoria.Text = "Cadastrar Categoria";
        TbCadastrarCategoria.UseVisualStyleBackColor = true;
        // 
        // BtnCancelarCadastroCategoria
        // 
        BtnCancelarCadastroCategoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        BtnCancelarCadastroCategoria.Location = new Point(3, 471);
        BtnCancelarCadastroCategoria.Name = "BtnCancelarCadastroCategoria";
        BtnCancelarCadastroCategoria.Size = new Size(139, 29);
        BtnCancelarCadastroCategoria.TabIndex = 15;
        BtnCancelarCadastroCategoria.Text = "Cancelar";
        BtnCancelarCadastroCategoria.UseVisualStyleBackColor = true;
        BtnCancelarCadastroCategoria.Click += BtnCancelarCadastroCategoria_Click;
        // 
        // BtnCadastrarCategoria
        // 
        BtnCadastrarCategoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        BtnCadastrarCategoria.Location = new Point(839, 471);
        BtnCadastrarCategoria.Name = "BtnCadastrarCategoria";
        BtnCadastrarCategoria.Size = new Size(139, 29);
        BtnCadastrarCategoria.TabIndex = 11;
        BtnCadastrarCategoria.Text = "Cadastrar";
        BtnCadastrarCategoria.UseVisualStyleBackColor = true;
        BtnCadastrarCategoria.Click += BtnCadastrarCategoria_Click;
        // 
        // TxtNomeCategoria
        // 
        TxtNomeCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        TxtNomeCategoria.Location = new Point(357, 73);
        TxtNomeCategoria.Name = "TxtNomeCategoria";
        TxtNomeCategoria.Size = new Size(271, 27);
        TxtNomeCategoria.TabIndex = 3;
        // 
        // TxtDescricaoCategoria
        // 
        TxtDescricaoCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        TxtDescricaoCategoria.Location = new Point(357, 139);
        TxtDescricaoCategoria.Multiline = true;
        TxtDescricaoCategoria.Name = "TxtDescricaoCategoria";
        TxtDescricaoCategoria.ScrollBars = ScrollBars.Vertical;
        TxtDescricaoCategoria.Size = new Size(271, 200);
        TxtDescricaoCategoria.TabIndex = 2;
        // 
        // label8
        // 
        label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label8.AutoSize = true;
        label8.Location = new Point(357, 116);
        label8.Name = "label8";
        label8.Size = new Size(74, 20);
        label8.TabIndex = 1;
        label8.Text = "Descrição";
        // 
        // label7
        // 
        label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label7.AutoSize = true;
        label7.Location = new Point(357, 50);
        label7.Name = "label7";
        label7.Size = new Size(119, 20);
        label7.TabIndex = 0;
        label7.Text = "Nome Categoria";
        // 
        // TbCadastrarProduto
        // 
        TbCadastrarProduto.Controls.Add(BtnCancelarCadastroProduto);
        TbCadastrarProduto.Controls.Add(NudEstoqueMinimo);
        TbCadastrarProduto.Controls.Add(BtnCadastrarProduto);
        TbCadastrarProduto.Controls.Add(CbFornecedor);
        TbCadastrarProduto.Controls.Add(CbCategoria);
        TbCadastrarProduto.Controls.Add(TxtValorVenda);
        TbCadastrarProduto.Controls.Add(TxtValorCompra);
        TbCadastrarProduto.Controls.Add(TxtDescricaoProduto);
        TbCadastrarProduto.Controls.Add(TxtNomeProduto);
        TbCadastrarProduto.Controls.Add(label15);
        TbCadastrarProduto.Controls.Add(label14);
        TbCadastrarProduto.Controls.Add(label13);
        TbCadastrarProduto.Controls.Add(label12);
        TbCadastrarProduto.Controls.Add(label11);
        TbCadastrarProduto.Controls.Add(label10);
        TbCadastrarProduto.Controls.Add(label9);
        TbCadastrarProduto.Location = new Point(4, 29);
        TbCadastrarProduto.Name = "TbCadastrarProduto";
        TbCadastrarProduto.Padding = new Padding(3);
        TbCadastrarProduto.Size = new Size(985, 506);
        TbCadastrarProduto.TabIndex = 7;
        TbCadastrarProduto.Text = "Cadastrar Produto";
        TbCadastrarProduto.UseVisualStyleBackColor = true;
        // 
        // BtnCancelarCadastroProduto
        // 
        BtnCancelarCadastroProduto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        BtnCancelarCadastroProduto.Location = new Point(3, 471);
        BtnCancelarCadastroProduto.Name = "BtnCancelarCadastroProduto";
        BtnCancelarCadastroProduto.Size = new Size(139, 29);
        BtnCancelarCadastroProduto.TabIndex = 17;
        BtnCancelarCadastroProduto.Text = "Cancelar";
        BtnCancelarCadastroProduto.UseVisualStyleBackColor = true;
        BtnCancelarCadastroProduto.Click += BtnCancelarCadastroProduto_Click;
        // 
        // NudEstoqueMinimo
        // 
        NudEstoqueMinimo.Location = new Point(19, 204);
        NudEstoqueMinimo.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
        NudEstoqueMinimo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        NudEstoqueMinimo.Name = "NudEstoqueMinimo";
        NudEstoqueMinimo.Size = new Size(271, 27);
        NudEstoqueMinimo.TabIndex = 15;
        NudEstoqueMinimo.TextAlign = HorizontalAlignment.Right;
        NudEstoqueMinimo.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // BtnCadastrarProduto
        // 
        BtnCadastrarProduto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        BtnCadastrarProduto.Location = new Point(839, 471);
        BtnCadastrarProduto.Name = "BtnCadastrarProduto";
        BtnCadastrarProduto.Size = new Size(139, 29);
        BtnCadastrarProduto.TabIndex = 14;
        BtnCadastrarProduto.Text = "Cadastrar";
        BtnCadastrarProduto.UseVisualStyleBackColor = true;
        BtnCadastrarProduto.Click += BtnCadastrarProduto_Click;
        // 
        // CbFornecedor
        // 
        CbFornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
        CbFornecedor.FormattingEnabled = true;
        CbFornecedor.Location = new Point(369, 117);
        CbFornecedor.Name = "CbFornecedor";
        CbFornecedor.Size = new Size(271, 28);
        CbFornecedor.TabIndex = 13;
        // 
        // CbCategoria
        // 
        CbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        CbCategoria.FormattingEnabled = true;
        CbCategoria.Location = new Point(19, 289);
        CbCategoria.Name = "CbCategoria";
        CbCategoria.Size = new Size(271, 28);
        CbCategoria.TabIndex = 12;
        // 
        // TxtValorVenda
        // 
        TxtValorVenda.Location = new Point(369, 39);
        TxtValorVenda.Name = "TxtValorVenda";
        TxtValorVenda.Size = new Size(271, 27);
        TxtValorVenda.TabIndex = 10;
        TxtValorVenda.TextAlign = HorizontalAlignment.Right;
        TxtValorVenda.TextChanged += TxtValorVenda_TextChanged;
        TxtValorVenda.KeyPress += TxtValorVenda_KeyPress;
        // 
        // TxtValorCompra
        // 
        TxtValorCompra.Location = new Point(19, 118);
        TxtValorCompra.Name = "TxtValorCompra";
        TxtValorCompra.Size = new Size(271, 27);
        TxtValorCompra.TabIndex = 9;
        TxtValorCompra.TextAlign = HorizontalAlignment.Right;
        TxtValorCompra.TextChanged += TxtValorCompra_TextChanged;
        TxtValorCompra.KeyPress += TxtValorCompra_KeyPress;
        // 
        // TxtDescricaoProduto
        // 
        TxtDescricaoProduto.Location = new Point(369, 203);
        TxtDescricaoProduto.Multiline = true;
        TxtDescricaoProduto.Name = "TxtDescricaoProduto";
        TxtDescricaoProduto.ScrollBars = ScrollBars.Vertical;
        TxtDescricaoProduto.Size = new Size(408, 114);
        TxtDescricaoProduto.TabIndex = 8;
        // 
        // TxtNomeProduto
        // 
        TxtNomeProduto.Location = new Point(19, 39);
        TxtNomeProduto.Name = "TxtNomeProduto";
        TxtNomeProduto.Size = new Size(271, 27);
        TxtNomeProduto.TabIndex = 7;
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Location = new Point(369, 95);
        label15.Name = "label15";
        label15.Size = new Size(84, 20);
        label15.TabIndex = 6;
        label15.Text = "Fornecedor";
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Location = new Point(19, 267);
        label14.Name = "label14";
        label14.Size = new Size(74, 20);
        label14.TabIndex = 5;
        label14.Text = "Categoria";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(19, 181);
        label13.Name = "label13";
        label13.Size = new Size(117, 20);
        label13.TabIndex = 4;
        label13.Text = "Estoque Mínimo";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(369, 16);
        label12.Name = "label12";
        label12.Size = new Size(109, 20);
        label12.TabIndex = 3;
        label12.Text = "Valor de Venda";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(19, 95);
        label11.Name = "label11";
        label11.Size = new Size(121, 20);
        label11.TabIndex = 2;
        label11.Text = "Valor de Compra";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(369, 180);
        label10.Name = "label10";
        label10.Size = new Size(74, 20);
        label10.TabIndex = 1;
        label10.Text = "Descrição";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(19, 16);
        label9.Name = "label9";
        label9.Size = new Size(107, 20);
        label9.TabIndex = 0;
        label9.Text = "Nome Produto";
        // 
        // TbCadastrarMovimentacao
        // 
        TbCadastrarMovimentacao.Controls.Add(CbProdutoMovimentacao);
        TbCadastrarMovimentacao.Controls.Add(label6);
        TbCadastrarMovimentacao.Controls.Add(BtnCancelarCadastroMovimentacao);
        TbCadastrarMovimentacao.Controls.Add(BtnCadastrarMovimentacao);
        TbCadastrarMovimentacao.Controls.Add(TxtObservacaoMovimentacao);
        TbCadastrarMovimentacao.Controls.Add(label18);
        TbCadastrarMovimentacao.Controls.Add(NudQuantidade);
        TbCadastrarMovimentacao.Controls.Add(label17);
        TbCadastrarMovimentacao.Controls.Add(CbTipoMovimentacao);
        TbCadastrarMovimentacao.Controls.Add(label16);
        TbCadastrarMovimentacao.Location = new Point(4, 29);
        TbCadastrarMovimentacao.Name = "TbCadastrarMovimentacao";
        TbCadastrarMovimentacao.Padding = new Padding(3);
        TbCadastrarMovimentacao.Size = new Size(985, 506);
        TbCadastrarMovimentacao.TabIndex = 8;
        TbCadastrarMovimentacao.Text = "Cadastrar Movimentação";
        TbCadastrarMovimentacao.UseVisualStyleBackColor = true;
        // 
        // CbProdutoMovimentacao
        // 
        CbProdutoMovimentacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        CbProdutoMovimentacao.DropDownStyle = ComboBoxStyle.DropDownList;
        CbProdutoMovimentacao.FormattingEnabled = true;
        CbProdutoMovimentacao.Location = new Point(304, 209);
        CbProdutoMovimentacao.Name = "CbProdutoMovimentacao";
        CbProdutoMovimentacao.Size = new Size(376, 28);
        CbProdutoMovimentacao.TabIndex = 20;
        // 
        // label6
        // 
        label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label6.AutoSize = true;
        label6.Location = new Point(304, 186);
        label6.Name = "label6";
        label6.Size = new Size(62, 20);
        label6.TabIndex = 19;
        label6.Text = "Produto";
        // 
        // BtnCancelarCadastroMovimentacao
        // 
        BtnCancelarCadastroMovimentacao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        BtnCancelarCadastroMovimentacao.Location = new Point(3, 471);
        BtnCancelarCadastroMovimentacao.Name = "BtnCancelarCadastroMovimentacao";
        BtnCancelarCadastroMovimentacao.Size = new Size(139, 29);
        BtnCancelarCadastroMovimentacao.TabIndex = 18;
        BtnCancelarCadastroMovimentacao.Text = "Cancelar";
        BtnCancelarCadastroMovimentacao.UseVisualStyleBackColor = true;
        BtnCancelarCadastroMovimentacao.Click += BtnCancelarCadastroMovimentacao_Click;
        // 
        // BtnCadastrarMovimentacao
        // 
        BtnCadastrarMovimentacao.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        BtnCadastrarMovimentacao.Location = new Point(839, 471);
        BtnCadastrarMovimentacao.Name = "BtnCadastrarMovimentacao";
        BtnCadastrarMovimentacao.Size = new Size(139, 29);
        BtnCadastrarMovimentacao.TabIndex = 15;
        BtnCadastrarMovimentacao.Text = "Cadastrar";
        BtnCadastrarMovimentacao.UseVisualStyleBackColor = true;
        BtnCadastrarMovimentacao.Click += BtnCadastrarMovimentacao_Click;
        // 
        // TxtObservacaoMovimentacao
        // 
        TxtObservacaoMovimentacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        TxtObservacaoMovimentacao.Location = new Point(304, 283);
        TxtObservacaoMovimentacao.Multiline = true;
        TxtObservacaoMovimentacao.Name = "TxtObservacaoMovimentacao";
        TxtObservacaoMovimentacao.ScrollBars = ScrollBars.Vertical;
        TxtObservacaoMovimentacao.Size = new Size(376, 155);
        TxtObservacaoMovimentacao.TabIndex = 5;
        // 
        // label18
        // 
        label18.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label18.AutoSize = true;
        label18.Location = new Point(304, 260);
        label18.Name = "label18";
        label18.Size = new Size(87, 20);
        label18.TabIndex = 4;
        label18.Text = "Observação";
        // 
        // NudQuantidade
        // 
        NudQuantidade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        NudQuantidade.Location = new Point(304, 139);
        NudQuantidade.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
        NudQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        NudQuantidade.Name = "NudQuantidade";
        NudQuantidade.Size = new Size(376, 27);
        NudQuantidade.TabIndex = 3;
        NudQuantidade.TextAlign = HorizontalAlignment.Right;
        NudQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label17
        // 
        label17.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label17.AutoSize = true;
        label17.Location = new Point(304, 116);
        label17.Name = "label17";
        label17.Size = new Size(87, 20);
        label17.TabIndex = 2;
        label17.Text = "Quantidade";
        // 
        // CbTipoMovimentacao
        // 
        CbTipoMovimentacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        CbTipoMovimentacao.DropDownStyle = ComboBoxStyle.DropDownList;
        CbTipoMovimentacao.FormattingEnabled = true;
        CbTipoMovimentacao.Location = new Point(304, 64);
        CbTipoMovimentacao.Name = "CbTipoMovimentacao";
        CbTipoMovimentacao.Size = new Size(376, 28);
        CbTipoMovimentacao.TabIndex = 1;
        // 
        // label16
        // 
        label16.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label16.AutoSize = true;
        label16.Location = new Point(304, 41);
        label16.Name = "label16";
        label16.Size = new Size(163, 20);
        label16.TabIndex = 0;
        label16.Text = "Tipo de Movimentação";
        // 
        // TbAtualizarUsuario
        // 
        TbAtualizarUsuario.Controls.Add(BtnAtualizarUsuario);
        TbAtualizarUsuario.Controls.Add(BtnCancelarAtualizacaoUsuario);
        TbAtualizarUsuario.Controls.Add(TxtNovaSenha);
        TbAtualizarUsuario.Controls.Add(TxtSenhaAtual);
        TbAtualizarUsuario.Controls.Add(TxtEmailUsuario);
        TbAtualizarUsuario.Controls.Add(TxtNomeUsuario);
        TbAtualizarUsuario.Controls.Add(TxtIdUsuario);
        TbAtualizarUsuario.Controls.Add(label23);
        TbAtualizarUsuario.Controls.Add(label22);
        TbAtualizarUsuario.Controls.Add(label21);
        TbAtualizarUsuario.Controls.Add(label20);
        TbAtualizarUsuario.Controls.Add(label19);
        TbAtualizarUsuario.Location = new Point(4, 29);
        TbAtualizarUsuario.Name = "TbAtualizarUsuario";
        TbAtualizarUsuario.Padding = new Padding(3);
        TbAtualizarUsuario.Size = new Size(985, 506);
        TbAtualizarUsuario.TabIndex = 9;
        TbAtualizarUsuario.Text = "Atualizar dados usuário";
        TbAtualizarUsuario.UseVisualStyleBackColor = true;
        // 
        // BtnAtualizarUsuario
        // 
        BtnAtualizarUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        BtnAtualizarUsuario.Location = new Point(839, 471);
        BtnAtualizarUsuario.Name = "BtnAtualizarUsuario";
        BtnAtualizarUsuario.Size = new Size(139, 29);
        BtnAtualizarUsuario.TabIndex = 20;
        BtnAtualizarUsuario.Text = "Salvar";
        BtnAtualizarUsuario.UseVisualStyleBackColor = true;
        BtnAtualizarUsuario.Click += BtnAtualizarUsuario_Click;
        // 
        // BtnCancelarAtualizacaoUsuario
        // 
        BtnCancelarAtualizacaoUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        BtnCancelarAtualizacaoUsuario.Location = new Point(3, 471);
        BtnCancelarAtualizacaoUsuario.Name = "BtnCancelarAtualizacaoUsuario";
        BtnCancelarAtualizacaoUsuario.Size = new Size(139, 29);
        BtnCancelarAtualizacaoUsuario.TabIndex = 19;
        BtnCancelarAtualizacaoUsuario.Text = "Cancelar";
        BtnCancelarAtualizacaoUsuario.UseVisualStyleBackColor = true;
        BtnCancelarAtualizacaoUsuario.Click += BtnCancelarAtualizacaoUsuario_Click;
        // 
        // TxtNovaSenha
        // 
        TxtNovaSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        TxtNovaSenha.Location = new Point(304, 338);
        TxtNovaSenha.Name = "TxtNovaSenha";
        TxtNovaSenha.Size = new Size(376, 27);
        TxtNovaSenha.TabIndex = 9;
        TxtNovaSenha.UseSystemPasswordChar = true;
        // 
        // TxtSenhaAtual
        // 
        TxtSenhaAtual.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        TxtSenhaAtual.Location = new Point(304, 272);
        TxtSenhaAtual.Name = "TxtSenhaAtual";
        TxtSenhaAtual.Size = new Size(376, 27);
        TxtSenhaAtual.TabIndex = 8;
        TxtSenhaAtual.UseSystemPasswordChar = true;
        // 
        // TxtEmailUsuario
        // 
        TxtEmailUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        TxtEmailUsuario.CharacterCasing = CharacterCasing.Lower;
        TxtEmailUsuario.Location = new Point(304, 202);
        TxtEmailUsuario.Name = "TxtEmailUsuario";
        TxtEmailUsuario.Size = new Size(376, 27);
        TxtEmailUsuario.TabIndex = 7;
        // 
        // TxtNomeUsuario
        // 
        TxtNomeUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        TxtNomeUsuario.Location = new Point(304, 134);
        TxtNomeUsuario.Name = "TxtNomeUsuario";
        TxtNomeUsuario.Size = new Size(376, 27);
        TxtNomeUsuario.TabIndex = 6;
        // 
        // TxtIdUsuario
        // 
        TxtIdUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        TxtIdUsuario.Location = new Point(304, 64);
        TxtIdUsuario.Name = "TxtIdUsuario";
        TxtIdUsuario.ReadOnly = true;
        TxtIdUsuario.Size = new Size(376, 27);
        TxtIdUsuario.TabIndex = 5;
        // 
        // label23
        // 
        label23.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label23.AutoSize = true;
        label23.Location = new Point(304, 315);
        label23.Name = "label23";
        label23.Size = new Size(88, 20);
        label23.TabIndex = 4;
        label23.Text = "Nova Senha";
        // 
        // label22
        // 
        label22.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label22.AutoSize = true;
        label22.Location = new Point(304, 249);
        label22.Name = "label22";
        label22.Size = new Size(88, 20);
        label22.TabIndex = 3;
        label22.Text = "Senha Atual";
        // 
        // label21
        // 
        label21.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label21.AutoSize = true;
        label21.Location = new Point(304, 179);
        label21.Name = "label21";
        label21.Size = new Size(52, 20);
        label21.TabIndex = 2;
        label21.Text = "E-mail";
        // 
        // label20
        // 
        label20.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label20.AutoSize = true;
        label20.Location = new Point(304, 111);
        label20.Name = "label20";
        label20.Size = new Size(50, 20);
        label20.TabIndex = 1;
        label20.Text = "Nome";
        // 
        // label19
        // 
        label19.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label19.AutoSize = true;
        label19.Location = new Point(304, 41);
        label19.Name = "label19";
        label19.Size = new Size(78, 20);
        label19.TabIndex = 0;
        label19.Text = "ID Usuário";
        // 
        // BtnSair
        // 
        BtnSair.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        BtnSair.Location = new Point(923, 6);
        BtnSair.Name = "BtnSair";
        BtnSair.Size = new Size(69, 29);
        BtnSair.TabIndex = 2;
        BtnSair.Text = "Sair";
        BtnSair.UseVisualStyleBackColor = true;
        BtnSair.Click += BtnSair_Click;
        // 
        // FrmPrincipal
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(997, 583);
        Controls.Add(BtnSair);
        Controls.Add(TabPrincipal);
        Controls.Add(LblUsuario);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MinimumSize = new Size(1015, 630);
        Name = "FrmPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Estoque Flow";
        Load += FrmPrincipal_Load;
        TabPrincipal.ResumeLayout(false);
        TbFornecedores.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)DgvFornecedores).EndInit();
        TbCategorias.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)DgvCategorias).EndInit();
        TbProdutos.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)DgvProdutos).EndInit();
        TbMovimentacoes.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)DgvMovimentacoes).EndInit();
        TbUsuarios.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)DgvUsuarios).EndInit();
        TbCadastrarFornecedor.ResumeLayout(false);
        TbCadastrarFornecedor.PerformLayout();
        TbCadastrarCategoria.ResumeLayout(false);
        TbCadastrarCategoria.PerformLayout();
        TbCadastrarProduto.ResumeLayout(false);
        TbCadastrarProduto.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NudEstoqueMinimo).EndInit();
        TbCadastrarMovimentacao.ResumeLayout(false);
        TbCadastrarMovimentacao.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NudQuantidade).EndInit();
        TbAtualizarUsuario.ResumeLayout(false);
        TbAtualizarUsuario.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label LblUsuario;
    private TabControl TabPrincipal;
    private TabPage TbFornecedores;
    private TabPage TbCategorias;
    private TabPage TbProdutos;
    private TabPage TbMovimentacoes;
    private TabPage TbUsuarios;
    private DataGridView DgvFornecedores;
    private Button BtnAdicionarFornecedor;
    private Button BtnAdicionarCategoria;
    private DataGridView DgvCategorias;
    private Button BtnAdicionarProduto;
    private DataGridView DgvProdutos;
    private Button BtnAdicionarMovimentacao;
    private DataGridView DgvMovimentacoes;
    private Button BtnDesativarConta;
    private DataGridView DgvUsuarios;
    private Button BtnAtualizarDados;
    private TabPage TbCadastrarFornecedor;
    private TabPage TbCadastrarCategoria;
    private TabPage TbCadastrarProduto;
    private TabPage TbCadastrarMovimentacao;
    private Label label1;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Button BtnCadastrarFornecedor;
    private TextBox TxtEmailFornecedor;
    private TextBox TxtNomeFantasia;
    private TextBox TxtRazaoSocial;
    private MaskedTextBox TxtTelefoneFixo;
    private MaskedTextBox TxtCnpj;
    private Label label8;
    private Label label7;
    private TextBox TxtNomeCategoria;
    private TextBox TxtDescricaoCategoria;
    private Button BtnCadastrarCategoria;
    private Label label14;
    private Label label13;
    private Label label12;
    private Label label11;
    private Label label10;
    private Label label9;
    private TextBox TxtValorVenda;
    private TextBox TxtValorCompra;
    private TextBox TxtDescricaoProduto;
    private TextBox TxtNomeProduto;
    private Label label15;
    private Button BtnCadastrarProduto;
    private ComboBox CbFornecedor;
    private ComboBox CbCategoria;
    private NumericUpDown NudEstoqueMinimo;
    private ComboBox CbTipoMovimentacao;
    private Label label16;
    private NumericUpDown NudQuantidade;
    private Label label17;
    private TextBox TxtObservacaoMovimentacao;
    private Label label18;
    private Button BtnCadastrarMovimentacao;
    private Button BtnCancelarCadastroFornecedor;
    private Button BtnCancelarCadastroCategoria;
    private Button BtnCancelarCadastroProduto;
    private Button BtnCancelarCadastroMovimentacao;
    private ComboBox CbProdutoMovimentacao;
    private Label label6;
    private Button BtnSair;
    private TabPage TbAtualizarUsuario;
    private Label label23;
    private Label label22;
    private Label label21;
    private Label label20;
    private Label label19;
    private TextBox TxtIdUsuario;
    private Button BtnAtualizarUsuario;
    private Button BtnCancelarAtualizacaoUsuario;
    private TextBox TxtNovaSenha;
    private TextBox TxtSenhaAtual;
    private TextBox TxtEmailUsuario;
    private TextBox TxtNomeUsuario;
}