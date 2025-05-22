namespace EstoqueFlow.Application.UseCases.Usuarios.Desativar;

public interface IDesativarUsuarioUseCase
{
    Task Executar(int id);
}
