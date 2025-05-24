namespace EstoqueFlow.UI;

partial class FrmCadastrarUsuario
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarUsuario));
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        LinkLblLogin = new LinkLabel();
        BtnCadastrar = new Button();
        TxtNome = new TextBox();
        TxtEmail = new TextBox();
        TxtSenha = new TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(193, 66);
        label1.Name = "label1";
        label1.Size = new Size(50, 20);
        label1.TabIndex = 0;
        label1.Text = "Nome";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(193, 132);
        label2.Name = "label2";
        label2.Size = new Size(52, 20);
        label2.TabIndex = 1;
        label2.Text = "E-mail";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(193, 202);
        label3.Name = "label3";
        label3.Size = new Size(49, 20);
        label3.TabIndex = 2;
        label3.Text = "Senha";
        // 
        // LinkLblLogin
        // 
        LinkLblLogin.AutoSize = true;
        LinkLblLogin.Location = new Point(290, 371);
        LinkLblLogin.Name = "LinkLblLogin";
        LinkLblLogin.Size = new Size(120, 20);
        LinkLblLogin.TabIndex = 4;
        LinkLblLogin.TabStop = true;
        LinkLblLogin.Text = "Voltar para login";
        // 
        // BtnCadastrar
        // 
        BtnCadastrar.Location = new Point(287, 302);
        BtnCadastrar.Name = "BtnCadastrar";
        BtnCadastrar.Size = new Size(125, 29);
        BtnCadastrar.TabIndex = 5;
        BtnCadastrar.Text = "Cadastrar";
        BtnCadastrar.UseVisualStyleBackColor = true;
        BtnCadastrar.Click += BtnCadastrar_Click;
        // 
        // TxtNome
        // 
        TxtNome.Location = new Point(193, 89);
        TxtNome.Name = "TxtNome";
        TxtNome.PlaceholderText = "Digite nome e sobrenome";
        TxtNome.Size = new Size(314, 27);
        TxtNome.TabIndex = 6;
        TxtNome.KeyUp += TxtNome_KeyUp;
        // 
        // TxtEmail
        // 
        TxtEmail.CharacterCasing = CharacterCasing.Lower;
        TxtEmail.Location = new Point(193, 155);
        TxtEmail.Name = "TxtEmail";
        TxtEmail.PlaceholderText = "Digite seu e-mail";
        TxtEmail.Size = new Size(314, 27);
        TxtEmail.TabIndex = 7;
        TxtEmail.KeyUp += TxtEmail_KeyUp;
        // 
        // TxtSenha
        // 
        TxtSenha.Location = new Point(193, 225);
        TxtSenha.Name = "TxtSenha";
        TxtSenha.PlaceholderText = "Digite sua senha";
        TxtSenha.Size = new Size(314, 27);
        TxtSenha.TabIndex = 8;
        TxtSenha.UseSystemPasswordChar = true;
        TxtSenha.KeyUp += TxtSenha_KeyUp;
        // 
        // FrmCadastrarUsuario
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(682, 463);
        Controls.Add(TxtSenha);
        Controls.Add(TxtEmail);
        Controls.Add(TxtNome);
        Controls.Add(BtnCadastrar);
        Controls.Add(LinkLblLogin);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "FrmCadastrarUsuario";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Estoque Flow - Cadastrar Usuário";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private LinkLabel LinkLblLogin;
    private Button BtnCadastrar;
    private TextBox TxtNome;
    private TextBox TxtEmail;
    private TextBox TxtSenha;
}
