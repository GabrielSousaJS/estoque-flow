using EstoqueFlow.Domain.Entities;

namespace EstoqueFlow.Domain.Repositories;

public interface IUsuarioRepository
{
    Task<Usuario> Adicionar(Usuario usuario);
    Task Atualizar(Usuario usuario);
    Task<IEnumerable<Usuario>> ObterTodos();
    Task<Usuario> ObterPorId(int id);
    Task<Usuario?> ObterUsuarioPorEmail(string email);
    Task<bool> ExisteUsuarioAtivoComEmail(string email);
    Task Desativar(int id);
}
