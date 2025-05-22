
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Application.UseCases.Usuarios.Desativar;

public class DesativarUsuarioUseCase(IUsuarioRepository usuarioRepository) : IDesativarUsuarioUseCase
{
    public async Task Executar(int id)
    {
        await usuarioRepository.Desativar(id);
    }
}
