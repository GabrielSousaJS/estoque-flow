using EstoqueFlow.Application.ViewModel.Usuarios;

namespace EstoqueFlow.Application.UseCases.Usuarios.Atualizar;

public interface IAtualizarUsuarioUseCase
{
    Task Executar(int id, AtualizarUsuarioRequest request);
}
