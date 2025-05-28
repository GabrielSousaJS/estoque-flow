using EstoqueFlow.Application.Services.Sessao;
using EstoqueFlow.Application.UseCases.Categorias.Atualizar;
using EstoqueFlow.Application.UseCases.Categorias.ObterPorId;
using EstoqueFlow.Application.UseCases.Categorias.ObterTodas;
using EstoqueFlow.Application.UseCases.Categorias.Registrar;
using EstoqueFlow.Application.UseCases.Fornecedores.Atualizar;
using EstoqueFlow.Application.UseCases.Fornecedores.ObterPorId;
using EstoqueFlow.Application.UseCases.Fornecedores.ObterTodos;
using EstoqueFlow.Application.UseCases.Fornecedores.Registrar;
using EstoqueFlow.Application.UseCases.Login;
using EstoqueFlow.Application.UseCases.Movimentacoes.ObterPorId;
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
using EstoqueFlow.Application.UseCases.Usuarios.Registrar;
using Microsoft.Extensions.DependencyInjection;

namespace EstoqueFlow.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        AddUseCases(services);
        AddServices(services);

        return services;
    }

    private static void AddUseCases(IServiceCollection services)
    {
        // Categorias
        services.AddScoped<IAtualizarCategoriaUseCase, AtualizarCategoriaUseCase>();
        services.AddScoped<IObterCategoriaPorIdUseCase, ObterCategoriaPorIdUseCase>();
        services.AddScoped<IObterTodosCategoriasUseCase, ObterTodosCategoriasUseCase>();
        services.AddScoped<IRegistrarCategoriaUseCase, RegistrarCategoriaUseCase>();

        // Fornecedores
        services.AddScoped<IAtualizarFornecedorUseCase, AtualizarFornecedorUseCase>();
        services.AddScoped<IObterFornecedorPorIdUseCase, ObterFornecedorPorIdUseCase>();
        services.AddScoped<IObterTodosFornecedoresUseCase, ObterTodosFornecedoresUseCase>();
        services.AddScoped<IRegistrarFornecedorUseCase, RegistrarFornecedorUseCase>();

        // Login
        services.AddScoped<ILoginUseCase, LoginUseCase>();

        // Movimentações
        services.AddScoped<IObterMovimentacaoPorIdUseCase, ObterMovimentacaoPorIdUseCase>();
        services.AddScoped<IObterTodosMovimentacoesUseCase, ObterTodosMovimentacoesUseCase>();
        services.AddScoped<IRegistrarMovimentacaoUseCase, RegistrarMovimentacaoUseCase>();

        // Produtos
        services.AddScoped<IAtualizarProdutoUseCase, AtualizarProdutoUseCase>();
        services.AddScoped<IObterProdutoPorIdUseCase, ObterProdutoPorIdUseCase>();
        services.AddScoped<IObterTodosProdutosUseCase, ObterTodosProdutosUseCase>();
        services.AddScoped<IRegistrarProdutoUseCase, RegistrarProdutoUseCase>();

        // Usuários
        services.AddScoped<IAtualizarUsuarioUseCase, AtualizarUsuarioUseCase>();
        services.AddScoped<IDesativarUsuarioUseCase, DesativarUsuarioUseCase>();
        services.AddScoped<IObterUsuarioPorIdUseCase, ObterUsuarioPorIdUseCase>();
        services.AddScoped<IObterTodosUsuariosUseCase, ObterTodosUsuariosUseCase>();
        services.AddScoped<IRegistrarUsuarioUseCase, RegistrarUsuarioUseCase>();
    }

    private static void AddServices(IServiceCollection services)
    {
        services.AddSingleton<ISessaoUsuarioService, SessaoUsuarioService>();
    }
}
