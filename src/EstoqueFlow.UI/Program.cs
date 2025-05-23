namespace EstoqueFlow.UI;

using EstoqueFlow.Application;
using EstoqueFlow.Infraestructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows.Forms;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;

        var appContext = new CustomAppContext(ServiceProvider);
        Application.Run(appContext);
    }

    public static IServiceProvider? ServiceProvider { get; private set; }

    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                // Registrar formulários
                services.AddTransient<FrmLogin>();
                services.AddTransient<FrmCadastrarUsuario>();
                services.AddTransient<FrmPrincipal>();

                services.AddApplication();
                services.AddInfraestructure();
            });
    }
}