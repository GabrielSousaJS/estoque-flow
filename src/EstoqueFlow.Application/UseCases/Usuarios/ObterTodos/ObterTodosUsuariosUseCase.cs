using EstoqueFlow.Application.Mappings;
using EstoqueFlow.Application.ViewModel.Usuarios;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Application.UseCases.Usuarios.ObterTodos;

public class ObterTodosUsuariosUseCase(IUsuarioRepository usuarioRepository) : IObterTodosUsuariosUseCase
{
    public async Task<IEnumerable<UsuarioResponse>> Executar()
    {
        var usuarios = await usuarioRepository.ObterTodos();

        return usuarios.Select(u => u.ToDto());
    }
}
