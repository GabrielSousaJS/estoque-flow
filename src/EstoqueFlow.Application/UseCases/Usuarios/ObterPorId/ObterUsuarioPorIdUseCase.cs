using EstoqueFlow.Application.Mappings;
using EstoqueFlow.Application.ViewModel.Usuarios;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Application.UseCases.Usuarios.ObterPorId;

public class ObterUsuarioPorIdUseCase(IUsuarioRepository usuarioRepository) : IObterUsuarioPorIdUseCase
{
    public async Task<UsuarioResponse> Executar(int id)
    {
        var usuario = await usuarioRepository.ObterPorId(id);

        return usuario.ToDto();
    }
}
