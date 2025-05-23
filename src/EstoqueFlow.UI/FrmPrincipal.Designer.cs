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
        SuspendLayout();
        // 
        // LblUsuario
        // 
        LblUsuario.AutoSize = true;
        LblUsuario.Location = new Point(3, 3);
        LblUsuario.Name = "LblUsuario";
        LblUsuario.Size = new Size(156, 20);
        LblUsuario.TabIndex = 0;
        LblUsuario.Text = "Usuário: _______________";
        // 
        // FrmPrincipal
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(997, 583);
        Controls.Add(LblUsuario);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MinimumSize = new Size(1015, 630);
        Name = "FrmPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Estoque Flow";
        Load += FrmPrincipal_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label LblUsuario;
}