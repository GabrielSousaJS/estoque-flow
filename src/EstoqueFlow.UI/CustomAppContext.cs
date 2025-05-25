using Microsoft.Extensions.DependencyInjection;

namespace EstoqueFlow.UI;

public class CustomAppContext : ApplicationContext
{
    private readonly IServiceProvider _serviceProvider;

    public CustomAppContext(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;

        AbrirFrmLogin();
    }

    private void AbrirFrmLogin()
    {
        var frmLogin = _serviceProvider.GetRequiredService<FrmLogin>();
        frmLogin.FormClosed += (s, e) => ExitThread();
        frmLogin.AbrirFrmCadastrarUsuario += AbrirFrmCadastrarUsuario;
        frmLogin.AbrirFrmPrincipal += AbrirFrmPrincipal;

        if (MainForm is not null)
            MainForm.Hide();

        MainForm = frmLogin;
        frmLogin.Show();
    }

    private void AbrirFrmCadastrarUsuario()
    {
        var frmCadastrarUsuario = _serviceProvider.GetRequiredService<FrmCadastrarUsuario>();
        frmCadastrarUsuario.FormClosed += (s, e) => ExitThread();
        frmCadastrarUsuario.AbrirFrmLogin += AbrirFrmLogin;
        frmCadastrarUsuario.AbrirFrmPrincipal += AbrirFrmPrincipal;

        MainForm.Hide();
        MainForm = frmCadastrarUsuario;
        frmCadastrarUsuario.Show();
    }

    private void AbrirFrmPrincipal()
    {
        var frmPrincipal = _serviceProvider.GetRequiredService<FrmPrincipal>();
        frmPrincipal.AbrirFrmLogin += AbrirFrmLogin;
        frmPrincipal.FormClosed += (s, e) => ExitThread();

        MainForm.Hide();
        MainForm = frmPrincipal;
        frmPrincipal.Show();
    }
}
