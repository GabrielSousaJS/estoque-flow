namespace EstoqueFlow.UI;

partial class FrmLogin
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
        label1 = new Label();
        label2 = new Label();
        LblMensagemErroLogin = new Label();
        label4 = new Label();
        TxtSenha = new TextBox();
        TxtEmail = new TextBox();
        LinkLblCadastro = new LinkLabel();
        BtnEntrar = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(193, 71);
        label1.Name = "label1";
        label1.Size = new Size(52, 20);
        label1.TabIndex = 3;
        label1.Text = "E-mail";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(193, 145);
        label2.Name = "label2";
        label2.Size = new Size(49, 20);
        label2.TabIndex = 4;
        label2.Text = "Senha";
        // 
        // LblMensagemErroLogin
        // 
        LblMensagemErroLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblMensagemErroLogin.ForeColor = Color.Red;
        LblMensagemErroLogin.Location = new Point(214, 198);
        LblMensagemErroLogin.Name = "LblMensagemErroLogin";
        LblMensagemErroLogin.Size = new Size(271, 20);
        LblMensagemErroLogin.TabIndex = 5;
        LblMensagemErroLogin.Text = "Verifique os dados e tente novamente.";
        LblMensagemErroLogin.TextAlign = ContentAlignment.MiddleCenter;
        LblMensagemErroLogin.Visible = false;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(233, 298);
        label4.Name = "label4";
        label4.Size = new Size(151, 20);
        label4.TabIndex = 6;
        label4.Text = "Não possui cadastro?";
        // 
        // TxtSenha
        // 
        TxtSenha.Location = new Point(193, 168);
        TxtSenha.Name = "TxtSenha";
        TxtSenha.PlaceholderText = "Digite sua senha";
        TxtSenha.Size = new Size(314, 27);
        TxtSenha.TabIndex = 1;
        TxtSenha.UseSystemPasswordChar = true;
        TxtSenha.KeyUp += TxtSenha_KeyUp;
        // 
        // TxtEmail
        // 
        TxtEmail.CharacterCasing = CharacterCasing.Lower;
        TxtEmail.Location = new Point(193, 94);
        TxtEmail.Name = "TxtEmail";
        TxtEmail.PlaceholderText = "Digite seu e-mail";
        TxtEmail.Size = new Size(314, 27);
        TxtEmail.TabIndex = 0;
        TxtEmail.KeyUp += TxtEmail_KeyUp;
        // 
        // LinkLblCadastro
        // 
        LinkLblCadastro.AutoSize = true;
        LinkLblCadastro.Location = new Point(378, 298);
        LinkLblCadastro.Name = "LinkLblCadastro";
        LinkLblCadastro.Size = new Size(84, 20);
        LinkLblCadastro.TabIndex = 7;
        LinkLblCadastro.TabStop = true;
        LinkLblCadastro.Text = "Clique aqui";
        LinkLblCadastro.LinkClicked += LinkLblCadastro_LinkClicked;
        // 
        // BtnEntrar
        // 
        BtnEntrar.Location = new Point(293, 241);
        BtnEntrar.Name = "BtnEntrar";
        BtnEntrar.Size = new Size(113, 29);
        BtnEntrar.TabIndex = 2;
        BtnEntrar.Text = "Entrar";
        BtnEntrar.UseVisualStyleBackColor = true;
        BtnEntrar.Click += BtnEntrar_Click;
        // 
        // FrmLogin
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(682, 403);
        Controls.Add(BtnEntrar);
        Controls.Add(LinkLblCadastro);
        Controls.Add(TxtEmail);
        Controls.Add(TxtSenha);
        Controls.Add(label4);
        Controls.Add(LblMensagemErroLogin);
        Controls.Add(label2);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "FrmLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Estoque Flow - Login";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label LblMensagemErroLogin;
    private Label label4;
    private TextBox TxtSenha;
    private TextBox TxtEmail;
    private LinkLabel LinkLblCadastro;
    private Button BtnEntrar;
}