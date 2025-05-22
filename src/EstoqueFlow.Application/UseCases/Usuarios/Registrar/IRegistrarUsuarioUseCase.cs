using EstoqueFlow.Application.ViewModel.Usuarios;

namespace EstoqueFlow.Application.UseCases.Usuarios.Registrar;

public interface IRegistrarUsuarioUseCase
{
    Task<UsuarioResponse> Executar(UsuarioRequest request);
}
