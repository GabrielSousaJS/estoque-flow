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
        TbCadastrarCategoria = new TabPage();
        TbCadastrarProduto = new TabPage();
        TbCadastrarMovimentacao = new TabPage();
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
        DgvUsuarios.Size = new Size(973, 424);
        DgvUsuarios.TabIndex = 4;
        // 
        // TbCadastrarFornecedor
        // 
        TbCadastrarFornecedor.Location = new Point(4, 29);
        TbCadastrarFornecedor.Name = "TbCadastrarFornecedor";
        TbCadastrarFornecedor.Padding = new Padding(3);
        TbCadastrarFornecedor.Size = new Size(985, 506);
        TbCadastrarFornecedor.TabIndex = 5;
        TbCadastrarFornecedor.Text = "Cadastrar Fornecedor";
        TbCadastrarFornecedor.UseVisualStyleBackColor = true;
        // 
        // TbCadastrarCategoria
        // 
        TbCadastrarCategoria.Location = new Point(4, 29);
        TbCadastrarCategoria.Name = "TbCadastrarCategoria";
        TbCadastrarCategoria.Padding = new Padding(3);
        TbCadastrarCategoria.Size = new Size(985, 506);
        TbCadastrarCategoria.TabIndex = 6;
        TbCadastrarCategoria.Text = "Cadastrar Categoria";
        TbCadastrarCategoria.UseVisualStyleBackColor = true;
        // 
        // TbCadastrarProduto
        // 
        TbCadastrarProduto.Location = new Point(4, 29);
        TbCadastrarProduto.Name = "TbCadastrarProduto";
        TbCadastrarProduto.Padding = new Padding(3);
        TbCadastrarProduto.Size = new Size(985, 506);
        TbCadastrarProduto.TabIndex = 7;
        TbCadastrarProduto.Text = "Cadastrar Produto";
        TbCadastrarProduto.UseVisualStyleBackColor = true;
        // 
        // TbCadastrarMovimentacao
        // 
        TbCadastrarMovimentacao.Location = new Point(4, 29);
        TbCadastrarMovimentacao.Name = "TbCadastrarMovimentacao";
        TbCadastrarMovimentacao.Padding = new Padding(3);
        TbCadastrarMovimentacao.Size = new Size(985, 506);
        TbCadastrarMovimentacao.TabIndex = 8;
        TbCadastrarMovimentacao.Text = "Cadastrar Movimentação";
        TbCadastrarMovimentacao.UseVisualStyleBackColor = true;
        // 
        // FrmPrincipal
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(997, 583);
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
}