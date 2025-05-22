using EstoqueFlow.Application.ViewModel.Usuarios;

namespace EstoqueFlow.Application.UseCases.Usuarios.ObterPorId;

public interface IObterUsuarioPorIdUseCase
{
    Task<UsuarioResponse> Executar(int id);
}
