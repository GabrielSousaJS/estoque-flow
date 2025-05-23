using EstoqueFlow.Domain.Repositories;
using EstoqueFlow.Domain.Seguranca.Criptografia;
using EstoqueFlow.Infraestructure.DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;
using BC = EstoqueFlow.Infraestructure.Seguranca.Criptografia.BCrypt;

namespace EstoqueFlow.Infraestructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfraestructure(this IServiceCollection services)
    {
        AddRepositories(services);
        AddServices(services);

        return services;
    }

    private static void AddRepositories(IServiceCollection services)
    {
        services.AddScoped<ICategoriaRepository, CategoriaRepository>();
        services.AddScoped<IFornecedorRepository, FornecedorRepository>();
        services.AddScoped<IMovimentacaoRepository, MovimentacaoRepository>();
        services.AddScoped<IProdutoRepository, ProdutoRepository>();
        services.AddScoped<IUsuarioRepository, UsuarioRepository>();
    }

    private static void AddServices(IServiceCollection services)
    {
        services.AddScoped<ICriptografarSenha, BC>();
    }
}

