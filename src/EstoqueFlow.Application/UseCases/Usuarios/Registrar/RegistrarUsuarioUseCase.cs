using EstoqueFlow.Application.Mappings;
using EstoqueFlow.Application.ViewModel.Usuarios;
using EstoqueFlow.Domain.Repositories;

namespace EstoqueFlow.Application.UseCases.Usuarios.Registrar;

public class RegistrarUsuarioUseCase(IUsuarioRepository usuarioRepository) : IRegistrarUsuarioUseCase
{
    public async Task<UsuarioResponse> Executar(UsuarioRequest request)
    {
        var entidade = request.ToEntidade();

        var usuario = await usuarioRepository.Adicionar(entidade);

        return usuario.ToDto();
    }
}
