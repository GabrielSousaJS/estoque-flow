using EstoqueFlow.Application.ViewModel.Login;
using EstoqueFlow.Application.ViewModel.Usuarios;

namespace EstoqueFlow.Application.UseCases.Login;

public interface ILoginUseCase
{
    Task<UsuarioResponse> Executar(LoginRequest request);
}
