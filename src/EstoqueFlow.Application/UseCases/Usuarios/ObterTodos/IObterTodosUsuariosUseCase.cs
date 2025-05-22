using EstoqueFlow.Application.ViewModel.Usuarios;

namespace EstoqueFlow.Application.UseCases.Usuarios.ObterTodos;

public interface IObterTodosUsuariosUseCase
{
    Task<IEnumerable<UsuarioResponse>> Executar();
}
